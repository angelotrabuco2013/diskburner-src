using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000032 RID: 50
	[ComEventInterface(typeof(DDiscFormat2RawCDEvents), typeof(DiscFormat2RawCD_EventProvider))]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	[ComVisible(false)]
	public interface DiscFormat2RawCD_Event
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000071 RID: 113
		// (remove) Token: 0x06000072 RID: 114
		event DiscFormat2RawCD_EventHandler Update;
	}
}
