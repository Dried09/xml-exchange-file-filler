using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Xml.XPath;

namespace XML_Filler
{
    public partial class MainForm : Form
    {
    	//НОВІ ЗМІННІ
    	SchemeInfo currentScheme = new SchemeInfo(Properties.Settings.Default.ChekingScheme);
    	public static TabControl mainTabControl;
    	Dictionary<TabPage, PageInfo> openedPages = new Dictionary<TabPage, PageInfo>();
    	//

        //Завантаження XML з локального сховища через діалогове вікно
        void OpenFiles()
        {     	
            if(OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
            	for (int i = 0; i < OpenFileDialog.FileNames.Length; i++)
                {
            		PageInfo pageInfo = new PageInfo(OpenFileDialog.SafeFileNames[i], 
            		                             OpenFileDialog.FileNames[i], 
            		                             currentScheme);
            		openedPages.Add(pageInfo.tabPage, pageInfo);
            		
            		ShowControls(pageInfo.xmlFileObject, pageInfo.tabPage);
            		
            		RefreshTabStatus(pageInfo);
                }	
    	
                cC.AddElement(ConsoleController.ConsoleElementType.notification, "Відкрито " + OpenFileDialog.FileNames.Count() + " обмінних файлів XML.");
            }
        }

        //Читання схеми фізично  
        public static List<GroupAbstract> ReadScheme(string schemePath)
        {
        	List<GroupAbstract> groupsAbstractions = new List<GroupAbstract>();
            
            string[] lines = File.ReadAllLines(schemePath, Encoding.Default);
            GroupAbstract lastGroup = null;
            int dividerCounter = 1;
            
            foreach (string line in lines)
            {
                if (!line.Contains("#") && line != "")
                {
                    if(line.Contains("-group"))
                    {
                        GroupAbstract group = new GroupAbstract(line);
                        groupsAbstractions.Add(group);
                        lastGroup = group;                       
                    }
                    else if(line.Contains("-single") && lastGroup != null)
                    {
                        SingleTagAbstract tag = new SingleTagAbstract(line);
                        lastGroup.tagsInGroup.Add(tag);
                    }
                    else if (line.Contains("-multiple") && lastGroup != null)
                    {
                        MultipleTagAbstract tagInfo = new MultipleTagAbstract(line);
                        lastGroup.tagsInGroup.Add(tagInfo);
                    }
                    else if (line.Contains("-divider") && lastGroup != null)
                    {
                        DividerTagAbstract divider = new DividerTagAbstract(line, dividerCounter);
                        lastGroup.tagsInGroup.Add(divider);
                        dividerCounter++;
                    }
                    else
                    {
                        throw new Exception("Помилка в схемі зчитування XML файлу (група тегів має бути перед тегами)");
                    }
                }
                else continue;
            }
            //xmlObj = new XmlInfo();
            //xmlObj.tagGroups.AddRange(groupsInfo);
            
            return groupsAbstractions;
        }

