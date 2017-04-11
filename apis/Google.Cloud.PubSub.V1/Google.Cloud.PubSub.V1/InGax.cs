using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Api.Gax
{
    public sealed class BatchingSettings
    {
        long? ElementCountThreshold { get; set; }
        long? RequestByteThreshold { get; set; }
        TimeSpan? DelayThreshold { get; set; }
    }

    public enum LimitExceededBehavior
    {
        Block = 0,
        ThrowException = 1,
        Ignore = 2, // This is present in Java; is it useful?
    }

    public sealed class FlowControlSettings
    {
        int? MaxOutstandingElementCount { get; set; }
        int? MaxOutstandingRequestBytes { get; set; }
        LimitExceededBehavior LimitExceededBehavior { get; set; }
    }
}
