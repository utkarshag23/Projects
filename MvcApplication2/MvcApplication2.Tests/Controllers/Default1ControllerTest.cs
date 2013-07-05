using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using NUnit.Framework;
using MvcApplication2.Controllers;
using MvcApplication2.Models;

namespace MvcApplication2.Tests.Controllers
{
    [TestFixture]
    public class Default1ControllerTest
    {
             [Test]
            public void firstp()
            {
                Default1Controller controller = new Default1Controller();
                var model = new Class1();
                model.text1 = "abc";
                string op = "b1";
                ViewResult result = controller.View1(model, op) as ViewResult;
                Assert.AreEqual(model.result, "correct input");
                
            }
        [Test]
             public void fnull()
             {
                 Default1Controller controller = new Default1Controller();
                 var model = new Class1();
                 model.text1 = null;
                 string op = "b1";
                 var result = controller.View1(model, op) as HttpNotFoundResult;
                // ViewResult result = controller.View1(model, op) as ViewResult;
              //   Assert.AreEqual(model.result, "");
                 Assert.AreEqual(404, result.StatusCode);

             }

            [Test]
            public void firstn()
            {
                Default1Controller controller = new Default1Controller();
                var model = new Class1();
                model.text1 = "234";
                string op = "b1";
                var result = controller.View1(model, op) as HttpStatusCodeResult;
              //  ViewResult result = controller.View1(model, op) as ViewResult;
                Assert.AreEqual(400, result.StatusCode);

            }

            [Test]
            public void secondp()
            {
                Default1Controller controller = new Default1Controller();
                var model = new Class1();

                model.text2 = "123";
                string op = "b2";
                ViewResult result = controller.View1(model, op) as ViewResult;
                Assert.AreEqual(model.result, "correct input");

            }

            [Test]
            public void secondn()
            {
                Default1Controller controller = new Default1Controller();
                var model = new Class1();

                model.text2 = "abc";
                string op = "b2";
             //   ViewResult result = controller.View1(model, op) as ViewResult;
               // Assert.AreEqual(model.result, "only numeric characters allowed");
                var result = controller.View1(model, op) as HttpStatusCodeResult;
                //  ViewResult result = controller.View1(model, op) as ViewResult;
                Assert.AreEqual(400, result.StatusCode);

            }

            [Test]
            public void thirdp()
            {
                Default1Controller controller = new Default1Controller();
                var model = new Class1();
                model.text3 = "/;'[]";
                string op = "b3";
                ViewResult result = controller.View1(model, op) as ViewResult;
                Assert.AreEqual(model.result, "correct input");
            }

            [Test]
            public void thirdn()
            {
                Default1Controller controller = new Default1Controller();
                var model = new Class1();
                model.text3 = "fvvfdv";
                string op = "b3";
              //  ViewResult result = controller.View1(model, op) as ViewResult;
                //Assert.AreEqual(model.result, "only special characters allowed");
                var result = controller.View1(model, op) as HttpStatusCodeResult;
                //  ViewResult result = controller.View1(model, op) as ViewResult;
                Assert.AreEqual(400, result.StatusCode);
            }
        }
       
    }

