﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Web.DAL;
using Capstone.Web.Models;

namespace Capstone.Web.Controllers
{
    public class PlaceController : Controller
    {
        private IPlacesDAL dal; 

        public PlaceController(IPlacesDAL userDAL)
        {
            this.dal = userDAL;
        }

        public ActionResult Restaurant()
        {
            List<PlacesModel> model = dal.GetAllPlaces();
            return View("Restaurant", model);
        }

        public ActionResult Shopping()
        {
            List<PlacesModel> model = dal.GetAllPlaces();
            return View("Shopping", model);
        }

        public ActionResult Entertainment()
        {
            List<PlacesModel> model = dal.GetAllPlaces();
            return View("Entertainment", model);
        }

        public ActionResult Landmarks()
        {
            List<PlacesModel> model = dal.GetAllPlaces();
            return View("Landmarks", model);
        }

        public ActionResult Sports()
        {
            List<PlacesModel> model = dal.GetAllPlaces();
            return View("Sports", model);
        }

    }
}