using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000031 RID: 49
	[TypeLibType(TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FOleAutomation | TypeLibTypeFlags.FDispatchable)]
	[Guid("27354142-7F64-5B0F-8F00-5D77AFBE261E")]
	[ComImport]
	public interface DDiscFormat2RawCDEvents
	{
		// Token: 0x06000070 RID: 112
		[DispId(512)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Update([MarshalAs(UnmanagedType.IDispatch)] [In] object sender, [MarshalAs(UnmanagedType.IDispatch)] [In] object progress);
	}
}
