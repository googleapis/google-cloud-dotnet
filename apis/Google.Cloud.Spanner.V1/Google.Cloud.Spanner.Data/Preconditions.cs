using System;
using System.Linq;

namespace Google.Cloud.Spanner.Data
{
    internal static class Preconditions
    {
        public static void AssertOneOf(this object argument, string nameofArg, params object[] values)
        {
            AssertOneOf(argument, nameofArg, "", values);
        }

        public static void AssertOneOf(this object argument, string nameofArg, string detail, params object[] values)
        {
            if (values == null || !values.Any(x => Equals(argument, x)))
                throw new ArgumentException($"Invalid value for {nameofArg}. {detail}");
        }
    }
}