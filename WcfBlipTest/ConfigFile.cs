using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Windows;
using System.Windows.Controls;
namespace WcfBlipTest
{
    static class ConfigFile
    {

        public static void LoadConfig(ref TextBox txtLogin, ref PasswordBox txtPassword)
        {
            if (!System.IO.File.Exists("config.xml"))
            {
                CreateConfig();
                return;
            }
            XDocument doc = XDocument.Load("config.xml");

            var username = doc.Element("config").Element("username").Value;
            var password = doc.Element("config").Element("password").Value;
            txtLogin.Text = username;
            txtPassword.Password = password;
        }
        private static void CreateConfig()
        {
            XElement doc = new XElement("config",
                new XElement("username", ""),
                new XElement("password", ""));
            doc.Save("config.xml");
        }
        public static void SaveConfig(TextBox txtLogin, PasswordBox txtPassword)
        {
            XElement doc = new XElement("config",
                            new XElement("username", txtLogin.Text),
                            new XElement("password", txtPassword.Password));
            doc.Save("config.xml");
        }
    }
}
