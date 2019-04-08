using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_4
{
    public class Money 
    {
        public int ban { get; set; }
        public int cnt { get; set; }
        public int sum { get; set; }

        public Money()
        {
            ban = 10;
            cnt = 1;
            sum = ban * cnt;
        }
        public Money(int value, int counts) 
        {
            ban = value;
            cnt = counts;
            sum = value * counts;
        }

        public void ShowAll() // Вывести номинал и количество купюр
        {
            Console.WriteLine("Value - {0}, counts - {1}", ban, cnt);
        }

        public bool CostEstimation(int productPrice) //Определить, хватит ли денежных средств на покупку товара на сумму N рублей
        {
            if (sum > productPrice)
            {
                Console.WriteLine("You have enough money to buy this product");
                return true;
            }
            else
            {
                Console.WriteLine("You don't have enough money to buy this product");
                return false;
            }
        }

        public int GetNumberOfPieces(int productPrice) //Определить, сколько штук товара стоимости n рублей можно купить на имеющиеся денежные
        {
            if (productPrice != 0)
            {
                return sum / productPrice;
            }
            else
            {
                Console.WriteLine("Wrong product price");
                return 0;
            }
        }

        public int BanknotesValue
        {
            get { return ban; }
            set { ban = value; }
        }

        public int BanknotesCounts
        {
            get { return cnt; }
            set { cnt = value; }
        }

        public int Sum
        {
            get { return sum; }
        }
    }
}
