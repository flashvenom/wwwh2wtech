using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace H2W_mvc.Models
{
    public class NewsModel
    {
        //Doesn't even need a model, then why the hell do I do here....
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PostedDate { get; set; }
    }


}