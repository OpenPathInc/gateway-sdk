using NUnit.Framework;
using OpenPath.Gateway.Builder;
using OpenPath.Gateway.Constant;
using OpenPath.Gateway.Model;
using OpenPath.Gateway.Service;

namespace OpenPath.Gateway.UnitTest {

    public class Tests {

        GatewayService  _gatewayService;
        ConnectionModel _connectionModel;


        [SetUp]
        public void Setup() {

            _connectionModel = new ConnectionModel {
                ApiUrl   = WebConstant.URL_UNITTEST_TRANSACTION,
                Username = "TZSdpU2VhaWcTZZ7",
                Password = "hsStGpREZVrG2M3Fkdqxwy4h"
            };

            _gatewayService = new GatewayService(_connectionModel);

        }

        [Test]
        public void Test1() {

            var transaction = new TransactionBuilder()
                .AddPayment(new CreditCardModel {
                    CcExp    = "0128",
                    CcNumber = "4111111111111111",
                    Cvv      = "123",
                    FirstName = "John",
                    LastName  = "Doe"
                })
                .AddCustomer()
                .AsSale();

            var response = _gatewayService.Process(transaction);

            Assert.Pass();

        }
    }
}