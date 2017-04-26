using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1
{
    internal struct SessionPoolEntry
    {
        public Session Session { get; set; }
        public CancellationTokenSource EvictTaskCancellationSource { get; set; }
    }
}
