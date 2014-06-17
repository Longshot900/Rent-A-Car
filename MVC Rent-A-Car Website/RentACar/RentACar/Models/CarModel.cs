using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace RentACar.Models
{
    public class CarModel
    {
        public int ID { get; set; }
        public string manufacturer { get; set; }
        public string make { get; set; }
        [Display(Name = "year")]
        [DataType(DataType.Date)]
        public DateTime year { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public double price { get; set; }
    }

    public class CarDBContext : DbContext
    {
        public DbSet<CarModel> Cars { get; set; }
    }
}