using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000075 RID: 117
	[Guid("27354156-8F64-5B0F-8F00-5D77AFBE261E")]
	[CoClass(typeof(MsftDiscFormat2EraseClass))]
	[ComImport]
	public interface MsftDiscFormat2Erase : IDiscFormat2Erase, DiscFormat2Erase_Event
	{
	}
}
