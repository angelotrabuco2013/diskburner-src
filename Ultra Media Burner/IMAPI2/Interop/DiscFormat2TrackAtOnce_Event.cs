using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000037 RID: 55
	[ComVisible(false)]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	[ComEventInterface(typeof(DDiscFormat2TrackAtOnceEvents), typeof(DiscFormat2TrackAtOnce_EventProvider))]
	public interface DiscFormat2TrackAtOnce_Event
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000084 RID: 132
		// (remove) Token: 0x06000085 RID: 133
		event DiscFormat2TrackAtOnce_EventHandler Update;
	}
}
