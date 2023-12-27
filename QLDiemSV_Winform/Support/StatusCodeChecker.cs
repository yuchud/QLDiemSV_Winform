using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV_Winform.Validation
{
    internal class StatusCodeChecker
    {
        public StatusCodeChecker() { }
        public static EnumCode.HTTPResponseStatusClass GetResponseClass(HttpStatusCode httpStatusCode)
        {
            int httpStatusCodeInt = (int)httpStatusCode;
            if (httpStatusCodeInt >= 100 && httpStatusCodeInt < 200)
            {
                return EnumCode.HTTPResponseStatusClass.InformationalResponses;
            }
            if (httpStatusCodeInt < 300)
            {
                return EnumCode.HTTPResponseStatusClass.SuccessfulResponses;
            }
            if (httpStatusCodeInt < 400)
            {
                return EnumCode.HTTPResponseStatusClass.RedirectionMessages;
            }
            if(httpStatusCodeInt < 500)
            {
                return EnumCode.HTTPResponseStatusClass.ClientErrorResponses;
            }
            return EnumCode.HTTPResponseStatusClass.ServerErrorResponses;
        }
    }
}
