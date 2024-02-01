using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace IMAPI2.Interop
{
	// Token: 0x02000095 RID: 149
	[Guid("0000000C-0000-0000-C000-000000000046")]
	[CoClass(typeof(FsiStreamClass))]
	[ComImport]
	public interface FsiStream : IStream
	{
	}
}
