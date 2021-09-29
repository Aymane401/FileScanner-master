using FileScanner.ViewModels;
using System;
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
using System.Windows.Forms;
using System.IO;
using System.Drawing;


namespace FileScanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BaseViewModel mainviewmodel ;
        public MainWindow()
        {
            InitializeComponent();
            mainviewmodel = new MainViewModel();
            this.DataContext = (MainViewModel)mainviewmodel;
        }



      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var directories = Directory.GetDirectories(((MainViewModel)mainviewmodel).SelectedFolder);

            // text1.Text = ((MainViewModel)mainviewmodel).FolderItems[0].ToString();

            // ((MainViewModel)mainviewmodel).ScanFolderCommand();




        }
        System.Drawing.Image newImage = System.Drawing.Image.FromFile(@"logos/File_Icon.png");
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {



        }
    }
}