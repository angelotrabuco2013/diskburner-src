using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace IMAPI2.Interop
{
	// Token: 0x02000053 RID: 83
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[Guid("27354153-9F64-5B0F-8F00-5D77AFBE261E")]
	public interface IDiscFormat2Data
	{
		// Token: 0x060000FF RID: 255
		[DispId(2048)]
		bool IsRecorderSupported(IDiscRecorder2 Recorder);

		// Token: 0x06000100 RID: 256
		[DispId(2049)]
		bool IsCurrentMediaSupported(IDiscRecorder2 Recorder);

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000101 RID: 257
		[DispId(1792)]
		bool MediaPhysicallyBlank { get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000102 RID: 258
		[DispId(1793)]
		bool MediaHeuristicallyBlank { get; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000103 RID: 259
		[DispId(1794)]
		object[] SupportedMediaTypes { get; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000105 RID: 261
		// (set) Token: 0x06000104 RID: 260
		[DispId(256)]
		IDiscRecorder2 Recorder { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000107 RID: 263
		// (set) Token: 0x06000106 RID: 262
		[DispId(257)]
		bool BufferUnderrunFreeDisabled { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000109 RID: 265
		// (set) Token: 0x06000108 RID: 264
		[DispId(260)]
		bool PostgapAlreadyInImage { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600010A RID: 266
		[DispId(262)]
		IMAPI_FORMAT2_DATA_MEDIA_STATE CurrentMediaStatus { get; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600010B RID: 267
		[DispId(263)]
		IMAPI_MEDIA_WRITE_PROTECT_STATE WriteProtectStatus { get; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600010C RID: 268
		[DispId(264)]
		int TotalSectorsOnMedia { get; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600010D RID: 269
		[DispId(265)]
		int FreeSectorsOnMedia { get; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600010E RID: 270
		[DispId(266)]
		int NextWritableAddress { get; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600010F RID: 271
		[DispId(267)]
		int StartAddressOfPreviousSession { get; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000110 RID: 272
		[DispId(268)]
		int LastWrittenAddressOfPreviousSession { get; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000112 RID: 274
		// (set) Token: 0x06000111 RID: 273
		[DispId(269)]
		bool ForceMediaToBeClosed { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000114 RID: 276
		// (set) Token: 0x06000113 RID: 275
		[DispId(270)]
		bool DisableConsumerDvdCompatibilityMode { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000115 RID: 277
		[DispId(271)]
		IMAPI_MEDIA_PHYSICAL_TYPE CurrentPhysicalMediaType { get; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000117 RID: 279
		// (set) Token: 0x06000116 RID: 278
		[DispId(272)]
		string ClientName { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000118 RID: 280
		[DispId(273)]
		int RequestedWriteSpeed { get; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000119 RID: 281
		[DispId(274)]
		bool RequestedRotationTypeIsPureCAV { get; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600011A RID: 282
		[DispId(275)]
		int CurrentWriteSpeed { get; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600011B RID: 283
		[DispId(276)]
		bool CurrentRotationTypeIsPureCAV { get; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600011C RID: 284
		[DispId(277)]
		object[] SupportedWriteSpeeds { get; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600011D RID: 285
		[DispId(278)]
		object[] SupportedWriteSpeedDescriptors { get; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600011F RID: 287
		// (set) Token: 0x0600011E RID: 286
		[DispId(279)]
		bool ForceOverwrite { get; set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000120 RID: 288
		[DispId(280)]
		object[] MultisessionInterfaces { get; }

		// Token: 0x06000121 RID: 289
		[DispId(512)]
		void Write(IStream data);

		// Token: 0x06000122 RID: 290
		[DispId(513)]
		void CancelWrite();

		// Token: 0x06000123 RID: 291
		[DispId(514)]
		void SetWriteSpeed(int RequestedSectorsPerSecond, bool RotationTypeIsPureCAV);
	}
}
