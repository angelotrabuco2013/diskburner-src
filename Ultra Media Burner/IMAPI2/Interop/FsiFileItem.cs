using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000091 RID: 145
	[CoClass(typeof(FsiFileItemClass))]
	[Guid("199D0C19-11E1-40EB-8EC2-C8C822A07792")]
	[ComImport]
	public interface FsiFileItem : IFsiFileItem2
	{
	}
}
