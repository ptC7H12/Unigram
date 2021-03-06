// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLChannelParticipantsBots : TLChannelParticipantsFilterBase 
	{
		public TLChannelParticipantsBots() { }
		public TLChannelParticipantsBots(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.ChannelParticipantsBots; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xB0D1865B);
			if (cache) WriteToCache(to);
		}
	}
}