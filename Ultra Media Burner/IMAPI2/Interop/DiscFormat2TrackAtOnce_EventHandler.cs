using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200003A RID: 58
	// (Invoke) Token: 0x06000093 RID: 147
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void DiscFormat2TrackAtOnce_EventHandler([MarshalAs(UnmanagedType.IDispatch)] [In] object sender, [MarshalAs(UnmanagedType.IDispatch)] [In] object progress);
}
