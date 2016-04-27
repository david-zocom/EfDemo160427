using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Demo1.Models
{
    public class NumbersContext : DbContext
    {
        public NumbersContext() : base() { }

        public DbSet<NumbersModel> Numbers { get; set; }

    }
}