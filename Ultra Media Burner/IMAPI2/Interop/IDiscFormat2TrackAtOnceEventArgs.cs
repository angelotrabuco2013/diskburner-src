using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000059 RID: 89
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[Guid("27354140-7F64-5B0F-8F00-5D77AFBE261E")]
	[ComImport]
	public interface IDiscFormat2TrackAtOnceEventArgs
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000181 RID: 385
		[DispId(256)]
		int StartLba { get; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000182 RID: 386
		[DispId(257)]
		int SectorCount { get; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000183 RID: 387
		[DispId(258)]
		int LastReadLba { get; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000184 RID: 388
		[DispId(259)]
		int LastWrittenLba { get; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000185 RID: 389
		[DispId(262)]
		int TotalSystemBuffer { get; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000186 RID: 390
		[DispId(263)]
		int UsedSystemBuffer { get; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000187 RID: 391
		[DispId(264)]
		int FreeSystemBuffer { get; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000188 RID: 392
		[DispId(768)]
		int CurrentTrackNumber { get; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000189 RID: 393
		[DispId(769)]
		IMAPI_FORMAT2_TAO_WRITE_ACTION CurrentAction { get; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600018A RID: 394
		[DispId(770)]
		int ElapsedTime { get; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600018B RID: 395
		[DispId(771)]
		int RemainingTime { get; }
	}
}
