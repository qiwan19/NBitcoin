﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBitcoin.Protocol.Filters
{
	public class NodeFiltersCollection : ThreadSafeCollection<INodeFilter>
	{
		public IDisposable Add(Action<IncomingMessage, Action> filter)
		{
			return base.Add(new ActionFilter(filter));
		}
	}
}
