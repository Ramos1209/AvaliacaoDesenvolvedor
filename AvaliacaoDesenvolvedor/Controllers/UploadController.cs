using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

using System.Collections;
using AvaliacaoDesenvolvedor.Models;

namespace AvaliacaoDesenvolvedor.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UploadDeArquivo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadDeArquivo(HttpPostedFileBase file)
        {
            try
            {
                if (file.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    string _path = Path.Combine(Server.MapPath("~/uploads"), _FileName);
                    file.SaveAs(_path);
                }
                ViewBag.Message = "Arquivo carregado com sucesso!!";
                return View();
            }
            catch
            {
                ViewBag.Message = "File upload failed!!";
                return View();
            }
        }
        public ActionResult LerArquivos()
        {

            return View();
        }

       



        
    }
}