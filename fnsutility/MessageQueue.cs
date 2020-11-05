using System;
using System.Messaging;
using FnsComposite;
using MSMQ = System.Messaging;

namespace FnsUtility
{
	/// <summary>
	/// Summary description for MessageQueue.
	/// </summary>
	public class MessageQueue
	{
		private const string Segment = "MessageQueue";
		private MessageQueue()
		{ }
		/// <summary>
        /// Gets the next message -waits forever.
		/// </summary>
		static public String GetNextMessage (string queueName)
		{
            return GetNextMessage(queueName, System.Messaging.MessageQueue.InfiniteTimeout);
		}

        /// <summary>
        /// Gets the next message or expire if not received in timespan.
        /// </summary>
        static public String GetNextMessage(string queueName, int seconds)
        {
            return GetNextMessage(queueName, new TimeSpan(0, 0, 0, seconds));
        }

        /// <summary>
        /// Gets the next message.
        /// </summary>
        static internal String GetNextMessage(string queueName, TimeSpan span)
        {
            var results = string.Empty;

            try
            {
                ErrorLog.DebugLog(String.Format("GetNextMessage getting from {0}", queueName), Segment);
                var queue = new MSMQ.MessageQueue(queueName) { Formatter = new ActiveXMessageFormatter() };
                // Set the formatter.
                var message = queue.Receive(span);
                if (message != null) results = message.Body as string;
                ErrorLog.DebugLog(String.Format("GetNextMessage received from {0}", queueName), Segment);
            }
            catch (MessageQueueException ex)
            {
                if (ex.MessageQueueErrorCode != MessageQueueErrorCode.IOTimeout)
                  ErrorLog.LogError(string.Format("GetNextMessage({0}) MessageQueueException: ", queueName) + ex.Message, Segment);
            }

                // Handle invalid serialization format.
            catch (InvalidOperationException ex)
            {
                ErrorLog.LogError(string.Format("GetNextMessage({0}) InvalidOperationException: ", queueName) + ex.Message, Segment);
            }

            catch (Exception ex)
            {
                ErrorLog.LogError(string.Format("GetNextMessage({0}) Exception: ", queueName) + ex.Message, Segment);
            }
            return results;
        }

        /// <summary>
        /// Purges the specified queue.
        /// </summary>
        static public void Purge(string queue)
        {
            try
            {
                var messageQueue = new MSMQ.MessageQueue(queue) { Formatter = new ActiveXMessageFormatter() };
                messageQueue.Purge();
                ErrorLog.DebugLog(String.Format("Purge called for: {0}", queue), Segment);
            }
            catch (MessageQueueException ex)
            {
                ErrorLog.LogError("Purge() MessageQueueException: " + ex.Message, Segment);
            }

                // Handle invalid serialization format.
            catch (InvalidOperationException ex)
            {
                ErrorLog.LogError("Purge() InvalidOperationException: " + ex.Message, Segment);
            }

            catch (Exception ex)
            {
                ErrorLog.LogError("Purge() Exception: " + ex.Message, Segment);
            }
        }

        /// <summary>
        /// Sends the composite object as an xml message.
        /// </summary>
        static public bool SendMessage(string queue, Composite compositeObject)
        {
            return SendMessage(queue, compositeObject.ToXml(), compositeObject.Name);
        }

		/// <summary>
		/// Sends the message.
		/// </summary>
		/// <param name="queueName">Name of the queue.</param>
		/// <param name="message">The message.</param>
		/// <returns></returns>
		static public bool SendMessage (string queueName, string message)
		{
			return SendMessage(queueName, message, "MESSAGE");
		}
		/// <summary>
		/// Sends the message.
		/// </summary>
		/// <param name="queueName">Name of the queue.</param>
		/// <param name="message">The message.</param>
		/// <param name="label">The label.</param>
		/// <returns></returns>
		static public bool SendMessage (string queueName, string message, string label)
		{
			var results = false;
			
			try
			{
				ErrorLog.DebugLog(String.Format("SendMessage sending to {0}",queueName),Segment);
				var queue = new MSMQ.MessageQueue(queueName) {Formatter = new ActiveXMessageFormatter()};
				// Set the formatter.

			    queue.Send(message,label);
				results = true;
				ErrorLog.DebugLog(String.Format("SendMessage sent from {0}",queueName),Segment);
			}
			catch (MessageQueueException ex)
			{
        ErrorLog.LogError("SendMessage() MessageQueueException: " + ex.Message, Segment);
			}

				// Handle invalid serialization format.
			catch (InvalidOperationException ex)
			{
        ErrorLog.LogError("SendMessage() InvalidOperationException: " + ex.Message, Segment);
			}

			catch(Exception ex)
			{
        ErrorLog.LogError("SendMessage() Exception: " + ex.Message, Segment);
			}
			return results;
		}
	}
}
