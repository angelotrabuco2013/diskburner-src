using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000071 RID: 113
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[Guid("27354136-7F64-5B0F-8F00-5D77AFBE261E")]
	[ComImport]
	public interface IWriteEngine2EventArgs
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060002FA RID: 762
		[DispId(256)]
		int StartLba { get; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060002FB RID: 763
		[DispId(257)]
		int SectorCount { get; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060002FC RID: 764
		[DispId(258)]
		int LastReadLba { get; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060002FD RID: 765
		[DispId(259)]
		int LastWrittenLba { get; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060002FE RID: 766
		[DispId(262)]
		int TotalSystemBuffer { get; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060002FF RID: 767
		[DispId(263)]
		int UsedSystemBuffer { get; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000300 RID: 768
		[DispId(264)]
		int FreeSystemBuffer { get; }
	}
}
