using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using H2W_lib;

namespace H2W_mvc.ViewModels
{
    public class CategoryVM
    {
        //What do we need (all the data)
        public int catid { get; set; }
        //string info { get; set; }
        public tblCategory catrec { get; set; }
        public List<tblProduct> products { get; set; }
        public List<tblText> textAreas { get; set; }
    }

    public class ManageCategoryViewModel
    {
        private H2WtechEntities db;
        public CategoryVM currentVM = new CategoryVM();

        public ManageCategoryViewModel(H2WtechEntities db)
        {
            this.db = db;
        }

        public void BuildVM(int catid)
        {
            currentVM.catrec = (from c in db.tblCategories
                         where c.CategoryId == catid
                         select c).FirstOrDefault();

            currentVM.products = currentVM.catrec.tblProducts.Where(c => c.Active == true).OrderBy(x => x.ProductNo).ToList();
            currentVM.textAreas = currentVM.catrec.tblTexts.ToList();

        }
    }
}