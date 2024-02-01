using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200003F RID: 63
	// (Invoke) Token: 0x060000A9 RID: 169
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void DiscMaster2_NotifyDeviceRemovedEventHandler([MarshalAs(UnmanagedType.IDispatch)] [In] object sender, string uniqueId);
}
