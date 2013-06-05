using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Teste.Controllers
{
    public class EstadosController : Controller
    {
        //
        // GET: /Cidades/

        public ActionResult Estado()
        {
            return View();
        }

        //
        // GET: /Cidades/Details/5

        public JsonResult Details(int? id)
        {
            var rsJson = new JsonResult();
            ProcessadorEstado.Estado objEstado = new ProcessadorEstado.Estado();
            objEstado.Codigo = 1;
            ProcessadorEstado.EstadoClient estadoPr = new ProcessadorEstado.EstadoClient();
            rsJson.Data = estadoPr.Consultar(objEstado);
            return rsJson;
        }

        //
        // POST: /Cidades/Create

        [HttpPost]
        public ActionResult Create(Models.Estado estado)
        {
            try
            {
                // TODO: Add insert logic here
                ProcessadorEstado.Estado objEstado = new ProcessadorEstado.Estado() 
                {
                    Codigo = estado.Codigo,
                    Nome = estado.Nome,
                    Pais = estado.Pais,
                    Regiao = estado.Regiao,
                    Sigla = estado.Sigla
                };
                ProcessadorEstado.EstadoClient estadoPr = new ProcessadorEstado.EstadoClient();
                estadoPr.Cadastrar(objEstado);
                return View();
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // POST: /Cidades/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
