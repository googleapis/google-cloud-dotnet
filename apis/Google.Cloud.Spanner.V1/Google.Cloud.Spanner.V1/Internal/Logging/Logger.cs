// Copyright 2017 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;

namespace Google.Cloud.Spanner.V1.Internal.Logging
{
    /// <summary>
    /// Provides diagnostic information on Cloud Spanner.
    /// By default, diagnostic logs will be sent to Trace.WriteLine for .Net desktop
    /// and stderr for .Net Core.
    /// The default LogLevel is LogLevel.Error which will only log error information.
    /// Performance logging can be turned on by setting LogPerformanceTraces = true.
    /// TODO: examine https://github.com/grpc/grpc/tree/master/src/csharp/Grpc.Core/Logging
    /// to determine if it should be used instead.
    /// </summary>
    public abstract class Logger
    {
        private static Logger s_instance;

        /// <summary>
        /// 
        /// </summary>
        public static Logger Instance
        {
            get { return s_instance ?? (s_instance = new DefaultLogger()); }
            private set { s_instance = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="instance"></param>
        public static void SetLogger(Logger instance)
        {
            Instance = instance;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public abstract void Debug(string message);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public abstract void Info(string message);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public abstract void Warn(string message);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public abstract void Error(string message, Exception exception = null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="valueFunc"></param>
        /// 
        public abstract void LogPerformanceCounter(string name, Func<double, double> valueFunc);

        /// <summary>
        /// 
        /// </summary>
        public static LogLevel LogLevel { get; set; } = LogLevel.Error;

        /// <summary>
        /// 
        /// </summary>
        public static bool LogPerformanceTraces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static TimeSpan PerformanceTraceLogInterval { get; set; } = TimeSpan.Zero;

        /// <summary>
        /// Logs performance data if performance logging is enabled.
        /// </summary>
        public static void LogPerformanceData()
        {
            if (LogPerformanceTraces)
            {
                Instance.LogPerformanceDataImpl();
            }
        }

        /// <summary>
        /// Performs the real performance logging.
        /// </summary>
        protected virtual void LogPerformanceDataImpl()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool ResetPerformanceTracesEachInterval { get; set; } = true;

        /// <summary>
        /// Logs a debug message.
        /// </summary>
        public static void Debug(Func<string> messageFunc)
        {
            if (LogLevel >= LogLevel.Debug)
            {
                Instance.Debug(messageFunc());
            }
        }

        /// <summary>
        /// Logs an information message.
        /// </summary>
        public static void Info(Func<string> messageFunc)
        {
            if (LogLevel >= LogLevel.Info)
            {
                Instance.Debug(messageFunc());
            }
        }

        /// <summary>
        /// Logs a warning.
        /// </summary>
        public static void Warn(Func<string> messageFunc)
        {
            if (LogLevel >= LogLevel.Warn)
            {
                Instance.Debug(messageFunc());
            }
        }

        /// <summary>
        /// Logs an error.
        /// </summary>
        public static void Error(Func<string> messageFunc, Exception exception = null)
        {
            if (LogLevel >= LogLevel.Error)
            {
                Instance.Debug(messageFunc());
            }
        }

        /// <summary>
        /// Logs a performance counter.
        /// </summary>
        public static void LogPerformanceCounter(string name, Func<double> valueFunc)
        {
            if (LogPerformanceTraces)
            {
                Instance.LogPerformanceCounter(name, x => valueFunc());
            }
        }

        /// <summary>
        /// Logs a performance counter.
        /// </summary>
        public static void LogPerformanceCounterFn(string name, Func<double, double> valueFunc)
        {
            if (LogPerformanceTraces)
            {
                Instance.LogPerformanceCounter(name, valueFunc);
            }
        }
    }
}
