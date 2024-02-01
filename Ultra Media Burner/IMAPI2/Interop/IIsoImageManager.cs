using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000069 RID: 105
	[TypeLibType(TypeLibTypeFlags.FDispatchable)]
	[Guid("6CA38BE5-FBBB-4800-95A1-A438865EB0D4")]
	[ComImport]
	public interface IIsoImageManager
	{
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060002B1 RID: 689
		[DispId(256)]
		string path
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060002B2 RID: 690
		[DispId(257)]
		FsiStream Stream
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		// Token: 0x060002B3 RID: 691
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetPath(string Val);

		// Token: 0x060002B4 RID: 692
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetStream([MarshalAs(UnmanagedType.Interface)] [In] FsiStream Data);

		// Token: 0x060002B5 RID: 693
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Validate();
	}
}
