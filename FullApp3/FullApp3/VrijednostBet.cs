using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullApp3
{
    public class VrijednostBet
    {
        private int _bet, _vrijednost;
        public int bet
        {
            get { return _bet;}
            set { _bet = value; }
        }
        public int vrijednost
        {
            get { return _vrijednost; }
            set { _vrijednost = value; }
        }
        public VrijednostBet()
        {
            _vrijednost = 99;
            _bet = 0;
        }
    }
}
