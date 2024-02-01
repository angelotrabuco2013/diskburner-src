using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000057 RID: 87
	[Guid("27354143-7F64-5B0F-8F00-5D77AFBE261E")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IDiscFormat2RawCDEventArgs
	{
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000159 RID: 345
		[DispId(256)]
		int StartLba { get; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600015A RID: 346
		[DispId(257)]
		int SectorCount { get; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600015B RID: 347
		[DispId(258)]
		int LastReadLba { get; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600015C RID: 348
		[DispId(259)]
		int LastWrittenLba { get; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600015D RID: 349
		[DispId(262)]
		int TotalSystemBuffer { get; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600015E RID: 350
		[DispId(263)]
		int UsedSystemBuffer { get; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600015F RID: 351
		[DispId(264)]
		int FreeSystemBuffer { get; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000160 RID: 352
		[DispId(769)]
		IMAPI_FORMAT2_RAW_CD_WRITE_ACTION CurrentAction { get; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000161 RID: 353
		[DispId(770)]
		int ElapsedTime { get; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000162 RID: 354
		[DispId(771)]
		int RemainingTime { get; }
	}
}
