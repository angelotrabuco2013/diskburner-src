using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000041 RID: 65
	[Guid("2C941FDF-975B-59BE-A960-9A2A262853A5")]
	[TypeLibType(TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FOleAutomation | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface DFileSystemImageEvents
	{
		// Token: 0x060000B6 RID: 182
		[DispId(256)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Update([MarshalAs(UnmanagedType.IDispatch)] [In] object sender, string currentFile, [In] int copiedSectors, [In] int totalSectors);
	}
}
