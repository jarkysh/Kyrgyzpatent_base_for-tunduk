using Nmpt.Domain;
using XRoadLib.Serialization;

namespace Nmpt.Contract
{
    public class SearchNmtpResponse : XRoadSerializable
    {
        public int PagesCount { get; set; }
        public NmtpItem[] Items { get; set; }
    }
}
