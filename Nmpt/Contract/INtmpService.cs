using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XRoadLib.Attributes;

namespace Nmpt.Contract
{
    public interface INmtpService
    {
        [XRoadService("SearchNtmpItems")]
        SearchNmtpResponse SearchNmtpItems(SearchNmtpRequest request);
    }
}
