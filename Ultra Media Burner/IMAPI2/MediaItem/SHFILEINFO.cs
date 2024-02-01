using System;
using System.Runtime.InteropServices;

namespace IMAPI2.MediaItem
{
	// Token: 0x0200000B RID: 11
	public struct SHFILEINFO
	{
		// Token: 0x04000045 RID: 69
		public IntPtr hIcon;

		// Token: 0x04000046 RID: 70
		public IntPtr iIcon;

		// Token: 0x04000047 RID: 71
		public uint dwAttributes;

		// Token: 0x04000048 RID: 72
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string szDisplayName;

		// Token: 0x04000049 RID: 73
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
		public string szTypeName;
	}
}
