using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using H2W_lib;

namespace H2W_mvc.ViewModels
{
    public class PagesVM
    {
        public int pageid { get; set; }
        public tblText textrec { get; set; }
    }

    public class ManagePageViewModel
    {
        private H2WtechEntities db;
        public PagesVM currentVM = new PagesVM();

        public ManagePageViewModel(H2WtechEntities db)
        {
            this.db = db;
        }

        public void BuildVM(int pageid)
        {
            currentVM.textrec = (from c in db.tblTexts
                                 where c.pageId == pageid
                                select c).FirstOrDefault();
        }
    }
}