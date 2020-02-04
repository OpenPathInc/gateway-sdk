using System;
using System.Collections.Generic;
using System.Text;
using OpenPath.Gateway.Constant.Enumerator;

namespace OpenPath.Gateway.Model {

    public class ResponseModel {

        public ResponseEnumerator Response { get; set; }

        public AvsResponseEnumerator AvsResponse { get; set; }

        public string ResponseText { get; set; }

        public string AuthorizationCode { get; set; }

        public string OrderId { get; set; }

        public string EmvAuthResponseData { get; set; }

    }

}
