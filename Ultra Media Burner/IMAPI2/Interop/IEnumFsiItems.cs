using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200005D RID: 93
	[Guid("2C941FDA-975B-59BE-A960-9A2A262853A5")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IEnumFsiItems
	{
		// Token: 0x060001B7 RID: 439
		void Next(uint celt, out IFsiItem rgelt, out uint pceltFetched);

		// Token: 0x060001B8 RID: 440
		void RemoteNext(uint celt, out IFsiItem rgelt, out uint pceltFetched);

		// Token: 0x060001B9 RID: 441
		void Skip(uint celt);

		// Token: 0x060001BA RID: 442
		void Reset();

		// Token: 0x060001BB RID: 443
		void Clone(out IEnumFsiItems ppEnum);
	}
}
