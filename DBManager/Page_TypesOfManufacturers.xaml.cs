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
    /// Interaction logic for Page_TypesOfManufacturers.xaml
    /// </summary>
    public partial class Page_TypesOfManufacturers : Page
    {
        public enum typyProducentow { Ciagniki =0, Kombajny = 1, Siewniki =2, MaszynyZielonkowe=3, Opryskiwacze =4, Rozsiewacze=5, ZestawyUprawowe=6 }
        public List<string> typyProducenta;
        public void fillList()
        {
            typyProducenta.Add("Ciągniki");
            typyProducenta.Add("Kombajny");
            typyProducenta.Add("Siewniki");
            typyProducenta.Add("Maszyny zielonkowe");
            typyProducenta.Add("Opryskiwacze");
            typyProducenta.Add("Rozsiewacze");
            typyProducenta.Add("Zestawy uprawowe");
        }
        public void checkTypeAndAdd(int index)
        {
            using (var db = new ModelJDB())
            {
            switch (index)
            {          
                case (int)typyProducentow.Ciagniki:
                    db.prod_ciagniki.Add(new prod_ciagniki { nazwa = Tb_Name.Text });
                    break;
                case (int)typyProducentow.Kombajny:
                     db.prod_kombajny.Add(new prod_kombajny { nazwa = Tb_Name.Text });
                     break;
                case (int)typyProducentow.Siewniki:
                     db.prod_siewniki.Add(  new prod_siewniki { nazwa = Tb_Name.Text });
                    break;
                case (int)typyProducentow.ZestawyUprawowe:
                    db.prod_zestawy_uprawowe.Add( new prod_zestawy_uprawowe { nazwa = Tb_Name.Text });
                    break;
                case (int)typyProducentow.Rozsiewacze:
                    db.prod_rozsiewacze.Add( new prod_rozsiewacze { nazwa = Tb_Name.Text });
                    break;
                case (int)typyProducentow.Opryskiwacze:
                    db.prod_opryskiwacze.Add( new prod_opryskiwacze { nazwa = Tb_Name.Text });
                    break;
                case (int)typyProducentow.MaszynyZielonkowe:
                    db.prod_zielonkowe.Add( new prod_zielonkowe { nazwa = Tb_Name.Text });
                    break;
                default:
                    break;                   
            }
                db.SaveChanges();
        }
        }
        public Page_TypesOfManufacturers()
        {
            InitializeComponent();
            typyProducenta = new List<string>();
            fillList();
            cb_typProducenta.ItemsSource = typyProducenta;
        }

        private void cb_typProducenta_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            checkTypeAndAdd(cb_typProducenta.SelectedIndex);
        }
    }
}
