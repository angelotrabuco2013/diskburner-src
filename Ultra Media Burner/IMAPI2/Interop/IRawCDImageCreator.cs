using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace IMAPI2.Interop
{
	// Token: 0x0200006E RID: 110
	[Guid("25983550-9D65-49CE-B335-40630D901227")]
	[TypeLibType(TypeLibTypeFlags.FDual | TypeLibTypeFlags.FNonExtensible | TypeLibTypeFlags.FDispatchable)]
	[ComImport]
	public interface IRawCDImageCreator
	{
		// Token: 0x060002CD RID: 717
		[DispId(512)]
		IStream CreateResultImage();

		// Token: 0x060002CE RID: 718
		[DispId(513)]
		int AddTrack(IMAPI_CD_SECTOR_TYPE dataType, [MarshalAs(UnmanagedType.Interface)] [In] IStream data);

		// Token: 0x060002CF RID: 719
		[DispId(514)]
		void AddSpecialPregap([MarshalAs(UnmanagedType.Interface)] [In] IStream data);

		// Token: 0x060002D0 RID: 720
		[DispId(515)]
		void AddSubcodeRWGenerator([MarshalAs(UnmanagedType.Interface)] [In] IStream subcode);

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060002D2 RID: 722
		// (set) Token: 0x060002D1 RID: 721
		[DispId(256)]
		IMAPI_FORMAT2_RAW_CD_DATA_SECTOR_TYPE ResultingImageType { get; set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060002D3 RID: 723
		[DispId(257)]
		int StartOfLeadout { get; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060002D5 RID: 725
		// (set) Token: 0x060002D4 RID: 724
		[DispId(258)]
		int StartOfLeadoutLimit { get; set; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060002D7 RID: 727
		// (set) Token: 0x060002D6 RID: 726
		[DispId(259)]
		bool DisableGaplessAudio { get; set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060002D9 RID: 729
		// (set) Token: 0x060002D8 RID: 728
		[DispId(260)]
		string MediaCatalogNumber { get; set; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060002DB RID: 731
		// (set) Token: 0x060002DA RID: 730
		[DispId(261)]
		int StartingTrackNumber { get; set; }

		// Token: 0x1700012F RID: 303
		[DispId(262)]
		IRawCDImageTrackInfo this[int trackIndex]
		{
			[DispId(262)]
			get;
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060002DD RID: 733
		[DispId(263)]
		int NumberOfExistingTracks { get; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060002DE RID: 734
		[DispId(264)]
		int LastUsedUserSectorInImage { get; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060002DF RID: 735
		[DispId(265)]
		object[] ExpectedTableOfContents { get; }
	}
}
