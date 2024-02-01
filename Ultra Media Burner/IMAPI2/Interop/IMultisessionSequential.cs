using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200006B RID: 107
	[Guid("27354151-7F64-5B0F-8F00-5D77AFBE261E")]
	[TypeLibType(TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IMultisessionSequential
	{
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060002BA RID: 698
		[DispId(256)]
		bool IsSupportedOnCurrentMediaState { get; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060002BC RID: 700
		// (set) Token: 0x060002BB RID: 699
		[DispId(257)]
		bool InUse { get; set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060002BD RID: 701
		[DispId(258)]
		MsftDiscRecorder2 ImportRecorder { get; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060002BE RID: 702
		[DispId(512)]
		bool IsFirstDataSession { get; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060002BF RID: 703
		[DispId(513)]
		int StartAddressOfPreviousSession { get; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060002C0 RID: 704
		[DispId(514)]
		int LastWrittenAddressOfPreviousSession { get; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060002C1 RID: 705
		[DispId(515)]
		int NextWritableAddress { get; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060002C2 RID: 706
		[DispId(516)]
		int FreeSectorsOnMedia { get; }
	}
}
