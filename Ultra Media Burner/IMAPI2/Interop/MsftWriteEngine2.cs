using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000083 RID: 131
	[Guid("27354135-7F64-5B0F-8F00-5D77AFBE261E")]
	[CoClass(typeof(MsftWriteEngine2Class))]
	[ComImport]
	public interface MsftWriteEngine2 : IWriteEngine2, DWriteEngine2_Event
	{
	}
}
