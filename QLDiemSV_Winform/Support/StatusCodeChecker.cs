using System;
using System.Linq;
using System.Net;

namespace QLDiemSV_Winform.Validation
{
    internal class StatusCodeChecker
    {
        public StatusCodeChecker()
        {
        }

        public static EnumCode.HTTPResponseStatusClass GetResponseClass(HttpStatusCode httpStatusCode)
        {
            if ((int)httpStatusCode >= 100 && (int)httpStatusCode < 200)
            {
                return EnumCode.HTTPResponseStatusClass.InformationalResponses;
            }
            if ((int)httpStatusCode < 300)
            {
                return EnumCode.HTTPResponseStatusClass.SuccessfulResponses;
            }
            if ((int)httpStatusCode < 400)
            {
                return EnumCode.HTTPResponseStatusClass.RedirectionMessages;
            }
            if ((int)httpStatusCode < 500)
            {
                return EnumCode.HTTPResponseStatusClass.ClientErrorResponses;
            }
            return EnumCode.HTTPResponseStatusClass.ServerErrorResponses;
        }
    }
}
