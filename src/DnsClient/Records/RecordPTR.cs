/*
 3.3.12. PTR RDATA format

    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
    /                   PTRDNAME                    /
    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+

where:

PTRDNAME        A <domain-name> which points to some location in the
                domain name space.

PTR records cause no additional section processing.  These RRs are used
in special domains to point to some other location in the domain space.
These records are simple data, and don't imply any special processing
similar to that performed by CNAME, which identifies aliases.  See the
description of the IN-ADDR.ARPA domain for an example.
 */

namespace DnsClient.Records
{
    public class RecordPTR : Record
    {
        public string PTRDName { get; }

        public RecordPTR(ResourceRecord resource, RecordReader recordReader)
            : base(resource)
        {
            PTRDName = recordReader.ReadDomainName();
        }

        public override string ToString()
        {
            return PTRDName;
        }
    }
}