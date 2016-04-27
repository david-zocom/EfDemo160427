using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Demo1.Models
{
    [Table("DavidsNumbers")]
    public class NumbersModel
    {
        [Key]
        public int Id { get; set; }

        public int Number { get; set; }

    }
}