using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200005E RID: 94
	[Guid("2C941FD6-975B-59BE-A960-9A2A262853A5")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IEnumProgressItems
	{
		// Token: 0x060001BC RID: 444
		void Next(uint celt, out IProgressItem rgelt, out uint pceltFetched);

		// Token: 0x060001BD RID: 445
		void RemoteNext(uint celt, out IProgressItem rgelt, out uint pceltFetched);

		// Token: 0x060001BE RID: 446
		void Skip(uint celt);

		// Token: 0x060001BF RID: 447
		void Reset();

		// Token: 0x060001C0 RID: 448
		void Clone(out IEnumProgressItems ppEnum);
	}
}
