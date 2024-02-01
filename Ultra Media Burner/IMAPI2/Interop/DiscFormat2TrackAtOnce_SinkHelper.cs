using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000039 RID: 57
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	[ClassInterface(ClassInterfaceType.None)]
	public sealed class DiscFormat2TrackAtOnce_SinkHelper : DDiscFormat2TrackAtOnceEvents
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00006304 File Offset: 0x00004504
		public DiscFormat2TrackAtOnce_SinkHelper(DiscFormat2TrackAtOnce_EventHandler eventHandler)
		{
			if (eventHandler == null)
			{
				throw new ArgumentNullException("Delegate (callback function) cannot be null");
			}
			this.m_dwCookie = 0;
			this.m_UpdateDelegate = eventHandler;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00006328 File Offset: 0x00004528
		public void Update(object sender, object progress)
		{
			this.m_UpdateDelegate(sender, progress);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00006337 File Offset: 0x00004537
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0000633F File Offset: 0x0000453F
		public int Cookie
		{
			get
			{
				return this.m_dwCookie;
			}
			set
			{
				this.m_dwCookie = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00006348 File Offset: 0x00004548
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00006350 File Offset: 0x00004550
		public DiscFormat2TrackAtOnce_EventHandler UpdateDelegate
		{
			get
			{
				return this.m_UpdateDelegate;
			}
			set
			{
				this.m_UpdateDelegate = value;
			}
		}

		// Token: 0x04000154 RID: 340
		private int m_dwCookie;

		// Token: 0x04000155 RID: 341
		private DiscFormat2TrackAtOnce_EventHandler m_UpdateDelegate;
	}
}
