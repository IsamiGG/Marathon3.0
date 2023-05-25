using MarathonNEW.AppServices;
using MarathonNEW.PageMain;
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

namespace MarathonNEW
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new MainButton());
        }

        private void BtnReg_Click1(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new RegisterAsRunner());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
