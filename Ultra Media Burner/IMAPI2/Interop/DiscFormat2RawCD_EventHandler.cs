using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000035 RID: 53
	// (Invoke) Token: 0x06000080 RID: 128
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void DiscFormat2RawCD_EventHandler([MarshalAs(UnmanagedType.IDispatch)] [In] object sender, [MarshalAs(UnmanagedType.IDispatch)] [In] object progress);
}
