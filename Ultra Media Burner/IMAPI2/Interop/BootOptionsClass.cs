using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000088 RID: 136
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	[Guid("2C941FCE-975B-59BE-A960-9A2A262853A5")]
	[ComImport]
	public class BootOptionsClass
	{
		// Token: 0x0600030E RID: 782
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern BootOptionsClass();
	}
}
