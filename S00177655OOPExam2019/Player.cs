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

    class Player
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string PrefPos { get; set; }
        public DateTime DoB { get; set; }




    }
}
