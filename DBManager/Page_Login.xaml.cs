﻿using System;
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

namespace DBManager
{
    /// <summary>
    /// Interaction logic for Page_Login.xaml
    /// </summary>
    public partial class Page_Login : Page
    {
        public Page_Login()
        {
            InitializeComponent();
        }
        private void Btn_LogIn_Click(object sender, RoutedEventArgs e)
        {

            MainPage mainPage = new MainPage();
            NavigationService.Navigate(mainPage);
        }
    }
}
