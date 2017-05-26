using System;
using Google.Protobuf;

namespace Google.Cloud.Spanner.V1
{
    //TODO: make this internal (internalsvisibleto the test dll)
    /// <summary>
    /// testonly
    /// </summary>
    public static class TestExtensions
    {

        /// <summary>
        /// 
        /// </summary>
        public static Func<Session, SessionName> SessionGetter = session => session.SessionName;

        /// <summary>
        /// 
        /// </summary>
        public static Func<Transaction, ByteString> TransactionIdGetter = tx => tx.Id;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        /// <returns></returns>
        public static SessionName GetSessionName(this Session session)
        {
            return SessionGetter(session);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static ByteString GetTransactionId(this Transaction transaction)
        {
            return TransactionIdGetter(transaction);
        }
    }
}
