using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace IMAPI2.Interop
{
	// Token: 0x02000056 RID: 86
	[Guid("27354155-8F64-5B0F-8F00-5D77AFBE261E")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IDiscFormat2RawCD
	{
		// Token: 0x0600013C RID: 316
		[DispId(2048)]
		bool IsRecorderSupported(IDiscRecorder2 Recorder);

		// Token: 0x0600013D RID: 317
		[DispId(2049)]
		bool IsCurrentMediaSupported(IDiscRecorder2 Recorder);

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600013E RID: 318
		[DispId(1792)]
		bool MediaPhysicallyBlank { get; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600013F RID: 319
		[DispId(1793)]
		bool MediaHeuristicallyBlank { get; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000140 RID: 320
		[DispId(1794)]
		object[] SupportedMediaTypes { get; }

		// Token: 0x06000141 RID: 321
		[DispId(512)]
		void PrepareMedia();

		// Token: 0x06000142 RID: 322
		[DispId(513)]
		void WriteMedia(IStream data);

		// Token: 0x06000143 RID: 323
		[DispId(514)]
		void WriteMedia2(IStream data, int streamLeadInSectors);

		// Token: 0x06000144 RID: 324
		[DispId(515)]
		void CancelWrite();

		// Token: 0x06000145 RID: 325
		[DispId(516)]
		void ReleaseMedia();

		// Token: 0x06000146 RID: 326
		[DispId(517)]
		void SetWriteSpeed(int RequestedSectorsPerSecond, bool RotationTypeIsPureCAV);

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000148 RID: 328
		// (set) Token: 0x06000147 RID: 327
		[DispId(256)]
		IDiscRecorder2 Recorder { get; set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600014A RID: 330
		// (set) Token: 0x06000149 RID: 329
		[DispId(258)]
		bool BufferUnderrunFreeDisabled { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600014B RID: 331
		[DispId(259)]
		int StartOfNextSession { get; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600014C RID: 332
		[DispId(260)]
		int LastPossibleStartOfLeadout { get; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600014D RID: 333
		[DispId(261)]
		IMAPI_MEDIA_PHYSICAL_TYPE CurrentPhysicalMediaType { get; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600014E RID: 334
		[DispId(264)]
		object[] SupportedSectorTypes { get; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000150 RID: 336
		// (set) Token: 0x0600014F RID: 335
		[DispId(265)]
		IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE RequestedSectorType { get; set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000152 RID: 338
		// (set) Token: 0x06000151 RID: 337
		[DispId(266)]
		string ClientName { get; set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000153 RID: 339
		[DispId(267)]
		int RequestedWriteSpeed { get; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000154 RID: 340
		[DispId(268)]
		bool RequestedRotationTypeIsPureCAV { get; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000155 RID: 341
		[DispId(269)]
		int CurrentWriteSpeed { get; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000156 RID: 342
		[DispId(270)]
		bool CurrentRotationTypeIsPureCAV { get; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000157 RID: 343
		[DispId(271)]
		object[] SupportedWriteSpeeds { get; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000158 RID: 344
		[DispId(272)]
		object[] SupportedWriteSpeedDescriptors { get; }
	}
}
