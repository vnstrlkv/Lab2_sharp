using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_sharp
{
   public class Truck:Car
    {
        int carrying;

        public     Truck() { name = ""; power = 0; price = 0; repairDate = new DateTime[0]; carrying = 0; }
        public     Truck(string name, int power,int carrying, int price, string[] repairDate)
        {
            this.name = name;
            this.power = power;
            this.price = price;
            this.carrying = carrying;
            this.repairDate = new DateTime[repairDate.Length];

            for (int i = 0; i < repairDate.Length; i++)
            {
                this.repairDate[i] = DateTime.Parse(repairDate[i]);
            }
        }
        public Truck(string name, int power, int carrying, int price, string repairDate)
        {
            DateTime tmp;
            this.name = name;
            this.power = power;
            this.price = price;
            this.carrying = carrying;
            if (DateTime.TryParse(repairDate, out tmp))
            {
                this.repairDate = new DateTime[1];
                this.repairDate[0] = DateTime.Parse(repairDate);
            }

        }

        public override void WriteLine()
        {
            Console.WriteLine("Name: {0}\npower: {1}\nCarrying capacity: {3}\nprice: {2}", this.name, this.power, price, carrying);
            Console.WriteLine("Date:");
            for (int i = 0; i < repairDate.Length; i++)
            {
                Console.WriteLine("{0}", repairDate[i]);
            }
        }

    }
}
