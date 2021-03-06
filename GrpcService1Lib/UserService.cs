// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: userService.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcService1 {

  /// <summary>Holder for reflection information generated from userService.proto</summary>
  public static partial class UserServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for userService.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChF1c2VyU2VydmljZS5wcm90bxIMR3JwY1NlcnZpY2UxIhAKDkdldExpc3RS",
            "ZXF1ZXN0Ih0KCkdldFJlcXVlc3QSDwoHdXNlcl9pZBgBIAEoCSIgCg1SZW1v",
            "dmVSZXF1ZXN0Eg8KB3VzZXJfaWQYASABKAkiVwoPR2V0TGlzdFJlc3BvbnNl",
            "EgwKBGNvZGUYASABKAUSDwoHbWVzc2FnZRgCIAEoCRIlCgREYXRhGAMgAygL",
            "MhcuR3JwY1NlcnZpY2UxLlVzZXJNb2RlbCJTCgtHZXRSZXNwb25zZRIMCgRj",
            "b2RlGAEgASgFEg8KB21lc3NhZ2UYAiABKAkSJQoERGF0YRgDIAEoCzIXLkdy",
            "cGNTZXJ2aWNlMS5Vc2VyTW9kZWwiPQoOUmVtb3ZlUmVzcG9uc2USDAoEY29k",
            "ZRgBIAEoBRIPCgdtZXNzYWdlGAIgASgJEgwKBERhdGEYAyABKAgiLwoJVXNl",
            "ck1vZGVsEg8KB3VzZXJfaWQYASABKAkSEQoJdXNlcl9uYW1lGAIgASgJMtUB",
            "CgRVc2VyEkgKB0dldExpc3QSHC5HcnBjU2VydmljZTEuR2V0TGlzdFJlcXVl",
            "c3QaHS5HcnBjU2VydmljZTEuR2V0TGlzdFJlc3BvbnNlIgASPAoDR2V0Ehgu",
            "R3JwY1NlcnZpY2UxLkdldFJlcXVlc3QaGS5HcnBjU2VydmljZTEuR2V0UmVz",
            "cG9uc2UiABJFCgZSZW1vdmUSGy5HcnBjU2VydmljZTEuUmVtb3ZlUmVxdWVz",
            "dBocLkdycGNTZXJ2aWNlMS5SZW1vdmVSZXNwb25zZSIAYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService1.GetListRequest), global::GrpcService1.GetListRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService1.GetRequest), global::GrpcService1.GetRequest.Parser, new[]{ "UserId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService1.RemoveRequest), global::GrpcService1.RemoveRequest.Parser, new[]{ "UserId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService1.GetListResponse), global::GrpcService1.GetListResponse.Parser, new[]{ "Code", "Message", "Data" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService1.GetResponse), global::GrpcService1.GetResponse.Parser, new[]{ "Code", "Message", "Data" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService1.RemoveResponse), global::GrpcService1.RemoveResponse.Parser, new[]{ "Code", "Message", "Data" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService1.UserModel), global::GrpcService1.UserModel.Parser, new[]{ "UserId", "UserName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// 获取用户列表请求参数
  /// </summary>
  public sealed partial class GetListRequest : pb::IMessage<GetListRequest> {
    private static readonly pb::MessageParser<GetListRequest> _parser = new pb::MessageParser<GetListRequest>(() => new GetListRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetListRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService1.UserServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetListRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetListRequest(GetListRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetListRequest Clone() {
      return new GetListRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetListRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetListRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetListRequest other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

  }

  /// <summary>
  /// 获取单个用户请求参数
  /// </summary>
  public sealed partial class GetRequest : pb::IMessage<GetRequest> {
    private static readonly pb::MessageParser<GetRequest> _parser = new pb::MessageParser<GetRequest>(() => new GetRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService1.UserServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetRequest(GetRequest other) : this() {
      userId_ = other.userId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetRequest Clone() {
      return new GetRequest(this);
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 1;
    private string userId_ = "";
    /// <summary>
    /// 用户id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId.Length != 0) hash ^= UserId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UserId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetRequest other) {
      if (other == null) {
        return;
      }
      if (other.UserId.Length != 0) {
        UserId = other.UserId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            UserId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 删除用户请求参数
  /// </summary>
  public sealed partial class RemoveRequest : pb::IMessage<RemoveRequest> {
    private static readonly pb::MessageParser<RemoveRequest> _parser = new pb::MessageParser<RemoveRequest>(() => new RemoveRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RemoveRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService1.UserServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemoveRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemoveRequest(RemoveRequest other) : this() {
      userId_ = other.userId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemoveRequest Clone() {
      return new RemoveRequest(this);
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 1;
    private string userId_ = "";
    /// <summary>
    /// 用户id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RemoveRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RemoveRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId.Length != 0) hash ^= UserId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UserId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RemoveRequest other) {
      if (other == null) {
        return;
      }
      if (other.UserId.Length != 0) {
        UserId = other.UserId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            UserId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 获取用户列表返回值
  /// </summary>
  public sealed partial class GetListResponse : pb::IMessage<GetListResponse> {
    private static readonly pb::MessageParser<GetListResponse> _parser = new pb::MessageParser<GetListResponse>(() => new GetListResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetListResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService1.UserServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetListResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetListResponse(GetListResponse other) : this() {
      code_ = other.code_;
      message_ = other.message_;
      data_ = other.data_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetListResponse Clone() {
      return new GetListResponse(this);
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 1;
    private int code_;
    /// <summary>
    /// 状态码
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 2;
    private string message_ = "";
    /// <summary>
    /// 错误信息
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Data" field.</summary>
    public const int DataFieldNumber = 3;
    private static readonly pb::FieldCodec<global::GrpcService1.UserModel> _repeated_data_codec
        = pb::FieldCodec.ForMessage(26, global::GrpcService1.UserModel.Parser);
    private readonly pbc::RepeatedField<global::GrpcService1.UserModel> data_ = new pbc::RepeatedField<global::GrpcService1.UserModel>();
    /// <summary>
    /// 用户列表
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::GrpcService1.UserModel> Data {
      get { return data_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetListResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetListResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Code != other.Code) return false;
      if (Message != other.Message) return false;
      if(!data_.Equals(other.data_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Code != 0) hash ^= Code.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      hash ^= data_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Code != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Code);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      data_.WriteTo(output, _repeated_data_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Code != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Code);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      size += data_.CalculateSize(_repeated_data_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetListResponse other) {
      if (other == null) {
        return;
      }
      if (other.Code != 0) {
        Code = other.Code;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      data_.Add(other.data_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Code = input.ReadInt32();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
          case 26: {
            data_.AddEntriesFrom(input, _repeated_data_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 获取单个用户返回值
  /// </summary>
  public sealed partial class GetResponse : pb::IMessage<GetResponse> {
    private static readonly pb::MessageParser<GetResponse> _parser = new pb::MessageParser<GetResponse>(() => new GetResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService1.UserServiceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetResponse(GetResponse other) : this() {
      code_ = other.code_;
      message_ = other.message_;
      Data = other.data_ != null ? other.Data.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetResponse Clone() {
      return new GetResponse(this);
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 1;
    private int code_;
    /// <summary>
    /// 状态码
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 2;
    private string message_ = "";
    /// <summary>
    /// 错误信息
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Data" field.</summary>
    public const int DataFieldNumber = 3;
    private global::GrpcService1.UserModel data_;
    /// <summary>
    /// 用户
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GrpcService1.UserModel Data {
      get { return data_; }
      set {
        data_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Code != other.Code) return false;
      if (Message != other.Message) return false;
      if (!object.Equals(Data, other.Data)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Code != 0) hash ^= Code.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (data_ != null) hash ^= Data.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Code != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Code);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (data_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Code != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Code);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (data_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetResponse other) {
      if (other == null) {
        return;
      }
      if (other.Code != 0) {
        Code = other.Code;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.data_ != null) {
        if (data_ == null) {
          data_ = new global::GrpcService1.UserModel();
        }
        Data.MergeFrom(other.Data);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Code = input.ReadInt32();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
          case 26: {
            if (data_ == null) {
              data_ = new global::GrpcService1.UserModel();
            }
            input.ReadMessage(data_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 删除用户用户返回值
  /// </summary>
  public sealed partial class RemoveResponse : pb::IMessage<RemoveResponse> {
    private static readonly pb::MessageParser<RemoveResponse> _parser = new pb::MessageParser<RemoveResponse>(() => new RemoveResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RemoveResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService1.UserServiceReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemoveResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemoveResponse(RemoveResponse other) : this() {
      code_ = other.code_;
      message_ = other.message_;
      data_ = other.data_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemoveResponse Clone() {
      return new RemoveResponse(this);
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 1;
    private int code_;
    /// <summary>
    /// 状态码
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 2;
    private string message_ = "";
    /// <summary>
    /// 错误信息
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Data" field.</summary>
    public const int DataFieldNumber = 3;
    private bool data_;
    /// <summary>
    /// 删除结果
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Data {
      get { return data_; }
      set {
        data_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RemoveResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RemoveResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Code != other.Code) return false;
      if (Message != other.Message) return false;
      if (Data != other.Data) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Code != 0) hash ^= Code.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (Data != false) hash ^= Data.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Code != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Code);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (Data != false) {
        output.WriteRawTag(24);
        output.WriteBool(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Code != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Code);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (Data != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RemoveResponse other) {
      if (other == null) {
        return;
      }
      if (other.Code != 0) {
        Code = other.Code;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.Data != false) {
        Data = other.Data;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Code = input.ReadInt32();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
          case 24: {
            Data = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 用户实体
  /// </summary>
  public sealed partial class UserModel : pb::IMessage<UserModel> {
    private static readonly pb::MessageParser<UserModel> _parser = new pb::MessageParser<UserModel>(() => new UserModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService1.UserServiceReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserModel(UserModel other) : this() {
      userId_ = other.userId_;
      userName_ = other.userName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserModel Clone() {
      return new UserModel(this);
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 1;
    private string userId_ = "";
    /// <summary>
    /// 用户id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user_name" field.</summary>
    public const int UserNameFieldNumber = 2;
    private string userName_ = "";
    /// <summary>
    /// 用户名
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserName {
      get { return userName_; }
      set {
        userName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      if (UserName != other.UserName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserId.Length != 0) hash ^= UserId.GetHashCode();
      if (UserName.Length != 0) hash ^= UserName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UserId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserId);
      }
      if (UserName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(UserName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
      }
      if (UserName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserModel other) {
      if (other == null) {
        return;
      }
      if (other.UserId.Length != 0) {
        UserId = other.UserId;
      }
      if (other.UserName.Length != 0) {
        UserName = other.UserName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            UserId = input.ReadString();
            break;
          }
          case 18: {
            UserName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
