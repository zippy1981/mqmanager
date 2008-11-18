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
using MQManager.SPI;

namespace MQManager.GUI
{
	public class DefaultMessageContents : IMessageContents
	{

		private string id;
		private string messageLabel;
		private DateTime timeStamp;

		private string messageBody;

		public DefaultMessageContents(IMessageContents imc)
		{
		    this.Id = imc.Id;
			this.MessageLabel = imc.MessageLabel;
			this.MessageBody = imc.MessageBody;
			this.TimeStamp = imc.TimeStamp;
		}

		public DefaultMessageContents()
		{
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
