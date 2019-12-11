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

namespace S00177655OOPExam2019
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Player> allPlayers;
        List<Player> selectedPlayers;
        int places = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private List<Player> GetPlayers()
        {
            List<Player> allPlayers = new List<Player>();

            Player g1 = new Player()
            {
                FirstName = "Jason",
            Surname = "Lynch",
            DoB = new DateTime(25, 02, 1992),
            PrefPos = "Goalkeeper",
            };
            Player g2 = new Player()
            {
                FirstName = "John",
                Surname = "Smyth",
                DoB = new DateTime(02, 05, 1995),
                PrefPos = "Goalkeeper",
            };
            Player d6= new Player()
            {
                FirstName = "Mary",
                Surname = "Kennedy",
                DoB = new DateTime(16, 04, 1999),
                PrefPos = "Defender",
            };
            Player d1 = new Player()
            {
                FirstName = "Anne",
                Surname = "Gilsenan",
                DoB = new DateTime(25, 12, 1994),
                PrefPos = "Defender",
            };
            Player d2 = new Player()
            {
                FirstName = "Claire",
                Surname = "Keegan",
                DoB = new DateTime(08, 10, 1998),
                PrefPos = "Defender",
            };
            Player d3 = new Player()
            {
                FirstName = "Michael",
                Surname = "Kearns",
                DoB = new DateTime(15, 06, 1990),
                PrefPos = "Defender",
            };
            Player d4 = new Player()
            {
                FirstName = "Bosco",
                Surname = "Meehan",
                DoB = new DateTime(01, 03, 1996),
                PrefPos = "Defender",
            };
            Player d5 = new Player()
            {
                FirstName = "Sean",
                Surname = "O'Regan",
                DoB = new DateTime(09, 02, 1999),
                PrefPos = "Defender",
            };
            Player m1 = new Player()
            {
                FirstName = "Nora",
                Surname = "McCloat",
                DoB = new DateTime(31, 11, 1991),
                PrefPos = "Midfielder",
            };
            Player m2 = new Player()
            {
                FirstName = "Ryan",
                Surname = "McGee",
                DoB = new DateTime(18, 01, 1997),
                PrefPos = "Midfielder",
            };
            Player m3 = new Player()
            {
                FirstName = "Dwayne",
                Surname = "Kilgannon",
                DoB = new DateTime(18, 11, 1996),
                PrefPos = "Midfielder",
            };
            Player m4 = new Player()
            {
                FirstName = "Shane",
                Surname = "Scott",
                DoB = new DateTime(17, 04, 1993),
                PrefPos = "Midfielder",
            };
            Player m5 = new Player()
            {
                FirstName = "Luke",
                Surname = "Kelly",
                DoB = new DateTime(17, 03, 1995),
                PrefPos = "Midfielder",
            };
            Player m6 = new Player()
            {
                FirstName = "Chloe",
                Surname = "Doyle",
                DoB = new DateTime(05, 05, 1996),
                PrefPos = "Midfielder",
            };
            Player f1 = new Player()
            {
                FirstName = "Hannah",
                Surname = "McDonagh",
                DoB = new DateTime(24, 11, 1999),
                PrefPos = "Forward",
            };
            Player f2 = new Player()
            {
                FirstName = "Noah",
                Surname = "Reilly",
                DoB = new DateTime(18, 04, 1999),
                PrefPos = "Forward",
            };
            Player f3 = new Player()
            {
                FirstName = "Jack",
                Surname = "O'Conner",
                DoB = new DateTime(22, 02, 1993),
                PrefPos = "Forward",
            };
            Player f4 = new Player()
            {
                FirstName = "Brian",
                Surname = "Byrne",
                DoB = new DateTime(05, 08, 1992),
                PrefPos = "Forward",
            };

            allPlayers.Add(g1);
            allPlayers.Add(g2);

            allPlayers.Add(d1);
            allPlayers.Add(d2);
            allPlayers.Add(d3);
            allPlayers.Add(d4);
            allPlayers.Add(d5);
            allPlayers.Add(d6);

            allPlayers.Add(m1);
            allPlayers.Add(m2);
            allPlayers.Add(m3);
            allPlayers.Add(m4);
            allPlayers.Add(m5);
            allPlayers.Add(m6);

            allPlayers.Add(f1);
            allPlayers.Add(f2);
            allPlayers.Add(f3);
            allPlayers.Add(f4);

            return allPlayers;

        }

        private void CmbxFormations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LbxAllPlayers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Player selectedPlayers = lbxAllPlayers.SelectedItem as Player;
            if (selectedPlayers != null)
                TextBlock.Text = selectedPlayers.
        }
    }
}
