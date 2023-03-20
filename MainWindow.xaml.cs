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

namespace ManagementVinarie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            VinarieContext db = new VinarieContext();
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
            */



        }






        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }
    }
}
