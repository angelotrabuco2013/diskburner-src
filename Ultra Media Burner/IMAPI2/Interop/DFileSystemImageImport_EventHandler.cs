using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200004A RID: 74
	// (Invoke) Token: 0x060000D9 RID: 217
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void DFileSystemImageImport_EventHandler([MarshalAs(UnmanagedType.IDispatch)] [In] object sender, FsiFileSystems fileSystem, string currentItem, int importedDirectoryItems, int totalDirectoryItems, int importedFileItems, int totalFileItems);
}
