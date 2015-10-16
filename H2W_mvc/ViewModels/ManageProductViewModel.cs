using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;
using H2W_lib;

namespace H2W_mvc.ViewModels
{
    public class ProductVM
    {
        //What do we need (all the data)
        public int productid { get; set; }
        //string info { get; set; }
        public tblProduct prodrec { get; set; }
        public List<tblProductSpec> prodspec { get; set; }
        public List<tblProduct> products { get; set; }
        public List<tblText> textAreas { get; set; }

        [Required(ErrorMessage = "We need to know your name.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please provide your company name.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Company")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Your phone number is required.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please enter a valid email address.")]
        [DataType(DataType.Text)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Product to Quote:")]
        public string Quest1 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Quantity Required:")]
        public string Quest2 { get; set; }

        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }
    }

    public class ManageProductViewModel
    {
        private H2WtechEntities db;
        public ProductVM currentVM = new ProductVM();

        public ManageProductViewModel(H2WtechEntities db)
        {
            this.db = db;
        }

        public void BuildVM(int productid)
        {
            currentVM.prodrec = (from c in db.tblProducts
                                 where c.ProductId == productid
                                 select c).FirstOrDefault();
            //currentVM.prodcat = currentVM.prodrec.tblCategory.CategoryPageUrl;
            if (currentVM.prodrec.ProductNo.StartsWith("BLDT"))
            {
                //This little hack allows us to display two sets of specs within a category by hiding and showing them.
                currentVM.prodspec = (from c in db.tblProductSpecs
                                      where c.ProductId == productid
                                      select c).OrderByDescending(x => x.tblCategorySpecificSpec.Sequence).Take(4).ToList();
            }
            else if (currentVM.prodrec.ProductNo.StartsWith("BLST")) {
                currentVM.prodspec = (from c in db.tblProductSpecs
                                      where c.ProductId == productid
                                      select c).OrderByDescending(x => x.tblCategorySpecificSpec.Sequence).Take(4).ToList();
            }
            else if(currentVM.prodrec.ProductNo.StartsWith("BLDM") || currentVM.prodrec.ProductNo.StartsWith("BLSM"))
            {
                currentVM.prodspec = (from c in db.tblProductSpecs
                                      where c.ProductId == productid
                                      select c).OrderBy(x => x.tblCategorySpecificSpec.Sequence).Take(19).ToList();
            }

            else if(currentVM.prodrec.ProductNo.StartsWith("BLSM"))
            {
                currentVM.prodspec = (from c in db.tblProductSpecs
                                      where c.ProductId == productid
                                      select c).OrderBy(x => x.tblCategorySpecificSpec.Sequence).Take(19).ToList();
            }
            else if (currentVM.prodrec.ProductNo.StartsWith("STP-"))
            {
                currentVM.prodspec = (from c in db.tblProductSpecs
                                      where c.ProductId == productid
                                      select c).OrderByDescending(x => x.tblCategorySpecificSpec.Sequence).Take(6).ToList();
            }
            else if (currentVM.prodrec.ProductNo.StartsWith("P12"))
            {
                currentVM.prodspec = (from c in db.tblProductSpecs
                                      where c.ProductId == productid
                                      select c).OrderByDescending(x => x.tblCategorySpecificSpec.Sequence).Take(6).ToList();
            }
            else {

                currentVM.prodspec = (from c in db.tblProductSpecs
                                  where c.ProductId == productid
                                  select c).OrderBy(x => x.tblCategorySpecificSpec.Sequence).ToList();
            }
        }
    }
}