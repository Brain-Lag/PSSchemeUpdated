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

namespace PSSchemeUpdated
{
    /// <summary>
    /// Логика взаимодействия для Storage_View.xaml
    /// </summary>
    public partial class Storage_View : UserControl
    {
        private int currentImageIndex = 1;
        public Storage_View()
        {
            InitializeComponent();
        }

        private void NextImage_Click(object sender, RoutedEventArgs e)
        {
            SwitchImage(true);
        }

        private void PreviousImage_Click(object sender, RoutedEventArgs e)
        {
            SwitchImage(false);
        }
        private void SwitchImage(bool next)
        {

            switch (currentImageIndex)
            {
                case 1:
                    ImageBorder1.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    ImageBorder2.Visibility = Visibility.Hidden;
                    break;
                case 3:
                    ImageBorder3.Visibility = Visibility.Hidden;
                    break;
            }
            if (next)
            {
                currentImageIndex++;
                if (currentImageIndex > 3)
                    currentImageIndex = 1;
            }
            else
            {
                currentImageIndex--;
                if (currentImageIndex < 1)
                    currentImageIndex = 3;
            }

            switch (currentImageIndex)
            {
                case 1:
                    ImageBorder1.Visibility = Visibility.Visible;
                    break;
                case 2:
                    ImageBorder2.Visibility = Visibility.Visible;
                    break;
                case 3:
                    ImageBorder3.Visibility = Visibility.Visible;
                    break;
            }
        }
    }
}
