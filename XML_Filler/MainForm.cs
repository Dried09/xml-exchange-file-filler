using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Diagnostics;

namespace XML_Filler
{
    public partial class MainForm : Form
    {
        ConsoleController consoleController;
        public static ConsoleController cC;

        bool canRefresh = true;

        public MainForm()
        {
            InitializeComponent();
            //Запуск таймера безперервного виконання
            
            TimerTicker.Start();

            if (Properties.Settings.Default.FullscreenMode == true) WindowState = FormWindowState.Maximized;
            consoleController = new ConsoleController(ConsoleView);
            cC = consoleController;
            cC.AddElement(ConsoleController.ConsoleElementType.notification, Greeting());
            
            mainTabControl = MainTabControl;

            OnViewHelper += DisableHelperButtons;
            OnCloseHelper += EnableHelperButtons;       
        }

        //Безперервний цикл за таймером
        private void TimerTicker_Tick(object sender, EventArgs e)
        {
        	if(MainTabControl.TabCount > 0) 
        	{
        		CloseAllMenuItem.Enabled = true;
        		CloseAllFilesToolStripButton.Enabled = true;
        		CloseCurrentMenuItem.Enabled = true;
        		CloseFileToolStripButton.Enabled = true;
        		SaveFileToolStripButton.Enabled = true;
        		SaveAllFilesToolStripButton.Enabled = true;
        		EditFileToolStripButton.Enabled = true;
        	}
        	else
        	{
				CloseAllMenuItem.Enabled = false;
        		CloseAllFilesToolStripButton.Enabled = false; 
        		CloseCurrentMenuItem.Enabled = false;
        		CloseFileToolStripButton.Enabled = false;
        		SaveFileToolStripButton.Enabled = false;
        		SaveAllFilesToolStripButton.Enabled = false;
        		EditFileToolStripButton.Enabled = false;
                ShowErrorsToolStripButton.Enabled = false;      	
            }
        }

        //КНОПКИ
        
        //МЕНЮ ПРОГРАМИ
        
        //Натиснення відкриття файлу
        private void OpenMenuItem_Click(object sender, EventArgs e)
        {     	
            OpenFiles();         
        }
        
