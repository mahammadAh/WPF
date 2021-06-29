
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace WPF_Galery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ImageFolder> ImageFolders { get; set; }
        public ObservableCollection<myImage> Images { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            ImageFolders = new ObservableCollection<ImageFolder>();
            Images = new ObservableCollection<myImage>();
            imageFolderListBox.ItemsSource = ImageFolders;
            imageListBox.ItemsSource = Images;
        }


     

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Images.Clear();
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
            
                ImageFolder image = new ImageFolder();
                image.Source = dialog.FileName;
                string[] folderName = dialog.FileName.Split('\\');
                image.Title = folderName[folderName.Length - 1];
                ImageFolders.Add(image);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Images.Clear();
            var select = imageFolderListBox.SelectedIndex;
            ImageFolders.RemoveAt(select);
        }

      

        private void imageFolderListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Images.Clear();
            var select = imageFolderListBox.SelectedIndex;
            string rootFile = ImageFolders[select].Source;

            foreach (var file in Directory.GetFiles(rootFile))
            {
                
                myImage image = new myImage();
                var fileInfo = new FileInfo(file);
                var fileSize = (fileInfo.Length/1024).ToString()+" Kb";
                var fileCreated = fileInfo.CreationTime;
                image.Date = fileCreated;
                image.Photo = file;
                image.Size = fileSize;
                string[] fileName = file.Split('\\');
                image.Title = fileName[fileName.Length - 1];
                Images.Add(image);

            }
        }

        private void imageListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            BigPhotoWindows bigPhotoWindows = new BigPhotoWindows(Images, imageListBox.SelectedIndex);
            bigPhotoWindows.Owner = this;
            bigPhotoWindows.Show();

        }
    }

    public class myImage
    {
        public string Photo { get; set; }
        public string Title { get; set; }
        public string Size { get; set; }
        public DateTime Date { get; set; }

    }

    public class ImageFolder
    {
        public string Source { get; set; }
        public string Title { get; set; }

    }
}
