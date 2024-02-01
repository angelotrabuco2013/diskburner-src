using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000081 RID: 129
	[Guid("25983550-9D65-49CE-B335-40630D901227")]
	[CoClass(typeof(MsftRawCDImageCreatorClass))]
	[ComImport]
	public interface MsftRawCDImageCreator : IRawCDImageCreator
	{
	}
}
