/*
 * Copyright 2005-2008 David H. DeWolf and Justin Dearing
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Messaging;

namespace MQManager.SPI.MSMQ
{
	/// <summary>
	/// A class that represents a host's MSMQ collection.
	/// </summary>
	public class MSMQHost : IQueueHostInfo
	{
	    readonly List<IMessagingProvider> _privateQueues = new List<IMessagingProvider>();
        /// <summary>
        /// The hosts private message queues.
        /// </summary>
		List<IMessagingProvider> IQueueHostInfo.PrivateQueues {
			get {
				return _privateQueues;
			}
		}

	    readonly List<IMessagingProvider> _publicQueues = new List<IMessagingProvider>();
        /// <summary>
        /// The hosts public message queues.
        /// </summary>
		List<IMessagingProvider> IQueueHostInfo.PublicQueues {
			get {
				return _publicQueues;
			}
		}
		
        /// <summary>
        /// Creates a <see cref="HostMSMQs"/> object and populates it with the hosts MSMQs.
        /// </summary>
        /// <param name="hostName">The host </param>
		public MSMQHost(string hostName)
		{
			try
			{
			    MessageQueue[] privateQueuesByMachine = MessageQueue.GetPrivateQueuesByMachine(hostName);
			    foreach (MessageQueue queue in privateQueuesByMachine)
				{
					_privateQueues.Add(new MSMQProvider(queue));
				}
			}
			catch (MessageQueueException ex)
			{
				Trace.TraceError("Error listing private queues. Message: {0}", ex.Message);
			}
            catch(InvalidOperationException ex)
            {
                Trace.TraceError("Error listing private queues. Message: {0}", ex.Message);
            }

			try
			{
			    MessageQueue[] publicQueuesByMachine = MessageQueue.GetPublicQueuesByMachine(hostName);
			    foreach (MessageQueue queue in publicQueuesByMachine)
				{
					_publicQueues.Add(new MSMQProvider(queue));
				}
			}
			catch (MessageQueueException ex)
			{
				Trace.TraceError("Error listing public queues. Message: {0}", ex.Message);
			}
			catch (InvalidOperationException ex)
			{
				Trace.TraceError("Error listing public queues. Message: {0}", ex.Message);
			}
		}
	}
}
