﻿using System;
using System.Collections.Generic;

namespace africanrancher.Models.Domain
{
    public class Cow
    {
        public int Id { get; set; }

        public string EarTag { get; set; }
        public string Bolus { get; set; }

        public string Brand { get; set; }


        public MaleCow Sire { get; set; }


        public FemaleCow Dam { get; set; }

        public DateTimeOffset? BirthDate { get; set; }

        public int? Breed { get; set; }
        public DateTimeOffset? WeeningDate { get; set; }
        
        public DateTimeOffset? Death { get; set; }
        public DateTimeOffset? Sale { get; set; }
        public DateTimeOffset? Purchase { get; set; }

        public  List<Weighing> Weighings { get; set; } 
        public List<Ailment> Ailments { get; set; } 
    }
}

