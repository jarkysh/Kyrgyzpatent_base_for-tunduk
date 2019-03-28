using XRoadLib.Attributes;
using XRoadLib.Serialization;

namespace Nmpt.Contract
{
    public class SearchNmtpRequest : XRoadSerializable
    {
        [XRoadXmlElement(IsNullable = false, IsOptional = false)]
        public int Page { get; set; }

        [XRoadXmlElement(IsOptional = true)]
        public string InNumberN { get; set; }

        [XRoadXmlElement(IsOptional = true)]
        public string K11n { get; set; }

        [XRoadXmlElement(IsOptional = true)]
        public string K15n { get; set; }

        [XRoadXmlElement(IsOptional = true)]
        public string K18n { get; set; }

        [XRoadXmlElement(IsOptional = true)]
        public string K21n { get; set; }

        [XRoadXmlElement(IsOptional = true)]
        public string K22n { get; set; }

        [XRoadXmlElement(IsOptional = true)]
        public string K46n { get; set; }

        [XRoadXmlElement(IsOptional = true)]
        public string K54n { get; set; }

        [XRoadXmlElement(IsOptional = true)]
        public string VidTovaraN { get; set; }

        [XRoadXmlElement(IsOptional = true)]
        public string K71n { get; set; }

        [XRoadXmlElement(IsOptional = true)]
        public string K73n { get; set; }

        [XRoadXmlElement(IsOptional = true)]
        public string K57n { get; set; }

        [XRoadXmlElement(IsOptional = true)]
        public string K98n { get; set; }

        [XRoadXmlElement(IsOptional = true)]
        public int? StatusNmpt { get; set; }
    }
}
