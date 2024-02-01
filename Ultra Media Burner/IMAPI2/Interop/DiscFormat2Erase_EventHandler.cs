using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000030 RID: 48
	// (Invoke) Token: 0x0600006D RID: 109
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void DiscFormat2Erase_EventHandler([MarshalAs(UnmanagedType.IDispatch)] [In] object sender, [In] int elapsedSeconds, [In] int estimatedTotalSeconds);
}
