using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00177655OOPExam2019
{
    public enum Position
    {
        Goalkeeper,
        Defender,
        Midfielder,
        Forward

    }

    public class Player
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string PrefPos { get; set; }
        public DateTime DoB { get; set; }


        string[] firstNames = {
                "Adam", "Amelia", "Ava", "Chloe", "Conor", "Daniel", "Emily",
                "Emma", "Grace", "Hannah", "Harry", "Jack", "James",
                "Lucy", "Luke", "Mia", "Michael", "Noah", "Sean", "Sophie"};


        string[] lastNames = {
                "Brennan", "Byrne", "Daly", "Doyle", "Dunne", "Fitzgerald", "Kavanagh",
                "Kelly", "Lynch", "McCarthy", "McDonagh", "Murphy", "Nolan", "O'Brien",
                "O'Connor", "O'Neill", "O'Reilly", "O'Sullivan", "Ryan", "Walsh"
            };

        int[] Age =
        {
            22, 24, 26, 24, 30, 28, 23, 21, 29, 20, 21, 24, 25, 27, 26, 30, 29, 23,
        };
    }

}

   
