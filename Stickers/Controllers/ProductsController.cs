﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stickers.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {

            List<Product> lp = new List<Product>();
            lp.Add(new Product() { nameprod = "Sticker Got", price = 30, idprod = 1 });
            lp.Add(new Product() { nameprod = "Sticker Vikings", price = 40, idprod = 1 });
            lp.Add(new Product() { nameprod = "Sticker Friends", price = 20, idprod = 1 });
            lp.Add(new Product() { nameprod = "Sticker Dark", price = 20, idprod = 1 });
            lp.Add(new Product() { nameprod = "Sticker TEST", price = 150, idprod = 1 });
            lp.Add(new Product() { nameprod = "Sticker Flash", price = 70, idprod = 1 });


            return View(lp);
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Products/Edit/5
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

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
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