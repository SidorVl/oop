using System;

namespace Address
{
    public class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private int appartment;

        public string Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        public string Country
        {
            get
            { return country; }
            set
            {
                country = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Street
        {
            get
            { 
                return street; 
            }
            set 
            { 
                street = value; 
            }
        }
        public string House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        public int Appartment
        {
            get
            {
                return appartment;
            }
            set 
            {
                appartment = value;
            }
        }

        public override string ToString()
        {
            return $"{Index}, {Country}: {City}; {Street} {House}, {Appartment}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address
            {
                Index = "74100",
                Country = "Ukraine",
                City = "Kherson",
                Street = "Sobornosti",
                House = "22",
                Appartment = 27
            };

            Console.WriteLine(address.ToString());
        }
    }
}
