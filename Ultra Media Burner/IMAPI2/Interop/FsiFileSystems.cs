using System;

namespace IMAPI2.Interop
{
	// Token: 0x02000010 RID: 16
	[Flags]
	public enum FsiFileSystems
	{
		// Token: 0x0400006A RID: 106
		FsiFileSystemNone = 0,
		// Token: 0x0400006B RID: 107
		FsiFileSystemISO9660 = 1,
		// Token: 0x0400006C RID: 108
		FsiFileSystemJoliet = 2,
		// Token: 0x0400006D RID: 109
		FsiFileSystemUDF = 4,
		// Token: 0x0400006E RID: 110
		FsiFileSystemUnknown = 1073741824
	}
}
