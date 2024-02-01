using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200002D RID: 45
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	[ComVisible(false)]
	[ComEventInterface(typeof(DDiscFormat2EraseEvents), typeof(DiscFormat2Erase_EventProvider))]
	public interface DiscFormat2Erase_Event
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600005E RID: 94
		// (remove) Token: 0x0600005F RID: 95
		event DiscFormat2Erase_EventHandler Update;
	}
}
