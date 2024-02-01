using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace IMAPI2.Interop
{
	// Token: 0x02000050 RID: 80
	[Guid("2C941FD4-975B-59BE-A960-9A2A262853A5")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	public interface IBootOptions
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000EF RID: 239
		[DispId(1)]
		IStream BootImage { get; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000F0 RID: 240
		// (set) Token: 0x060000F1 RID: 241
		[DispId(2)]
		string Manufacturer { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000F2 RID: 242
		// (set) Token: 0x060000F3 RID: 243
		[DispId(3)]
		PlatformId PlatformId { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000F4 RID: 244
		// (set) Token: 0x060000F5 RID: 245
		[DispId(4)]
		EmulationType Emulation { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000F6 RID: 246
		[DispId(5)]
		uint ImageSize { get; }

		// Token: 0x060000F7 RID: 247
		[DispId(20)]
		void AssignBootImage(IStream newVal);
	}
}
