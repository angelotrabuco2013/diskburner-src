using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200006D RID: 109
	[Guid("2C941FD7-975B-59BE-A960-9A2A262853A5")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	public interface IProgressItems
	{
		// Token: 0x060002C7 RID: 711
		[DispId(-4)]
		[TypeLibFunc(65)]
		IEnumerator GetEnumerator();

		// Token: 0x17000126 RID: 294
		[DispId(0)]
		IProgressItem this[int Index] { get; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060002C9 RID: 713
		[DispId(1)]
		int Count { get; }

		// Token: 0x060002CA RID: 714
		[DispId(2)]
		IProgressItem ProgressItemFromBlock(uint block);

		// Token: 0x060002CB RID: 715
		[DispId(3)]
		IProgressItem ProgressItemFromDescription(string Description);

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060002CC RID: 716
		[DispId(4)]
		IEnumProgressItems EnumProgressItems { get; }
	}
}
