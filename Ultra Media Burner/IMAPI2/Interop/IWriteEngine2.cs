using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace IMAPI2.Interop
{
	// Token: 0x02000070 RID: 112
	[Guid("27354135-7F64-5B0F-8F00-5D77AFBE261E")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IWriteEngine2
	{
		// Token: 0x060002ED RID: 749
		[DispId(512)]
		void WriteSection(IStream data, int startingBlockAddress, int numberOfBlocks);

		// Token: 0x060002EE RID: 750
		[DispId(513)]
		void CancelWrite();

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060002F0 RID: 752
		// (set) Token: 0x060002EF RID: 751
		[DispId(256)]
		IDiscRecorder2Ex Recorder { get; set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060002F2 RID: 754
		// (set) Token: 0x060002F1 RID: 753
		[DispId(257)]
		bool UseStreamingWrite12 { get; set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060002F4 RID: 756
		// (set) Token: 0x060002F3 RID: 755
		[DispId(258)]
		int StartingSectorsPerSecond { get; set; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060002F6 RID: 758
		// (set) Token: 0x060002F5 RID: 757
		[DispId(259)]
		int EndingSectorsPerSecond { get; set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060002F8 RID: 760
		// (set) Token: 0x060002F7 RID: 759
		[DispId(260)]
		int BytesPerSector { get; set; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060002F9 RID: 761
		[DispId(261)]
		bool WriteInProgress { get; }
	}
}
