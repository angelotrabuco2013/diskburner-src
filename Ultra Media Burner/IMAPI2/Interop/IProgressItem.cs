using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200006C RID: 108
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[Guid("2C941FD5-975B-59BE-A960-9A2A262853A5")]
	public interface IProgressItem
	{
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060002C3 RID: 707
		[DispId(1)]
		string Description { get; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060002C4 RID: 708
		[DispId(2)]
		uint FirstBlock { get; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060002C5 RID: 709
		[DispId(3)]
		uint LastBlock { get; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060002C6 RID: 710
		[DispId(4)]
		uint BlockCount { get; }
	}
}
