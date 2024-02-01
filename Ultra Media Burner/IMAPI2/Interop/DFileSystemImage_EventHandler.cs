using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000045 RID: 69
	// (Invoke) Token: 0x060000C6 RID: 198
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void DFileSystemImage_EventHandler([MarshalAs(UnmanagedType.IDispatch)] [In] object sender, string currentFile, int copiedSectors, int totalSectors);
}
