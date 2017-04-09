using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace XML_Filler
{
    public class ConsoleController
    {
        List<ConsoleElement> consoleElements;
        ListView targetViewer = null;
        public enum ConsoleElementType { notification, warning, error };

        public ConsoleController(ListView targetToView)
        {
            targetViewer = targetToView;
            consoleElements = new List<ConsoleElement>();
        }

        public void RefreshView()
        {
            targetViewer.Clear();
            ColumnHeader colHeader = new ColumnHeader();
            colHeader.Width = targetViewer.Width - 4;
            targetViewer.Columns.Add(colHeader);
            for(int i = consoleElements.Count() - 1; i >= 0; i--)
            {
                ConsoleElement tempConsEl = consoleElements[i];
                string prefix = "";
                string time = "[" + DateTime.Now.ToString() + "]";
                Color textColor = Color.Black;
                switch (tempConsEl.ElementType)
                {
                    case ConsoleElementType.notification:
                        prefix = "Повідомлення: ";
                        textColor = Color.Green;
                        break;
                    case ConsoleElementType.warning:
                        prefix = "Попередження: ";
                        textColor = Color.Blue;
                        break;
                    case ConsoleElementType.error:
                        prefix = "Помилка: ";
                        textColor = Color.Red;
                        break;
                }
                ListViewItem tempItem = new ListViewItem();
                tempItem.Text = "[" + tempConsEl.Date + "] " + prefix + tempConsEl.Message;
                tempItem.ForeColor = textColor;
                targetViewer.Items.Add(tempItem);
            }
            
        }

        public void AddElement(ConsoleElementType consoleElementType, string message)
        {
            consoleElements.Add(new ConsoleElement(consoleElementType, message));
            if (Properties.Settings.Default.EnableLogging == true)
            {
                using (FileStream fs = new FileStream("Log.log", FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine("[" + DateTime.Now.ToString() + "] " + consoleElementType.ToString() + ": " + message);
                    }
                }
            }
            RefreshView();
        }

        public void ClearConsoleShort()
        {
            for(int i = 0; i < consoleElements.Count(); i++)
            {
                if (consoleElements[i].ElementType == ConsoleElementType.notification)
                {
                    consoleElements.RemoveAt(i);
                }
                else if (consoleElements[i].ElementType == ConsoleElementType.warning)
                {
                    consoleElements.RemoveAt(i);
                }
                else if (consoleElements[i].ElementType == ConsoleElementType.error)
                {
                    continue;
                }
            }
            RefreshView();
        }

        public void ClearConsoleComplete()
        {
            consoleElements.Clear();
            RefreshView();
        }

        public void SetViewer(ListView targetToView)
        {
            targetViewer = targetToView;
        }
    }

    struct ConsoleElement
    {
        ConsoleController.ConsoleElementType consElType;
        string message;
        string date;

        public ConsoleElement(ConsoleController.ConsoleElementType consoleElementType, string innerMessage)
        {
            consElType = consoleElementType;
            message = innerMessage;
            date = DateTime.Now.ToLongTimeString();
        }

        public ConsoleController.ConsoleElementType ElementType
        {
            get { return consElType; }
        }

        public string Message
        {
            get { return message; }
        }

        public string Date
        {
            get { return date; }
        }
    }
}
