using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_sharp
{
  public class Car
    {
        //АВТОМОБИЛЬ: марка, мощность, стоимость, даты ремонта.
      
        protected string name;
        protected int power;
        protected int price;
        protected DateTime[] repairDate;
   public     Car() { name = ""; power = 0; price = 0; repairDate = new DateTime[0]; }
   public     Car(string name, int power, int price, string[] repairDate)
        {
            DateTime tmp;
            this.name = name;
            this.power = power;
            this.price = price;
            this.repairDate = new DateTime[repairDate.Length];
           
                for (int i = 0; i<repairDate.Length;i++)
            {
                if (DateTime.TryParse(repairDate[i], out tmp))
                    this.repairDate[i] = DateTime.Parse(repairDate[i]);
                else this.repairDate[i] = DateTime.Parse("00 00 0000");

            }               
        }
   public Car(string name, int power, int price, string repairDate)
        {
            DateTime tmp;
            this.name = name;
            this.power = power;
            this.price = price;
            if (DateTime.TryParse(repairDate, out tmp))
            {
                this.repairDate = new DateTime[1];
                this.repairDate[0] = DateTime.Parse(repairDate);
            }
            
        }

     public  virtual void WriteLine()
        {
            Console.WriteLine("Name: {0}\npower: {1}\nprice: {2}", this.name,this.power,price);
            Console.WriteLine("Date:");
            for (int i=0;i<repairDate.Length;i++)
            {
                Console.WriteLine("{0}",repairDate[i]);
            }
        }

     public bool AddRepairDate(string repairDate)
        {
            bool flag = false;
            DateTime tmp;
           if (DateTime.TryParse(repairDate,out tmp))
            {
                Array.Resize(ref this.repairDate, this.repairDate.Length + 1);       
                this.repairDate[this.repairDate.Length-1] = tmp;
                flag = true;
            }
            return flag;
        }

    public string GetName()
        {
            return this.name;
        }

    public int GetPower()
        {
            return this.power;
        }
    public int GetPrice()
        {
            return price;
        }
    public void SetPrice(int price)
        {
            this.price = price;
        }
    public DateTime[] GetDate()
        {
            return repairDate;
        }           

    }
}
