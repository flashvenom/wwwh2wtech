using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using H2W_lib;

namespace H2W_mvc.ViewModels
{
    public class TopMenu
    {
        public TopMenu()
        {
            Motors = new List<tblCategory>();
            PoitioningStages = new List<tblCategory>();
            OtherProducts = new List<tblCategory>();
        }

        public List<tblCategory> Motors { get; set; }
        public List<tblCategory> PoitioningStages { get; set; }
        public List<tblCategory> OtherProducts { get; set; }

    }

    public class BuildTopMenu
    {
       public TopMenu topmenu{ get; set; }
       
       private H2WtechEntities db = new H2WtechEntities();

        public BuildTopMenu()
        {
            topmenu = new TopMenu();
            topmenu.Motors = (from c in db.tblCategories
                        where c.CategoryGroup == "Motors"
                        orderby c.CategoryId
                        select c).OrderBy(c => c.FeaturedSequence).ToList();
            topmenu.PoitioningStages = (from c in db.tblCategories
                        where c.CategoryGroup == "Stages"
                        orderby c.CategoryId
                        select c).OrderBy(c => c.FeaturedSequence).ToList();
            topmenu.OtherProducts = (from c in db.tblCategories
                        where c.CategoryGroup == "Other"
                        orderby c.CategoryId
                        select c).ToList();

        }
    }

    
}