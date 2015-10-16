using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace H2W_mvc.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            Names = new List<string>();
            Names.Add("Anthony");
            Names.Add("Nathan");
        }

        public List<string> Names { get; set; }
        [Required (ErrorMessage="You need to fill out the product you dummy")]
        [RegularExpression("^[0-9A]$",ErrorMessage="Not correct format")]
        public string Product { get; set; }
        public DateTime When { get { return DateTime.Now; } set { this.When = value; } }
        public Boolean Buy { get; set; }

    }
}