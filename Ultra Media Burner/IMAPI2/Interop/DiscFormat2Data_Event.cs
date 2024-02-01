using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000028 RID: 40
	[ComVisible(false)]
	[ComEventInterface(typeof(DDiscFormat2DataEvents), typeof(DiscFormat2Data_EventProvider))]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	public interface DiscFormat2Data_Event
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600004B RID: 75
		// (remove) Token: 0x0600004C RID: 76
		event DiscFormat2Data_EventHandler Update;
	}
}
