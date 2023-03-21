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
using ManagementVinarie.Data;
using ManagementVinarie.Models.Vin;
using ManagementVinarie.Models.Servicii;
using Microsoft.Win32;
using System.IO;

namespace ManagementVinarie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            VinarieContext db = new VinarieContext();


        public Culoare CuloareSelectata;
        public ContinutAlcool AlcoolSelectat;
        public CalitateStruguri CalitateSelectat;
        public CantitateZahar ZaharSelectat;
        public SalaDegustare SalaSelectat;


        byte[] FSala;



        public MainWindow()
        {
            InitializeComponent();
            //date initiale
            /*
            db.Culori.AddRange
                (
                new Culoare { CuloareDenumire = "Alb" },
                new Culoare { CuloareDenumire = "Roșu" },
                new Culoare { CuloareDenumire = "Roz" }
                );
            db.ContinuturiAlcool.AddRange
                (
                new ContinutAlcool { ContinutAlcoolDenumire="Corp Plin"},
                new ContinutAlcool { ContinutAlcoolDenumire="Corp Mediu"},
                new ContinutAlcool { ContinutAlcoolDenumire="Corp Ușor"}
                );
            
               db.CalitatiStruguri.AddRange
                   (
                   new CalitateStruguri { CalitateStruguriNume = "De masă" },
                   new CalitateStruguri { CalitateStruguriNume = "De calitate superioară" },
                   new CalitateStruguri { CalitateStruguriNume = "De origine controlată" }
                   );
               db.CantitatiZahar.AddRange
                   (
                   new CantitateZahar { CantitateZaharDenumire = "Sec" },
                   new CantitateZahar { CantitateZaharDenumire = "Demisec" },
                   new CantitateZahar { CantitateZaharDenumire = "Demidulce" },
                   new CantitateZahar { CantitateZaharDenumire = "Dulce" }
                   );

               db.Clienti.AddRange
                   (
                   new Client { Nume = "1", Prenume = "1", DataNasterii = new DateOnly(1, 1, 1), Gen = "M", Telefon = "11111111", Email = "1.mail.com" },
                   new Client { Nume = "1", Prenume = "1", DataNasterii = new DateOnly(1, 1, 1), Gen = "M", Telefon = "11111111", Email = "1.mail.com" },
                   new Client { Nume = "1", Prenume = "1", DataNasterii = new DateOnly(1, 1, 1), Gen = "M", Telefon = "11111111", Email = "1.mail.com" },
                   new Client { Nume = "1", Prenume = "1", DataNasterii = new DateOnly(1, 1, 1), Gen = "M", Telefon = "11111111", Email = "1.mail.com" }
                   );

               db.SaveChanges();
               */

            CuloriDG.ItemsSource = db.Culori.ToList();
            AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
            CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
            ZaharDG.ItemsSource = db.CantitatiZahar.ToList();

            SaliDG.ItemsSource = db.SaliDegustare.ToList();

        }






        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }
       
        //////////////////////////////////////////
      
        private void AdaugareB_Click(object sender, RoutedEventArgs e)
        {
           
            
            string DenumireCuloare = DenumireCuloareTB.Text;

            if (DenumireCuloare == "") { MessageBox.Show("Introduceți o valaoare în câmpul denumire culoare"); }
            else
            {
                if (DenumireCuloare.Any(char.IsDigit)) 
                    { MessageBox.Show("Denumirea culorii nu poate conține cifre"); }
                else { 
                db.Culori.Add(new Culoare { CuloareDenumire = DenumireCuloare });

                db.SaveChanges();

                CuloriDG.ItemsSource = db.Culori.ToList();
                }
            }
        }

        private void CuloriDG_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }

        private void CuloriDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CuloareSelectata = (Culoare)CuloriDG.SelectedItem;
            if (CuloareSelectata != null)
            {
                DenumireCuloareTB.Text = CuloareSelectata.CuloareDenumire;
            }
            else
            {
                DenumireCuloareTB.Text = "";

            }
            
        }

        private void ModificareB_Click(object sender, RoutedEventArgs e)
        {

            if (CuloareSelectata != null) { 
            CuloareSelectata.CuloareDenumire = DenumireCuloareTB.Text;
            db.SaveChanges();
            CuloriDG.ItemsSource = db.Culori.ToList();
            }
            else
            {
                MessageBox.Show("Selectați culoarea care va fi modificată");
            }


        }

        private void StergereB_Click(object sender, RoutedEventArgs e)
        {
            if (CuloareSelectata != null)
            {
                db.Culori.Remove(CuloareSelectata);
                db.SaveChanges();
                CuloriDG.ItemsSource = db.Culori.ToList();
            }
            else
            {
                MessageBox.Show("Selectați culoarea care va fi ștearsă");

            }
        }
        private void AdaugareAlcoolB_Click(object sender, RoutedEventArgs e)
        {


            string DenumireAlcool = DenumireAlcoolTB.Text;

            if (DenumireAlcool == "") { MessageBox.Show("Introduceți o valaoare în câmpul denumire culoare"); }
            else
            {
                if (DenumireAlcool.Any(char.IsDigit))
                { MessageBox.Show("Denumirea culorii nu poate conține cifre"); }
                else
                {
                    db.ContinuturiAlcool.Add(new ContinutAlcool { ContinutAlcoolDenumire = DenumireAlcool });

                    db.SaveChanges();

                    AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
                }
            }
        }

        
        
        //////////////////////////////////////////////////////////////////////////
       
        private void AlcoolDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AlcoolSelectat = (ContinutAlcool)AlcoolDG.SelectedItem;
            if (AlcoolSelectat != null)
            {
                DenumireAlcoolTB.Text = AlcoolSelectat.ContinutAlcoolDenumire;
            }
            else
            {
                DenumireAlcoolTB.Text = "";

            }

        }

        private void ModificareAlcoolB_Click(object sender, RoutedEventArgs e)
        {

            if (AlcoolSelectat != null)
            {
                AlcoolSelectat.ContinutAlcoolDenumire = DenumireAlcoolTB.Text;
                db.SaveChanges();
                AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
            }
            else
            {
                MessageBox.Show("Selectați conținutul de alcool care va fi modificat");
            }


        }

        private void StergereAlcoolB_Click(object sender, RoutedEventArgs e)
        {
            if (AlcoolSelectat != null)
            {
                db.ContinuturiAlcool.Remove(AlcoolSelectat);
                db.SaveChanges();
                AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();

            }
            else
            {
                MessageBox.Show("Selectați conținutul de alcool care va fi șters");
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////
        private void AdaugareCalitateB_Click(object sender, RoutedEventArgs e)
        {


            string DenumireCalitate = DenumireCalitateTB.Text;

            if (DenumireCalitate == "") { MessageBox.Show("Introduceți o valaoare în câmpul denumire calității strugurilor"); }
            else
            {
                if (DenumireCalitate.Any(char.IsDigit))
                { MessageBox.Show("Denumirea calității strugurilor nu poate conține cifre"); }
                else
                {
                    db.CalitatiStruguri.Add(new CalitateStruguri { CalitateStruguriNume = DenumireCalitate });

                    db.SaveChanges();

                    CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
                }
            }
        }



        private void CalitatiDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CalitateSelectat = (CalitateStruguri)CalitatiDG.SelectedItem;
            if (CalitateSelectat != null)
            {
                DenumireCalitateTB.Text = CalitateSelectat.CalitateStruguriNume;
            }
            else
            {
                DenumireCalitateTB.Text = "";

            }

        }

        private void ModificareCalitateB_Click(object sender, RoutedEventArgs e)
        {

            if (CalitateSelectat != null)
            {
                CalitateSelectat.CalitateStruguriNume = DenumireCalitateTB.Text;
                db.SaveChanges();
                CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
            }
            else
            {
                MessageBox.Show("Selectați calitatea strugurilor care va fi modificată");
            }


        }

        private void StergereCalitateB_Click(object sender, RoutedEventArgs e)
        {
            if (CalitateSelectat != null)
            {
                db.CalitatiStruguri.Remove(CalitateSelectat);
                db.SaveChanges();
                CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();

            }
            else
            {
                MessageBox.Show("Selectați calitatea strugurilor care va fi ștersă");
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////
        private void AdaugareZaharB_Click(object sender, RoutedEventArgs e)
        {


            string DenumireZahar = DenumireZaharTB.Text;

            if (DenumireZahar == "") { MessageBox.Show("Introduceți o valaoare în câmpul denumire cantității zahărului"); }
            else
            {
                if (DenumireZahar.Any(char.IsDigit))
                { MessageBox.Show("Denumirea cantității zahărului nu poate conține cifre"); }
                else
{
    db.CantitatiZahar.Add(new CantitateZahar { CantitateZaharDenumire = DenumireZahar });

    db.SaveChanges();

    ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
}
            }
        }



        private void ZaharDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
    ZaharSelectat = (CantitateZahar)ZaharDG.SelectedItem;
    if (ZaharSelectat != null)
    {
        DenumireZaharTB.Text = ZaharSelectat.CantitateZaharDenumire;
    }
    else
    {
                DenumireZaharTB.Text = "";

    }

}

private void ModificareZaharB_Click(object sender, RoutedEventArgs e)
{

    if (ZaharSelectat != null)
    {
                ZaharSelectat.CantitateZaharDenumire = DenumireZaharTB.Text;
        db.SaveChanges();
        ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
    }
    else
    {
        MessageBox.Show("Selectați cantitatea de zahăr care va fi modificată");
    }


}

private void StergereZaharB_Click(object sender, RoutedEventArgs e)
{
    if (ZaharSelectat != null)
    {
        db.CantitatiZahar.Remove(ZaharSelectat);
        db.SaveChanges();
        ZaharDG.ItemsSource = db.CantitatiZahar.ToList();

    }
    else
    {
        MessageBox.Show("Selectați  cantitatea de zahăr care va fi ștersă");
    }
}

        ////////////////////////////////////////////////////////////////////////////////////
        private void AdaugareSalaB_Click(object sender, RoutedEventArgs e)
        {


            string DenumireSala = DenumireSalaTB.Text;

            if (SalaIMG.Source == null) { MessageBox.Show("Introduceți o imagine în câmpul pentru imagine sală");return; }

            if (DenumireSala == "") { MessageBox.Show("Introduceți o valaoare în câmpul denumire sala"); }
            else
            {
                if (DescriereSalaTB.Text == "") MessageBox.Show("Introduceți o valaoare în câmpul denumire sala");
                else
                    if (DenumireSala.Any(char.IsDigit))
                { MessageBox.Show("Denumirea sălii nu poate conține cifre"); }
                else
                {
                    db.SaliDegustare.Add(new SalaDegustare {SalaDegustareDenumire  = DenumireSala,SalaDegustareDescriere= DescriereSalaTB.Text,Foto=FSala});

                    db.SaveChanges();

                    SaliDG.ItemsSource = db.SaliDegustare.ToList();
                }
            }
        }

       

        private void SaliDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SalaSelectat = (SalaDegustare)SaliDG.SelectedItem;
            if (SalaSelectat != null)
            {
                DenumireSalaTB.Text = SalaSelectat.SalaDegustareDenumire;
                DescriereSalaTB.Text = SalaSelectat.SalaDegustareDescriere;
               
            }
            else
            {
                DenumireSalaTB.Text ="";
                DescriereSalaTB.Text = "";
                SalaIMG.Source = null;

            }

        }

        private void ModificareSalaB_Click(object sender, RoutedEventArgs e)
        {

            if (SalaSelectat != null)
            {
                SalaSelectat.SalaDegustareDenumire = DenumireSalaTB.Text;
                db.SaveChanges();
                SaliDG.ItemsSource = db.SaliDegustare.ToList();
            }
            else
            {
                MessageBox.Show("Selectați sala care va fi modificată");
            }


        }

        private void StergereSalaB_Click(object sender, RoutedEventArgs e)
        {
            if (SalaSelectat != null)
            {
                db.SaliDegustare.Remove(SalaSelectat);
                db.SaveChanges();
                SaliDG.ItemsSource = db.SaliDegustare.ToList();

            }
            else
            {
                MessageBox.Show("Selectați  sala care va fi ștersă");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);

                SalaIMG.Source = new BitmapImage(fileUri);

               FSala = File.ReadAllBytes(openFileDialog.FileName);

            }
        }
    }
}
