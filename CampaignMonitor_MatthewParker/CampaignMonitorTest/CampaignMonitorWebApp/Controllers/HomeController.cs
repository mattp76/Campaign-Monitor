using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CampaignMonitorWebApp.Extensions;
using CampaignMonitorWebApp.Helpers;

namespace CampaignMonitorWebApp.Controllers
{
    public class HomeController : Controller
    {
        string _null = null;
        string _stringA = "a";
        string _emptyString = "";
        string _emptyNullString = "null";

        public ActionResult Index()
        {
            ViewBag.checkForNull = _null.IsNullOrEmpty();
            ViewBag.checkForStringA = _stringA.IsNullOrEmpty();
            ViewBag.checkForEmptyString = _emptyString.IsNullOrEmpty();
            ViewBag.checkForEmptyNullString = _emptyNullString.IsNullOrEmpty();

            //Return positive divisors of input integer
            ViewBag.divisorsFor60 = String.Join("-", IntHelper.GetDivisors(60));
            ViewBag.divisorsFor42 = String.Join("-", IntHelper.GetDivisors(42));


            //triangle helper class. This contains a method - GetTriangleType which will return
            //the type of triangle (selected from Enum) and its output int.
            //Negative or a non triangle will return the user defined exception InvalidTriangleException
            ViewBag.areaOfTriangle = TriangleHelper.GetTriangleType(3, 4, 5).ToString();

            ViewBag.commonIntegers1 = String.Join("-", IntHelper.getMostPopularElement(new int[] { 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 }));
            ViewBag.commonIntegers2 = String.Join("-", IntHelper.getMostPopularElement(new int[] { 1, 2, 3, 4, 5, 1, 6, 7 }));
            ViewBag.commonIntegers3 = String.Join("-", IntHelper.getMostPopularElement(new int[] { 1, 2, 3, 4, 5, 6, 7 }));

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
