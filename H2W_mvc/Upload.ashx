<%@ WebHandler Language="C#" Class="Upload" %>

using System;
using System.Web;
using System.IO;
using System.Web.Mail;
using System.Globalization;

public class Upload : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        context.Response.Expires = -1;
        try
        {
            HttpPostedFile postedFile = context.Request.Files["Filedata"];
            
            string savepath = "";
            string tempPath = "";
            string filepath = "";

			tempPath = context.Request["myfolder"];
            savepath = context.Server.MapPath(tempPath);
            filepath = savepath + postedFile.FileName;
            string filename = postedFile.FileName;
            if (!Directory.Exists(savepath))
                Directory.CreateDirectory(savepath);

            if (File.Exists(filepath))
            {
                string extension = System.IO.Path.GetExtension(postedFile.FileName);
                string strFile = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss", CultureInfo.InvariantCulture);
                filename = strFile + extension;
            }
            

            postedFile.SaveAs(savepath + @"\" + filename);
            context.Response.Write(filename);
            context.Response.StatusCode = 200;
			
			
        }
        catch (Exception ex)
        {
            context.Response.Write("Error: " + ex.Message);
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }
}