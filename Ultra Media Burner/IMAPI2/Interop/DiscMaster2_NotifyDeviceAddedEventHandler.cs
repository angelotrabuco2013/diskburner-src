using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200003E RID: 62
	// (Invoke) Token: 0x060000A5 RID: 165
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void DiscMaster2_NotifyDeviceAddedEventHandler([MarshalAs(UnmanagedType.IDispatch)] [In] object sender, string uniqueId);
}
