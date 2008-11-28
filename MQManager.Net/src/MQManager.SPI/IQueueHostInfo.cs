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

namespace MQManager.SPI
{
	/// <summary>
	/// Interface for classes that represent a host's collections of queues.
	/// </summary>
	public interface IQueueHostInfo
	{
		// TODO: Refactor this to contain a collection of queue types. The private/pubic thing is MSMQ specific.
		
		/// <summary>
		/// The host's private queues.
		/// </summary>
		List<IMessagingProvider> PrivateQueues {
			get;
		}
		
		/// <summary>
		/// The host's public queues.
		/// </summary>
		List<IMessagingProvider> PublicQueues {
			get;
		}
	}
}
