using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using PSSchemeUpdated.ViewModel;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace PSSchemeUpdated
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}