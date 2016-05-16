
using MoneySearchEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoneySearchMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View(GetAllMoney());
        }

        public void ConvertChange(int number)
        {
            //get the value of the number to change

            // get the money available from the table

            //foreach each money 
            /*
            (     /50
                /20
                /10
                /5
                /2
                /and so onn)
            {
                start getting the remaining and go to the next one.
           
            }

            // 
            GetAllSearches();
             * */
        }


        public List<MoneyClass> GetAllMoney()
        {
            MoneyClass moneyClass = new MoneyClass();
            List<MoneyClass> moneyList = moneyClass.GetAll();
            return moneyList;
        }


        public List<SearchClass> GetAllSearches()
        {
            SearchClass searchClass = new SearchClass();
            List<SearchClass> searchList = searchClass.GetAllSearches();
            return searchList;
        }
    }
}
