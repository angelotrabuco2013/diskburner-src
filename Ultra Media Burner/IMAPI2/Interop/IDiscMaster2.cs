using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200005A RID: 90
	[Guid("27354130-7F64-5B0F-8F00-5D77AFBE261E")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IDiscMaster2
	{
		// Token: 0x0600018C RID: 396
		[DispId(-4)]
		[TypeLibFunc(65)]
		IEnumerator GetEnumerator();

		// Token: 0x1700008B RID: 139
		[DispId(0)]
		string this[int index] { get; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600018E RID: 398
		[DispId(1)]
		int Count { get; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600018F RID: 399
		[DispId(2)]
		bool IsSupportedEnvironment { get; }
	}
}
