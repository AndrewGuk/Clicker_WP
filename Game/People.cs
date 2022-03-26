using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Game
{
    public class People
    {
            Work<People> work = new Work<People>();
            public string Name { get; set; }
            public int BankAccount { get; private set; }

            internal List<Transport> transports = new List<Transport>();
            internal void DecreaseBankAccount(int price)
            {
                BankAccount -= price;
            }
            internal void IncreaseBankAccount(int price)
            {
                BankAccount += price;
            }
            public string DriveInSea()
            {
            string x = string.Empty;
                if (BankAccount > SeaCost())
                {
                    DecreaseBankAccount(SeaCost());
                    x = "HURRAH! We are going to the sea!";
                }
                else
                    x = "Not enough money (You still need to work!";
                return x;
            }
            public void Working(People people)
            {
                 work.StartWork(people);
            }
            public string[] PrintProperty()
            {
                string[] name = new string[transports.Count];
                var temp = 0;

                transports.Sort(new TransportComparer((a, b) => b.Price - a.Price));
                foreach (var item in transports)
                {
                    name[temp] = item.Name;
                    temp++;
                }
                return name;
            }
            int SeaCost()
            {
                int t;
                transports.Sort(new TransportComparer((a, b) => b.Price - a.Price));
                string x = transports[0].ToString().Remove(0, 22);
                switch (x)
                {
                    case "Car":
                        t = 2000;
                        break;
                    case "Motorcycle":
                        t = 1500;
                        break;
                    case "Bike":
                        t = 1000;
                        break;
                    case "Bus":
                        t = 3000;
                        break;
                    case "Airplane":
                        t = 30000;
                        break;
                    case "Helicopter":
                        t = 10000;
                        break;
                    case "Rollers":
                        t = 500;
                        break;
                    case "Truck":
                        t = 6000;
                        break;
                    case "Pickup":
                        t = 4000;
                        break;
                    default:
                        t = 5000;
                        break;
                }
                return t;
            }
    }
}
