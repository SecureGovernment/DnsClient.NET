namespace DnsClient.Protocol
{
    /// <summary>
    /// A <see cref="DnsResourceRecord"/> represending a text resource.
    /// <para>
    /// SPF RRs are used to hold text for the Sender Policy Framework. This record
    /// has been depercated in favor of <see cref="TxtRecord"/>
    /// </para>
    /// </summary>
    /// <seealso href="https://tools.ietf.org/html/rfc4408">RFC 4408</seealso>
    /// <seealso href="https://tools.ietf.org/html/rfc7208">RFC 7208(Obsoletes RFC 4408)</seealso>
    public class SpfRecord : TxtRecord
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpfRecord"/> class.
        /// </summary>
        /// <param name="info">The information.</param>
        /// <param name="values">The values.</param>
        /// <param name="utf8Values">The UTF8 values.</param>
        /// <exception cref="System.ArgumentNullException">
        /// If <paramref name="info"/> or <paramref name="utf8Values"/> or <paramref name="values"/> is null.
        /// </exception>
        public SpfRecord(ResourceRecordInfo info, string[] values, string[] utf8Values) : base(info, values, utf8Values) { }
    }
}
