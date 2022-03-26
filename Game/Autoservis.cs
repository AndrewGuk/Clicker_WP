using System.Collections.Generic;

namespace WindowsFormsApp1.Game
{
    public class Autoservis<T> where T : People
    {
        public People People { get; set; }
        public Autoservis()
        {
            StartPrice();
        }
        List<Transport> priceList = new List<Transport>();
        void StartPrice()
        {
            var car = new Car();
            var moto = new Motorcycle();
            var bike = new Bike();
            var bus = new Bus();
            var airplane = new Airplane();
            var helicopter = new Helicopter();
            var rollers = new Rollers();
            var truck = new Truck();
            var pickup = new Pickup();

            priceList.Add(truck);
            priceList.Add(helicopter);
            priceList.Add(airplane);
            priceList.Add(rollers);
            priceList.Add(bike);
            priceList.Add(moto);
            priceList.Add(car);
            priceList.Add(bus);
            priceList.Add(pickup);
            priceList.Sort(new TransportComparer((a, b) => a.Price - b.Price));

        }
        public string[][] PrintProperty()
        {
            string[] types = new string[priceList.Count];
            string[] price = new string[priceList.Count];
            string[][] all = new string[2][];
            var temp = 0;

            priceList.Sort(new TransportComparer((a, b) => a.Price - b.Price));
            foreach (var item in priceList)
            {
                types[temp] = item.ToString().Remove(0, 22);
                price[temp] = $"{item.Price.ToString()} $";
                temp++;
            }
            all[0] = types;
            all[1] = price;
            return all;
        }
        public string BuyTransport(int x)
        {
            if (People.BankAccount > priceList[x].Price)
            {
                People.DecreaseBankAccount(priceList[x].Price);
                People.transports.Add(priceList[x]);
                return $"Nice! You bought <{priceList[x].ToString().Remove(0, 22)}>! Now let's earn more!!";
            }
            else
                return "Oops, not enough funds, go work some more and come back!";
        }
        public string SellTransport(string x)
        {
            string y = string.Empty;
            for (int i = 0; i < People.transports.Count; i++)
            {
                if (People.transports[i].Name == x)
                {
                    y = $"Nice! You sold <{People.transports[i].Name}>";
                    People.IncreaseBankAccount(People.transports[i].Price / 2);
                    People.transports.Remove(People.transports[i]);
                    return y;
                }
            }
            return y;
        }
    }
}
