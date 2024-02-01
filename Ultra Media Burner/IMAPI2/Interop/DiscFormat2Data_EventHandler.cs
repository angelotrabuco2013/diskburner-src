using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200002B RID: 43
	// (Invoke) Token: 0x0600005A RID: 90
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void DiscFormat2Data_EventHandler([MarshalAs(UnmanagedType.IDispatch)] [In] object sender, [MarshalAs(UnmanagedType.IDispatch)] [In] object progress);
}
