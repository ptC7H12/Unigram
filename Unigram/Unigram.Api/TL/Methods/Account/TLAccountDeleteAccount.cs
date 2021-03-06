// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.deleteAccount
	/// </summary>
	public partial class TLAccountDeleteAccount : TLObject
	{
		public String Reason { get; set; }

		public TLAccountDeleteAccount() { }
		public TLAccountDeleteAccount(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.AccountDeleteAccount; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Reason = from.ReadString();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x418D4E0B);
			to.Write(Reason);
			if (cache) WriteToCache(to);
		}
	}
}