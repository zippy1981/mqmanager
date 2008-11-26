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
using System.Messaging;

namespace MQManager.SPI.MSMQ
{
	/// <summary>
	/// Description of HostMSMQs.
	/// </summary>
	public class HostMSMQs : IHostQueueInfo
	{
		List<IMessagingProvider> privateQueues = new List<IMessagingProvider>();
		List<IMessagingProvider> IHostQueueInfo.PrivateQueues {
			get {
				return privateQueues;
			}
		}
		
		List<IMessagingProvider> publicQueues = new List<IMessagingProvider>();
		List<IMessagingProvider> IHostQueueInfo.PublicQueues {
			get {
				return publicQueues;
			}
		}
		
		public HostMSMQs(string hostName)
		{
			try {
				foreach (MessageQueue queue in MessageQueue.GetPrivateQueuesByMachine(hostName))
				{
					privateQueues.Add(new MSMQProvider(queue));
				}
			}
			catch (MessageQueueException ex)
			{
				System.Diagnostics.Trace.TraceError("Error listing private queues. Message: {0}", ex.Message);
			}
			try {
				foreach (MessageQueue queue in MessageQueue.GetPublicQueuesByMachine(hostName))
				{
					publicQueues.Add(new MSMQProvider(queue));
				}
			}
			catch (MessageQueueException ex)
			{
				System.Diagnostics.Trace.TraceError("Error listing public queues. Message: {0}", ex.Message);
			}
		}
	}
}
