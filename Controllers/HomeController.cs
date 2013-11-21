using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS445.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormatPhoneNumber(string inputNumber)
        {

          if (string.IsNullOrEmpty(inputNumber))
          {
            return Content("invalid input, please try again");
          }
          else
          {
            string formatted = formatNumber(inputNumber);
            return View((object)formatted);
          }
        }

        // please implement your phone number formatting logic here
        private string formatNumber(string inputNumber)
        {
          // imiplement formatting here
            string sub1 = inputNumber.Substring(0, 3);
            string sub2 = inputNumber.Substring(3, 3);
            string sub3 = inputNumber.Substring(6, 4);
            return  "(" + sub1 + ")" + " " + sub2 + "-" + sub3;
            
        }
        public ActionResult Task2()
        {
            return View();
        }
        public ActionResult FormatText(string inputText)
        {
            if (string.IsNullOrEmpty(inputText))
            {
                return Content("invalid input, please try again");
            }
            else
            {
                string formatted = formatText(inputText);
                return View((object)formatted);
            }
        }
        private string formatText(string inputText)
        {
            string[] words = inputText.Split(' ');
            string word2 = "";
            foreach (string word in words.Reverse<string>())
            {
                word2 = word2 + " " + word;
            }
            return word2;
        }
    }
}
