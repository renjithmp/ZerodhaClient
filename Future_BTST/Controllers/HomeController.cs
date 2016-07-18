﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Future_BTST.Controllers
{
    public class HomeController : ZerodhaController
    {
        public void Index()
        {
            ViewBag.Title = "Home Page";

            var redirectUri = ZClient.ZLogin.SiteLogin();
            HttpContext.Response.Redirect(redirectUri);

        }
        [Route("Home/zerodha_response")]
        public string zerodha_response(string status, string request_token)
        {
            var response = ZClient.ZLogin.GetUserToken(request_token);
            HttpContext.Session["UserToken"] = response ?? "Default";
            return response;
        }



    }
}
