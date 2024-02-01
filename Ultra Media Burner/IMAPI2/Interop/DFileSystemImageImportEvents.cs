using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000046 RID: 70
	[Guid("D25C30F9-4087-4366-9E24-E55BE286424B")]
	[TypeLibType(TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FOleAutomation | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface DFileSystemImageImportEvents
	{
		// Token: 0x060000C9 RID: 201
		[DispId(257)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void UpdateImport([MarshalAs(UnmanagedType.IDispatch)] [In] object sender, FsiFileSystems fileSystem, string currentItem, int importedDirectoryItems, int totalDirectoryItems, int importedFileItems, int totalFileItems);
	}
}
