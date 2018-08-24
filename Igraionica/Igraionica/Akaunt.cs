using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igraionica
{
    class Akaunt
    {
        private int sifra;
        private string username;
        private string pass;
        private string tip;

        public int Sifra
        {
            get
            {
                return sifra;
            }

            set
            {
                sifra = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        public string Tip
        {
            get
            {
                return tip;
            }

            set
            {
                tip = value;
            }
        }

        public Akaunt(int s, string u, string p, string t)
        {
            sifra = s;
            username = u;
            pass = p;
            tip = t;
        }
        public Akaunt()
        {
            sifra = 0;
            username = "";
            pass = "";
            tip = "";
        }
        public override string ToString()
        {
            return "Username: " + username + " pass: " + pass + "tip: " + tip;
        }
    }
}
