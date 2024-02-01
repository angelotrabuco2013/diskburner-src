using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000027 RID: 39
	[Guid("2735413C-7F64-5B0F-8F00-5D77AFBE261E")]
	[TypeLibType(TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FOleAutomation | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface DDiscFormat2DataEvents
	{
		// Token: 0x0600004A RID: 74
		[DispId(512)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Update([MarshalAs(UnmanagedType.IDispatch)] [In] object sender, [MarshalAs(UnmanagedType.IDispatch)] [In] object progress);
	}
}
