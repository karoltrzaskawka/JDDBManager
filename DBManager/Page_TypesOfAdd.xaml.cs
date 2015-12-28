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

namespace DBManager
{
    /// <summary>
    /// Interaction logic for Page_TypesOfAdd.xaml
    /// </summary>
    public partial class Page_TypesOfAdd : Page
    {
        public Page_TypesOfAdd()
        {
            InitializeComponent();
        }
        private void Btn_AddClient_Click(object sender, RoutedEventArgs e)
        {
            Page_AddClient AddClientPage = new Page_AddClient();
            NavigationService.Navigate(AddClientPage);
        }

        private void Btn_AddMachine_Click(object sender, RoutedEventArgs e)
        {
            Page_AddMachine AddMachinePage = new Page_AddMachine();
            NavigationService.Navigate(AddMachinePage);
        }

        private void Btn_AddService_Click(object sender, RoutedEventArgs e)
        {
            Page_AddService AddServicePage = new Page_AddService();
            NavigationService.Navigate(AddServicePage);
        }

        private void Btn_AddJob_Click(object sender, RoutedEventArgs e)
        {
            Page_AddJob AddJobPage = new Page_AddJob();
            NavigationService.Navigate(AddJobPage);
        }

        private void Btn_TypeOfManufacturer_Click(object sender, RoutedEventArgs e)
        {
            Page_TypesOfManufacturers typesOfManufacturers = new Page_TypesOfManufacturers();
            NavigationService.Navigate(typesOfManufacturers);
        }
    }
}
