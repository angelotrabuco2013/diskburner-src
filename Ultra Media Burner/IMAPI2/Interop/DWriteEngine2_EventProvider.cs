using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace IMAPI2.Interop
{
	// Token: 0x0200004D RID: 77
	[ClassInterface(ClassInterfaceType.None)]
	internal sealed class DWriteEngine2_EventProvider : DWriteEngine2_Event, IDisposable
	{
		// Token: 0x060000DF RID: 223 RVA: 0x00006BA4 File Offset: 0x00004DA4
		public DWriteEngine2_EventProvider(object pointContainer)
		{
			lock (this)
			{
				Guid guid = typeof(DWriteEngine2Events).GUID;
				(pointContainer as IConnectionPointContainer).FindConnectionPoint(ref guid, out this.m_connectionPoint);
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060000E0 RID: 224 RVA: 0x00006C08 File Offset: 0x00004E08
		// (remove) Token: 0x060000E1 RID: 225 RVA: 0x00006C64 File Offset: 0x00004E64
		public event DWriteEngine2_EventHandler Update
		{
			add
			{
				lock (this)
				{
					DWriteEngine2_SinkHelper dwriteEngine2_SinkHelper = new DWriteEngine2_SinkHelper(value);
					int num;
					this.m_connectionPoint.Advise(dwriteEngine2_SinkHelper, out num);
					dwriteEngine2_SinkHelper.Cookie = num;
					this.m_aEventSinkHelpers.Add(dwriteEngine2_SinkHelper.UpdateDelegate, dwriteEngine2_SinkHelper);
				}
			}
			remove
			{
				lock (this)
				{
					DWriteEngine2_SinkHelper dwriteEngine2_SinkHelper = this.m_aEventSinkHelpers[value] as DWriteEngine2_SinkHelper;
					if (dwriteEngine2_SinkHelper != null)
					{
						this.m_connectionPoint.Unadvise(dwriteEngine2_SinkHelper.Cookie);
						this.m_aEventSinkHelpers.Remove(dwriteEngine2_SinkHelper.UpdateDelegate);
					}
				}
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00006CCC File Offset: 0x00004ECC
		~DWriteEngine2_EventProvider()
		{
			this.Cleanup();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00006CF8 File Offset: 0x00004EF8
		public void Dispose()
		{
			this.Cleanup();
			GC.SuppressFinalize(this);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00006D08 File Offset: 0x00004F08
		private void Cleanup()
		{
			lock (this)
			{
				try
				{
					foreach (object obj in this.m_aEventSinkHelpers.Values)
					{
						DWriteEngine2_SinkHelper dwriteEngine2_SinkHelper = (DWriteEngine2_SinkHelper)obj;
						this.m_connectionPoint.Unadvise(dwriteEngine2_SinkHelper.Cookie);
					}
					this.m_aEventSinkHelpers.Clear();
					Marshal.ReleaseComObject(this.m_connectionPoint);
				}
				catch (SynchronizationLockException)
				{
				}
			}
		}

		// Token: 0x04000163 RID: 355
		private Hashtable m_aEventSinkHelpers = new Hashtable();

		// Token: 0x04000164 RID: 356
		private IConnectionPoint m_connectionPoint;
	}
}
