﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game_store.Entyties
{
    public class Game
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public double Price { get; set; }

        public string Rating { get; set; }

        public string Genre { get; set; }

        public string Developer { get; set; }

        public DateTime Release { get; set; }

        public SystemRequirements MinSystemRequirements { get; set; }

        public SystemRequirements RecommendedSystemRequirements { get; set; }

    }
}