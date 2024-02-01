using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000097 RID: 151
	[CoClass(typeof(MsftFileSystemImageClass))]
	[Guid("2C941FE1-975B-59BE-A960-9A2A262853A5")]
	[ComImport]
	public interface MsftFileSystemImage : IFileSystemImage, DFileSystemImage_Event
	{
	}
}
