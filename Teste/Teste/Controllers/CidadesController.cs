using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teste.Controllers;

namespace Teste.Controllers
{
    public class CidadesController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cidade()
        {
            return View();
        }

        //
        // POST: /Home/Details

        [HttpPost]
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(Models.Cidade cidade, Models.Estado estado)
        {
            ProcessadorCidade.Cidade objCidade = new ProcessadorCidade.Cidade();
            objCidade.Estado = new ProcessadorCidade.Estado();
            objCidade.Codigo = cidade.Codigo;
            objCidade.Capital = cidade.Capital;
            objCidade.Estado.Codigo = estado.Codigo;
            objCidade.Nome = cidade.Nome;
            ProcessadorCidade.CidadeClient cidadePr = new ProcessadorCidade.CidadeClient();
            cidadePr.Cadastrar(objCidade);
            return View();
        }

        //
        // POST: /Home/Edit/5

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

        //
        // POST: /Home/Delete/5

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
