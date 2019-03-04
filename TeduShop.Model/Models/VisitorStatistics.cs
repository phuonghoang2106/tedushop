﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("visitorStatistics")]
    public class VisitorStatistics
    {
        [Key]
        public Guid ID { set; get; }

        [Required]
        public DateTime VisiteDate { set; get; }

        [MaxLength(50)]
        public string IPAddress { set; get; }
    }
}
