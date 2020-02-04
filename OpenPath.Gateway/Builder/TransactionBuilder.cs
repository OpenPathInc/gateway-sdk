using OpenPath.Gateway.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPath.Gateway.Builder {

    public class TransactionBuilder {

        internal string          _type;
        internal decimal?        _amount;
        internal CreditCardModel _creditCard;

        public TransactionBuilder AsSale() {
            _type = "sale";
            return this;
        }

        public TransactionBuilder AsAuthorization() {
            _type = "auth";
            return this;
        }

        public TransactionBuilder AsCapture() {
            _type = "capture";
            return this;
        }

        public TransactionBuilder AsValidation() {
            _type = "validate";
            return this;
        }

        public TransactionBuilder AsCredit() {
            _type = "credit";
            return this;
        }

        public TransactionBuilder AsRefund() {
            _type = "refund";
            return this;
        }

        public TransactionBuilder AsVoid() {
            _type = "void";
            return this;
        }

        public TransactionBuilder AsOffline() {
            _type = "offline";
            return this;
        }

        public TransactionBuilder AddPayment(CreditCardModel creditCard) {
            _creditCard = creditCard;
            return this;
        }

        public TransactionBuilder AddAmount(decimal amount) {
            _amount = amount;
            return this;
        }

        public string ToUrlEncodedString() {

            var urlEncodedString = "?";

            if(!string.IsNullOrEmpty(_type)) urlEncodedString += $"type={_type}&";
            if(_amount             != null ) urlEncodedString += $"amount={_amount.ToString()}&";


            return urlEncodedString;

        }

    }

}
