using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000026 RID: 38
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct tagSTATSTG
	{
		// Token: 0x0400013B RID: 315
		[MarshalAs(UnmanagedType.LPWStr)]
		public string pwcsName;

		// Token: 0x0400013C RID: 316
		public uint type;

		// Token: 0x0400013D RID: 317
		public _ULARGE_INTEGER cbSize;

		// Token: 0x0400013E RID: 318
		public _FILETIME mtime;

		// Token: 0x0400013F RID: 319
		public _FILETIME ctime;

		// Token: 0x04000140 RID: 320
		public _FILETIME atime;

		// Token: 0x04000141 RID: 321
		public uint grfMode;

		// Token: 0x04000142 RID: 322
		public uint grfLocksSupported;

		// Token: 0x04000143 RID: 323
		public Guid clsid;

		// Token: 0x04000144 RID: 324
		public uint grfStateBits;

		// Token: 0x04000145 RID: 325
		public uint reserved;
	}
}
