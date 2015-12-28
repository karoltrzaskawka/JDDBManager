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
    /// Interaction logic for Page_AddClient.xaml
    /// </summary>
    public partial class Page_AddClient : Page
    {
        List<TextBox> TbList = new List<TextBox>();
        public Page_AddClient()
        {            
            TbList.Add(Tb_Address);
            TbList.Add(Tb_Name);
            TbList.Add(Tb_Email);
            TbList.Add(Tb_LastName);
            TbList.Add(Tb_HouseNumber);
            TbList.Add(Tb_NIP);
            TbList.Add(Tb_CompanyName);
            TbList.Add(Tb_City);
            TbList.Add(Tb_PostCode);
            TbList.Add(Tb_Title);
            TbList.Add(Tb_Area);
            TbList.Add(Tb_phoneNumber);
            InitializeComponent();
        }
        private bool checkColor(bool[] isGood)
        {
            foreach (var n in TbList)
                n.Background = Brushes.Yellow;
            if (isGood[(int)Vfunc.polaKlient.imie] == false)
                Tb_Name.Background = Brushes.Red;
            if (isGood[(int)Vfunc.polaKlient.nazwisko] == false)
                Tb_LastName.Background = Brushes.Red;
            if (isGood[(int)Vfunc.polaKlient.adres] == false)
                Tb_Address.Background = Brushes.Red;
            if (isGood[(int)Vfunc.polaKlient.telefon] == false)
                Tb_phoneNumber.Background = Brushes.Red;
            if (isGood[(int)Vfunc.polaKlient.email] == false)
                Tb_Email.Background = Brushes.Red;
            if (isGood[(int)Vfunc.polaKlient.zwrot] == false)
                Tb_Title.Background = Brushes.Red;
            if (isGood[(int)Vfunc.polaKlient.nazwafirmy] == false)
                Tb_CompanyName.Background = Brushes.Red;
            if (isGood[(int)Vfunc.polaKlient.kod_pocztowy] == false)
                Tb_PostCode.Background = Brushes.Red;
            if (isGood[(int)Vfunc.polaKlient.NIP] == false)
                Tb_NIP.Background = Brushes.Red;
            for (int i = 0; i < 9; i++)
                if (isGood[i] == false)
                    return false;
            return true;
        }

        private void Btn_AddNewClient_Click(object sender, RoutedEventArgs e)
        {            
            using (var db = new ModelJDB())
            {
                var klient = new klient { imie = Tb_Name.Text, nazwisko = Tb_LastName.Text, telefon = Tb_phoneNumber.Text, adres = Tb_Address.Text, email = Tb_Email.Text, nazwa_firmy = Tb_CompanyName.Text, kod_pocztowy = Tb_PostCode.Text, nip = Tb_NIP.Text };  
                if(checkColor(Vfunc.validateAddKlientValues(klient))==true)
                {
                     db.klients.Add(klient);
                     db.SaveChanges();
                }
            }
    }
    }
}
