// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLDocument : TLDocumentBase 
	{
		public Int64 AccessHash { get; set; }
		public Int32 Date { get; set; }
		public String MimeType { get; set; }
		public Int32 Size { get; set; }
		public TLPhotoSizeBase Thumb { get; set; }
		public Int32 DCId { get; set; }
		public Int32 Version { get; set; }
		public TLVector<TLDocumentAttributeBase> Attributes { get; set; }

		public TLDocument() { }
		public TLDocument(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.Document; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Id = from.ReadInt64();
			AccessHash = from.ReadInt64();
			Date = from.ReadInt32();
			MimeType = from.ReadString();
			Size = from.ReadInt32();
			Thumb = TLFactory.Read<TLPhotoSizeBase>(from, cache);
			DCId = from.ReadInt32();
			Version = from.ReadInt32();
			Attributes = TLFactory.Read<TLVector<TLDocumentAttributeBase>>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x87232BC7);
			to.Write(Id);
			to.Write(AccessHash);
			to.Write(Date);
			to.Write(MimeType);
			to.Write(Size);
			to.WriteObject(Thumb, cache);
			to.Write(DCId);
			to.Write(Version);
			to.WriteObject(Attributes, cache);
			if (cache) WriteToCache(to);
		}
	}
}