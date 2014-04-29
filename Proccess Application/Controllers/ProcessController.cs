using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Web;
using System.Web.Mvc;

namespace Proccess_Application.Controllers
{
    public class ProcessController : Controller
    {
        //
        // GET: /Kill/
        public ActionResult Index(int process = 0)
        {
			Process p = Process.GetProcessById(process);
            return View(p);
        }
		public ActionResult Kill(int process = 0) {
			Process p = Process.GetProcessById(process);
			try {
			
			p.Kill();
			}
			catch (Exception e) {
				Console.WriteLine(e.Message);
			}
			return Redirect("/");
		}
	}
}