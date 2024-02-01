using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000077 RID: 119
	[CoClass(typeof(MsftDiscFormat2RawCDClass))]
	[Guid("27354155-8F64-5B0F-8F00-5D77AFBE261E")]
	[ComImport]
	public interface MsftDiscFormat2RawCD : IDiscFormat2RawCD, DiscFormat2RawCD_Event
	{
	}
}
