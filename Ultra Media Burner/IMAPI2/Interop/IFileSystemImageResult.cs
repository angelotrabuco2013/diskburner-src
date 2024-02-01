using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace IMAPI2.Interop
{
	// Token: 0x02000062 RID: 98
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[Guid("2C941FD8-975B-59BE-A960-9A2A262853A5")]
	public interface IFileSystemImageResult
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600025E RID: 606
		[DispId(1)]
		IStream ImageStream { get; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600025F RID: 607
		[DispId(2)]
		IProgressItems ProgressItems { get; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000260 RID: 608
		[DispId(3)]
		int TotalBlocks { get; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000261 RID: 609
		[DispId(4)]
		int BlockSize { get; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000262 RID: 610
		[DispId(5)]
		string DiscId { get; }
	}
}
