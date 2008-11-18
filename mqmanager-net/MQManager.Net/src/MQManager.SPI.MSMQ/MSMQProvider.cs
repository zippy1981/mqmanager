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
using System.Messaging;
using MQManager.GUI;
using MQManager.SPI;

namespace MQManager.SPI.MSMQ
{
	public class MSMQProvider : IMessagingProvider
	{

		private MessageQueue queue;
		private MSMQMessagingTransaction currentTransaction;


		public MSMQProvider(string path)
		{
			queue = new MessageQueue(path);
		}

		public IList GetMessageHeaders()
		{
			IList headers = new ArrayList();
			IList list = queue.GetAllMessages();
			foreach(Message msg  in list)
			{
				MessageContents header = new MessageContents(msg);
				headers.Add(header);
			}
			return headers;
		}

		public IMessageContents PreviewMessage(IMessageHeader header)
		{
			try
			{
				Message msg = queue.PeekById(header.Id, new TimeSpan(0, 0, 5));
				if(msg == null)
					throw new MessagingException("MSG no longer exists in the queue.");

				MessageContents contents = new MessageContents(msg);
				return contents;
			}
			catch(MessageQueueException e)
			{
				throw new MessagingException(e.Message);
			}
		}

		public IMessageContents GetMessage(IMessageHeader header)
		{
			try
			{
				Message msg = queue.ReceiveById(header.Id, new TimeSpan(0, 0, 5), currentTransaction.Transaction);
				if(msg == null) 
					throw new MessagingException("Unable to retreive message: "+header.MessageLabel);

				MessageContents contents = new MessageContents(msg);
				return contents;
			}
			catch(MessageQueueException mqe)
			{
				throw new MessagingException(mqe.Message);
			}
		}

		public void Send(IMessageContents msg)
		{
			try
			{
				Message message = new Message();
				message.Formatter = new ActiveXMessageFormatter();
				message.Body = msg.MessageBody;
				message.Label = msg.MessageLabel;
				queue.Send(message, currentTransaction.Transaction);
			}
			catch(MessageQueueException mqe)
			{
				throw new MessagingException(mqe.Message);
			}
		}

		public IMessagingTransaction BeginTransaction()
		{
			currentTransaction = new MSMQMessagingTransaction();
			currentTransaction.Transaction.Begin();
			return currentTransaction;
		}

		/// <summary>
		/// TODO: Support other types of transactions
		/// </summary>
		/// <param name="transaction"></param>
		public void ShareTransaction(IMessagingTransaction transaction)
		{
			if(transaction is MSMQMessagingTransaction)
				this.currentTransaction = new MSMQMessagingTransaction(
					((MSMQMessagingTransaction) transaction).Transaction
					);
		}

		public void CommitTransaction()
		{
			if(!currentTransaction.Shared)
				currentTransaction.Transaction.Commit();

			this.currentTransaction = null;
		}

		public void RollbackTransaction()
		{
			if(!currentTransaction.Shared)
				currentTransaction.Transaction.Abort();

			this.currentTransaction = null;
		}

	}
}

namespace MQManager.GUI
{
	class MSMQMessagingTransaction : IMessagingTransaction
	{
		private MessageQueueTransaction transaction = new MessageQueueTransaction();
		private readonly bool shared;

		public MSMQMessagingTransaction()
		{
		}

		public MSMQMessagingTransaction(MessageQueueTransaction transaction)
		{
			this.transaction = transaction;
			this.shared = true;
		}

		public MessageQueueTransaction Transaction
		{
			get { return transaction; }
			set { transaction = value; }
		}

		public bool Shared
		{
			get { return shared; }
		}
	}
}
