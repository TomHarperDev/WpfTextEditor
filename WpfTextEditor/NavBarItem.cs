using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfTextEditor
{
    internal class NavBarItem
    {
        public string name;
        public string filePath;
        public string fileContents;
        public NavBarItem(string Name, string FilePath, string FileContents, StackPanel SpOpenFiles) 
        {
            name = Name;
            filePath = FilePath;
            fileContents = FileContents;

            Button button = new Button();
            button.Content = name;
            button.Name = name;

            SpOpenFiles.Children.Add(button);
        }
    }
}
