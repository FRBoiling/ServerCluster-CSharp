//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: WM2CM.CODE.proto
namespace Protocol.WorldManager.WM2CM
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MSG_WM2CM_Heartbeat")]
  public partial class MSG_WM2CM_Heartbeat : global::ProtoBuf.IExtensible
  {
    public MSG_WM2CM_Heartbeat() {}
    
    private int _GroupId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"GroupId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GroupId
    {
      get { return _GroupId; }
      set { _GroupId = value; }
    }
    private int _SubId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"SubId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SubId
    {
      get { return _SubId; }
      set { _SubId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MSG_WM2CM_Register")]
  public partial class MSG_WM2CM_Register : global::ProtoBuf.IExtensible
  {
    public MSG_WM2CM_Register() {}
    
    private int _GroupId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"GroupId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int GroupId
    {
      get { return _GroupId; }
      set { _GroupId = value; }
    }
    private int _SubId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"SubId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int SubId
    {
      get { return _SubId; }
      set { _SubId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}