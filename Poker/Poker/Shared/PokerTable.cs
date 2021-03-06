﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Poker.Shared
{
    public class PokerTable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int MaxPlayers { get; set; }
    }
}