        //Натиснення збереження файлу у меню
        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
			if(!openedPages[MainTabControl.SelectedTab].isErrorsOccurred) 
			{
				openedPages[MainTabControl.SelectedTab].xmlFileObject.SaveTags();
				openedPages[MainTabControl.SelectedTab].xmlFile.Save(Properties.Settings.Default.SavePath  + MainTabControl.SelectedTab.Text);
			}
			else 
			{
				MessageBox.Show("Файл містить критичні помилки!\nСпочатку виправте помилки.", "Помилка збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
        }
        
        //Натиснення на збереження всіх файлів
        private void SaveAllMenuItemClick(object sender, EventArgs e)
		{
			List<PageInfo> filesWithError = new List<PageInfo>();
			for(int i = 0; i < MainTabControl.TabCount; i++) 
			{
				if(!openedPages[MainTabControl.TabPages[i]].isErrorsOccurred) 
				{
					openedPages[MainTabControl.TabPages[i]].xmlFileObject.SaveTags();
					openedPages[MainTabControl.TabPages[i]].xmlFile.Save(Properties.Settings.Default.SavePath + MainTabControl.TabPages[i].Text);
				}
				else 
				{
					filesWithError.Add(openedPages[MainTabControl.TabPages[i]]);
				}			
			}
			if(filesWithError.Count > 0) 
			{
				string msg = "";
				foreach(PageInfo pi in filesWithError) 
				{
					msg += pi.originalFileName + "\n";
				}
				MessageBox.Show("Збережено частину або жодного файлу.\n\nФайл(и) містить критичні помилки.\n\nНе збережено файли з помилками:\n" + msg, "Помилка збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
        
        //Натиснення закриття одного файлу
        private void CloseCurrentMenuItemClick(object sender, EventArgs e)
		{
            openedPages.Remove(MainTabControl.SelectedTab);
            MainTabControl.TabPages.RemoveAt(MainTabControl.SelectedIndex);
            if (MainTabControl.SelectedIndex < 0) MainTabControl.SelectedIndex = 0;
        }
        
        //Натиснення закриття всіх файлів у вікні програми
        private void CloseAllMenuItem_Click(object sender, EventArgs e)
        {
            canRefresh = false;
            openedPages.Clear();
            MainTabControl.TabPages.Clear();
            MainTabControl.SelectedIndex = -1;
            canRefresh = true;
            cC.ClearConsoleComplete();
        }

        //Кнопка показати помилки у файлі
        private void ShowErrorsButton_Click(object sender, EventArgs e)
        {
            ErrorForm errorForm = new ErrorForm(openedPages[MainTabControl.SelectedTab].xmlFileObject.errors);
            errorForm.ShowDialog();
        }
        
        //Натискання кнопки редагування обмінного файлу у вікні програми
        private void EditXMLButton_Click(object sender, EventArgs e)
        {
        	EditXML editForm = new EditXML(openedPages[MainTabControl.SelectedTab]);
            editForm.ShowDialog();
        	
			if (editForm.DialogResult == DialogResult.OK)
            {
            	openedPages[MainTabControl.SelectedTab].xmlFile = editForm.returnValue;
            	openedPages[MainTabControl.SelectedTab].xmlFileObject.ReadTags();
            	RefreshTabStatus(openedPages[MainTabControl.SelectedTab]);
                ShowControls(openedPages[MainTabControl.SelectedTab].xmlFileObject, MainTabControl.SelectedTab); 
				cC.AddElement(ConsoleController.ConsoleElementType.notification, "Файл " + MainTabControl.SelectedTab.Text + " було змінено");                
            }
        }
              
        //Натиснення на налаштування у меню
        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        //Показ вікна про програму
        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Програмне забезпечення \"XML Filler Заповнювач обмінних файлів\"\nРозроблено на замовлення ПП \"СхідГеоЛенд\" у 2016-2017 році\n\nСтосовно питань, побажань, скарг та технічної підтримки\nзвертатися до розробника за адресою:\n\ndriedsf@gmail.com", "Про програму", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        //ПАНЕЛІ
        void OpenFileToolStripButtonClick(object sender, EventArgs e)
		{
			OpenFiles();
		}
		void SaveFileToolStripButtonClick(object sender, EventArgs e)
		{
			if(!openedPages[MainTabControl.SelectedTab].isErrorsOccurred) 
			{
				openedPages[MainTabControl.SelectedTab].xmlFileObject.SaveTags();
				openedPages[MainTabControl.SelectedTab].xmlFile.Save(Properties.Settings.Default.SavePath  + MainTabControl.SelectedTab.Text);
			}
			else 
			{
				MessageBox.Show("Файл містить критичні помилки!\nСпочатку виправте помилки.", "Помилка збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
		}
		void SaveAllFilesToolStripButtonClick(object sender, EventArgs e)
		{
			List<PageInfo> filesWithError = new List<PageInfo>();
			for(int i = 0; i < MainTabControl.TabCount; i++) 
			{
				if(!openedPages[MainTabControl.TabPages[i]].isErrorsOccurred) 
				{
					openedPages[MainTabControl.TabPages[i]].xmlFileObject.SaveTags();
					openedPages[MainTabControl.TabPages[i]].xmlFile.Save(Properties.Settings.Default.SavePath + MainTabControl.TabPages[i].Text);
				}
				else 
				{
					filesWithError.Add(openedPages[MainTabControl.TabPages[i]]);
				}			
			}
			if(filesWithError.Count > 0) 
			{
				string msg = "";
				foreach(PageInfo pi in filesWithError) 
				{
					msg += pi.originalFileName + "\n";
				}
				MessageBox.Show("Збережено частину або жодного файлу.\n\nФайл(и) містить критичні помилки.\n\nНе збережено файли з помилками:\n" + msg, "Помилка збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void CloseFileToolStripButtonClick(object sender, EventArgs e)
		{
			openedPages.Remove(MainTabControl.SelectedTab);
			MainTabControl.TabPages.RemoveAt(MainTabControl.SelectedIndex);
            if (MainTabControl.SelectedIndex < 0) MainTabControl.SelectedIndex = 0;
		}
		void CloseAllFilesToolStripButtonClick(object sender, EventArgs e)
		{
            canRefresh = false;
			openedPages.Clear();
            MainTabControl.TabPages.Clear();
            MainTabControl.SelectedIndex = -1;
            canRefresh = true;
            cC.ClearConsoleComplete();
        }
        void SaveDirectoryToolStripButton_Click(object sender, EventArgs e)
        {
            Process.Start(@Properties.Settings.Default.SavePath);
        }
        void ShowErrorsToolStripButtonClick(object sender, EventArgs e)
		{
			ErrorForm errorForm = new ErrorForm(openedPages[MainTabControl.SelectedTab].xmlFileObject.errors);
            errorForm.ShowDialog();
		}
		void EditFileToolStripButtonClick(object sender, EventArgs e)
		{
			EditXML editForm = new EditXML(openedPages[MainTabControl.SelectedTab]);
            editForm.ShowDialog();
            
            if (editForm.DialogResult == DialogResult.OK)
            {
            	openedPages[MainTabControl.SelectedTab].xmlFile = editForm.returnValue;

                openedPages[MainTabControl.SelectedTab].RefreshPageInfo();

                RefreshTabStatus(openedPages[MainTabControl.SelectedTab]);
                ShowControls(openedPages[MainTabControl.SelectedTab].xmlFileObject, MainTabControl.SelectedTab); 
				cC.AddElement(ConsoleController.ConsoleElementType.notification, "Файл " + MainTabControl.SelectedTab.Text + " було змінено");                
            }

		}
		void SettingsToolStripButtonClick(object sender, EventArgs e)
		{
			SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
		}	
        
        //ІНШІ ДІЇ
        
        void MainTabControlSelecting(object sender, TabControlCancelEventArgs e)
        {
            if (MainTabControl.SelectedIndex >= 0 && canRefresh)
            {
                RefreshTabStatus(openedPages[MainTabControl.TabPages[MainTabControl.SelectedIndex]]);
            }
        }
        
        //Кнопка очистки консолі
        private void ClearButton_Click(object sender, EventArgs e)
        {
            cC.ClearConsoleComplete();
        }
        
        //Зміна довжини лінії в консолі, коли змінюється розмір вікна
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            cC.RefreshView();
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", "ReadMe.txt");
        }
    }
}
