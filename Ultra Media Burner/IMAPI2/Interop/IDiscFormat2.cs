using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000052 RID: 82
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[Guid("27354152-8F64-5B0F-8F00-5D77AFBE261E")]
	[ComImport]
	public interface IDiscFormat2
	{
		// Token: 0x060000FA RID: 250
		[DispId(2048)]
		bool IsRecorderSupported(IDiscRecorder2 Recorder);

		// Token: 0x060000FB RID: 251
		[DispId(2049)]
		bool IsCurrentMediaSupported(IDiscRecorder2 Recorder);

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000FC RID: 252
		[DispId(1792)]
		bool MediaPhysicallyBlank { get; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000FD RID: 253
		[DispId(1793)]
		bool MediaHeuristicallyBlank { get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000FE RID: 254
		[DispId(1794)]
		object[] SupportedMediaTypes { get; }
	}
}
