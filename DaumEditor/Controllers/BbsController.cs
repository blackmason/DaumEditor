using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace DaumEditor.Controllers
{
    public class BbsController : Controller
    {
        //
        // GET: /Bbs/

        public ActionResult Write()
        {
            return View();
        }

        public ActionResult ImageUpload()
        {
            return View();
        }

        public JsonResult SubmitAttach(HttpPostedFileBase images)
        {
            string fileName = null;
            string filePath = null;

            if (images.ContentLength > 0)
            {
                fileName = Path.GetFileName(images.FileName);
                filePath = Path.Combine(Server.MapPath("../Uploads"), fileName);
                images.SaveAs(filePath);
            }

            return Json(filePath, JsonRequestBehavior.AllowGet);
        }

    }
}
