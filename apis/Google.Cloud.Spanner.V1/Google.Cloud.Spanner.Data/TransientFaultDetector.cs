using System;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// </summary>
    public static class TransientFaultDetector
    {
        /// <summary>
        /// </summary>
        /// <returns></returns>
        public static bool IsTransientSpannerFault(this Exception exception)
        {
            SpannerException spannerException = (exception as SpannerException)
                  ?? SpannerException.TryTranslateRpcException(exception);

            return spannerException != null && spannerException.IsRetryable;
        }
    }
}