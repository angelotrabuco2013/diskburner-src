using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200002C RID: 44
	[TypeLibType(TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FOleAutomation | TypeLibTypeFlags.FDispatchable)]
	[Guid("2735413A-7F64-5B0F-8F00-5D77AFBE261E")]
	[ComImport]
	public interface DDiscFormat2EraseEvents
	{
		// Token: 0x0600005D RID: 93
		[DispId(512)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Update([MarshalAs(UnmanagedType.IDispatch)] [In] object sender, [In] int elapsedSeconds, [In] int estimatedTotalSeconds);
	}
}
