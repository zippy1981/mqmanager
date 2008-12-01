using System;

namespace MQManager.SPI.MSMQ
{
    /// <summary>
    /// Custom exception class for MSMQPrvider.
    /// </summary>
    public class MSMQProviderException : MessagingException
    {
        private string _queue;
        
        /// <summary>
        /// The queue that caused the exception.
        /// </summary>
        public string Queue
        {
            get { return _queue; }
        }


        /// <summary>
        /// Constructor that sets the message.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="queue">The queue that caused the exception,</param>
        public MSMQProviderException(string message, string queue) : base(message)
        {
            _queue = queue;
        }
    }
}