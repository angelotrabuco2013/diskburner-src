using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200009D RID: 157
	[Guid("2C941FD7-975B-59BE-A960-9A2A262853A5")]
	[CoClass(typeof(ProgressItemsClass))]
	[ComImport]
	public interface ProgressItems : IProgressItems
	{
	}
}
