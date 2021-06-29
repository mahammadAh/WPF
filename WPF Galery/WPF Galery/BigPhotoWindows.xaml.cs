using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Galery
{
    /// <summary>
    /// Логика взаимодействия для BigPhotoWindows.xaml
    /// </summary>
    public partial class BigPhotoWindows : Window
    {
        public ObservableCollection<myImage> Images { get; set; }
        int index;
        public BigPhotoWindows( ObservableCollection<myImage> Images , int index )
        {
            
            this.Images = Images;
            this.index = index;
           
            InitializeComponent();

            var uri = new Uri(Images[index].Photo);
            var bitmap = new BitmapImage(uri);
            imageBox.Source = bitmap;
            this.Title= Images[index].Title;
        }

      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (index > 0)
            {
                index--;
                var uri = new Uri(Images[index].Photo);
                var bitmap = new BitmapImage(uri);
                imageBox.Source = bitmap;
                this.Title = Images[index].Title;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (index < Images.Count - 1)
            {
                index++;
                var uri = new Uri(Images[index].Photo);
                var bitmap = new BitmapImage(uri);
                imageBox.Source = bitmap;
                this.Title = Images[index].Title;
            }
        
        }
    }


}
