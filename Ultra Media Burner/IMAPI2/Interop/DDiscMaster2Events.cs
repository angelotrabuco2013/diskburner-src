using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200003B RID: 59
	[Guid("27354131-7F64-5B0F-8F00-5D77AFBE261E")]
	[TypeLibType(TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FOleAutomation | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface DDiscMaster2Events
	{
		// Token: 0x06000096 RID: 150
		[DispId(256)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void NotifyDeviceAdded([MarshalAs(UnmanagedType.IDispatch)] [In] object sender, string uniqueId);

		// Token: 0x06000097 RID: 151
		[DispId(257)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void NotifyDeviceRemoved([MarshalAs(UnmanagedType.IDispatch)] [In] object sender, string uniqueId);
	}
}
