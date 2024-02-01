using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace IMAPI2.Interop
{
	// Token: 0x02000065 RID: 101
	[Guid("2C941FDB-975B-59BE-A960-9A2A262853A5")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	public interface IFsiFileItem
	{
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600027A RID: 634
		[DispId(11)]
		string Name { get; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600027B RID: 635
		[DispId(12)]
		string FullPath { get; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600027C RID: 636
		// (set) Token: 0x0600027D RID: 637
		[DispId(13)]
		DateTime CreationTime { get; set; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600027E RID: 638
		// (set) Token: 0x0600027F RID: 639
		[DispId(14)]
		DateTime LastAccessedTime { get; set; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000280 RID: 640
		// (set) Token: 0x06000281 RID: 641
		[DispId(15)]
		DateTime LastModifiedTime { get; set; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000282 RID: 642
		// (set) Token: 0x06000283 RID: 643
		[DispId(16)]
		bool IsHidden { get; set; }

		// Token: 0x06000284 RID: 644
		[DispId(17)]
		string FileSystemName(FsiFileSystems fileSystem);

		// Token: 0x06000285 RID: 645
		[DispId(18)]
		string FileSystemPath(FsiFileSystems fileSystem);

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000286 RID: 646
		[DispId(41)]
		long DataSize { get; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000287 RID: 647
		[DispId(42)]
		int DataSize32BitLow { get; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000288 RID: 648
		[DispId(43)]
		int DataSize32BitHigh { get; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000289 RID: 649
		// (set) Token: 0x0600028A RID: 650
		[DispId(44)]
		IStream Data { get; set; }
	}
}
