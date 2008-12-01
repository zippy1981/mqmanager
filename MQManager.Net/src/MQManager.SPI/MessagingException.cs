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

namespace MQManager.SPI
{
	/// <summary>
	/// Summary description for MessagingException.
	/// </summary>
	public class MessagingException : Exception
	{
		/// <summary>
		/// Creates a MessagingException with the given message.
		/// </summary>
		/// <param name="message">Message for the exception.</param>
		public MessagingException(string message) : base(message)
		{
			
		}

		/// <summary>
		/// Creates a MessagingException with the given inner exception.
		/// </summary>
		/// <param name="inner">The inner exception.</param>
		public MessagingException(Exception inner) : base(inner.Message) { }

		/// <summary>
		/// Creates a MessagingException with the given message and inner exception.
		/// </summary>
		/// <param name="message">Message for the exception.</param>
		/// <param name="inner">The inner exception.</param>
		public MessagingException(string message, Exception inner) : base(message, inner) { }
	}
}
