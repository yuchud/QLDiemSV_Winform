using System;
using System.Linq;

namespace QLDiemSV_Winform.Validation
{
    public class EnumCode {
        public enum ApiDeleteResult
        {
            Success,
            Failure
        }

        public enum Decentralization
        {
            None,
            GiangVien,
            NhanVien
        }

        public enum HTTPResponseStatusClass {
            InformationalResponses,
            SuccessfulResponses,
            RedirectionMessages,
            ClientErrorResponses,
            ServerErrorResponses
        }
    }
}
