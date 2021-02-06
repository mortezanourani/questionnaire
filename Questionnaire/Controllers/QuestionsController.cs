using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Questionnaire.Models;

namespace Questionnaire.Controllers
{
    public class QuestionsController : Controller
    {
        // GET: /
        public ActionResult Index()
        {
            return View();
        }

        // POST: /
        [HttpPost]
        public string Index(FormCollection Identification)
        {
            if (string.IsNullOrEmpty(Session["pesronId"] as string))
            {
                int personId = MySqlModel.createPerson(Identification);
                if (personId > 0)
                    Session["personId"] = personId;
            }
            
            // /questions/pagei/
            return "/cfab96c5584a38a84561c0d6ccc38ed4/";
        }



        // GET: Questions/PageI/
        public ActionResult cfab96c5584a38a84561c0d6ccc38ed4()
        {
            ViewData.Add("Questions", MySqlModel.Read(1));
            return View();
        }

        // POST: Questions/PageI/
        [HttpPost]
        public string cfab96c5584a38a84561c0d6ccc38ed4(FormCollection Ambi)
        {
            MySqlModel.updateAnswers(Session["personId"].ToString(), Ambi);

            // /questions/pageiv/
            return "/db9044c0d2425a2e5b9c1e48463c52b4/";
        }



        // GET: Questions/PageIV/
        public ActionResult db9044c0d2425a2e5b9c1e48463c52b4()
        {
            ViewData.Add("Questions", MySqlModel.Read(2));
            return View();
        }

        // POST: Questions/PageIV
        [HttpPost]
        public string db9044c0d2425a2e5b9c1e48463c52b4(FormCollection Dark)
        {
            MySqlModel.updateAnswers(Session["personId"].ToString(), Dark);

            // /questions/pagevi/
            return "/e528c25aaf5807c50aad6bc058c013a29/";
        }



        // GET: Questions/PageVI/
        public ActionResult e528c25aaf5807c50aad6bc058c013a29()
        {
            ViewData.Add("Questions", MySqlModel.Read(3));
            return View();
        }

        // POST: Questions/PageVI/
        [HttpPost]
        public string e528c25aaf5807c50aad6bc058c013a29(FormCollection Covid)
        {
            MySqlModel.updateAnswers(Session["personId"].ToString(), Covid);

            // /questions/pagex/
            return "/fc7c91ef31aa22cc8ad4c221b12b770ed/";
        }



        // GET: Questions/PageX/
        public ActionResult fc7c91ef31aa22cc8ad4c221b12b770ed()
        {
            ViewData.Add("Questions", MySqlModel.Read(4));
            return View();
        }

        // POST: Questions/PageX/
        [HttpPost]
        public string fc7c91ef31aa22cc8ad4c221b12b770ed(FormCollection Emotion)
        {
            MySqlModel.updateAnswers(Session["personId"].ToString(), Emotion);

            // /questions/thanks/
            return "/g00d06796e489999226fb5bb27fe1b3b2/";
        }



        // GET: Questions/Thanks/
        public ActionResult g00d06796e489999226fb5bb27fe1b3b2()
        {
            Session.Clear();
            return View();
        }



        // GET: /Results/
        public ActionResult Results()
        {
            ViewData.Add("Results", MySqlModel.Result());
            return View();
        }
    }
}
