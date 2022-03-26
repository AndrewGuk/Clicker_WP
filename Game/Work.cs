using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Game
{
    internal class Work<T> where T : People
    {
        Random random = new Random();
        int tempCount;
        public void StartWork(People people)
        {
            if (people.transports.Count == 0)
            {
                NoneWork(people);
                return;
            }
            people.transports.Sort(new TransportComparer((a, b) => b.Price - a.Price));
            string x = people.transports[0].ToString().Remove(0, 22);

            switch (x)
            {
                case "Car":
                    CarWork(people);
                    break;
                case "Motorcycle":
                    MotorcycleWork(people);
                    break;
                case "Bike":
                    BikeWork(people);
                    break;
                case "Bus":
                    BusWork(people);
                    break;
                case "Airplane":
                    AirplaneWork(people);
                    break;
                case "Helicopter":
                    HelicopterWork(people);
                    break;
                case "Rollers":
                    RollersWork(people);
                    break;
                case "Truck":
                    TruckWork(people);
                    break;
                case "Pickup":
                    PickupWork(people);
                    break;
                default:
                    break;
            }
        }
        void CarWork(People people)
        {
            tempCount = random.Next(150, 700);
            people.IncreaseBankAccount(tempCount);
            PrintCount(tempCount, people);
        }
        void MotorcycleWork(People people)
        {
            tempCount = random.Next(100, 500);
            people.IncreaseBankAccount(tempCount);
            PrintCount(tempCount, people);
        }
        void BikeWork(People people)
        {
            tempCount = random.Next(20, 200);
            people.IncreaseBankAccount(tempCount);
            PrintCount(tempCount, people);
        }
        void BusWork(People people)
        {
            tempCount = random.Next(300, 1300);
            people.IncreaseBankAccount(tempCount);
            PrintCount(tempCount, people);
        }
        void AirplaneWork(People people)
        {
            tempCount = random.Next(350, 2200);
            people.IncreaseBankAccount(tempCount);
            PrintCount(tempCount, people);
        }
        void HelicopterWork(People people)
        {
            tempCount = random.Next(300, 2000);
            people.IncreaseBankAccount(tempCount);
            PrintCount(tempCount, people);
        }
        void RollersWork(People people)
        {
            tempCount = random.Next(5, 25);
            people.IncreaseBankAccount(tempCount);
            PrintCount(tempCount, people);
        }
        void TruckWork(People people)
        {
            tempCount = random.Next(350, 2000);
            people.IncreaseBankAccount(tempCount);
            PrintCount(tempCount, people);
        }
        void PickupWork(People people)
        {
            tempCount = random.Next(250, 1100);
            people.IncreaseBankAccount(tempCount);
            PrintCount(tempCount, people);
        }
        void NoneWork(People people)
        {
            tempCount = random.Next(1, 10);
            people.IncreaseBankAccount(tempCount);
            OffTransport(tempCount, people);
        }
        void PrintCount(int tempCount, People people)
        {
            string x = $"Good! You worked on the {people.transports[0].ToString().Remove(0, 22)} You have earned {tempCount}$";
            MessageBox.Show(x);
        }
        void OffTransport(int tempCount, People people)
        {
            string x = $"Good! You worked without transport! You have earned {tempCount}$";
            MessageBox.Show(x);
        }
    }
}
