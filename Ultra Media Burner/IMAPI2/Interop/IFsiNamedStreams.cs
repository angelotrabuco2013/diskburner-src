using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000068 RID: 104
	[Guid("ED79BA56-5294-4250-8D46-F9AECEE23459")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IFsiNamedStreams : IEnumerable
	{
		// Token: 0x17000112 RID: 274
		[DispId(0)]
		FsiFileItem this[int Index] { get; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060002AF RID: 687
		[DispId(81)]
		int Count
		{
			[DispId(81)]
			get;
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060002B0 RID: 688
		[DispId(82)]
		EnumFsiItems EnumNamedStreams { get; }
	}
}
