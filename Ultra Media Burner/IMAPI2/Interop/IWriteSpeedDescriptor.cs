using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x02000072 RID: 114
	[Guid("27354144-7F64-5B0F-8F00-5D77AFBE261E")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IWriteSpeedDescriptor
	{
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000301 RID: 769
		[DispId(257)]
		IMAPI_MEDIA_PHYSICAL_TYPE MediaType { get; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000302 RID: 770
		[DispId(258)]
		bool RotationTypeIsPureCAV { get; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000303 RID: 771
		[DispId(259)]
		int WriteSpeed { get; }
	}
}
