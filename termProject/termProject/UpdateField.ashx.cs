using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using termProjectLibrary;

namespace termProject
{
    /// <summary>
    /// Summary description for UpdateField
    /// </summary>
    public class UpdateField : IHttpHandler, System.Web.SessionState.IReadOnlySessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string newName = context.Request.QueryString["name"].ToString();
            string email = "inastela@gmail.com";
            int result;
            customer customerObj = new customer();
            result = customerObj.changeName(newName, email);
            context.Response.Write(result);

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}