using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000099 RID: 153
	[Guid("6CA38BE5-FBBB-4800-95A1-A438865EB0D4")]
	[CoClass(typeof(MsftIsoImageManagerClass))]
	[ComImport]
	public interface MsftIsoImageManager : IIsoImageManager
	{
	}
}
