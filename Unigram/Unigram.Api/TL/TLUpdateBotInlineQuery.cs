// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateBotInlineQuery : TLUpdateBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			Geo = (1 << 0),
		}

		public bool HasGeo { get { return Flags.HasFlag(Flag.Geo); } set { Flags = value ? (Flags | Flag.Geo) : (Flags & ~Flag.Geo); } }

		public Flag Flags { get; set; }
		public Int64 QueryId { get; set; }
		public Int32 UserId { get; set; }
		public String Query { get; set; }
		public TLGeoPointBase Geo { get; set; }
		public String Offset { get; set; }

		public TLUpdateBotInlineQuery() { }
		public TLUpdateBotInlineQuery(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.UpdateBotInlineQuery; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Flags = (Flag)from.ReadInt32();
			QueryId = from.ReadInt64();
			UserId = from.ReadInt32();
			Query = from.ReadString();
			if (HasGeo) Geo = TLFactory.Read<TLGeoPointBase>(from, cache);
			Offset = from.ReadString();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			UpdateFlags();

			to.Write(0x54826690);
			to.Write((Int32)Flags);
			to.Write(QueryId);
			to.Write(UserId);
			to.Write(Query);
			if (HasGeo) to.WriteObject(Geo, cache);
			to.Write(Offset);
			if (cache) WriteToCache(to);
		}

		private void UpdateFlags()
		{
			HasGeo = Geo != null;
		}
	}
}