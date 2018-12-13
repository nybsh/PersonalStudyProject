using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MVCSolutionLib
{
    public class UrlRoutingModule : IHttpModule
    {
        public void Dispose()
        {

        }

        public void Init(HttpApplication app)
        {
            app.PostResolveRequestCache += app_PostResolveRequestCache;
        }
        private void app_PostResolveRequestCache(object sender, EventArgs e)
        {
            var app = (HttpApplication)sender;

            app.Context.RemapHandler(new MVCHandler());
        }
    }
}