        //Виправлення неповних тегів
        public static XDocument ReadTagsToReplace(XDocument xmlDoc, string fileName)
        {
        	XDocument currentXDoc = xmlDoc;
        	
            //StateActInfo
            if(Properties.Settings.Default.EnableTagAutofix && Properties.Settings.Default.FixStateActInfo)
            {
                cC.AddElement(ConsoleController.ConsoleElementType.notification, "Спроба відновлення блоку Державного Акту в файлі: " + fileName + " ...");
                FixTag(@"Теги\StateActInfo.snp", "//StateActInfo", "//InfoPart/CadastralZoneInfo/CadastralQuarters/CadastralQuarterInfo/Parcels/ParcelInfo/StateActInfo", currentXDoc);
            }
            //
            if (Properties.Settings.Default.EnableTagAutofix && Properties.Settings.Default.FixProprietorInfo)
            {
                cC.AddElement(ConsoleController.ConsoleElementType.notification, "Спроба відновлення блоку Власника у файлі: " + fileName + " ...");
                FixTag(@"Теги\ProprietorInfo.snp", "//ProprietorInfo", "//InfoPart/CadastralZoneInfo/CadastralQuarters/CadastralQuarterInfo/Parcels/ParcelInfo/Proprietors/ProprietorInfo", currentXDoc);
            }

            return currentXDoc;
        }
		//Універсальний метод виправлення   
        public static void FixTag(string snippetPath, string shortXPath, string fullXPath, XDocument xDoc)
        {
            if (xDoc.Root.XPathSelectElements(fullXPath).Count() == 1)
            {
                XElement newTag = XDocument.Load(snippetPath).XPathSelectElement(shortXPath);
                XElement currentTag = xDoc.Root.XPathSelectElement(fullXPath);
                for (int i = 0; i < currentTag.Descendants().Count(); i++)
                {
                    if (currentTag.Descendants().ElementAt(i).HasElements) continue;
                    else
                    {
                        string xpath = GetXpath(currentTag.Descendants().ElementAt(i));
                        string shortXpath = GetShortXpath(xpath, newTag.Name.ToString());

                        if (newTag.XPathSelectElement(shortXpath) != null)
                        {
                            newTag.XPathSelectElement(shortXpath).Value = currentTag.XPathSelectElement(xpath).Value;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                currentTag.RemoveAll();
                currentTag.Add(newTag.Elements());
                cC.AddElement(ConsoleController.ConsoleElementType.notification, "Тег успішно відновлено");
            }
            else if (xDoc.Root.XPathSelectElements(fullXPath).Count() > 1)
            {
                for(int j = 0; j < xDoc.Root.XPathSelectElements(fullXPath).Count(); j++)
                {
                    XElement newTag = XDocument.Load(snippetPath).XPathSelectElement(shortXPath);
                    XElement currentTag = xDoc.Root.XPathSelectElements(fullXPath).ElementAt(j);
                    for (int i = 0; i < currentTag.Descendants().Count(); i++)
                    {
                        if (currentTag.Descendants().ElementAt(i).HasElements) continue;
                        else
                        {
                            string xpath = GetXpath(currentTag.Descendants().ElementAt(i));
                            string shortXpath = GetShortXpath(xpath, newTag.Name.ToString());

                            if (newTag.XPathSelectElement(shortXpath) != null)
                            {
                                newTag.XPathSelectElement(shortXpath).Value = currentTag.XPathSelectElement(xpath).Value;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }

                    currentTag.RemoveAll();
                    currentTag.Add(newTag.Elements());
                }
                cC.AddElement(ConsoleController.ConsoleElementType.notification, "Тег(и) успішно відновлено");
            }

            else
            {
                cC.AddElement(ConsoleController.ConsoleElementType.warning, "Спроба відновлення невдала. Даний тег відсутній або його і не повинно бути.");
            }          
        }
		//Отримання повного xpath
        public static string GetXpath(XElement element)
        {
            string xpath = "//";
            IEnumerable<XElement> parents = element.AncestorsAndSelf();
            for(int i = 0; i < parents.Count(); i++)
            {
                xpath += parents.ElementAt(parents.Count() - 1 - i).Name + "/";
            }
            xpath = xpath.Substring(0, xpath.Length - 1);
            return xpath;
        }
		//Отримання короткого xpath
        public static string GetShortXpath(string longXpath, string baseTag)
        {
            string xpath = "//";
            List<string> dividedXpath = longXpath.Replace("//", "").Split('/').ToList();
            for(int i = 0; i < dividedXpath.Count; i++)
            {
                if (dividedXpath[i] == baseTag)
                {
                    for(int j = 0; j < dividedXpath.Count - i; j++)
                    {
                        xpath += dividedXpath[i + j] + "/";
                    }
                }
                else continue;
            }
            xpath = xpath.Substring(0, xpath.Length - 1);

            return xpath;
        }

        //Привітання в консоль
        string Greeting()
        {
            if (DateTime.Now.Hour >= 5 && DateTime.Now.Hour <= 11) return "Доброго ранку!";
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour <= 17) return "Добрий день!";
            else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour <= 21) return "Добрий вечір! Щось ви запрацювалися.";
            else if (DateTime.Now.Hour >= 22 && DateTime.Now.Hour <= 24) return "Доброї ночі! Чому не спиться?";
            else if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour <= 4) return "Доброї ночі! Пора спати!";
            else return "Здрастє!";
        }
        
        void RefreshTabStatus(PageInfo pageInfo) 
        {
        	if(pageInfo.isErrorsOccurred) 
        	{
        		ShowErrorsToolStripButton.Enabled = true;
        	}
        	else 
        	{
        		ShowErrorsToolStripButton.Enabled = false;
        	}
        }
    }
}
