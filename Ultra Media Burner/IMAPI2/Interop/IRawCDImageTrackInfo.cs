using System;
using System.Runtime.InteropServices;

namespace IMAPI2.Interop
{
	// Token: 0x0200006F RID: 111
	[Guid("25983551-9D65-49CE-B335-40630D901227")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IRawCDImageTrackInfo
	{
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060002E0 RID: 736
		[DispId(256)]
		int StartingLba { get; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060002E1 RID: 737
		[DispId(257)]
		int SectorCount { get; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060002E2 RID: 738
		[DispId(258)]
		int TrackNumber { get; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060002E3 RID: 739
		[DispId(259)]
		IMAPI_CD_SECTOR_TYPE SectorType { get; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060002E4 RID: 740
		// (set) Token: 0x060002E5 RID: 741
		[DispId(260)]
		string ISRC { get; set; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060002E6 RID: 742
		// (set) Token: 0x060002E7 RID: 743
		[DispId(261)]
		IMAPI_CD_TRACK_DIGITAL_COPY_SETTING DigitalAudioCopySetting { get; set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060002E8 RID: 744
		// (set) Token: 0x060002E9 RID: 745
		[DispId(262)]
		bool AudioHasPreemphasis { get; set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060002EA RID: 746
		[DispId(263)]
		object[] TrackIndexes { get; }

		// Token: 0x060002EB RID: 747
		[DispId(512)]
		void AddTrackIndex(int lbaOffset);

		// Token: 0x060002EC RID: 748
		[DispId(513)]
		void ClearTrackIndex(int lbaOffset);
	}
}
