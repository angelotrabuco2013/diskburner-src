using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace IMAPI2.Interop
{
	// Token: 0x02000066 RID: 102
	[Guid("199D0C19-11E1-40EB-8EC2-C8C822A07792")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IFsiFileItem2
	{
		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600028B RID: 651
		[DispId(11)]
		string Name { get; }

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600028C RID: 652
		[DispId(12)]
		string FullPath { get; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600028D RID: 653
		// (set) Token: 0x0600028E RID: 654
		[DispId(13)]
		DateTime CreationTime { get; set; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600028F RID: 655
		// (set) Token: 0x06000290 RID: 656
		[DispId(14)]
		DateTime LastAccessedTime { get; set; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000291 RID: 657
		// (set) Token: 0x06000292 RID: 658
		[DispId(15)]
		DateTime LastModifiedTime { get; set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000293 RID: 659
		// (set) Token: 0x06000294 RID: 660
		[DispId(16)]
		bool IsHidden { get; set; }

		// Token: 0x06000295 RID: 661
		[DispId(17)]
		string FileSystemName(FsiFileSystems fileSystem);

		// Token: 0x06000296 RID: 662
		[DispId(18)]
		string FileSystemPath(FsiFileSystems fileSystem);

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000297 RID: 663
		[DispId(41)]
		long DataSize { get; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000298 RID: 664
		[DispId(42)]
		int DataSize32BitLow { get; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000299 RID: 665
		[DispId(43)]
		int DataSize32BitHigh { get; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600029A RID: 666
		// (set) Token: 0x0600029B RID: 667
		[DispId(44)]
		IStream Data { get; set; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600029C RID: 668
		[DispId(45)]
		FsiNamedStreams FsiNamedStreams { get; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600029D RID: 669
		[DispId(46)]
		bool IsNamedStream { get; }

		// Token: 0x0600029E RID: 670
		[DispId(47)]
		void AddStream(string Name, FsiStream streamData);

		// Token: 0x0600029F RID: 671
		[DispId(48)]
		void RemoveStream(string Name);

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002A0 RID: 672
		// (set) Token: 0x060002A1 RID: 673
		[DispId(49)]
		bool IsRealTime { get; set; }
	}
}
