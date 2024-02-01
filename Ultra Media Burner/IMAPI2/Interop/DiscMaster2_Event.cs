using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200003C RID: 60
	[ComVisible(false)]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	[ComEventInterface(typeof(DDiscMaster2Events), typeof(DiscMaster2_EventProvider))]
	public interface DiscMaster2_Event
	{
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000098 RID: 152
		// (remove) Token: 0x06000099 RID: 153
		event DiscMaster2_NotifyDeviceAddedEventHandler NotifyDeviceAdded;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600009A RID: 154
		// (remove) Token: 0x0600009B RID: 155
		event DiscMaster2_NotifyDeviceRemovedEventHandler NotifyDeviceRemoved;
	}
}
