using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using XRoadLib;
using XRoadLib.Headers;
using XRoadLib.Schema;

namespace Nmpt
{
    public class NmtpServiceManager : ServiceManager<XRoadHeader40>
    {
        public NmtpServiceManager()
            : base("4.0", new DefaultSchemaExporter("http://patent.kg", typeof(NmtpServiceManager).GetTypeInfo().Assembly))
        {

        }
    }
}
