using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace IMAPI2.Interop
{
	// Token: 0x02000058 RID: 88
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[Guid("27354154-8F64-5B0F-8F00-5D77AFBE261E")]
	[ComImport]
	public interface IDiscFormat2TrackAtOnce
	{
		// Token: 0x06000163 RID: 355
		[DispId(2048)]
		bool IsRecorderSupported(IDiscRecorder2 Recorder);

		// Token: 0x06000164 RID: 356
		[DispId(2049)]
		bool IsCurrentMediaSupported(IDiscRecorder2 Recorder);

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000165 RID: 357
		[DispId(1792)]
		bool MediaPhysicallyBlank { get; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000166 RID: 358
		[DispId(1793)]
		bool MediaHeuristicallyBlank { get; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000167 RID: 359
		[DispId(1794)]
		object[] SupportedMediaTypes { get; }

		// Token: 0x06000168 RID: 360
		[DispId(512)]
		void PrepareMedia();

		// Token: 0x06000169 RID: 361
		[DispId(513)]
		void AddAudioTrack(IStream data);

		// Token: 0x0600016A RID: 362
		[DispId(514)]
		void CancelAddTrack();

		// Token: 0x0600016B RID: 363
		[DispId(515)]
		void ReleaseMedia();

		// Token: 0x0600016C RID: 364
		[DispId(516)]
		void SetWriteSpeed(int RequestedSectorsPerSecond, bool RotationTypeIsPureCAV);

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600016E RID: 366
		// (set) Token: 0x0600016D RID: 365
		[DispId(256)]
		IDiscRecorder2 Recorder { get; set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000170 RID: 368
		// (set) Token: 0x0600016F RID: 367
		[DispId(258)]
		bool BufferUnderrunFreeDisabled { get; set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000171 RID: 369
		[DispId(259)]
		int NumberOfExistingTracks { get; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000172 RID: 370
		[DispId(260)]
		int TotalSectorsOnMedia { get; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000173 RID: 371
		[DispId(261)]
		int FreeSectorsOnMedia { get; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000174 RID: 372
		[DispId(262)]
		int UsedSectorsOnMedia { get; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000176 RID: 374
		// (set) Token: 0x06000175 RID: 373
		[DispId(263)]
		bool DoNotFinalizeMedia { get; set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000177 RID: 375
		[DispId(266)]
		object[] ExpectedTableOfContents { get; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000178 RID: 376
		[DispId(267)]
		IMAPI_MEDIA_PHYSICAL_TYPE CurrentPhysicalMediaType { get; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600017A RID: 378
		// (set) Token: 0x06000179 RID: 377
		[DispId(270)]
		string ClientName { get; set; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600017B RID: 379
		[DispId(271)]
		int RequestedWriteSpeed { get; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600017C RID: 380
		[DispId(272)]
		bool RequestedRotationTypeIsPureCAV { get; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600017D RID: 381
		[DispId(273)]
		int CurrentWriteSpeed { get; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600017E RID: 382
		[DispId(274)]
		bool CurrentRotationTypeIsPureCAV { get; }

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600017F RID: 383
		[DispId(275)]
		object[] SupportedWriteSpeeds { get; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000180 RID: 384
		[DispId(276)]
		object[] SupportedWriteSpeedDescriptors { get; }
	}
}
