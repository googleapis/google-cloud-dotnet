using System;

namespace Google.Cloud.Spanner.V1.Logging
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
    internal abstract class Logger
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
        public static int PerformanceTraceLogInterval { get; set; } = 30000;

        /// <summary>
        /// 
        /// </summary>
        public static bool ResetPerformanceTracesEachInterval { get; set; } = true;

        internal static void Debug(Func<string> messageFunc)
        {
            if (LogLevel >= LogLevel.Debug)
            {
                Instance.Debug(messageFunc());
            }
        }

        internal static void Info(Func<string> messageFunc)
        {
            if (LogLevel >= LogLevel.Info)
            {
                Instance.Debug(messageFunc());
            }
        }

        internal static void Warn(Func<string> messageFunc)
        {
            if (LogLevel >= LogLevel.Warn)
            {
                Instance.Debug(messageFunc());
            }
        }

        internal static void Error(Func<string> messageFunc, Exception exception = null)
        {
            if (LogLevel >= LogLevel.Error)
            {
                Instance.Debug(messageFunc());
            }
        }

        internal static void LogPerformanceCounter(string name, Func<double> valueFunc)
        {
            if (LogPerformanceTraces)
            {
                Instance.LogPerformanceCounter(name, x => valueFunc());
            }
        }

        internal static void LogPerformanceCounterFn(string name, Func<double, double> valueFunc)
        {
            if (LogPerformanceTraces)
            {
                Instance.LogPerformanceCounter(name, valueFunc);
            }
        }
    }
}
