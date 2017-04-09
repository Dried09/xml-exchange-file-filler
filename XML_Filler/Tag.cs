using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Drawing;

namespace XML_Filler
{
	//Програмна модель схеми
	public class SchemeInfo
	{
		public string name;
		public List<GroupAbstract> groupsAbstractions;
		
		public SchemeInfo(string schemePath) 
		{
			name = schemePath.Split('\'')[schemePath.Split('\'').Length - 1];
			groupsAbstractions = MainForm.ReadScheme(schemePath);
		}
	}
	
    //Програмна модель вкладки
    public class PageInfo
	{
    	public string originalFileName;
    	SchemeInfo currentScheme;
		public XDocument xmlFile;
		public XmlInfo xmlFileObject;
		public TabPage tabPage;
		public bool isErrorsOccurred;
		
		public PageInfo(string fileName, string filePath, SchemeInfo scheme)
		{
			isErrorsOccurred = false;
			originalFileName = fileName;
			currentScheme = scheme;
			xmlFile = XDocument.Load(filePath);
			
			tabPage = new TabPage(originalFileName);
			tabPage.AutoScroll = true;
			
			xmlFile = MainForm.ReadTagsToReplace(xmlFile, originalFileName);
			
			xmlFileObject = FillGroups(currentScheme);
			
			CheckForErrors();
			
			MainForm.mainTabControl.Controls.Add(tabPage);
		}

        public void CheckForErrors() 
		{
			if (xmlFileObject.ReadTags() != 0)
            {
				isErrorsOccurred = true;
            }
			else 
			{
				isErrorsOccurred = false;
			}
		}
		
		XmlInfo FillGroups(SchemeInfo scheme) 
		{
			XmlInfo xmlInfo = new XmlInfo();
			
			List<GroupInfo> groupsInfo = new List<GroupInfo>();
			
			for(int i = 0; i < scheme.groupsAbstractions.Count; i++) 
			{
				GroupInfo gi = new GroupInfo(scheme.groupsAbstractions[i].groupParameters);
				for(int j = 0; j < scheme.groupsAbstractions[i].tagsInGroup.Count; j++) 
				{
					if(scheme.groupsAbstractions[i].tagsInGroup[j] is SingleTagAbstract)
					{
						SingleTagAbstract sta = scheme.groupsAbstractions[i].tagsInGroup[j] as SingleTagAbstract;
						TagSingleInfo tsi = new TagSingleInfo(sta.tagParameters);
						tsi.xmlDoc = xmlFile;
						gi.elements.Add(tsi);
					}
					else if(scheme.groupsAbstractions[i].tagsInGroup[j] is MultipleTagAbstract) 
					{
						MultipleTagAbstract mta = scheme.groupsAbstractions[i].tagsInGroup[j] as MultipleTagAbstract;
						TagMultipleInfo tmi = new TagMultipleInfo(mta.tagParameters);
						tmi.xmlDoc = xmlFile;
						gi.elements.Add(tmi);
					}
					else if(scheme.groupsAbstractions[i].tagsInGroup[j] is DividerTagAbstract) 
					{
						DividerTagAbstract dta = scheme.groupsAbstractions[i].tagsInGroup[j] as DividerTagAbstract;
						TagDivider td = new TagDivider(dta.tagParameters, dta.counter);
						gi.elements.Add(td);
					}
					else throw new Exception("Помилка в побудові обїектної моделі Xml файлу");
				}
				groupsInfo.Add(gi);
			}
			
			xmlInfo.tagGroups.AddRange(groupsInfo);
			
			return xmlInfo;
		}

        public void RefreshPageInfo()
        {
            xmlFileObject = FillGroups(currentScheme);
            CheckForErrors();
        }
	}
    
    //Програмна модель XML файлу
    public class XmlInfo
    {
        public List<GroupInfo> tagGroups;

        public List<ReadError> errors;

        public XmlInfo()
        {
            tagGroups = new List<GroupInfo>();
            errors = new List<ReadError>();
        }

