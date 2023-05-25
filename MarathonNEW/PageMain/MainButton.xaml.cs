using MarathonNEW.AppServices;
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

namespace MarathonNEW.PageMain
{
    /// <summary>
    /// Логика взаимодействия для MainButton.xaml
    /// </summary>
    public partial class MainButton : Page
    {
        public MainButton()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new RegisterRunner());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Information());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
