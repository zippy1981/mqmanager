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

namespace MQManager.SPI
{
	/// <summary>
	/// Summary description for MessagingException.
	/// </summary>
	public class MessagingException : Exception
	{
		private Exception exception;

		public MessagingException(string message) : base(message)
		{
			
		}

		public MessagingException(Exception ex) : base(ex.Message)
		{
			
		}

		public MessagingException(string message, Exception ex) : base(message)
		{
			this.exception = ex;
		}
	}
}
