﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Poker.Shared.Models
{
    public class CreateTableResult
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
