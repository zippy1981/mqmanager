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

using Aga.Controls.Tree;
using MQManager.SPI;

namespace MQManager.GUI.Forms
{
	/// <summary>
	/// A node for TreeViewAdv that handles <see cref="IMessagingProvider"/>
	/// </summary>
    internal class MessagingProviderNode : Node
    {
    	private IMessagingProvider _provider;
    	
    	/// <summary>
    	/// The provider contained in this node.
    	/// </summary>
    	public IMessagingProvider Provider
    	{
    		get { return _provider; }
    	}


        public uint MessageCount
        {
            get { return _provider.MessageCount; }
        }
    	
    	/// <summary>
    	/// Created a new <see cref="MessagingProviderNode"/>.
    	/// </summary>
    	/// <param name="messagingProvider">The instance of <see cref="IMessagingProvider"/>.</param>
        public MessagingProviderNode(IMessagingProvider messagingProvider) : base(messagingProvider.Name)
        {
        	_provider = messagingProvider;
    	}
    }
}
