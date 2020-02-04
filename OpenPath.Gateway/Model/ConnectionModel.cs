using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPath.Gateway.Model {

    public class ConnectionModel {

        public string ApiUrl { get; set; } = Constant.WebConstant.URL_PRODUCTION_TRANSACTION;

        public string Username { get; set; }

        public string Password { get; set; }

    }

}
