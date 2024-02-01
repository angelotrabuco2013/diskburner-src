using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000051 RID: 81
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("D2FFD834-958B-426D-8470-2A13879C6A91")]
	[ComImport]
	public interface IBurnVerification
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000F9 RID: 249
		// (set) Token: 0x060000F8 RID: 248
		[DispId(1024)]
		IMAPI_BURN_VERIFICATION_LEVEL BurnVerificationLevel { get; set; }
	}
}
