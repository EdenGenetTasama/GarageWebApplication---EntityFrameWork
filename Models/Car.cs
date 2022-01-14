using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarageWebApplication.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string OwnerName { get; set; }
        public int CarNum { get; set; }
        public bool IsFixed { get; set; }



    }
}