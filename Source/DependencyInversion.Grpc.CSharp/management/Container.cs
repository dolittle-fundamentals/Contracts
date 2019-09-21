// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DependencyInversion/management/container.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Dolittle.DependencyInversion.Management.Grpc {

  /// <summary>Holder for reflection information generated from DependencyInversion/management/container.proto</summary>
  public static partial class ContainerReflection {

    #region Descriptor
    /// <summary>File descriptor for DependencyInversion/management/container.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ContainerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5EZXBlbmRlbmN5SW52ZXJzaW9uL21hbmFnZW1lbnQvY29udGFpbmVyLnBy",
            "b3RvEhxkb2xpdHRsZS5kZXBlbmRlbmN5aW52ZXJzaW9uIhQKEkdldEJpbmRp",
            "bmdzUmVxdWVzdCJRCgdCaW5kaW5nEg8KB1NlcnZpY2UYASABKAkSEAoIU3Ry",
            "YXRlZ3kYAiABKAkSFAoMU3RyYXRlZ3lEYXRhGAMgASgJEg0KBVNjb3BlGAQg",
            "ASgJIkMKCEJpbmRpbmdzEjcKCEJpbmRpbmdzGAEgAygLMiUuZG9saXR0bGUu",
            "ZGVwZW5kZW5jeWludmVyc2lvbi5CaW5kaW5nMnYKCUNvbnRhaW5lchJpCgtH",
            "ZXRCaW5kaW5ncxIwLmRvbGl0dGxlLmRlcGVuZGVuY3lpbnZlcnNpb24uR2V0",
            "QmluZGluZ3NSZXF1ZXN0GiYuZG9saXR0bGUuZGVwZW5kZW5jeWludmVyc2lv",
            "bi5CaW5kaW5ncyIAQi+qAixEb2xpdHRsZS5EZXBlbmRlbmN5SW52ZXJzaW9u",
            "Lk1hbmFnZW1lbnQuR3JwY2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Dolittle.DependencyInversion.Management.Grpc.GetBindingsRequest), global::Dolittle.DependencyInversion.Management.Grpc.GetBindingsRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Dolittle.DependencyInversion.Management.Grpc.Binding), global::Dolittle.DependencyInversion.Management.Grpc.Binding.Parser, new[]{ "Service", "Strategy", "StrategyData", "Scope" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Dolittle.DependencyInversion.Management.Grpc.Bindings), global::Dolittle.DependencyInversion.Management.Grpc.Bindings.Parser, new[]{ "Bindings_" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetBindingsRequest : pb::IMessage<GetBindingsRequest> {
    private static readonly pb::MessageParser<GetBindingsRequest> _parser = new pb::MessageParser<GetBindingsRequest>(() => new GetBindingsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetBindingsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dolittle.DependencyInversion.Management.Grpc.ContainerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetBindingsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetBindingsRequest(GetBindingsRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetBindingsRequest Clone() {
      return new GetBindingsRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetBindingsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetBindingsRequest other) {
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
    public void MergeFrom(GetBindingsRequest other) {
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

  public sealed partial class Binding : pb::IMessage<Binding> {
    private static readonly pb::MessageParser<Binding> _parser = new pb::MessageParser<Binding>(() => new Binding());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Binding> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dolittle.DependencyInversion.Management.Grpc.ContainerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Binding() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Binding(Binding other) : this() {
      service_ = other.service_;
      strategy_ = other.strategy_;
      strategyData_ = other.strategyData_;
      scope_ = other.scope_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Binding Clone() {
      return new Binding(this);
    }

    /// <summary>Field number for the "Service" field.</summary>
    public const int ServiceFieldNumber = 1;
    private string service_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Service {
      get { return service_; }
      set {
        service_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Strategy" field.</summary>
    public const int StrategyFieldNumber = 2;
    private string strategy_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Strategy {
      get { return strategy_; }
      set {
        strategy_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "StrategyData" field.</summary>
    public const int StrategyDataFieldNumber = 3;
    private string strategyData_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StrategyData {
      get { return strategyData_; }
      set {
        strategyData_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Scope" field.</summary>
    public const int ScopeFieldNumber = 4;
    private string scope_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Scope {
      get { return scope_; }
      set {
        scope_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Binding);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Binding other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Service != other.Service) return false;
      if (Strategy != other.Strategy) return false;
      if (StrategyData != other.StrategyData) return false;
      if (Scope != other.Scope) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Service.Length != 0) hash ^= Service.GetHashCode();
      if (Strategy.Length != 0) hash ^= Strategy.GetHashCode();
      if (StrategyData.Length != 0) hash ^= StrategyData.GetHashCode();
      if (Scope.Length != 0) hash ^= Scope.GetHashCode();
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
      if (Service.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Service);
      }
      if (Strategy.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Strategy);
      }
      if (StrategyData.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(StrategyData);
      }
      if (Scope.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Scope);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Service.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Service);
      }
      if (Strategy.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Strategy);
      }
      if (StrategyData.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StrategyData);
      }
      if (Scope.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Scope);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Binding other) {
      if (other == null) {
        return;
      }
      if (other.Service.Length != 0) {
        Service = other.Service;
      }
      if (other.Strategy.Length != 0) {
        Strategy = other.Strategy;
      }
      if (other.StrategyData.Length != 0) {
        StrategyData = other.StrategyData;
      }
      if (other.Scope.Length != 0) {
        Scope = other.Scope;
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
            Service = input.ReadString();
            break;
          }
          case 18: {
            Strategy = input.ReadString();
            break;
          }
          case 26: {
            StrategyData = input.ReadString();
            break;
          }
          case 34: {
            Scope = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Bindings : pb::IMessage<Bindings> {
    private static readonly pb::MessageParser<Bindings> _parser = new pb::MessageParser<Bindings>(() => new Bindings());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Bindings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dolittle.DependencyInversion.Management.Grpc.ContainerReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Bindings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Bindings(Bindings other) : this() {
      bindings_ = other.bindings_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Bindings Clone() {
      return new Bindings(this);
    }

    /// <summary>Field number for the "Bindings" field.</summary>
    public const int Bindings_FieldNumber = 1;
    private static readonly pb::FieldCodec<global::Dolittle.DependencyInversion.Management.Grpc.Binding> _repeated_bindings_codec
        = pb::FieldCodec.ForMessage(10, global::Dolittle.DependencyInversion.Management.Grpc.Binding.Parser);
    private readonly pbc::RepeatedField<global::Dolittle.DependencyInversion.Management.Grpc.Binding> bindings_ = new pbc::RepeatedField<global::Dolittle.DependencyInversion.Management.Grpc.Binding>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Dolittle.DependencyInversion.Management.Grpc.Binding> Bindings_ {
      get { return bindings_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Bindings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Bindings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!bindings_.Equals(other.bindings_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= bindings_.GetHashCode();
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
      bindings_.WriteTo(output, _repeated_bindings_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += bindings_.CalculateSize(_repeated_bindings_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Bindings other) {
      if (other == null) {
        return;
      }
      bindings_.Add(other.bindings_);
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
            bindings_.AddEntriesFrom(input, _repeated_bindings_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
