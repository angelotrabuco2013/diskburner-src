using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200007F RID: 127
	[Guid("27354151-7F64-5B0F-8F00-5D77AFBE261E")]
	[CoClass(typeof(MsftMultisessionSequentialClass))]
	[ComImport]
	public interface MsftMultisessionSequential : IMultisessionSequential
	{
	}
}
