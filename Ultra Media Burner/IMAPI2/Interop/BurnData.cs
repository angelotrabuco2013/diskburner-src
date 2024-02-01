using System;

namespace IMAPI2.Interop
{
	// Token: 0x0200000E RID: 14
	public class BurnData
	{
		// Token: 0x04000055 RID: 85
		public string uniqueRecorderId;

		// Token: 0x04000056 RID: 86
		public string statusMessage;

		// Token: 0x04000057 RID: 87
		public BURN_MEDIA_TASK task;

		// Token: 0x04000058 RID: 88
		public long elapsedTime;

		// Token: 0x04000059 RID: 89
		public long remainingTime;

		// Token: 0x0400005A RID: 90
		public long totalTime;

		// Token: 0x0400005B RID: 91
		public IMAPI_FORMAT2_DATA_WRITE_ACTION currentAction;

		// Token: 0x0400005C RID: 92
		public long startLba;

		// Token: 0x0400005D RID: 93
		public long sectorCount;

		// Token: 0x0400005E RID: 94
		public long lastReadLba;

		// Token: 0x0400005F RID: 95
		public long lastWrittenLba;

		// Token: 0x04000060 RID: 96
		public long totalSystemBuffer;

		// Token: 0x04000061 RID: 97
		public long usedSystemBuffer;

		// Token: 0x04000062 RID: 98
		public long freeSystemBuffer;
	}
}
