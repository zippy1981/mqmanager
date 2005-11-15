/*
 * Copyright 2005 David H. DeWolf
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
using System.Messaging;
using MQManager.SPI;

namespace MQManager.SPI.MSMQ
{
	/// <summary>
	/// Summary description for MessageContents.
	/// </summary>
	class MessageContents : IMessageHeader, IMessageContents 
	{
		private string id;
		private string messageLabel;
		private DateTime timeStamp;

		private String messageBody;


		public MessageContents(Message msg)
		{
			this.Id = msg.Id;
			this.MessageLabel = msg.Label;
            read(msg);
		}

		private void read(Message msg)
		{
			msg.Formatter = new ActiveXMessageFormatter();	
			MessageBody = msg.Body.ToString();
		}

		public string Id
		{
			get { return id; }
			set { id = value; }
		}

		public string MessageLabel
		{
			get { return messageLabel; }
			set { messageLabel = value; }
		}

		public DateTime TimeStamp
		{
			get { return timeStamp; }
			set { timeStamp = value; }
		}

		public string MessageBody
		{
			get { return messageBody; }
			set { messageBody = value; }
		}
	}
}
