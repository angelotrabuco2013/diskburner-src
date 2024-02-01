using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200006A RID: 106
	[Guid("27354150-7F64-5B0F-8F00-5D77AFBE261E")]
	[TypeLibType(TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IMultisession
	{
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060002B6 RID: 694
		[DispId(256)]
		bool IsSupportedOnCurrentMediaState { get; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060002B8 RID: 696
		// (set) Token: 0x060002B7 RID: 695
		[DispId(257)]
		bool InUse { get; set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060002B9 RID: 697
		[DispId(258)]
		MsftDiscRecorder2 ImportRecorder { get; }
	}
}
