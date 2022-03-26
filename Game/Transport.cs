namespace WindowsFormsApp1.Game
{
    public abstract class Transport
    {
        public string Name { get; set; }  
        
        public int Price { get; set; }
        public Transport Type { get; set; }

    }
    public class Car : Transport
    {
        public Car()
        {
            Name = "Mercedes";
            Price = 8000;
        }
    }
    public class Motorcycle : Transport
    {
        public Motorcycle()
        {
            Name = "Java";
            Price = 5000;
        }
    }
    public class Bike : Transport
    {
        public Bike()
        {
            Name = "Aist";
            Price = 200;
        }
    }
    public class Bus : Transport
    {
        public Bus()
        {
            Name = "MAZ";
            Price = 25000;
        }
    }
    public class Airplane : Transport
    {
        public Airplane()
        {
            Name = "Charter";
            Price = 100000;
        }
    }
    public class Helicopter : Transport
    {
        public Helicopter()
        {
            Name = "Mi-26";
            Price = 75000;
        }
    }
    public class Rollers : Transport
    {
        public Rollers()
        {
            Name = "Forrest Gump";
            Price = 50;
        }
    }
    public class Truck : Transport
    {
        public Truck()
        {
            Name = "Volvo";
            Price = 50000;
        }
    }
    public class Pickup : Transport
    {
        public Pickup()
        {
            Name = "Tundra";
            Price = 20000;
        }
    }
}
