﻿using System.Collections.Generic;

namespace NEO.Api.Models
{
    public class Wallet
    {
        public Wallet()
        {
            TransfersIn = new List<Transfers>();
            TransfersOut = new List<Transfers>();
        }
        public long Id { get; set; }
        public string Address { get; set; }

        public List<Transfers> TransfersIn { get; set; }
        public List<Transfers> TransfersOut { get; set; }

    }
}
