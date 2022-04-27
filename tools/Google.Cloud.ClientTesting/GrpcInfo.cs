// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#if NET462_OR_GREATER
using Grpc.Core;
using Grpc.Core.Logging;
using System;
using System.Linq;
using System.Threading;

namespace Google.Cloud.ClientTesting
{
    /// <summary>
    /// Exposes information about the underlying gRPC layer.
    /// </summary>
    public static class GrpcInfo
    {
        private static readonly object _lock = new object();
        private static SubchannelCountingLogger _subchannelCounter;

        /// <summary>
        /// Enables the use of <see cref="SubchannelCount"/> to get the number of created subchannels.
        /// Must be called before anything is done by Grpc.Core.
        /// </summary>
        public static void EnableSubchannelCounting()
        {
            lock (_lock)
            {
                if (_subchannelCounter == null)
                {
                    _subchannelCounter = new SubchannelCountingLogger();
                }
            }
        }

        /// <summary>
        /// Gets the number of subchannels (actual connections) created in Grpc.Core.
        /// Must call <see cref="EnableSubchannelCounting"/> before this can be used.
        /// </summary>
        public static int SubchannelCount =>
            _subchannelCounter?.Count ??
            throw new InvalidOperationException($"{nameof(EnableSubchannelCounting)} must be called first.");

        private class SubchannelCountingLogger : ILogger
        {
            private readonly ILogger _inner;
            private int _count;

            public int Count => _count;

            public SubchannelCountingLogger()
            {
                const string verbosityVar = "GRPC_VERBOSITY";
                const string traceVar = "GRPC_TRACE";
                const string subchannelTracer = "subchannel";
                const char tracerSeparator = ',';

                _inner = GrpcEnvironment.Logger;

                // Bump up the verbosity to INFO if necessary.
                var currentVerbosity = Environment.GetEnvironmentVariable(verbosityVar);
                if (currentVerbosity != "DEBUG")
                {
                    Environment.SetEnvironmentVariable(verbosityVar, "INFO");
                }

                // Add the tracer that will let us count subchannels created.
                var tracers = Environment.GetEnvironmentVariable(traceVar);
                if (tracers == null || !tracers.Split(tracerSeparator).Contains(subchannelTracer))
                {
                    if (!string.IsNullOrEmpty(tracers))
                    {
                        tracers += tracerSeparator;
                    }
                    tracers += subchannelTracer;
                    Environment.SetEnvironmentVariable(traceVar, tracers);
                }

                GrpcEnvironment.SetLogger(this);
            }

            public void Debug(string message) => _inner.Debug(message);
            public void Debug(string format, params object[] formatArgs) => _inner.Debug(format, formatArgs);
            public void Error(string message) => _inner.Error(message);
            public void Error(string format, params object[] formatArgs) => _inner.Error(format, formatArgs);
            public void Error(Exception exception, string message) => _inner.Error(exception, message);
            public ILogger ForType<T>() => _inner.ForType<T>();

            public void Info(string message)
            {
                if (message.Contains("New connected subchannel"))
                {
                    Interlocked.Increment(ref _count);
                }
                _inner.Info(message);
            }

            public void Info(string format, params object[] formatArgs) => _inner.Info(format, formatArgs);
            public void Warning(string message) => _inner.Warning(message);
            public void Warning(string format, params object[] formatArgs) => _inner.Warning(format, formatArgs);
            public void Warning(Exception exception, string message) => _inner.Warning(exception, message);
        }
    }
}
#endif