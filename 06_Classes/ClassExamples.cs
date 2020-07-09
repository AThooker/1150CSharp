using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycle, Spaceship, Plane, Boat, Submarine }
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public string Color { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public Vehicle() { }
        public Vehicle(string make, string model, int year, double mileage, string color, VehicleType typeofvehicle)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
            Color = color;
            TypeOfVehicle = typeofvehicle;

        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName
        { get { return $"{FirstName} {LastName}"; } }

        public DateTime DateOfBirth { get; set; }

        public int AgeInYears
        {
            get
            {
                if (DateOfBirth == new DateTime())
                {
                    return 9001;
                }

                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalAgeInYears));
            }
        }

        public Vehicle Transport { get; set; }

        public Person(string firstName, string lastName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = birthday;
        }

    }
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; }
        public DateTime BirthDay { get; set; }

        public User() { }
        public User(string firstName, string lastName, int id, DateTime birthDay)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            BirthDay = birthDay;
        }
    }
}
