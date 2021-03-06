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
using System.Collections;

namespace MQManager.SPI
{
	/// <summary>
	/// A provider for a collection of messages of some type. E.g. a MSMQ.
    /// </summary>
    [CLSCompliant(false)]
    public interface IMessagingProvider
	{
		/// <summary>
		/// The name of the instance of the messaging provider.
		/// </summary>
        string Name { get; }

        /// <summary>
        /// The number of messages in the queue.
        /// </summary>
        [CLSCompliant(false)]
        uint MessageCount { get; }
		
		/// <summary>
		/// Gets all the messages for the provider.
		/// </summary>
		/// <returns>a list of messages for the provider.</returns>
		IList GetMessageHeaders();

		IMessageContents PreviewMessage(IMessageHeader header);

		IMessageContents GetMessage(IMessageHeader header);

        void Send(IMessageContents contents);


		#region Transaction Management
		/// <summary>
		/// Begin a messaging transaction
		/// </summary>
		IMessagingTransaction BeginTransaction();

		/// <summary>
		/// Begin a shared transaction with the specified provider
		/// </summary>
		/// <param name="transaction"></param>
		void ShareTransaction(IMessagingTransaction transaction);

		/// <summary>
		/// Commit a messaging transaction
		/// </summary>
		void CommitTransaction();

		/// <summary>
		/// Begin a messaging transaction
		/// </summary>
		void RollbackTransaction();
		#endregion

	}
}
