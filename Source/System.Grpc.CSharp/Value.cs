// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: system/value.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace System.Protobuf {

  /// <summary>Holder for reflection information generated from system/value.proto</summary>
  public static partial class ValueReflection {

    #region Descriptor
    /// <summary>File descriptor for system/value.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ValueReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJzeXN0ZW0vdmFsdWUucHJvdG8SBnN5c3RlbRoTc3lzdGVtL29iamVjdC5w",
            "cm90byKWAQoFVmFsdWUSJgoMb2JqZWN0X3ZhbHVlGAEgASgLMg4uc3lzdGVt",
            "Lk9iamVjdEgAEigKCmxpc3RfdmFsdWUYAiABKAsyEi5zeXN0ZW0uQXJyYXlW",
            "YWx1ZUgAEjMKEGRpY3Rpb25hcnlfdmFsdWUYAyABKAsyFy5zeXN0ZW0uRGlj",
            "dGlvbmFyeVZhbHVlSABCBgoEa2luZCIrCgpBcnJheVZhbHVlEh0KBnZhbHVl",
            "cxgBIAMoCzINLnN5c3RlbS5WYWx1ZSKEAQoPRGljdGlvbmFyeVZhbHVlEjMK",
            "Bm9iamVjdBgBIAMoCzIjLnN5c3RlbS5EaWN0aW9uYXJ5VmFsdWUuT2JqZWN0",
            "RW50cnkaPAoLT2JqZWN0RW50cnkSCwoDa2V5GAEgASgJEhwKBXZhbHVlGAIg",
            "ASgLMg0uc3lzdGVtLlZhbHVlOgI4AUISqgIPU3lzdGVtLlByb3RvYnVmYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::System.Protobuf.ObjectReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::System.Protobuf.Value), global::System.Protobuf.Value.Parser, new[]{ "ObjectValue", "ListValue", "DictionaryValue" }, new[]{ "Kind" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::System.Protobuf.ArrayValue), global::System.Protobuf.ArrayValue.Parser, new[]{ "Values" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::System.Protobuf.DictionaryValue), global::System.Protobuf.DictionaryValue.Parser, new[]{ "Object" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Value : pb::IMessage<Value> {
    private static readonly pb::MessageParser<Value> _parser = new pb::MessageParser<Value>(() => new Value());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Value> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::System.Protobuf.ValueReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Value() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Value(Value other) : this() {
      switch (other.KindCase) {
        case KindOneofCase.ObjectValue:
          ObjectValue = other.ObjectValue.Clone();
          break;
        case KindOneofCase.ListValue:
          ListValue = other.ListValue.Clone();
          break;
        case KindOneofCase.DictionaryValue:
          DictionaryValue = other.DictionaryValue.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Value Clone() {
      return new Value(this);
    }

    /// <summary>Field number for the "object_value" field.</summary>
    public const int ObjectValueFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::System.Protobuf.Object ObjectValue {
      get { return kindCase_ == KindOneofCase.ObjectValue ? (global::System.Protobuf.Object) kind_ : null; }
      set {
        kind_ = value;
        kindCase_ = value == null ? KindOneofCase.None : KindOneofCase.ObjectValue;
      }
    }

    /// <summary>Field number for the "list_value" field.</summary>
    public const int ListValueFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::System.Protobuf.ArrayValue ListValue {
      get { return kindCase_ == KindOneofCase.ListValue ? (global::System.Protobuf.ArrayValue) kind_ : null; }
      set {
        kind_ = value;
        kindCase_ = value == null ? KindOneofCase.None : KindOneofCase.ListValue;
      }
    }

    /// <summary>Field number for the "dictionary_value" field.</summary>
    public const int DictionaryValueFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::System.Protobuf.DictionaryValue DictionaryValue {
      get { return kindCase_ == KindOneofCase.DictionaryValue ? (global::System.Protobuf.DictionaryValue) kind_ : null; }
      set {
        kind_ = value;
        kindCase_ = value == null ? KindOneofCase.None : KindOneofCase.DictionaryValue;
      }
    }

    private object kind_;
    /// <summary>Enum of possible cases for the "kind" oneof.</summary>
    public enum KindOneofCase {
      None = 0,
      ObjectValue = 1,
      ListValue = 2,
      DictionaryValue = 3,
    }
    private KindOneofCase kindCase_ = KindOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KindOneofCase KindCase {
      get { return kindCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearKind() {
      kindCase_ = KindOneofCase.None;
      kind_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Value);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Value other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ObjectValue, other.ObjectValue)) return false;
      if (!object.Equals(ListValue, other.ListValue)) return false;
      if (!object.Equals(DictionaryValue, other.DictionaryValue)) return false;
      if (KindCase != other.KindCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (kindCase_ == KindOneofCase.ObjectValue) hash ^= ObjectValue.GetHashCode();
      if (kindCase_ == KindOneofCase.ListValue) hash ^= ListValue.GetHashCode();
      if (kindCase_ == KindOneofCase.DictionaryValue) hash ^= DictionaryValue.GetHashCode();
      hash ^= (int) kindCase_;
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
      if (kindCase_ == KindOneofCase.ObjectValue) {
        output.WriteRawTag(10);
        output.WriteMessage(ObjectValue);
      }
      if (kindCase_ == KindOneofCase.ListValue) {
        output.WriteRawTag(18);
        output.WriteMessage(ListValue);
      }
      if (kindCase_ == KindOneofCase.DictionaryValue) {
        output.WriteRawTag(26);
        output.WriteMessage(DictionaryValue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (kindCase_ == KindOneofCase.ObjectValue) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ObjectValue);
      }
      if (kindCase_ == KindOneofCase.ListValue) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ListValue);
      }
      if (kindCase_ == KindOneofCase.DictionaryValue) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DictionaryValue);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Value other) {
      if (other == null) {
        return;
      }
      switch (other.KindCase) {
        case KindOneofCase.ObjectValue:
          if (ObjectValue == null) {
            ObjectValue = new global::System.Protobuf.Object();
          }
          ObjectValue.MergeFrom(other.ObjectValue);
          break;
        case KindOneofCase.ListValue:
          if (ListValue == null) {
            ListValue = new global::System.Protobuf.ArrayValue();
          }
          ListValue.MergeFrom(other.ListValue);
          break;
        case KindOneofCase.DictionaryValue:
          if (DictionaryValue == null) {
            DictionaryValue = new global::System.Protobuf.DictionaryValue();
          }
          DictionaryValue.MergeFrom(other.DictionaryValue);
          break;
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
            global::System.Protobuf.Object subBuilder = new global::System.Protobuf.Object();
            if (kindCase_ == KindOneofCase.ObjectValue) {
              subBuilder.MergeFrom(ObjectValue);
            }
            input.ReadMessage(subBuilder);
            ObjectValue = subBuilder;
            break;
          }
          case 18: {
            global::System.Protobuf.ArrayValue subBuilder = new global::System.Protobuf.ArrayValue();
            if (kindCase_ == KindOneofCase.ListValue) {
              subBuilder.MergeFrom(ListValue);
            }
            input.ReadMessage(subBuilder);
            ListValue = subBuilder;
            break;
          }
          case 26: {
            global::System.Protobuf.DictionaryValue subBuilder = new global::System.Protobuf.DictionaryValue();
            if (kindCase_ == KindOneofCase.DictionaryValue) {
              subBuilder.MergeFrom(DictionaryValue);
            }
            input.ReadMessage(subBuilder);
            DictionaryValue = subBuilder;
            break;
          }
        }
      }
    }

  }

  public sealed partial class ArrayValue : pb::IMessage<ArrayValue> {
    private static readonly pb::MessageParser<ArrayValue> _parser = new pb::MessageParser<ArrayValue>(() => new ArrayValue());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ArrayValue> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::System.Protobuf.ValueReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArrayValue() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArrayValue(ArrayValue other) : this() {
      values_ = other.values_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArrayValue Clone() {
      return new ArrayValue(this);
    }

    /// <summary>Field number for the "values" field.</summary>
    public const int ValuesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::System.Protobuf.Value> _repeated_values_codec
        = pb::FieldCodec.ForMessage(10, global::System.Protobuf.Value.Parser);
    private readonly pbc::RepeatedField<global::System.Protobuf.Value> values_ = new pbc::RepeatedField<global::System.Protobuf.Value>();
    /// <summary>
    /// Repeated field of dynamically typed values.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::System.Protobuf.Value> Values {
      get { return values_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ArrayValue);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ArrayValue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!values_.Equals(other.values_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= values_.GetHashCode();
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
      values_.WriteTo(output, _repeated_values_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += values_.CalculateSize(_repeated_values_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ArrayValue other) {
      if (other == null) {
        return;
      }
      values_.Add(other.values_);
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
            values_.AddEntriesFrom(input, _repeated_values_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class DictionaryValue : pb::IMessage<DictionaryValue> {
    private static readonly pb::MessageParser<DictionaryValue> _parser = new pb::MessageParser<DictionaryValue>(() => new DictionaryValue());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DictionaryValue> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::System.Protobuf.ValueReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DictionaryValue() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DictionaryValue(DictionaryValue other) : this() {
      object_ = other.object_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DictionaryValue Clone() {
      return new DictionaryValue(this);
    }

    /// <summary>Field number for the "object" field.</summary>
    public const int ObjectFieldNumber = 1;
    private static readonly pbc::MapField<string, global::System.Protobuf.Value>.Codec _map_object_codec
        = new pbc::MapField<string, global::System.Protobuf.Value>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::System.Protobuf.Value.Parser), 10);
    private readonly pbc::MapField<string, global::System.Protobuf.Value> object_ = new pbc::MapField<string, global::System.Protobuf.Value>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::System.Protobuf.Value> Object {
      get { return object_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DictionaryValue);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DictionaryValue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Object.Equals(other.Object)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Object.GetHashCode();
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
      object_.WriteTo(output, _map_object_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += object_.CalculateSize(_map_object_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DictionaryValue other) {
      if (other == null) {
        return;
      }
      object_.Add(other.object_);
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
            object_.AddEntriesFrom(input, _map_object_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
