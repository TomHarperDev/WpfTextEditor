using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Security.RightsManagement;
using Microsoft.Win32;

namespace WpfTextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string currentFilePath;
        public TextBox tbFileContents = new TextBox();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Save to {currentFilePath}?", "Save confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                File.WriteAllText(currentFilePath, tbFileContents.Text);
            }
        }

        private void btnSaveAll_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnOpenNew_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnOpenExisting_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            Openfile.Title = "Select a file to open";
            
            if (Openfile.ShowDialog() == true)
            {
                string fileContents = File.ReadAllText(Openfile.FileName);
                MessageBox.Show(Openfile.FileName);
                tbInfo.Visibility = Visibility.Hidden;
                tbFileContents.Text = fileContents;
                myGrid.Children.Add(tbFileContents);
                currentFilePath = Openfile.FileName;
                NavBarItem newItem = new NavBarItem("test", Openfile.FileName, fileContents, SpOpenFiles);
            }


        }





    }
}
