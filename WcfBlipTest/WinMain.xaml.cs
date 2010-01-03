using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Xml.Linq;
using WcfBlip;

namespace WcfBlipTest
{
    /// <summary>
    /// Interaction logic for WinMain.xaml
    /// </summary>
    public partial class WinMain : Window
    {
        private Blip blip = null;

        public WinMain()
        {
            InitializeComponent();            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Load username and password from config.xml file
            //due to faster debuging stuff
            ConfigFile.LoadConfig(ref txtLogin,ref txtPassword);
        }


        private bool PrepareBlip()
        {
            if (blip != null)
                return true;
            if (string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show(this, "Login i hasło nie mogą być puste");
                return false;
            }
            blip = new Blip(txtLogin.Text, txtPassword.Password);
            return true;
        }

        private void BtnProcess(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            if (!PrepareBlip())
                return;
            switch (b.Name)
            {
                case "btnDashboard":
                    dbgBlip.ItemsSource = blip.Api.GetDashboardUpdates();
                    break;
                case "btnMyUpdates":
                    dbgBlip.ItemsSource = blip.Api.GetUpdates();
                    break;
                case "btnMyNotices":
                    dbgBlip.ItemsSource = blip.Api.GetNotices();
                    break;
                case "btnAllUpdates":
                    dbgBlip.ItemsSource = blip.Api.GetAllUpdates();
                    break;
                default:
                    break;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Saving current setting of username and password
            ConfigFile.SaveConfig(txtLogin, txtPassword);
        }

        
    }
}
