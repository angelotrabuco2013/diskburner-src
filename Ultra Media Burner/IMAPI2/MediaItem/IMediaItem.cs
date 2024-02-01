using System;
using System.Drawing;
using IMAPI2.Interop;

namespace IMAPI2.MediaItem
{
	// Token: 0x0200000A RID: 10
	internal interface IMediaItem
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000041 RID: 65
		string Path { get; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000042 RID: 66
		long SizeOnDisc { get; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000043 RID: 67
		Image FileIconImage { get; }

		// Token: 0x06000044 RID: 68
		bool AddToFileSystem(IFsiDirectoryItem rootItem);
	}
}
