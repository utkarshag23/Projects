using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;
using System.Net;
using System.Text.RegularExpressions;

namespace MvcApplication2.Controllers
{
    public class Default1Controller : Controller
    {
        //
        // GET: /Default1/

        public ActionResult Index()
        {
            return View();
        }

         public ActionResult View1(Class1 model, string op)
        {
            if (op != null)
            {
                if (op.Equals("b1"))
                {
                    //   model.text3 = model.text1;
                    if (model.text1 == null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        //String a=model.text1;
                        Regex r = new Regex(@"^[a-zA-Z\s]*$");
                        bool ab = r.IsMatch(model.text1);
                        if (ab)
                        {
                            model.result = "correct input";
                        }
                        else
                        {
                            // model.result = "only alphabetic characters allowed";
                            int i = (int)HttpStatusCode.BadRequest;
                            return new HttpStatusCodeResult(i, "Bad Request");
                        }
                    }
                }


                if (op.Equals("b2"))
                {
                     //   model.text3 = model.text1;
                    if (model.text2 == null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        //String a=model.text1;
                        Regex r = new Regex(@"^[0-9\s]*$");
                        //string s = model.text2.ToString();
                        bool ab = r.IsMatch(model.text2);
                        if (ab)
                        {
                            model.result = "correct input";
                        }
                        else
                        {
                            // model.result = "only alphabetic characters allowed";
                            int i = (int)HttpStatusCode.BadRequest;
                            return new HttpStatusCodeResult(i, "Bad Request");
                        }
                    }
                }

                if (op.Equals("b3"))
                {
                    //   model.text3 = model.text1;
                    if (model.text3 == null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        //String a=model.text1;
                        Regex r = new Regex(@"^[a-zA-Z0-9\s]*$");
                        bool ab = r.IsMatch(model.text3);
                        if (!ab)
                        {
                            model.result = "correct input";
                        }
                        else
                        {
                            // model.result = "only alphabetic characters allowed";
                            int i = (int)HttpStatusCode.BadRequest;
                            return new HttpStatusCodeResult(i, "Bad Request");
                        }
                    }
                }
            }
            return View(model);
        }


    }
}
