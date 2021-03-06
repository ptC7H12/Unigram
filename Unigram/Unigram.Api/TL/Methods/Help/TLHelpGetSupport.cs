// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Help
{
	/// <summary>
	/// RCP method help.getSupport
	/// </summary>
	public partial class TLHelpGetSupport : TLObject
	{
		public TLHelpGetSupport() { }
		public TLHelpGetSupport(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.HelpGetSupport; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x9CDF08CD);
			if (cache) WriteToCache(to);
		}
	}
}