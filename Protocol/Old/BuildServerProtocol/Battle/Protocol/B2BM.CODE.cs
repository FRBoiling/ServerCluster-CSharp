using System;
namespace Protocol.Battle.B2BM {

	public partial class MSG_B2BM_HEARTBEAT {}
	public partial class MSG_B2BM_REGISTER {}
	public class Api {
		static public void GenerateId() {
			Engine.Foundation.Id<Protocol.Battle.B2BM.MSG_B2BM_HEARTBEAT>.Value = 0x6500001;
			Engine.Foundation.Id<Protocol.Battle.B2BM.MSG_B2BM_REGISTER>.Value = 0x6500002;
		}
	}

}
