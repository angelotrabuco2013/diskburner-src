using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000067 RID: 103
	[Guid("2C941FD9-975B-59BE-A960-9A2A262853A5")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	public interface IFsiItem
	{
		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002A2 RID: 674
		[DispId(11)]
		string Name { get; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002A3 RID: 675
		[DispId(12)]
		string FullPath { get; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060002A4 RID: 676
		// (set) Token: 0x060002A5 RID: 677
		[DispId(13)]
		DateTime CreationTime { get; set; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060002A6 RID: 678
		// (set) Token: 0x060002A7 RID: 679
		[DispId(14)]
		DateTime LastAccessedTime { get; set; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060002A8 RID: 680
		// (set) Token: 0x060002A9 RID: 681
		[DispId(15)]
		DateTime LastModifiedTime { get; set; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060002AA RID: 682
		// (set) Token: 0x060002AB RID: 683
		[DispId(16)]
		bool IsHidden { get; set; }

		// Token: 0x060002AC RID: 684
		[DispId(17)]
		string FileSystemName(FsiFileSystems fileSystem);

		// Token: 0x060002AD RID: 685
		[DispId(18)]
		string FileSystemPath(FsiFileSystems fileSystem);
	}
}
