using System;
using System.Web;

namespace SimpleHandlerNameSpace.App_Code
{
    public class SimpleHandlerClass : IHttpHandler
    {
        /// <summary>
        /// </summary>
        #region IHttpHandler Members

        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest Request = context.Request;
            HttpResponse Response = context.Response;

            Response.Write("<html>");
            Response.Write("<body>");
            Response.Write("<h1>This is SimpleHandler.</h1>");
            Response.Write("</body>");
            Response.Write("</html>");
        }

        #endregion
    }
}
