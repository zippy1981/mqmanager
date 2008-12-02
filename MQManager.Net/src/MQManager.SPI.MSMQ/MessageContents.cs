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
using System.Diagnostics;
using System.IO;
using System.Messaging;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

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
			read(msg);
		}

		private void read(Message msg)
		{
			try 
			{
				msg.Formatter = new BinaryMessageFormatter();
				// To trip the catch -- I dont know of a better way than this
				msg.Body.GetType();
			}
			catch(SerializationException ex) 
			{
				MessageBody = ex.Message;
				return;
			}
			catch (Exception)
			{
				try
				{
					msg.Formatter = new ActiveXMessageFormatter();
				
					// To trip the catch -- I dont know of a better way than this
					msg.Body.GetType();
				}

				catch (InvalidOperationException)
				{
					try 
					{
						// We are going to assume that this is the least perferable form of serialization for a message.
						msg.Formatter = new XmlMessageFormatter();				
						// To trip the catch -- I dont know of a better way than this
						msg.Body.GetType();
					}
					catch (InvalidOperationException ex)
					{
						Trace.WriteLine("Type: " + ex.GetType().Name + " Message: " + ex.Message);
						MessageBody = ex.Message;
						return;
					}
				}
			}

			this.MessageLabel = (msg.Label == null || msg.Label == "")
				? msg.Body.GetType().Name
				: msg.Label;


			XmlSerializer serializer = new XmlSerializer(msg.Body.GetType());


			try 
			{
				StringBuilder sb = new StringBuilder();
				XmlWriter wtr = new XmlTextWriter(new StringWriter(sb));
				serializer.Serialize(wtr, msg.Body);
				MessageBody = sb.ToString();
			}
			catch (Exception ex)
			{
				Trace.WriteLine("Exception occurred serializing message. Type: " + ex.GetType().FullName + " Message: " + ex.Message);
				MessageBody = msg.Body.ToString();
			}
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
