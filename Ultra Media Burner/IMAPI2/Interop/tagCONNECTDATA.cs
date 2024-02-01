using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000025 RID: 37
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct tagCONNECTDATA
	{
		// Token: 0x04000139 RID: 313
		[MarshalAs(UnmanagedType.IUnknown)]
		public object pUnk;

		// Token: 0x0400013A RID: 314
		public uint dwCookie;
	}
}
