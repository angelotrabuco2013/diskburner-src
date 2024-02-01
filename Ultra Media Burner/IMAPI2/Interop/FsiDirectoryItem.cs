using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200008F RID: 143
	[Guid("F7FB4B9B-6D96-4D7B-9115-201B144811EF")]
	[CoClass(typeof(FsiDirectoryItemClass))]
	[ComImport]
	public interface FsiDirectoryItem : IFsiDirectoryItem2, IFsiDirectoryItem
	{
	}
}
