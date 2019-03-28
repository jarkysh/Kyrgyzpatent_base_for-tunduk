using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XRoadLib.Serialization;

namespace Nmpt.Domain
{
    public class NmtpItem : XRoadSerializable
    {
        public long IdNmtp { get; set; }
        public string InNumberN { get; set; }
        public string K11n { get; set; }
        public string K15n { get; set; }
        public string K18n { get; set; }
        public string K21n { get; set; }
        public string K22n { get; set; }
        public string K46n { get; set; }
        public string K54n { get; set; }
        public string VidTovaraN { get; set; }
        public string K71n { get; set; }
        public string K73n { get; set; }
        public string K57n { get; set; }
        public string K98n { get; set; }
        public int StatusNmpt { get; set; }
    }
}
