using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPath.Gateway.Model {

    public class CreditCardModel {

        public string CcNumber { get; set; }

        public string CcExp { get; set; }

        public string Cvv { get; set; }

        public string Payment { get; set; } = "creditcard";

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }

}
