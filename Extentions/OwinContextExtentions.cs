using Microsoft.Ajax.Utilities;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;

namespace WebApiOAuth2.Extentions
{
    public static class OwinContextExtentions
    {
        public static string GetUserId(this IOwinContext ctx)
        {
            var result = "-1";
            var claim = ctx.Authentication.User.Claims.FirstOrDefault(c => c.Type == "UserId" );
            if ( claim != null )
            {
                result = claim.Value;
            }
            return result;
        }
    }
}