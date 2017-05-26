using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1
{
    internal struct SessionPoolEntry
    {
        public SessionPoolEntry(Session session, CancellationTokenSource evictCancellationTokenSource)
        {
            Session = session;
            EvictTaskCancellationSource = evictCancellationTokenSource;
        }

        public Session Session { get; }
        public CancellationTokenSource EvictTaskCancellationSource { get; }
    }
}
