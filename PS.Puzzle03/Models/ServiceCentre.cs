﻿using System;

namespace PS.Puzzle03.Models
{
    public class ServiceCentre : IEntity
    {
        public Guid id
        {
            get
            {
                return new Guid();
            }
        }

        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Phone { get; set; }
        public string Url { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address { get; set; }
    }
}