using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVCLaboratorio.Utilerias;
using System.Data.SqlClient;
using System.Data;

namespace MVCLaboratorio.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //Obtener la información de los videos
           
            DataTable dtVideos;

            dtVideos = BaseHelper.ejecutarConsulta("Select * from Video", CommandType.Text);

            ViewData["no_videos"] = dtVideos.Rows.Count;
           

            return View();
            
        }

    }
}
