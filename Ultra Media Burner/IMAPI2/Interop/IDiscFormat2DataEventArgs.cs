using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000054 RID: 84
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[Guid("2735413D-7F64-5B0F-8F00-5D77AFBE261E")]
	public interface IDiscFormat2DataEventArgs
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000124 RID: 292
		[DispId(256)]
		int StartLba { get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000125 RID: 293
		[DispId(257)]
		int SectorCount { get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000126 RID: 294
		[DispId(258)]
		int LastReadLba { get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000127 RID: 295
		[DispId(259)]
		int LastWrittenLba { get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000128 RID: 296
		[DispId(262)]
		int TotalSystemBuffer { get; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000129 RID: 297
		[DispId(263)]
		int UsedSystemBuffer { get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600012A RID: 298
		[DispId(264)]
		int FreeSystemBuffer { get; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600012B RID: 299
		[DispId(768)]
		int ElapsedTime { get; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600012C RID: 300
		[DispId(769)]
		int RemainingTime { get; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600012D RID: 301
		[DispId(770)]
		int TotalTime { get; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600012E RID: 302
		[DispId(771)]
		IMAPI_FORMAT2_DATA_WRITE_ACTION CurrentAction { get; }
	}
}
