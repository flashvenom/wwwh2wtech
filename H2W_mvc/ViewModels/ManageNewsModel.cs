using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using H2W_lib;

namespace H2W_mvc.ViewModels
{
    public class NewsVM
    {
        public int articleid { get; set; }
        public tblNewsArticle newsrec { get; set; }

        //ANTHONY: This might be a good learning experience. How do I add this column from the table to my model? I'm guessing GET?
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime PostedDate { get; set; }
    }

    public class ManageNewsViewModel
    {
        private H2WtechEntities db;
        public NewsVM currentVM = new NewsVM();

        public ManageNewsViewModel(H2WtechEntities db)
        {
            this.db = db;
        }

        public void BuildVM(int articleid)
        {
            currentVM.newsrec = (from c in db.tblNewsArticles
                                 where c.NewsArticleId == articleid
                                select c).FirstOrDefault();
        }
    }
}