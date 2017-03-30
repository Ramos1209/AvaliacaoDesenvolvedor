using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

using System.Collections;
using AvaliacaoDesenvolvedor.Models;
using AvaliacaoDesenvolvedor.EF;

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
                    List<Pedido> lista = new List<Pedido>();
                    DbContexto db = new DbContexto();
                    string[] array = System.IO.File.ReadAllLines(_path);

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (i > 0)
                        {

                            Pedido p = new Pedido();

                            string[] auxiliar = array[i].Replace("\t", "|").Split('|');

                            p.Comprador = auxiliar[0];
                            p.Descricao = auxiliar[1];
                            p.PrecoUnitario = Convert.ToDecimal(auxiliar[2]);
                            p.Quantidade = Convert.ToInt32(auxiliar[3]);
                            p.Endereco = auxiliar[4];
                            p.Fornecedor = auxiliar[5];
                            p.Total = p.Quantidade * p.PrecoUnitario;
                            //Adiciono o objeto a lista
                            lista.Add(p);
                            db.Pedido.Add(p);
                            db.SaveChanges();
                           
                        }


                    }
                    return View("ListaDeUpload", lista);


                }
                return null;


            }
            catch (Exception erro)
            {
                ViewBag.Message = "File upload failed!!";

                return View();
            }
        }
        public ActionResult SalvaNoBanco()
        {



            return View("ListasDeUploads");

        }



    }
        

    }
