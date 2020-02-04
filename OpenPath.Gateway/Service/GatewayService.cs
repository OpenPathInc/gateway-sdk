using OpenPath.Gateway.Builder;
using OpenPath.Gateway.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPath.Gateway.Service {

    public class GatewayService {

        ConnectionModel _connectionModel;

        public GatewayService(ConnectionModel connectionModel) {

            _connectionModel = connectionModel;

        }

        public ResponseModel Process(TransactionBuilder transaction) {
        
            var response = (ResponseModel) null;

            

            return response;

        }

    }

}
