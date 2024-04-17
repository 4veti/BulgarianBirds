using App_9_2.Models.Contracts;
using System;
using System.Collections.Generic;

namespace App_9_2.Models
{
    public class Bird : IBird
    {
        public string Name { get; set; }
        public bool IsEndangered { get; set; }
        public string EndangeredInfo
        {
            get => IsEndangered ? "Застрашен." : "Не е застрашен.";
        }
        public List<string> ImageUrls { get; set; } = new List<string>();
        public string ResidesInAreas { get; set; }
        public string Description { get; set; }
        public string IsEndangeredLabelColor => IsEndangered ? "#b30000" : "DarkGreen";
    }
}
