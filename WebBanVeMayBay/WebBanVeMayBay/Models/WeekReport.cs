using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebBanVeMayBay.Models
{
    [Table("WeekReports")]
    public class WeekReport
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Day { get; set; }
        public int Number { get; set; }
        public int Revenue { get; set; }
        public int Rate { get; set; }
        public int? Created_By { get; set; }
        public DateTime? Created_At { get; set; }
        public int? Update_By { get; set; }
        public DateTime? Update_At { get; set; }
    }
}