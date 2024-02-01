using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200008D RID: 141
	[Guid("2C941FD8-975B-59BE-A960-9A2A262853A5")]
	[CoClass(typeof(FileSystemImageResultClass))]
	[ComImport]
	public interface FileSystemImageResult : IFileSystemImageResult
	{
	}
}
