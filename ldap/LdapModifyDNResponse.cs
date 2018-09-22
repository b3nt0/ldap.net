﻿using zivillian.ldap.Asn1;

namespace zivillian.ldap
{
    public class LdapModifyDNResponse : LdapResponseMessage
    {
        internal LdapModifyDNResponse(Asn1LDAPResult result, Asn1LdapMessage message)
            : base(result, message)
        {
        }

        internal override void SetProtocolOp(Asn1ProtocolOp op, Asn1LDAPResult result)
        {
            op.ModifyDNResponse = result;
        }
    }
}