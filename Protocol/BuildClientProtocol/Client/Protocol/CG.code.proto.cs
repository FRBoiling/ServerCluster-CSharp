//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: CG.code.proto
namespace Message.Client.Gate.Protocol.CG
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MSG_C2G_HEARTBEAT")]
  public partial class MSG_C2G_HEARTBEAT : global::ProtoBuf.IExtensible
  {
    public MSG_C2G_HEARTBEAT() {}
    
    private int _UId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"UId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int UId
    {
      get { return _UId; }
      set { _UId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}