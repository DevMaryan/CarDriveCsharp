﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarDrive.Models
{
    class Driver
    {
        public Driver(string name, int skill)
        {
            Name = name;
            Skill = skill;
        }
        public string Name { get; set; }
        public int Skill { get; set; }
    }
}
