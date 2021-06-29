using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_move_search.Model;
using WPF_move_search.ViewModel;

namespace WPF_move_search.View
{
    /// <summary>
    /// Логика взаимодействия для IMDb.xaml
    /// </summary>
    public partial class IMDb : Window
    {
        public IMDb()
        {
            InitializeComponent();
            DataContext = new IMDbViewModel();
           
        }

   
    }
}
