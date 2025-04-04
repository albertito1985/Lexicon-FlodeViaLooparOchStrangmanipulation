using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_FlodeViaLooparOchStrangmanipulation
{
    public class Client
    {
        private int age;
        private int price;
        private string priceType;

        public int Age { get { return age; }}
        public int Price { get { return price; }}
        public string PriceType { get { return priceType; }}

        public Client(int InAge) {
            age = InAge;
            setPriceType(InAge);
        }

        private void setPriceType(int age)
        {
            switch (age)
            {
                case < 20 and > 0:
                    price = 80;
                    priceType = "Youth";
                    break;
                case > 64:
                    price = 90;
                    priceType = "Elderly";
                    break;
                default:
                    priceType = "Standard";
                    price = 120;
                    break;
            }
        }
    }
}
