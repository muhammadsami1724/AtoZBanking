﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtoZBanking.Models
{
    public class AtoZBankingDBContext : DbContext
    {
        public AtoZBankingDBContext(DbContextOptions<AtoZBankingDBContext> options)
    : base(options)
        { }
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
    }

}
