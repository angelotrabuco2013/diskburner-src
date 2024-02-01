using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200004F RID: 79
	// (Invoke) Token: 0x060000EC RID: 236
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void DWriteEngine2_EventHandler([MarshalAs(UnmanagedType.IDispatch)] [In] object sender, [MarshalAs(UnmanagedType.IDispatch)] [In] object progress);
}
