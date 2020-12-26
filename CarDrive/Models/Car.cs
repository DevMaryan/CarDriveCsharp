using System;
using System.Collections.Generic;
using System.Text;

namespace CarDrive.Models
{
    class Car
    {
        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public int CalculateSpeed()
        {
            return Driver.Skill * Speed;
        }
    }
}
