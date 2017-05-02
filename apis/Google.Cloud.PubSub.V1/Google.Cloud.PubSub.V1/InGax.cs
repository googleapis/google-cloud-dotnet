using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Api.Gax
{
    public sealed class BatchingSettings
    {
        public long? ElementCountThreshold { get; set; }
        public long? RequestByteThreshold { get; set; }
        public TimeSpan? DelayThreshold { get; set; }
    }

    public enum LimitExceededBehavior
    {
        Block = 0,
        ThrowException = 1,
        Ignore = 2, // This is present in Java; is it useful?
    }

    public sealed class FlowControlSettings
    {
        public int? MaxOutstandingElementCount { get; set; }
        public int? MaxOutstandingRequestBytes { get; set; }
        public LimitExceededBehavior LimitExceededBehavior { get; set; }
    }
}
