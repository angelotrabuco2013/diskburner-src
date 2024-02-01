using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000022 RID: 34
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct _FILETIME
	{
		// Token: 0x04000135 RID: 309
		public uint dwLowDateTime;

		// Token: 0x04000136 RID: 310
		public uint dwHighDateTime;
	}
}
