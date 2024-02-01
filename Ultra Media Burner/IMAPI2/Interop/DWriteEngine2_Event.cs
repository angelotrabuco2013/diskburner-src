using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200004C RID: 76
	[ComVisible(false)]
	[ComEventInterface(typeof(DWriteEngine2Events), typeof(DWriteEngine2_EventProvider))]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	public interface DWriteEngine2_Event
	{
		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060000DD RID: 221
		// (remove) Token: 0x060000DE RID: 222
		event DWriteEngine2_EventHandler Update;
	}
}
