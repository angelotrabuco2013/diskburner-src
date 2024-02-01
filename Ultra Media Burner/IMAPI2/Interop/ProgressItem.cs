using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200009B RID: 155
	[Guid("2C941FD5-975B-59BE-A960-9A2A262853A5")]
	[CoClass(typeof(ProgressItemClass))]
	[ComImport]
	public interface ProgressItem : IProgressItem
	{
	}
}
