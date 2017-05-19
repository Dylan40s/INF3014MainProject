using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MainProject.Models
{
    public class Product
    {
        /* this class is used to store product information
         * it will be called to hold product info throughout the website
         * */
        // create variables to be used, get set allows variable to be accesses and set easier from outisde the class
        [ScaffoldColumn(false)]
        // scaffoldColumn usde for
        public int ProductID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string ProductName { get; set; }

        [Required, StringLength(10000), Display(Name = "Product description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string ImagePath { get; set; }

        [Display(Name = "Price")]
        // ? used as it signals that it can be null or a double
        public double? UnitPrice{get; set;}
        public int? CategoryID { get; set; }
        public virtual Category Cateory { get; set; }
    }
}