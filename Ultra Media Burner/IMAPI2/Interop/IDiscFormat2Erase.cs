using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000055 RID: 85
	[Guid("27354156-8F64-5B0F-8F00-5D77AFBE261E")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IDiscFormat2Erase
	{
		// Token: 0x0600012F RID: 303
		[DispId(2048)]
		bool IsRecorderSupported(IDiscRecorder2 Recorder);

		// Token: 0x06000130 RID: 304
		[DispId(2049)]
		bool IsCurrentMediaSupported(IDiscRecorder2 Recorder);

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000131 RID: 305
		[DispId(1792)]
		bool MediaPhysicallyBlank { get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000132 RID: 306
		[DispId(1793)]
		bool MediaHeuristicallyBlank { get; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000133 RID: 307
		[DispId(1794)]
		object[] SupportedMediaTypes { get; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000135 RID: 309
		// (set) Token: 0x06000134 RID: 308
		[DispId(256)]
		IDiscRecorder2 Recorder { get; set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000137 RID: 311
		// (set) Token: 0x06000136 RID: 310
		[DispId(257)]
		bool FullErase { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000138 RID: 312
		[DispId(258)]
		IMAPI_MEDIA_PHYSICAL_TYPE CurrentPhysicalMediaType { get; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600013A RID: 314
		// (set) Token: 0x06000139 RID: 313
		[DispId(259)]
		string ClientName { get; set; }

		// Token: 0x0600013B RID: 315
		[DispId(513)]
		void EraseMedia();
	}
}
