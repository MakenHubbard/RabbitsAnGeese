﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitAndGeese.Model
{
    public class Saddle
    {
        public string Material { get; set; }
        public Size Size { get; set; }
        public double Price { get; set; }
        public SaddleType Type { get; set; }
        public bool InUse { get; set; }
    }

    public enum SaddleType
    {
        War,
        Speed,
        Yoga,
        Karate,
        Luxury,
        Party
    }

}
