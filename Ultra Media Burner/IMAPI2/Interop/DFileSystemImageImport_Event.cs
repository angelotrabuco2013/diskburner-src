using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000047 RID: 71
	[ComVisible(false)]
	[ComEventInterface(typeof(DFileSystemImageImportEvents), typeof(DFileSystemImageImport_EventProvider))]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	public interface DFileSystemImageImport_Event
	{
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060000CA RID: 202
		// (remove) Token: 0x060000CB RID: 203
		event DFileSystemImageImport_EventHandler UpdateImport;
	}
}
