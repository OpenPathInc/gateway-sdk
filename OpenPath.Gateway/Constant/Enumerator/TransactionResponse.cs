using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPath.Gateway.Constant.Enumerator {
    
    public enum ResponseEnumerator {
        Approved = 1,
        Declined = 2,
        Error    = 3
    }

    public enum AvsResponseEnumerator {
        ExactMatch9CharacterNumericZip,
        ExactMatch5CharacterNumericZip,
        ExactMatch5CharacterNumericZipCustomerName,
        AddressMatchOnly,
        AddressCustomerNameMatchOnly,
        CharacterNumericZipMatchOnly,
        CharacterZipMatchOnly,
        CharacterZipCustomerNameMatchOnly,
        NoAddressOrZipMatchOnly,
        NoAddressOrZipOrCustomerNameMatchOnly,
        AddressUnavailable,
        NonUSIssuerDoesNotParticipate,
        IssuerSystemUnavailable,
        NotAMailPhoneOrder,
        ServiceNotSupported,
        AvsNotAvailable
    }
    
}