        public int ReadTags()
        {
            foreach(GroupInfo gi in tagGroups)
            {
                foreach(TagInfo ti in gi.elements)
                {
                    if(ti is TagSingleInfo)
                    {
                        TagSingleInfo tsi = ti as TagSingleInfo;
                        tsi.ReadValue(errors);
                    }

                    else if(ti is TagMultipleInfo)
                    {
                        TagMultipleInfo tmi = ti as TagMultipleInfo;
                        tmi.ReadValue(errors);
                    }
                }
            }
            if(errors.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void SaveTags()
        {
            foreach (GroupInfo gi in tagGroups)
            {
                foreach (TagInfo ti in gi.elements)
                {
                    if (ti is TagSingleInfo)
                    {
                        TagSingleInfo tsi = ti as TagSingleInfo;
                        tsi.SaveValue();
                    }

                    else if (ti is TagMultipleInfo)
                    {
                        TagMultipleInfo tmi = ti as TagMultipleInfo;
                        tmi.SaveValue();
                    }
                }
            }
        }
    }

    //Програмна модель тегу
    public abstract class TagInfo
    {
        public string name;
        public string localizedName;
        public bool show;
        public XDocument xmlDoc;
    }

    public class TagSingleInfo : TagInfo
    {
        public string fullXPath;
        public string existence;
        public bool helper;
        public string value;
        public Label infoLabel;
        public Control infoControl;
        public Button helperButton;

        public TagSingleInfo(string parameters)
        {
            name = parameters.Split(' ')[1].Split(':')[1];
            localizedName = parameters.Split(' ')[1].Split(':')[2].Replace("_", " ");
            fullXPath = parameters.Split(' ')[2].Split(':')[1];
            existence = parameters.Split(' ')[0].Split(':')[1];
            helper = parameters.Split(' ')[0].Split(':').Count() == 3 ? true : false;
            value = "Тег відсутній в XML файлі";
            show = false;
        }

        public void ReadValue(List<ReadError> errors)
        {
            if (xmlDoc.Root.XPathSelectElement(fullXPath) != null)
            {
                value = xmlDoc.Root.XPathSelectElement(fullXPath).Value;
                show = true;

                infoLabel = new Label();
                infoLabel.Name = name + "Label";
                infoLabel.Text = localizedName + ": ";

                infoControl = new TextBox();
                infoControl.Name = name + "TextBox";
                infoControl.Text = value;

                if(helper)
                {
                    helperButton = new Button();
                    helperButton.Name = name + "HelperButton";
                    helperButton.Text = "+";
                }
                
                
            }
            else if (xmlDoc.Root.XPathSelectElement(fullXPath) == null && existence == "required")
            {
                show = true;
                //MainForm.cC.AddElement(ConsoleController.ConsoleElementType.error, "Одиночний тег XML за адресою " + fullXPath + " помилковий або відсутній і потребує ручного редагування");
                errors.Add(new ReadError("Одиночний тег XML помилковий або відсутній і потребує ручного редагування", this));

                infoLabel = new Label();
                infoLabel.Name = name + "Label";
                infoLabel.Text = localizedName + ": ";

                infoControl = new TextBox();
                infoControl.Name = name + "TextBox";
                infoControl.Text = value;
                infoControl.BackColor = Color.Red;

                if(helper)
                {
                    helperButton = new Button();
                    helperButton.Name = name + "HelperButton";
                    helperButton.Text = "+";
                    helperButton.Enabled = false;
                }              
            }
            else
            {
                show = false;
                return;
            }
        }

        public void SaveValue()
        {
            if(show == true) xmlDoc.Root.XPathSelectElement(fullXPath).Value = infoControl.Text;
        }
    }

    public class TagMultipleInfo : TagInfo
    {
        public string baseXPath;
        public string targetXPath;
        public string fullXPath;
        public string existence;
        public bool helper;
        public List<string> values;
        public List<Label> infoLabels;
        public List<Control> infoControls;
        public List<Button> helperButtons;

        public TagMultipleInfo(string parameters)
        {
            show = false;
            name = parameters.Split(' ')[1].Split(':')[1];
            localizedName = parameters.Split(' ')[1].Split(':')[2].Replace("_", " ");
            existence = parameters.Split(' ')[0].Split(':')[1];
            helper = parameters.Split(' ')[0].Split(':').Count() == 3 ? true : false;
            baseXPath = parameters.Split(' ')[2].Split(':')[1];
            targetXPath = parameters.Split(' ')[2].Split(':')[2];
            fullXPath = parameters.Split(' ')[2].Split(':')[3];
            values = new List<string>();
            values.Add("Тег відсутній в XML файлі");
            infoLabels = new List<Label>();
            infoControls = new List<Control>();
            helperButtons = new List<Button>();
        }

        public void ReadValue(List<ReadError> errors)
        {
            values.Clear();
            infoLabels.Clear();
            infoControls.Clear();
            List<XElement> tempElements = xmlDoc.Root.XPathSelectElements(baseXPath).ToList();
            for(int i = 0; i < tempElements.Count; i++) 
            {
                if (tempElements[i].XPathSelectElement(targetXPath) != null) show = true;
                else
                {
                    show = false;
                    //MainForm.cC.AddElement(ConsoleController.ConsoleElementType.error, "Множинний тег XML за адресою " + fullXPath + " помилковий або відсутній і потребує ручного редагування");
                    errors.Add(new ReadError("Множинний тег XML помилковий або відсутній і потребує ручного редагування", this));
                    break;
                }
                values.Add(tempElements[i].XPathSelectElement(targetXPath).Value);
                infoLabels.Add(new Label());
                infoLabels[i].Name = name + "Label" + i;
                infoLabels[i].Text = localizedName + " " + (i + 1) + ": ";

                infoControls.Add(new TextBox());
                infoControls[i].Name = name + "TextBox" + i;
                infoControls[i].Text = values[i];

                if (helper)
                {
                    helperButtons.Add(new Button());
                    helperButtons[i].Name = name + "HelperButton" + i;
                    helperButtons[i].Text = "+";
                }
            }
        }

        public void SaveValue()
        {
            if(show == true)
            {
                List<XElement> tempElements = xmlDoc.Root.XPathSelectElements(baseXPath).ToList();
                for (int i = 0; i < tempElements.Count; i++)
                {
                    tempElements[i].XPathSelectElement(targetXPath).Value = infoControls[i].Text;
                }
            }         
        }
    }

    public class TagDivider : TagInfo
    {
        public Label divider;

        public TagDivider(string parameters, int counter)
        {
            name = "Divider" + counter;
            localizedName = parameters.Split(':')[1].Replace("_", " ");
            show = true;
            divider = new Label();
            divider.Name = name;
            divider.Text = localizedName + ":";

            divider.Font = new Font(divider.Font, FontStyle.Underline);
        }
    }

    //Програмна модель групи тегів
    public class GroupInfo
    {
        public string name;
        public string localizedName;
        public GroupBox infoGroup;

        public List<TagInfo> elements;

        public GroupInfo(string parameters)
        {
            name = parameters.Split(':')[1];
            localizedName = parameters.Split(':')[2].Replace("_", " ");
            elements = new List<TagInfo>();
            infoGroup = new GroupBox();
            infoGroup.Name = name + "GroupBox";
            infoGroup.Text = localizedName;
        }
    }

    //Клас помилки зчитування
    public class ReadError
    {
        public string message;
        public TagInfo problemTag;

        public ReadError(string message, TagInfo problemTag)
        {
            this.message = message;
            this.problemTag = problemTag;

        }
    }
    
    //Абстрактні конструкції тегів та груп для обєкта схеми
    public class GroupAbstract 
    {
    	public string groupParameters;
    	public List<TagAbstract> tagsInGroup;
    	public GroupAbstract(string parameters) 
    	{
    		groupParameters = parameters;
    		tagsInGroup = new List<TagAbstract>();
    	}
    }
    
    public abstract class TagAbstract 
    {
    }
    
    public class SingleTagAbstract : TagAbstract
    {
    	public string tagParameters;
    	public SingleTagAbstract(string parameters) 
    	{
    		tagParameters = parameters;
    	}
    }
    
    public class MultipleTagAbstract : TagAbstract
    {
    	public string tagParameters;
    	public MultipleTagAbstract(string parameters) 
    	{
    		tagParameters = parameters;
    	}
    }
    
    public class DividerTagAbstract : TagAbstract
    {
    	public string tagParameters;
    	public int counter;
    	public DividerTagAbstract(string parameters, int counter) 
    	{
    		tagParameters = parameters;
    		this.counter = counter;
    	}
    }

    public class HelperFunctions
    {
        public static Control GetHelperBody(string name)
        {
            string newName = "";
            foreach(char ch in name)
            {
                if (char.IsDigit(ch)) continue;
                else newName += ch;
            }


            Control control = null;

            if (name.Contains("LicenseIssuedDate") || name.Contains("ProprietorPassportIssuedDate") ||
                name.Contains("TechnicalDocumentationDraftingDate") || name.Contains("StateActRegistrationDate") ||
                name.Contains("StateActDeliveryDate") || name.Contains("EntitlementDocumentDate"))
            {
                control = new DateTimePicker();
                (control as DateTimePicker).CustomFormat = "yyyy-MM-dd";
                (control as DateTimePicker).Format = DateTimePickerFormat.Custom;
                (control as DateTimePicker).Value = DateTime.Now;
            }

            if(name.Contains("ParcelCategory"))
            {
                control = new ComboBox();
                List<string> itemsFromFile = new List<string>();
                string[] lines = File.ReadAllLines(@"Вміст помічника\ParcelCategory.hlpr", Encoding.Default);
                foreach(string line in lines)
                {
                    if (line.Contains("#") || line == String.Empty) continue;
                    else itemsFromFile.Add(line);
                }
                if (itemsFromFile.Count > 0) (control as ComboBox).Items.AddRange(itemsFromFile.ToArray());
                else (control as ComboBox).Text = "Помилка зчитування файлу хелпера";
            }

            if (name.Contains("ParcelPurpose"))
            {
                control = new ComboBox();
                List<string> itemsFromFile = new List<string>();
                string[] lines = File.ReadAllLines(@"Вміст помічника\ParcelPurpose.hlpr", Encoding.Default);
                foreach (string line in lines)
                {
                    if (line.Contains("#") || line == String.Empty) continue;
                    else itemsFromFile.Add(line);
                }
                if (itemsFromFile.Count > 0) (control as ComboBox).Items.AddRange(itemsFromFile.ToArray());
                else (control as ComboBox).Text = "Помилка зчитування файлу хелпера";
            }

            if (name.Contains("ParcelOwnershipCode"))
            {
                control = new ComboBox();
                List<string> itemsFromFile = new List<string>();
                string[] lines = File.ReadAllLines(@"Вміст помічника\ParcelOwnershipCode.hlpr", Encoding.Default);
                foreach (string line in lines)
                {
                    if (line.Contains("#") || line == String.Empty) continue;
                    else itemsFromFile.Add(line);
                }
                if (itemsFromFile.Count > 0) (control as ComboBox).Items.AddRange(itemsFromFile.ToArray());
                else (control as ComboBox).Text = "Помилка зчитування файлу хелпера";
            }

            if (name.Contains("TechnicalDocumentationInfo"))
            {
                control = new ComboBox();
                List<string> itemsFromFile = new List<string>();
                string[] lines = File.ReadAllLines(@"Вміст помічника\TechnicalDocumentationInfo.hlpr", Encoding.Default);
                foreach (string line in lines)
                {
                    if (line.Contains("#") || line == String.Empty) continue;
                    else itemsFromFile.Add(line);
                }
                if (itemsFromFile.Count > 0) (control as ComboBox).Items.AddRange(itemsFromFile.ToArray());
                else (control as ComboBox).Text = "Помилка зчитування файлу хелпера";
            }

            if (name.Contains("EntitlementDocument"))
            {
                control = new ComboBox();
                List<string> itemsFromFile = new List<string>();
                string[] lines = File.ReadAllLines(@"Вміст помічника\EntitlementDocument.hlpr", Encoding.Default);
                foreach (string line in lines)
                {
                    if (line.Contains("#") || line == String.Empty) continue;
                    else itemsFromFile.Add(line);
                }
                if (itemsFromFile.Count > 0) (control as ComboBox).Items.AddRange(itemsFromFile.ToArray());
                else (control as ComboBox).Text = "Помилка зчитування файлу хелпера";
            }

            if (name.Contains("LandParcel"))
            {
                control = new ComboBox();
                List<string> itemsFromFile = new List<string>();
                string[] lines = File.ReadAllLines(@"Вміст помічника\LandParcel.hlpr", Encoding.Default);
                foreach (string line in lines)
                {
                    if (line.Contains("#") || line == String.Empty) continue;
                    else itemsFromFile.Add(line);
                }
                if (itemsFromFile.Count > 0) (control as ComboBox).Items.AddRange(itemsFromFile.ToArray());
                else (control as ComboBox).Text = "Помилка зчитування файлу хелпера";
            }

            return control;
        }
    }
}
