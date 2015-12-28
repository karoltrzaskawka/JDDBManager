using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.Entity;
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
    /// Interaction logic for Page_AddMachine.xaml
    /// </summary>
    public partial class Page_AddMachine : Page
    {
        List<String> typesOfMachines;
        List<String> typySiewnika;
        public enum typSiewnika { zwykly = 0, punktowy = 1 };
        public enum typyProducentow { Ciagniki =0, Kombajny = 1, Siewniki =2, MaszynyZielonkowe=3, Opryskiwacze =4, Rozsiewacze=5, ZestawyUprawowe=6 }
       public void checkTypeAndAdd(int index)
        {
            using (var db = new ModelJDB())
            {
                switch (index)
                {
                    case (int)typyProducentow.Ciagniki:
                   //     db.ciagniki.Add(new ciagniki { });
                        break;
                    /*  case (int)typyProducentow.Kombajny:
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
                          break;*/
                    default:
                        break;
                }
            }
                //db.SaveChanges();
        }
        public void hideAdditionalFields()
       {
           tb_liczbaRzedow.Visibility = Visibility.Hidden;
           L_liczbaRzedow.Visibility = Visibility.Hidden;
           tb_liczbaSekcji.Visibility = Visibility.Hidden;
           L_liczbaSekcji.Visibility = Visibility.Hidden;
           tb_szerokosc.Visibility = Visibility.Hidden;
           L_szerokosc.Visibility = Visibility.Hidden;
       }
        public void checkGUI(int index)
        {
            Btn_Add.Visibility = Visibility.Visible;
            GUI_Ciagnik.Visibility = Visibility.Visible;
            Cb_TypSiewnika.Visibility = Visibility.Hidden;
            hideAdditionalFields();
            switch (index)
            {          
                
                case (int)typyProducentow.Ciagniki:
                    ChkB_ISOBUS.Visibility=Visibility.Hidden;
                    hideAdditionalFields();
                    break;
               case (int)typyProducentow.Kombajny:
                    ChkB_ISOBUS.Visibility = Visibility.Hidden;
                    hideAdditionalFields();
                     break;
                case (int)typyProducentow.Siewniki:
                     ChkB_ISOBUS.Visibility = Visibility.Visible;
                     Cb_TypSiewnika.Visibility = Visibility.Visible;
                    break;
                case (int)typyProducentow.ZestawyUprawowe:
                    ChkB_ISOBUS.Visibility = Visibility.Hidden;                    
                    hideAdditionalFields();
                    L_szerokosc.Visibility = Visibility.Visible;
                    tb_szerokosc.Visibility = Visibility.Visible;
                    break;
                case (int)typyProducentow.Rozsiewacze:
                    ChkB_ISOBUS.Visibility = Visibility.Visible;
                    hideAdditionalFields();
                    break;
                case (int)typyProducentow.Opryskiwacze:
                    ChkB_ISOBUS.Visibility = Visibility.Visible;
                    hideAdditionalFields();
                    break;
                case (int)typyProducentow.MaszynyZielonkowe:
                    hideAdditionalFields();
                    ChkB_ISOBUS.Visibility = Visibility.Visible;
                    L_szerokosc.Visibility = Visibility.Visible;
                    tb_szerokosc.Visibility = Visibility.Visible;
                    break;
                default:                    
                    break;    
            }
        }
        public void checkSiewnikGUI(int index)
        {
            if (Cb_TypSiewnika.Visibility == Visibility.Visible)
            {
                tb_liczbaSekcji.Visibility = Visibility.Visible;
                L_liczbaSekcji.Visibility = Visibility.Visible;
                tb_szerokosc.Visibility = Visibility.Visible;
                L_szerokosc.Visibility = Visibility.Visible;
                switch (index)
                {
                    case (int)typSiewnika.zwykly:
                        tb_liczbaRzedow.Visibility = Visibility.Visible;
                        L_liczbaRzedow.Visibility = Visibility.Visible;
                        break;
                    case (int)typSiewnika.punktowy:
                        tb_liczbaRzedow.Visibility = Visibility.Hidden;
                        L_liczbaRzedow.Visibility = Visibility.Hidden;
                        break;
                    default:
                        break;
                }
            }
        }
            void fillList()
        {
            typesOfMachines = new List<String>();
            typesOfMachines.Add("Ciagnik");
            typesOfMachines.Add("Kombajn");
            typesOfMachines.Add("Siewnik");
            typesOfMachines.Add("Zestaw uprawowy");
            typesOfMachines.Add("Rozsiewacz");
            typesOfMachines.Add("Opryskiwacz");           
            typesOfMachines.Add("Maszyna zielonkowa");
            typySiewnika = new List<String>();
            typySiewnika.Add("Zwykły");
            typySiewnika.Add("Punktowy");
            
        }
        private ModelJDB _context = new ModelJDB();
        public void loadManufacturer(int TypMaszyny)
        {
            switch (TypMaszyny)
            {
                case (int)typyProducentow.Ciagniki:          
                _context.prod_ciagniki.Load();
                cb_producent.ItemsSource = _context.prod_ciagniki.Local;
                    break;            
                case (int)typyProducentow.Kombajny:
                _context.prod_kombajny.Load();
                cb_producent.ItemsSource = _context.prod_kombajny.Local;
                break;
                case (int)typyProducentow.Opryskiwacze:
                _context.prod_opryskiwacze.Load();
                cb_producent.ItemsSource = _context.prod_opryskiwacze.Local;
                break;
                case (int)typyProducentow.Rozsiewacze:
                _context.prod_rozsiewacze.Load();
                cb_producent.ItemsSource = _context.prod_rozsiewacze.Local;
                break;
                case (int)typyProducentow.Siewniki:
                _context.prod_siewniki.Load();
                cb_producent.ItemsSource = _context.prod_siewniki.Local;
                break;
                case (int)typyProducentow.ZestawyUprawowe:
                _context.prod_zestawy_uprawowe.Load();
                cb_producent.ItemsSource = _context.zestawy_uprawowe.Local;
                break;
                case (int)typyProducentow.MaszynyZielonkowe:
                _context.prod_zielonkowe.Load();
                cb_producent.ItemsSource = _context.prod_zielonkowe.Local;               
                break;
                default:
                break;
        }
            cb_producent.DisplayMemberPath = "nazwa";
        }
        public Page_AddMachine()
        {
            InitializeComponent();
            fillList();
            cb_typesOfMachines.ItemsSource = typesOfMachines;
            Cb_TypSiewnika.ItemsSource = typySiewnika;
            _context.klients.Load();
            cb_klient.ItemsSource = _context.klients.Local ;
            cb_klient.DisplayMemberPath = "imie";
        }
        private void cb_typesOfMachines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            checkGUI(cb_typesOfMachines.SelectedIndex);
            checkSiewnikGUI(Cb_TypSiewnika.SelectedIndex);
            loadManufacturer(cb_typesOfMachines.SelectedIndex);
        }
        public void addMachine(int TypMaszyny)
        {
            using (var db = new ModelJDB())
                    {
                        klient tempKlient = (klient)cb_klient.SelectedItem;
            switch (TypMaszyny)
            {
                case (int)typyProducentow.Ciagniki:                                      
                        prod_ciagniki tempProdC = (prod_ciagniki)cb_producent.SelectedItem;
                        var ciagnik = new ciagniki { id_klienta =tempKlient.id_klienta, marka = tempProdC.id_producenta,  model = tb_model.Text, rok_produkcji = Int32.Parse(tb_rokProdukcji.Text), nr_seryjny = tb_numerSeryjny.Text };
                        db.ciagnikis.Add(ciagnik);                                    
                    break;
                 case (int)typyProducentow.Kombajny:
                        prod_kombajny tempProdK = (prod_kombajny)cb_producent.SelectedItem;                       
                        var kombajn = new kombajny { id_klienta =tempKlient.id_klienta, marka = tempProdK.id_producenta,  model = tb_model.Text, rok_produkcji = Int32.Parse(tb_rokProdukcji.Text), nr_seryjny = tb_numerSeryjny.Text };
                        db.kombajnies.Add(kombajn);
                     break;
                 case (int)typyProducentow.Opryskiwacze:
                        prod_opryskiwacze tempProdO = (prod_opryskiwacze)cb_producent.SelectedItem;
                        var opryskiwacz = new opryskiwacze { isobus = (bool)ChkB_ISOBUS.IsChecked, id_klienta = tempKlient.id_klienta, marka = tempProdO.id_producenta, model = tb_model.Text, rok_produkcji = Int32.Parse(tb_rokProdukcji.Text), nr_seryjny = tb_numerSeryjny.Text };
                        db.opryskiwaczes.Add(opryskiwacz);
                     break;
                 case (int)typyProducentow.Rozsiewacze:
                        prod_rozsiewacze tempProdR = (prod_rozsiewacze)cb_producent.SelectedItem;                       
                        var rozsiewacz = new rozsiewacze { id_klienta =tempKlient.id_klienta, marka = tempProdR.id_producenta,  model = tb_model.Text, rok_produkcji = Int32.Parse(tb_rokProdukcji.Text), nr_seryjny = tb_numerSeryjny.Text };
                        db.rozsiewaczes.Add(rozsiewacz);
                     break;
                 case (int)typyProducentow.Siewniki:
                        prod_siewniki tempProdS = (prod_siewniki)cb_producent.SelectedItem;                       
                        var siewnik = new siewniki {liczba_rzedow = Int32.Parse(tb_liczbaRzedow.Text),liczba_sekcji = Int32.Parse(tb_liczbaSekcji.Text), szerokosc = Int32.Parse(tb_szerokosc.Text), isobus = (bool)ChkB_ISOBUS.IsChecked, id_klienta =tempKlient.id_klienta, marka = tempProdS.id_producenta,  model = tb_model.Text, rok_produkcji = Int32.Parse(tb_rokProdukcji.Text), nr_seryjny = tb_numerSeryjny.Text };
                        db.siewnikis.Add(siewnik);
                     break;
                 case (int)typyProducentow.ZestawyUprawowe:
                     prod_zestawy_uprawowe tempProdZ = (prod_zestawy_uprawowe)cb_producent.SelectedItem;                       
                        var zestawUprawowy = new zestawy_uprawowe { szerokosc = Int32.Parse(tb_szerokosc.Text), id_klienta =tempKlient.id_klienta, marka = tempProdZ.id_producenta,  model = tb_model.Text, rok_produkcji = Int32.Parse(tb_rokProdukcji.Text), nr_seryjny = tb_numerSeryjny.Text };
                        db.zestawy_uprawowe.Add(zestawUprawowy);
                     break;
                 case (int)typyProducentow.MaszynyZielonkowe:
                      prod_zielonkowe tempProdZiel = (prod_zielonkowe)cb_producent.SelectedItem;                       
                        var MaszynaZielonkowa = new maszyny_zielonkowe {szerokosc = Int32.Parse(tb_szerokosc.Text), id_klienta =tempKlient.id_klienta, marka = tempProdZiel.id_producenta,  model = tb_model.Text, rok_produkcji = Int32.Parse(tb_rokProdukcji.Text), nr_seryjny = tb_numerSeryjny.Text };
                        db.maszyny_zielonkowe.Add(MaszynaZielonkowa);
                     break;
                default:
                    break;
            }
                db.SaveChanges();   
            }
            }
        
        private void comboBoxFormat(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            addMachine(cb_typesOfMachines.SelectedIndex);
        }

        private void Cb_TypSiewnika_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            checkSiewnikGUI(Cb_TypSiewnika.SelectedIndex);
        }
    }
}
