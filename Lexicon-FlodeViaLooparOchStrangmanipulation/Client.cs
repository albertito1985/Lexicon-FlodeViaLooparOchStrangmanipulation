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
                case >= 0 and < 5:
                    price = 0;
                    priceType = "Free";
                    break;
                case >=5  and < 20:
                    price = 80;
                    priceType = "Youth";
                    break;
                case >= 65 and < 100:
                    price = 90;
                    priceType = "Elderly";
                    break;
                case >= 100:
                    price = 0;
                    priceType = "Free";
                    break;
                default:
                    priceType = "Standard";
                    price = 120;
                    break;
            }
        }
    }
}
