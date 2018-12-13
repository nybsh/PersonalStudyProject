using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MVCSolutionLib
{
    public class MVCHandler: IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }
        
        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write(string.Format("当前页面访问地址：{0} ", context.Request.Url.AbsoluteUri));
            context.Response.Write("Hello MVC");
        }
    }
}
