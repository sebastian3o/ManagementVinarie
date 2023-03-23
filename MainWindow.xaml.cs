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
using ManagementVinarie.Models.Vin_;
using ManagementVinarie.Models.Servicii;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ManagementVinarie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VinarieContext db;


        public Culoare CuloareSelectata;
        public ContinutAlcool AlcoolSelectat;
        public CalitateStruguri CalitateSelectat;
        public CantitateZahar ZaharSelectat;
        public Clasificare ClasificareSelectat;
        public Vin VinSelectat;

        public SalaDegustare SalaSelectat;
        public Client ClientSelectat;
        public Pachet PachetSelectat;
        public Rezervare RezervareSelectat;
       


        bool AdaugaImagine;
        bool AdaugaImagineVin;
        Byte[] ImagineSelectata;


        public MainWindow()
        {
            InitializeComponent();
            db = new VinarieContext();
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
                 new Client { Nume = "Popescu", Prenume = "Alexandra", DataNasterii = new DateOnly(1995, 3, 15), Gen = "F", Telefon = "0723456789", Email = "alexandra.popescu@gmail.com" },
new Client { Nume = "Ionescu", Prenume = "Andrei", DataNasterii = new DateOnly(1987, 11, 4), Gen = "M", Telefon = "0756789123", Email = "andrei.ionescu@yahoo.com" },
new Client { Nume = "Marinescu", Prenume = "Maria", DataNasterii = new DateOnly(2001, 8, 22), Gen = "F", Telefon = "0721456789", Email = "maria.marinescu@hotmail.com" },
new Client { Nume = "Popa", Prenume = "Mihai", DataNasterii = new DateOnly(1998, 5, 1), Gen = "M", Telefon = "0732123456", Email = "mihai.popa@gmail.com" },
new Client { Nume = "Radu", Prenume = "Ana", DataNasterii = new DateOnly(2002, 9, 12), Gen = "F", Telefon = "0744567890", Email = "ana.radu@yahoo.com" },
new Client { Nume = "Badea", Prenume = "Cristian", DataNasterii = new DateOnly(1980, 2, 27), Gen = "M", Telefon = "0723456123", Email = "cristian.badea@gmail.com" },
new Client { Nume = "Pop", Prenume = "Alina", DataNasterii = new DateOnly(1992, 12, 10), Gen = "F", Telefon = "0723789456", Email = "alina.pop@yahoo.com" },
new Client { Nume = "Stoica", Prenume = "Mircea", DataNasterii = new DateOnly(1985, 6, 19), Gen = "M", Telefon = "0732678945", Email = "mircea.stoica@hotmail.com" },
new Client { Nume = "Dumitru", Prenume = "Elena", DataNasterii = new DateOnly(2004, 1, 3), Gen = "F", Telefon = "0723678912", Email = "elena.dumitru@gmail.com" },
new Client { Nume = "Gheorghe", Prenume = "Victor", DataNasterii = new DateOnly(1977, 8, 7), Gen = "M", Telefon = "0745789123", Email = "victor.gheorghe@yahoo.com" },
new Client { Nume = "Iancu", Prenume = "Loredana", DataNasterii = new DateOnly(1999, 4, 25), Gen = "F", Telefon = "0723456709", Email = "loredana.iancu@hotmail.com" },
new Client { Nume = "Neagu", Prenume = "George", DataNasterii = new DateOnly(1982, 10, 8), Gen = "M", Telefon = "0721345678", Email = "george.neagu@gmail.com" },
new Client { Nume = "Constantin", Prenume = "Andreea", DataNasterii = new DateOnly(1997, 2, 17), Gen = "F", Telefon = "0724567891", Email = "andreea.constantin@yahoo.com" },
new Client { Nume = "Diaconu", Prenume = "Ciprian", DataNasterii = new DateOnly(1988, 6, 29), Gen = "M", Telefon = "0756789123", Email = "ciprian.diaconu@hotmail.com" },
new Client { Nume = "Vasilescu", Prenume = "Diana", DataNasterii = new DateOnly(2000, 11, 14), Gen = "F", Telefon = "0723456789", Email = "diana.vasilescu@gmail.com" },
new Client { Nume = "Munteanu", Prenume = "Ionut", DataNasterii = new DateOnly(1993, 7, 23), Gen = "M", Telefon = "0745678912", Email = "ionut.munteanu@yahoo.com" },
new Client { Nume = "Preda", Prenume = "Ana-Maria", DataNasterii = new DateOnly(1990, 4, 12), Gen = "F", Telefon = "0734567890", Email = "ana-maria.preda@hotmail.com" },
new Client { Nume = "Georgescu", Prenume = "Andrei", DataNasterii = new DateOnly(1983, 9, 2), Gen = "M", Telefon = "0741234567", Email = "andrei.georgescu@gmail.com" },
new Client { Nume = "Petrescu", Prenume = "Elena", DataNasterii = new DateOnly(1996, 5, 7), Gen = "F", Telefon = "0723678912", Email = "elena.petrescu@yahoo.com" },
new Client { Nume = "Mihai", Prenume = "George", DataNasterii = new DateOnly(1989, 12, 20), Gen = "M", Telefon = "0732123456", Email = "george.mihai@hotmail.com" }
                   );
            */

            /*
            db.Culori.AddRange
               (
              new Culoare { CuloareDenumire = "Roșu închis" },
new Culoare { CuloareDenumire = "Roșu rubiniu" },
new Culoare { CuloareDenumire = "Roșu violaceu" },
new Culoare { CuloareDenumire = "Portocaliu" },
new Culoare { CuloareDenumire = "Galben pai" },
new Culoare { CuloareDenumire = "Auriu" },
new Culoare { CuloareDenumire = "Culoare somon" },
new Culoare { CuloareDenumire = "Roșu-deschis" },
new Culoare { CuloareDenumire = "Roșu-grena" },
new Culoare { CuloareDenumire = "Culoare rubinie" }
               );
            */
           

            db.SaveChanges();
            CuloriDG.ItemsSource = db.Culori.ToList();
            AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
            CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
            ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
           ClasificariDG.ItemsSource = db.Clasificari.ToList();
           


            SaliDG.ItemsSource = db.SaliDegustare.ToList();
            ClientiDG.ItemsSource = db.Clienti.ToList();
            PacheteDG.ItemsSource = db.Pachete.ToList();
           RezervariDG.ItemsSource = db.Rezervari.ToList();

            VinuriDG.ItemsSource = db.Vinuri.ToList();



          //  SalaDegustareCB.Items.Clear();


        }





        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }

        /////////////////////////////////////////////

        private void AdaugareB_Click(object sender, RoutedEventArgs e)
        {


            string DenumireCuloare = DenumireCuloareTB.Text;

            if (String.IsNullOrEmpty(DenumireCuloare)) { MessageBox.Show("Introduceți o valaoare în câmpul denumire culoare"); }
            else
            {
                if (DenumireCuloare.Any(char.IsDigit))
                { MessageBox.Show("Denumirea culorii nu poate conține cifre"); }
                else
                {
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

            if (CuloareSelectata != null)
            {
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
                if (db.Clasificari.Any(x => x.Culoare == CuloareSelectata))
                {
                    MessageBoxResult result = MessageBox.Show("Stergerea dată va provoca ștergerea rândurilor din tabelul clasificari", "Confirmation", MessageBoxButton.OKCancel);

                    if (result == MessageBoxResult.OK)
                    {
                        db.Culori.Remove(CuloareSelectata);
                        db.SaveChanges();
                        CuloriDG.ItemsSource = db.Culori.ToList();

                        CuloriDG.ItemsSource = db.Culori.ToList();
                        AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
                        CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
                        ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
                        ClasificariDG.ItemsSource = db.Clasificari.ToList();



                        SaliDG.ItemsSource = db.SaliDegustare.ToList();
                        ClientiDG.ItemsSource = db.Clienti.ToList();
                        PacheteDG.ItemsSource = db.Pachete.ToList();
                        RezervariDG.ItemsSource = db.Rezervari.ToList();

                        VinuriDG.ItemsSource = db.Vinuri.ToList();
                    }

                }
                else
                {
                    db.Culori.Remove(CuloareSelectata);
                    db.SaveChanges();
                    CuloriDG.ItemsSource = db.Culori.ToList();

                    CuloriDG.ItemsSource = db.Culori.ToList();
                    AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
                    CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
                    ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
                    ClasificariDG.ItemsSource = db.Clasificari.ToList();



                    SaliDG.ItemsSource = db.SaliDegustare.ToList();
                    ClientiDG.ItemsSource = db.Clienti.ToList();
                    PacheteDG.ItemsSource = db.Pachete.ToList();
                    RezervariDG.ItemsSource = db.Rezervari.ToList();

                    VinuriDG.ItemsSource = db.Vinuri.ToList();
                }
            }
            else
            {
                MessageBox.Show("Selectați culoarea care va fi ștearsă");

            }
        }
        //////////////////////////////////////////////////////////////////////////
        private void AdaugareAlcoolB_Click(object sender, RoutedEventArgs e)
        {


            string DenumireAlcool = DenumireAlcoolTB.Text;

            if (String.IsNullOrEmpty(DenumireAlcool)) { MessageBox.Show("Introduceți o valaoare în câmpul denumire culoare"); }
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
                if (db.Clasificari.Any(x => x.ContinutAlcool == AlcoolSelectat))
                {
                    MessageBoxResult result = MessageBox.Show("Stergerea dată va provoca ștergerea rândurilor din tabelul clasificari", "Confirmation", MessageBoxButton.OKCancel);

                    if (result == MessageBoxResult.OK)
                    {

                        db.ContinuturiAlcool.Remove(AlcoolSelectat);
                        db.SaveChanges();
                        AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();


                        CuloriDG.ItemsSource = db.Culori.ToList();
                        AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
                        CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
                        ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
                        ClasificariDG.ItemsSource = db.Clasificari.ToList();



                        SaliDG.ItemsSource = db.SaliDegustare.ToList();
                        ClientiDG.ItemsSource = db.Clienti.ToList();
                        PacheteDG.ItemsSource = db.Pachete.ToList();
                        RezervariDG.ItemsSource = db.Rezervari.ToList();

                        VinuriDG.ItemsSource = db.Vinuri.ToList();
                    }

                }
                else
                {
                    db.ContinuturiAlcool.Remove(AlcoolSelectat);
                    db.SaveChanges();
                    AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();


                    CuloriDG.ItemsSource = db.Culori.ToList();
                    AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
                    CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
                    ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
                    ClasificariDG.ItemsSource = db.Clasificari.ToList();



                    SaliDG.ItemsSource = db.SaliDegustare.ToList();
                    ClientiDG.ItemsSource = db.Clienti.ToList();
                    PacheteDG.ItemsSource = db.Pachete.ToList();
                    RezervariDG.ItemsSource = db.Rezervari.ToList();

                    VinuriDG.ItemsSource = db.Vinuri.ToList();
                }
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

            if (String.IsNullOrEmpty(DenumireCalitate)) { MessageBox.Show("Introduceți o valaoare în câmpul denumire calității strugurilor"); }
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
                if (db.Clasificari.Any(x => x.CalitateStruguri == CalitateSelectat))
                {
                    MessageBoxResult result = MessageBox.Show("Stergerea dată va provoca ștergerea rândurilor din tabelul clasificari", "Confirmation", MessageBoxButton.OKCancel);

                    if (result == MessageBoxResult.OK)
                    {
                        db.CalitatiStruguri.Remove(CalitateSelectat);
                        db.SaveChanges();
                        CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();

                        CuloriDG.ItemsSource = db.Culori.ToList();
                        AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
                        CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
                        ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
                        ClasificariDG.ItemsSource = db.Clasificari.ToList();



                        SaliDG.ItemsSource = db.SaliDegustare.ToList();
                        ClientiDG.ItemsSource = db.Clienti.ToList();
                        PacheteDG.ItemsSource = db.Pachete.ToList();
                        RezervariDG.ItemsSource = db.Rezervari.ToList();

                        VinuriDG.ItemsSource = db.Vinuri.ToList();
                    }

                }
                else
                {
                    db.CalitatiStruguri.Remove(CalitateSelectat);
                    db.SaveChanges();
                    CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();

                    CuloriDG.ItemsSource = db.Culori.ToList();
                    AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
                    CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
                    ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
                    ClasificariDG.ItemsSource = db.Clasificari.ToList();



                    SaliDG.ItemsSource = db.SaliDegustare.ToList();
                    ClientiDG.ItemsSource = db.Clienti.ToList();
                    PacheteDG.ItemsSource = db.Pachete.ToList();
                    RezervariDG.ItemsSource = db.Rezervari.ToList();

                    VinuriDG.ItemsSource = db.Vinuri.ToList();
                }
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

            if (String.IsNullOrEmpty(DenumireZahar)) { MessageBox.Show("Introduceți o valaoare în câmpul denumire cantității zahărului"); }
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
                if (db.Clasificari.Any(x => x.CantitateZahar == ZaharSelectat))
                {
                    MessageBoxResult result = MessageBox.Show("Stergerea dată va provoca ștergerea rândurilor din tabelul clasificari", "Confirmation", MessageBoxButton.OKCancel);

                    if (result == MessageBoxResult.OK)
                    {
                        db.CantitatiZahar.Remove(ZaharSelectat);
                        db.SaveChanges();
                        ZaharDG.ItemsSource = db.CantitatiZahar.ToList();

                        CuloriDG.ItemsSource = db.Culori.ToList();
                        AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
                        CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
                        ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
                        ClasificariDG.ItemsSource = db.Clasificari.ToList();



                        SaliDG.ItemsSource = db.SaliDegustare.ToList();
                        ClientiDG.ItemsSource = db.Clienti.ToList();
                        PacheteDG.ItemsSource = db.Pachete.ToList();
                        RezervariDG.ItemsSource = db.Rezervari.ToList();

                        VinuriDG.ItemsSource = db.Vinuri.ToList();
                    }

                }
                else
                {
                    db.CantitatiZahar.Remove(ZaharSelectat);
                    db.SaveChanges();
                    ZaharDG.ItemsSource = db.CantitatiZahar.ToList();

                    CuloriDG.ItemsSource = db.Culori.ToList();
                    AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
                    CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
                    ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
                    ClasificariDG.ItemsSource = db.Clasificari.ToList();



                    SaliDG.ItemsSource = db.SaliDegustare.ToList();
                    ClientiDG.ItemsSource = db.Clienti.ToList();
                    PacheteDG.ItemsSource = db.Pachete.ToList();
                    RezervariDG.ItemsSource = db.Rezervari.ToList();

                    VinuriDG.ItemsSource = db.Vinuri.ToList();
                }
            }
            else
            {
                MessageBox.Show("Selectați  cantitatea de zahăr care va fi ștersă");
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////

        public byte[] ConvertImageSourceToByteArray(ImageSource imageSource)
        {
            if (imageSource == null)
                return null;

            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
            bitmapImage.UriSource = new Uri(imageSource.ToString());
            bitmapImage.EndInit();

            var encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bitmapImage));

            using (var stream = new MemoryStream())
            {
                encoder.Save(stream);
                return stream.ToArray();
            }
        }
       

        public BitmapImage LoadImageFromByteArray(byte[] byteArray)
        {
            BitmapImage image = new BitmapImage();
            using (MemoryStream stream = new MemoryStream(byteArray))
            {
                stream.Position = 0;
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = stream;
                image.EndInit();
            }
            return image;
        }

        private void AdaugareSalaB_Click(object sender, RoutedEventArgs e)
        {
           
                //db.SaliDegustare.Remove()   
                string DenumireSala = DenumireSalaTB.Text;

                if (SalaIMG.Source == null) { MessageBox.Show("Introduceți o imagine în c85âmpul pentru imagine sală"); return; }

                if (String.IsNullOrEmpty(DenumireSala)) { MessageBox.Show("Introduceți o valaoare în câmpul denumire sala"); }
                else
                {
                    if (String.IsNullOrEmpty(DescriereSalaTB.Text)) MessageBox.Show("Introduceți o valaoare în câmpul denumire sala");
                    else
                        if (DenumireSala.Any(char.IsDigit))
                    { MessageBox.Show("Denumirea sălii nu poate conține cifre"); }
                    else
                    {
                      if(AdaugaImagine)  db.SaliDegustare.Add(new SalaDegustare { SalaDegustareDenumire = DenumireSala, SalaDegustareDescriere = DescriereSalaTB.Text, Foto = ConvertImageSourceToByteArray(SalaIMG.Source) });
                      else db.SaliDegustare.Add(new SalaDegustare { SalaDegustareDenumire = DenumireSala, SalaDegustareDescriere = DescriereSalaTB.Text, Foto = SalaSelectat.Foto });
                    //  MessageBox.Show(BufferFromImage((BitmapImage)SalaIMG.Source).ToString());
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
                // FSala = SalaSelectat.Foto;
                SalaIMG.Source = LoadImageFromByteArray(SalaSelectat.Foto);
                AdaugaImagine = false;

            }
            else
            {
                DenumireSalaTB.Text = "";
                DescriereSalaTB.Text = "";
                SalaIMG.Source = null;
                AdaugaImagine = false;

            }

        }

        private void ModificareSalaB_Click(object sender, RoutedEventArgs e)
        {

            if (SalaSelectat != null)
            {
                SalaSelectat.SalaDegustareDenumire = DenumireSalaTB.Text;
                if (AdaugaImagine) SalaSelectat.Foto = ConvertImageSourceToByteArray(SalaIMG.Source);
                db.SaveChanges();
                SaliDG.ItemsSource = db.SaliDegustare.ToList();
                AdaugaImagine = false;

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

                if (db.Pachete.Any(x => x.SalaDegustare == SalaSelectat))
                    {
                        MessageBoxResult result = MessageBox.Show("Stergerea dată va provoca ștergerea rândurilor din tabelul pachete", "Confirmation", MessageBoxButton.OKCancel);

                        if (result == MessageBoxResult.OK)
                        {

                            db.SaliDegustare.Remove(SalaSelectat);
                            db.SaveChanges();
                            SaliDG.ItemsSource = db.SaliDegustare.ToList();

                            CuloriDG.ItemsSource = db.Culori.ToList();
                            AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
                            CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
                            ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
                            ClasificariDG.ItemsSource = db.Clasificari.ToList();



                            SaliDG.ItemsSource = db.SaliDegustare.ToList();
                            ClientiDG.ItemsSource = db.Clienti.ToList();
                            PacheteDG.ItemsSource = db.Pachete.ToList();
                            RezervariDG.ItemsSource = db.Rezervari.ToList();

                            VinuriDG.ItemsSource = db.Vinuri.ToList();
                        }

                    }
                    else
                    {
                        db.SaliDegustare.Remove(SalaSelectat);
                        db.SaveChanges();
                        SaliDG.ItemsSource = db.SaliDegustare.ToList();

                        CuloriDG.ItemsSource = db.Culori.ToList();
                        AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
                        CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
                        ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
                        ClasificariDG.ItemsSource = db.Clasificari.ToList();



                        SaliDG.ItemsSource = db.SaliDegustare.ToList();
                        ClientiDG.ItemsSource = db.Clienti.ToList();
                        PacheteDG.ItemsSource = db.Pachete.ToList();
                        RezervariDG.ItemsSource = db.Rezervari.ToList();

                        VinuriDG.ItemsSource = db.Vinuri.ToList();
                    }

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



            }
            AdaugaImagine = true;
        }
        
        /// ////////////////////////////////////////////////
        
        public const string TelefonValid = "^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$";

public static bool IsPhoneNbr(string number)
        {
            if (number != null) return Regex.IsMatch(number, TelefonValid);
            else return false;
        }


        // //////////////////////////////////////////////


        private void AdaugareClientB_Click(object sender, RoutedEventArgs e)
        {


            string NumeCLient = NumeClientTB.Text;

            


            if (String.IsNullOrEmpty(NumeCLient)) { MessageBox.Show("Introduceți o valaoare în câmpul nume"); return; }
            if (String.IsNullOrEmpty(PrenumeClientTB.Text)) { MessageBox.Show("Introduceți o valaoare în câmpul prenume"); return; }
            if (String.IsNullOrEmpty(DataNastereClientDP.Text)) { MessageBox.Show("Introduceți o valaoare în câmpul data nasterii"); return; }
            if (String.IsNullOrEmpty(EmailClientTB.Text)) { MessageBox.Show("Introduceți o valaoare în câmpul email"); return; }
            if (!IsValidEmail(EmailClientTB.Text)) { MessageBox.Show("Introduceți o valaoare valida în câmpul email"); return; }
            if (!IsPhoneNbr(TelefonClientTB.Text)) { MessageBox.Show("Introduceți o valaoare valida în câmpul telefon"); return; }
            
            else
            {
                if (NumeCLient.Any(char.IsDigit))
                { MessageBox.Show("Numele  nu poate conține cifre"); }
                else
                {
                    String gen = "";
                    if ((bool)MGenRB.IsChecked) gen = "M"; else if((bool)FGenRB.IsChecked) gen = "F"; if(gen=="") { MessageBox.Show("Alegeti genul!"); return; }
                    db.Clienti.Add(new Client { Nume = NumeCLient ,Prenume=PrenumeClientTB.Text,DataNasterii= DateOnly.FromDateTime((DateTime)DataNastereClientDP.SelectedDate),Gen=gen,Telefon=TelefonClientTB.Text,Email = EmailClientTB.Text});

                    db.SaveChanges();

                    ClientiDG.ItemsSource = db.Clienti.ToList();
                }
            }
        }

        

        private void ClientiDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ClientSelectat = (Client)ClientiDG.SelectedItem;
            if (ClientSelectat != null)
            {
                NumeClientTB.Text = ClientSelectat.Nume;
                PrenumeClientTB.Text=ClientSelectat.Prenume;
                DataNastereClientDP.SelectedDate = ClientSelectat.DataNasterii.ToDateTime(TimeOnly.Parse("10:00 PM"));
                if (ClientSelectat.Gen == "M") MGenRB.IsChecked = true; else FGenRB.IsChecked = true;
                TelefonClientTB.Text = ClientSelectat.Telefon;
                EmailClientTB.Text = ClientSelectat.Email;
            }
            else
            {
                NumeClientTB.Text = "";
                PrenumeClientTB.Text = "";
                DataNastereClientDP.Text = "";
                TelefonClientTB.Text = "";
                EmailClientTB.Text = "";
                FGenRB.IsChecked=false;
                MGenRB.IsChecked=false;

            }

        }

        private void ModificareClientB_Click(object sender, RoutedEventArgs e)
        {

            if (ClientSelectat != null)
            {
                ClientSelectat.Nume = NumeClientTB.Text;

                ClientSelectat.Prenume =PrenumeClientTB.Text;
               ClientSelectat.DataNasterii= DateOnly.FromDateTime((DateTime)DataNastereClientDP.SelectedDate);
                ClientSelectat.Telefon= TelefonClientTB.Text;
                ClientSelectat.Email= EmailClientTB.Text;
                String gen = "";
                if ((bool)MGenRB.IsChecked) gen = "M"; else gen = "F";
                ClientSelectat.Gen = gen;

                db.SaveChanges();
                ClientiDG.ItemsSource = db.Clienti.ToList();
            }
            else
            {
                MessageBox.Show("Selectați clientul care va fi modificat");
            }


        }

        private void StergereClientB_Click(object sender, RoutedEventArgs e)
        {
            if (ClientSelectat != null)
            {
               
                    if (db.Rezervari.Any(x => x.Client == ClientSelectat))
                    {
                        MessageBoxResult result = MessageBox.Show("Stergerea dată va provoca ștergerea rândurilor din tabelul rezervari", "Confirmation", MessageBoxButton.OKCancel);

                        if (result == MessageBoxResult.OK)
                        {

                        db.Clienti.Remove(ClientSelectat);
                        db.SaveChanges();
                        ClientiDG.ItemsSource = db.Clienti.ToList();

                        CuloriDG.ItemsSource = db.Culori.ToList();
                        AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
                        CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
                        ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
                        ClasificariDG.ItemsSource = db.Clasificari.ToList();



                        SaliDG.ItemsSource = db.SaliDegustare.ToList();
                        ClientiDG.ItemsSource = db.Clienti.ToList();
                        PacheteDG.ItemsSource = db.Pachete.ToList();
                        RezervariDG.ItemsSource = db.Rezervari.ToList();

                        VinuriDG.ItemsSource = db.Vinuri.ToList();
                    }

                    }
                    else
                    {
                        db.Clienti.Remove(ClientSelectat);
                        db.SaveChanges();
                        ClientiDG.ItemsSource = db.Clienti.ToList();

                        CuloriDG.ItemsSource = db.Culori.ToList();
                        AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
                        CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
                        ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
                        ClasificariDG.ItemsSource = db.Clasificari.ToList();



                        SaliDG.ItemsSource = db.SaliDegustare.ToList();
                        ClientiDG.ItemsSource = db.Clienti.ToList();
                        PacheteDG.ItemsSource = db.Pachete.ToList();
                        RezervariDG.ItemsSource = db.Rezervari.ToList();

                        VinuriDG.ItemsSource = db.Vinuri.ToList();
                    }
            }
            else
            {
                MessageBox.Show("Selectați clienutl care va fi șters");

            }
        }


        // //////////////////////////////////////////////////////

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; 
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        private void AdaugarePachetB_Click(object sender, RoutedEventArgs e)
        {


            string DenumirePachet = DenumirePachetTB.Text;


            decimal d;
            if (String.IsNullOrEmpty(DenumirePachet)) { MessageBox.Show("Introduceți o valaoare în câmpul denumire"); return; }
            if (String.IsNullOrEmpty(PretTB.Text)) { MessageBox.Show("Introduceți o valaoare în câmpul pret"); return; }
            if (!decimal.TryParse(PretTB.Text, out d)) { MessageBox.Show("Introduceți o valaoare corespunzatoare in campul pentru pret"); return; }

            if (String.IsNullOrEmpty(DescrierePachetTB.Text)) { MessageBox.Show("Introduceți o valaoare în câmpul descriere"); return; }
            if (String.IsNullOrEmpty(DurataInOreTB.Text)) { MessageBox.Show("Introduceți o valaoare în câmpul durata in ore"); return; }
            if (!decimal.TryParse(DurataInOreTB.Text, out d)) { MessageBox.Show("Introduceți o valaoare corespunzatoare in campul pentru durata in ore"); return; }
            if (String.IsNullOrEmpty(SalaDegustareCB.Text)) { MessageBox.Show("Introduceți o valaoare în câmpul id sala degustare"); return; }

            else
            {
                
               
                    
                 //   SalaDegustare? sd= db.SaliDegustare.Find(Convert.ToInt32(SalaDegustareCB.Text));
                    db.Pachete.Add(new Pachet { PachetDenumire = DenumirePachet, Descriere = DescrierePachetTB.Text, Pret = Convert.ToDecimal(PretTB.Text), DurataInOre = Convert.ToDecimal(DurataInOreTB.Text), SalaDegustare = (SalaDegustare) SalaDegustareCB.SelectedValue }) ;

                    db.SaveChanges();

                    PacheteDG.ItemsSource = db.Pachete.ToList();
                
            }
        }



        private void PacheteDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PachetSelectat = (Pachet)PacheteDG.SelectedItem;
            if (PachetSelectat != null)
            {
                DenumirePachetTB.Text = PachetSelectat.PachetDenumire;
                DescrierePachetTB.Text = PachetSelectat.Descriere;
                PretTB.Text = PachetSelectat.Pret.ToString();
                DurataInOreTB.Text = PachetSelectat.DurataInOre.ToString();
                SalaDegustareCB.SelectedValue = PachetSelectat.SalaDegustare;


            }
            else
            {
                DenumirePachetTB.Text = "";
                DescrierePachetTB.Text = "";
                PretTB.Text = "";
                DurataInOreTB.Text = "";
                SalaDegustareCB.Text = "";
               

            }

        }

        private void ModificarePachetB_Click(object sender, RoutedEventArgs e)
        {

            if (PachetSelectat != null)
            {
                PachetSelectat.PachetDenumire = DenumirePachetTB.Text;
                PachetSelectat.Descriere = DescrierePachetTB.Text;
                PachetSelectat.Pret = decimal.Parse(PretTB.Text);
                PachetSelectat.DurataInOre = decimal.Parse(DurataInOreTB.Text);
                //SalaDegustare? sd = db.SaliDegustare.Find(Convert.ToInt32(SalaDegustareCB.Text));

                PachetSelectat.SalaDegustare= (SalaDegustare) SalaDegustareCB.SelectedValue;



                db.SaveChanges();
                PacheteDG.ItemsSource = db.Pachete.ToList();
            }
            else
            {
                MessageBox.Show("Selectați clientul care va fi modificat");
            }


        }

        private void StergerePachetB_Click(object sender, RoutedEventArgs e)
        {
            if (PachetSelectat != null)
            {
                if (db.Rezervari.Any(x => x.Pachet == PachetSelectat))
                {
                    MessageBoxResult result = MessageBox.Show("Stergerea dată va provoca ștergerea rândurilor din tabelul rezervari", "Confirmation", MessageBoxButton.OKCancel);

                    if (result == MessageBoxResult.OK)
                    {


                        db.Pachete.Remove(PachetSelectat);
                        db.SaveChanges();
                        PacheteDG.ItemsSource = db.Pachete.ToList();

                        CuloriDG.ItemsSource = db.Culori.ToList();
                        AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
                        CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
                        ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
                        ClasificariDG.ItemsSource = db.Clasificari.ToList();



                        SaliDG.ItemsSource = db.SaliDegustare.ToList();
                        ClientiDG.ItemsSource = db.Clienti.ToList();
                        PacheteDG.ItemsSource = db.Pachete.ToList();
                        RezervariDG.ItemsSource = db.Rezervari.ToList();

                        VinuriDG.ItemsSource = db.Vinuri.ToList();
                    }

                }
                else
                {
                    db.Pachete.Remove(PachetSelectat);
                    db.SaveChanges();
                    PacheteDG.ItemsSource = db.Pachete.ToList();

                    CuloriDG.ItemsSource = db.Culori.ToList();
                    AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
                    CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
                    ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
                    ClasificariDG.ItemsSource = db.Clasificari.ToList();



                    SaliDG.ItemsSource = db.SaliDegustare.ToList();
                    ClientiDG.ItemsSource = db.Clienti.ToList();
                    PacheteDG.ItemsSource = db.Pachete.ToList();
                    RezervariDG.ItemsSource = db.Rezervari.ToList();

                    VinuriDG.ItemsSource = db.Vinuri.ToList();
                }
            }
            else
            {
                MessageBox.Show("Selectați clienutl care va fi șters");

            }
        }
        
        //////////////////////////////////////////////////////////// initializare comboboxuri
    
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //  MessageBox.Show("nu");
            if (e.Source is TabControl)
            {
                //do work when tab is changed
            
            SalaDegustareCB.Items.Clear();
            ClientCB.Items.Clear();
            PachetCB.Items.Clear();
            ClasificareCB.Items.Clear();

            ZaharCB.Items.Clear();
            CalitateCB.Items.Clear();
            AlcoolCB.Items.Clear();
            CuloareCB.Items.Clear();

                

            foreach (var s in db.SaliDegustare.ToList()) SalaDegustareCB.Items.Add(s);

            foreach (var s in db.Clienti.ToList()) ClientCB.Items.Add(s);
            foreach (var s in db.Pachete.ToList()) PachetCB.Items.Add(s);

            foreach (var s in db.Culori.ToList()) CuloareCB.Items.Add(s);
            foreach (var s in db.ContinuturiAlcool.ToList()) AlcoolCB.Items.Add(s);
            foreach (var s in db.CalitatiStruguri.ToList()) CalitateCB.Items.Add(s);
            foreach (var s in db.CantitatiZahar.ToList()) ZaharCB.Items.Add(s);

            foreach (var s in db.Clasificari.ToList()) ClasificareCB.Items.Add(s);

            }
        }

        private void SalaDegustareCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (!comboBox.IsLoaded)
                return;
        }


        // ///////////////////////////////////////////////////////////


        private void AdaugareRezervareB_Click(object sender, RoutedEventArgs e)
        {


           



            if (String.IsNullOrEmpty(PachetCB.Text)){ MessageBox.Show("Introduceți o valaoare în câmpul pachet"); }
            if (String.IsNullOrEmpty(ClientCB.Text)){ MessageBox.Show("Introduceți o valaoare în câmpul client"); }
            if (String.IsNullOrEmpty(DataRezervareDP.Text)) { MessageBox.Show("Introduceți o valaoare în câmpul data si ora rezervarii"); }

            else
            {



               // Pachet? p = db.Pachete.Find(Convert.ToInt32(PachetCB.Text));
              //  Client? c = db.Clienti.Find(Convert.ToInt32(ClientCB.Text));
              
                db.Rezervari.Add(new Rezervare { Pachet = (Pachet)PachetCB.SelectedValue,Client= (Client)ClientCB.SelectedValue,DataOraRezervare= (DateTime)DataRezervareDP.SelectedDate});

                db.SaveChanges();

                RezervariDG.ItemsSource = db.Rezervari.ToList();

            }
        }



        private void RezervariDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RezervareSelectat = (Rezervare)RezervariDG.SelectedItem;
            if (RezervareSelectat != null)
            {
                PachetCB.SelectedValue = RezervareSelectat.Pachet;
                ClientCB.SelectedValue = RezervareSelectat.Client;
                DataRezervareDP.Text = RezervareSelectat.DataOraRezervare.ToString();
               
             


            }
            else
            {
                PachetCB.Text = "";
                ClientCB.Text = "";
                DataRezervareDP.Text = "";



            }

        }

        private void ModificareRezervareB_Click(object sender, RoutedEventArgs e)
        {

            if (RezervareSelectat != null)
            {



              //  Client? c = db.Clienti.Find(Convert.ToInt32(ClientCB.Text));
              //  Pachet? p = db.Pachete.Find(Convert.ToInt32(PachetCB.Text));

                RezervareSelectat.Pachet = (Pachet)PachetCB.SelectedValue;
                RezervareSelectat.Client = (Client)ClientCB.SelectedValue;
                RezervareSelectat.DataOraRezervare =(DateTime) DataRezervareDP.SelectedDate;


              



                db.SaveChanges();
                RezervariDG.ItemsSource = db.Rezervari.ToList();
            }
            else
            {
                MessageBox.Show("Selectați rezervarea care va fi modificata");
            }


        }

        private void StergereRezervareB_Click(object sender, RoutedEventArgs e)
        {
            if (RezervareSelectat != null)
            {
                db.Rezervari.Remove(RezervareSelectat);
                db.SaveChanges();
                RezervariDG.ItemsSource = db.Rezervari.ToList();

                CuloriDG.ItemsSource = db.Culori.ToList();
                AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
                CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
                ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
                ClasificariDG.ItemsSource = db.Clasificari.ToList();



                SaliDG.ItemsSource = db.SaliDegustare.ToList();
                ClientiDG.ItemsSource = db.Clienti.ToList();
                PacheteDG.ItemsSource = db.Pachete.ToList();
                RezervariDG.ItemsSource = db.Rezervari.ToList();

                VinuriDG.ItemsSource = db.Vinuri.ToList();
            }
            else
            {
                MessageBox.Show("Selectați rezervarea care va fi ștersa");

            }
        }


        // /////////////////////////////////////////////

        private void AdaugareClasificareB_Click(object sender, RoutedEventArgs e)
        {






            if (String.IsNullOrEmpty(CuloareCB.Text)) { MessageBox.Show("Introduceți o valaoare în câmpul id culoare"); }
            if (String.IsNullOrEmpty(ZaharCB.Text)) { MessageBox.Show("Introduceți o valaoare în câmpul id cantitate zahar"); }
            if (String.IsNullOrEmpty(CalitateCB.Text)) { MessageBox.Show("Introduceți o valaoare în câmpul id calitate struguri"); }
            if (String.IsNullOrEmpty(AlcoolCB.Text)) { MessageBox.Show("Introduceți o valaoare în câmpul continut alcool"); }

            else
            {



              //  Culoare? c = db.Culori.Find(Convert.ToInt32(CuloareCB.Text));
               // ContinutAlcool? a = db.ContinuturiAlcool.Find(Convert.ToInt32(AlcoolCB.Text));
               // CantitateZahar? z = db.CantitatiZahar.Find(Convert.ToInt32(ZaharCB.Text));
               // CalitateStruguri? st = db.CalitatiStruguri.Find(Convert.ToInt32(CalitateCB.Text));

                db.Clasificari.Add(new Clasificare { Culoare =(Culoare)CuloareCB.SelectedValue, ContinutAlcool = (ContinutAlcool)AlcoolCB.SelectedValue, CantitateZahar = (CantitateZahar)ZaharCB.SelectedValue, CalitateStruguri = (CalitateStruguri) CalitateCB.SelectedValue }) ;

                db.SaveChanges();

                ClasificariDG.ItemsSource = db.Clasificari.ToList();

            }
        }



        private void ClasificariDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             ClasificareSelectat= (Clasificare)ClasificariDG.SelectedItem;
            if (ClasificareSelectat != null)
            {
                CuloareCB.SelectedValue = ClasificareSelectat.Culoare;
                AlcoolCB.SelectedValue = ClasificareSelectat.ContinutAlcool;
                ZaharCB.SelectedValue = ClasificareSelectat.CantitateZahar;
                CalitateCB.SelectedValue = ClasificareSelectat.CalitateStruguri;




            }
            else
            {


                CuloareCB.Text = "";
                AlcoolCB.Text = "";
                ZaharCB.Text = "";
                CalitateCB.Text = "";

            }

        }

        private void ModificareClasificareB_Click(object sender, RoutedEventArgs e)
        {

            if (ClasificareSelectat != null)
            {





               // Culoare? c = db.Culori.Find(Convert.ToInt32(CuloareCB.Text));
               // ContinutAlcool? a = db.ContinuturiAlcool.Find(Convert.ToInt32(AlcoolCB.Text));
               // CantitateZahar? z = db.CantitatiZahar.Find(Convert.ToInt32(ZaharCB.Text));
               // CalitateStruguri? st = db.CalitatiStruguri.Find(Convert.ToInt32(CalitateCB.Text));

                ClasificareSelectat.Culoare = (Culoare) CuloareCB.SelectedValue;
                ClasificareSelectat.ContinutAlcool = (ContinutAlcool) AlcoolCB.SelectedValue;
                ClasificareSelectat.CantitateZahar = (CantitateZahar)ZaharCB.SelectedValue ;
                ClasificareSelectat.CalitateStruguri = (CalitateStruguri)CalitateCB.SelectedValue;







                db.SaveChanges();
                ClasificariDG.ItemsSource = db.Clasificari.ToList();
            }
            else
            {
                MessageBox.Show("Selectați clasificarea care va fi modificata");
            }


        }

        private void StergereClasificareB_Click(object sender, RoutedEventArgs e)
        {
            if (ClasificareSelectat != null)
            {

                if (db.Vinuri.Any(x => x.Clasificare == ClasificareSelectat))
                {
                    MessageBoxResult result = MessageBox.Show("Stergerea dată va provoca ștergerea rândurilor din tabelul vinuri", "Confirmation", MessageBoxButton.OKCancel);

                    if (result == MessageBoxResult.OK)
                    {
                        db.Clasificari.Remove(ClasificareSelectat);
                        db.SaveChanges();
                        ClasificariDG.ItemsSource = db.Clasificari.ToList();

                        CuloriDG.ItemsSource = db.Culori.ToList();
                        AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
                        CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
                        ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
                        ClasificariDG.ItemsSource = db.Clasificari.ToList();



                        SaliDG.ItemsSource = db.SaliDegustare.ToList();
                        ClientiDG.ItemsSource = db.Clienti.ToList();
                        PacheteDG.ItemsSource = db.Pachete.ToList();
                        RezervariDG.ItemsSource = db.Rezervari.ToList();

                        VinuriDG.ItemsSource = db.Vinuri.ToList();
                    }
                    else
                    {
                        // User clicked "Cancel"
                    }
                }
                else
                {
                    db.Clasificari.Remove(ClasificareSelectat);
                    db.SaveChanges();
                    ClasificariDG.ItemsSource = db.Clasificari.ToList();

                    CuloriDG.ItemsSource = db.Culori.ToList();
                    AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
                    CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
                    ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
                    ClasificariDG.ItemsSource = db.Clasificari.ToList();



                    SaliDG.ItemsSource = db.SaliDegustare.ToList();
                    ClientiDG.ItemsSource = db.Clienti.ToList();
                    PacheteDG.ItemsSource = db.Pachete.ToList();
                    RezervariDG.ItemsSource = db.Rezervari.ToList();

                    VinuriDG.ItemsSource = db.Vinuri.ToList();
                }
            }
            else
            {
                MessageBox.Show("Selectați clasificarea care va fi ștersa");

            }
        }




        ///////////////////////////////////////////////////////////////////////

        public bool DataValida(string dateTime)
        {
            string[] formats = { "MM/dd/yyyy " };
            DateTime parsedDateTime;
            return DateTime.TryParseExact(dateTime, formats, new CultureInfo("en-US"),
                                           DateTimeStyles.None, out parsedDateTime);
        }
        private void AdaugareVinB_Click(object sender, RoutedEventArgs e)
        {


            decimal d;int i;
            if (VinIMG.Source == null) { MessageBox.Show("Introduceți o imagine în câmpul pentru imagine vin"); return; }
           // if (!decimal.TryParse(CantitateVinTB.Text, out d)) { MessageBox.Show("Introduceți  în câmpul pentru imagine vin"); return; }
            if (!int.TryParse(CantitateVinTB.Text, out i)) { MessageBox.Show("Introduceți  în câmpul pentru cantitate un numar natural"); return; }
            if (DataFabricareDP.SelectedDate==null) { MessageBox.Show("Introduceți  în câmpul pentru data fabricarii o data "); return; }

            if (String.IsNullOrEmpty(DenumireVinTB.Text)) { MessageBox.Show("Introduceți o valaoare în câmpul denumire vin"); }
            else
            {
                
                
                   // Clasificare? c = db.Clasificari.Find(Convert.ToInt32(ClasificareCB.Text));

                    if (AdaugaImagineVin) db.Vinuri.Add(new Vin { VinDenumire = DenumireVinTB.Text, Cantitate = Convert.ToInt32(CantitateVinTB.Text),Clasificare =(Clasificare) ClasificareCB.SelectedValue, DataProducerii= DateOnly.FromDateTime((DateTime)DataFabricareDP.SelectedDate), ImagineVin = ConvertImageSourceToByteArray(VinIMG.Source) });
                    else db.Vinuri.Add(new Vin { VinDenumire = DenumireVinTB.Text, Cantitate = Convert.ToInt32(CantitateVinTB.Text), Clasificare = (Clasificare)ClasificareCB.SelectedValue, DataProducerii = DateOnly.FromDateTime((DateTime)DataFabricareDP.SelectedDate), ImagineVin = VinSelectat.ImagineVin});
                    //  MessageBox.Show(BufferFromImage((BitmapImage)SalaIMG.Source).ToString());
                    db.SaveChanges();

                    VinuriDG.ItemsSource = db.Vinuri.ToList();
                
            }

        }



        private void VinuriDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            VinSelectat = (Vin)VinuriDG.SelectedItem;
            if (VinSelectat != null)
            {
                DenumireVinTB.Text = VinSelectat.VinDenumire;
                CantitateVinTB.Text = VinSelectat.Cantitate.ToString();
                DataFabricareDP.SelectedDate = VinSelectat.DataProducerii.ToDateTime(new TimeOnly(11,11));
                ClasificareCB.SelectedValue = VinSelectat.Clasificare;
                VinIMG.Source = LoadImageFromByteArray(VinSelectat.ImagineVin);
                AdaugaImagineVin = false;
            }
            else
            {

                DenumireVinTB.Text ="";
                CantitateVinTB.Text = "";
                DataFabricareDP.Text = "";
                ClasificareCB.Text = "";
                VinIMG.Source = null;
                AdaugaImagineVin = false;

            }

        }

        private void ModificareVinB_Click(object sender, RoutedEventArgs e)
        {

            if (VinSelectat != null)
            {
                 VinSelectat.VinDenumire= DenumireVinTB.Text;
                VinSelectat.Cantitate =Convert.ToInt32(CantitateVinTB.Text);
                VinSelectat.DataProducerii = DateOnly.FromDateTime((DateTime)DataFabricareDP.SelectedDate);

              //  Clasificare? c = db.Clasificari.Find(Convert.ToInt32(ClasificareCB.Text));

                VinSelectat.Clasificare =(Clasificare) ClasificareCB.SelectedValue;

            if(AdaugaImagineVin)    VinSelectat.ImagineVin = ConvertImageSourceToByteArray(VinIMG.Source);


                db.SaveChanges();
                VinuriDG.ItemsSource = db.Vinuri.ToList();
                AdaugaImagineVin = false;
            }
            else
            {
                MessageBox.Show("Selectați clientul care va fi modificat");
            }


        }

        private void StergereVinB_Click(object sender, RoutedEventArgs e)
        {
            if (VinSelectat != null)
            {
                db.Vinuri.Remove(VinSelectat);
                db.SaveChanges();
                VinuriDG.ItemsSource = db.Vinuri.ToList();

                CuloriDG.ItemsSource = db.Culori.ToList();
                AlcoolDG.ItemsSource = db.ContinuturiAlcool.ToList();
                CalitatiDG.ItemsSource = db.CalitatiStruguri.ToList();
                ZaharDG.ItemsSource = db.CantitatiZahar.ToList();
                ClasificariDG.ItemsSource = db.Clasificari.ToList();



                SaliDG.ItemsSource = db.SaliDegustare.ToList();
                ClientiDG.ItemsSource = db.Clienti.ToList();
                PacheteDG.ItemsSource = db.Pachete.ToList();
                RezervariDG.ItemsSource = db.Rezervari.ToList();

                VinuriDG.ItemsSource = db.Vinuri.ToList();
            }
            else
            {
                MessageBox.Show("Selectați clienutl care va fi șters");

            }
        }

        private void AdaugareImagineVinB_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);

                VinIMG.Source = new BitmapImage(fileUri);



            }
            AdaugaImagineVin = true;
        }
    }

}
