using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000042 RID: 66
	[ComVisible(false)]
	[ComEventInterface(typeof(DFileSystemImageEvents), typeof(DFileSystemImage_EventProvider))]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	public interface DFileSystemImage_Event
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060000B7 RID: 183
		// (remove) Token: 0x060000B8 RID: 184
		event DFileSystemImage_EventHandler Update;
	}
}
