// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: blendShape.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace VrmProtobuf {

  /// <summary>Holder for reflection information generated from blendShape.proto</summary>
  public static partial class BlendShapeReflection {

    #region Descriptor
    /// <summary>File descriptor for blendShape.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BlendShapeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBibGVuZFNoYXBlLnByb3RvEgtWcm1Qcm90b2J1ZhoeZ29vZ2xlL3Byb3Rv",
            "YnVmL3dyYXBwZXJzLnByb3RvIkQKCkJsZW5kU2hhcGUSNgoQYmxlbmRTaGFw",
            "ZUdyb3VwcxgBIAMoCzIcLlZybVByb3RvYnVmLkJsZW5kU2hhcGVHcm91cCLy",
            "BgoPQmxlbmRTaGFwZUdyb3VwEgwKBG5hbWUYASABKAkSPQoGcHJlc2V0GAIg",
            "ASgOMi0uVnJtUHJvdG9idWYuQmxlbmRTaGFwZUdyb3VwLkJsZW5kU2hhcGVQ",
            "cmVzZXQSOgoFYmluZHMYAyADKAsyKy5Wcm1Qcm90b2J1Zi5CbGVuZFNoYXBl",
            "R3JvdXAuQmxlbmRTaGFwZUJpbmQSQgoObWF0ZXJpYWxWYWx1ZXMYBCADKAsy",
            "Ki5Wcm1Qcm90b2J1Zi5CbGVuZFNoYXBlR3JvdXAuTWF0ZXJpYWxWYWx1ZRIs",
            "Cghpc0JpbmFyeRgHIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5Cb29sVmFsdWUS",
            "LwoLaWdub3JlQmxpbmsYCCABKAsyGi5nb29nbGUucHJvdG9idWYuQm9vbFZh",
            "bHVlEjAKDGlnbm9yZUxvb2tBdBgJIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5C",
            "b29sVmFsdWUSLwoLaWdub3JlTW91dGgYCiABKAsyGi5nb29nbGUucHJvdG9i",
            "dWYuQm9vbFZhbHVlGj0KDkJsZW5kU2hhcGVCaW5kEgwKBG5vZGUYASABKAUS",
            "DQoFaW5kZXgYAiABKAUSDgoGd2VpZ2h0GAMgASgCGnUKDU1hdGVyaWFsVmFs",
            "dWUSEAoIbWF0ZXJpYWwYASABKAUSPQoEdHlwZRgCIAEoDjIvLlZybVByb3Rv",
            "YnVmLkJsZW5kU2hhcGVHcm91cC5NYXRlcmlhbFZhbHVlVHlwZXMSEwoLdGFy",
            "Z2V0VmFsdWUYAyADKAIi3QEKEEJsZW5kU2hhcGVQcmVzZXQSCgoGY3VzdG9t",
            "EAASBgoCYWEQARIGCgJpaBACEgYKAm91EAMSBgoCZWUQBBIGCgJvaBAFEgkK",
            "BWJsaW5rEAYSBwoDam95EAcSCQoFYW5ncnkQCBIKCgZzb3Jyb3cQCRIHCgNm",
            "dW4QChIKCgZsb29rVXAQCxIMCghsb29rRG93bhAMEgwKCGxvb2tMZWZ0EA0S",
            "DQoJbG9va1JpZ2h0EA4SDQoJYmxpbmtMZWZ0EA8SDgoKYmxpbmtSaWdodBAQ",
            "EgsKB25ldXRyYWwQESI6ChJNYXRlcmlhbFZhbHVlVHlwZXMSCQoFY29sb3IQ",
            "ABILCgd1dlNjYWxlEAESDAoIdXZPZmZzZXQQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::VrmProtobuf.BlendShape), global::VrmProtobuf.BlendShape.Parser, new[]{ "BlendShapeGroups" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::VrmProtobuf.BlendShapeGroup), global::VrmProtobuf.BlendShapeGroup.Parser, new[]{ "Name", "Preset", "Binds", "MaterialValues", "IsBinary", "IgnoreBlink", "IgnoreLookAt", "IgnoreMouth" }, null, new[]{ typeof(global::VrmProtobuf.BlendShapeGroup.Types.BlendShapePreset), typeof(global::VrmProtobuf.BlendShapeGroup.Types.MaterialValueTypes) }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::VrmProtobuf.BlendShapeGroup.Types.BlendShapeBind), global::VrmProtobuf.BlendShapeGroup.Types.BlendShapeBind.Parser, new[]{ "Node", "Index", "Weight" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::VrmProtobuf.BlendShapeGroup.Types.MaterialValue), global::VrmProtobuf.BlendShapeGroup.Types.MaterialValue.Parser, new[]{ "Material", "Type", "TargetValue" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Create animation (morph target &amp; material color &amp; texture offset)
  /// </summary>
  public sealed partial class BlendShape : pb::IMessage<BlendShape> {
    private static readonly pb::MessageParser<BlendShape> _parser = new pb::MessageParser<BlendShape>(() => new BlendShape());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BlendShape> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::VrmProtobuf.BlendShapeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BlendShape() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BlendShape(BlendShape other) : this() {
      blendShapeGroups_ = other.blendShapeGroups_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BlendShape Clone() {
      return new BlendShape(this);
    }

    /// <summary>Field number for the "blendShapeGroups" field.</summary>
    public const int BlendShapeGroupsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::VrmProtobuf.BlendShapeGroup> _repeated_blendShapeGroups_codec
        = pb::FieldCodec.ForMessage(10, global::VrmProtobuf.BlendShapeGroup.Parser);
    private readonly pbc::RepeatedField<global::VrmProtobuf.BlendShapeGroup> blendShapeGroups_ = new pbc::RepeatedField<global::VrmProtobuf.BlendShapeGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::VrmProtobuf.BlendShapeGroup> BlendShapeGroups {
      get { return blendShapeGroups_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BlendShape);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BlendShape other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!blendShapeGroups_.Equals(other.blendShapeGroups_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= blendShapeGroups_.GetHashCode();
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
      blendShapeGroups_.WriteTo(output, _repeated_blendShapeGroups_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += blendShapeGroups_.CalculateSize(_repeated_blendShapeGroups_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BlendShape other) {
      if (other == null) {
        return;
      }
      blendShapeGroups_.Add(other.blendShapeGroups_);
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
            blendShapeGroups_.AddEntriesFrom(input, _repeated_blendShapeGroups_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Group morph target &amp; material color &amp; texture offset
  /// </summary>
  public sealed partial class BlendShapeGroup : pb::IMessage<BlendShapeGroup> {
    private static readonly pb::MessageParser<BlendShapeGroup> _parser = new pb::MessageParser<BlendShapeGroup>(() => new BlendShapeGroup());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BlendShapeGroup> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::VrmProtobuf.BlendShapeReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BlendShapeGroup() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BlendShapeGroup(BlendShapeGroup other) : this() {
      name_ = other.name_;
      preset_ = other.preset_;
      binds_ = other.binds_.Clone();
      materialValues_ = other.materialValues_.Clone();
      IsBinary = other.IsBinary;
      IgnoreBlink = other.IgnoreBlink;
      IgnoreLookAt = other.IgnoreLookAt;
      IgnoreMouth = other.IgnoreMouth;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BlendShapeGroup Clone() {
      return new BlendShapeGroup(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "preset" field.</summary>
    public const int PresetFieldNumber = 2;
    private global::VrmProtobuf.BlendShapeGroup.Types.BlendShapePreset preset_ = global::VrmProtobuf.BlendShapeGroup.Types.BlendShapePreset.Custom;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::VrmProtobuf.BlendShapeGroup.Types.BlendShapePreset Preset {
      get { return preset_; }
      set {
        preset_ = value;
      }
    }

    /// <summary>Field number for the "binds" field.</summary>
    public const int BindsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::VrmProtobuf.BlendShapeGroup.Types.BlendShapeBind> _repeated_binds_codec
        = pb::FieldCodec.ForMessage(26, global::VrmProtobuf.BlendShapeGroup.Types.BlendShapeBind.Parser);
    private readonly pbc::RepeatedField<global::VrmProtobuf.BlendShapeGroup.Types.BlendShapeBind> binds_ = new pbc::RepeatedField<global::VrmProtobuf.BlendShapeGroup.Types.BlendShapeBind>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::VrmProtobuf.BlendShapeGroup.Types.BlendShapeBind> Binds {
      get { return binds_; }
    }

    /// <summary>Field number for the "materialValues" field.</summary>
    public const int MaterialValuesFieldNumber = 4;
    private static readonly pb::FieldCodec<global::VrmProtobuf.BlendShapeGroup.Types.MaterialValue> _repeated_materialValues_codec
        = pb::FieldCodec.ForMessage(34, global::VrmProtobuf.BlendShapeGroup.Types.MaterialValue.Parser);
    private readonly pbc::RepeatedField<global::VrmProtobuf.BlendShapeGroup.Types.MaterialValue> materialValues_ = new pbc::RepeatedField<global::VrmProtobuf.BlendShapeGroup.Types.MaterialValue>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::VrmProtobuf.BlendShapeGroup.Types.MaterialValue> MaterialValues {
      get { return materialValues_; }
    }

    /// <summary>Field number for the "isBinary" field.</summary>
    public const int IsBinaryFieldNumber = 7;
    private static readonly pb::FieldCodec<bool?> _single_isBinary_codec = pb::FieldCodec.ForStructWrapper<bool>(58);
    private bool? isBinary_;
    /// <summary>
    /// Interpret non-zero values ​​as 1
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? IsBinary {
      get { return isBinary_; }
      set {
        isBinary_ = value;
      }
    }


    /// <summary>Field number for the "ignoreBlink" field.</summary>
    public const int IgnoreBlinkFieldNumber = 8;
    private static readonly pb::FieldCodec<bool?> _single_ignoreBlink_codec = pb::FieldCodec.ForStructWrapper<bool>(66);
    private bool? ignoreBlink_;
    /// <summary>
    /// Disable Blink when this BlendShapeGroup is enabled
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? IgnoreBlink {
      get { return ignoreBlink_; }
      set {
        ignoreBlink_ = value;
      }
    }


    /// <summary>Field number for the "ignoreLookAt" field.</summary>
    public const int IgnoreLookAtFieldNumber = 9;
    private static readonly pb::FieldCodec<bool?> _single_ignoreLookAt_codec = pb::FieldCodec.ForStructWrapper<bool>(74);
    private bool? ignoreLookAt_;
    /// <summary>
    /// Disable LookAt when this BlendShapeGroup is enabled
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? IgnoreLookAt {
      get { return ignoreLookAt_; }
      set {
        ignoreLookAt_ = value;
      }
    }


    /// <summary>Field number for the "ignoreMouth" field.</summary>
    public const int IgnoreMouthFieldNumber = 10;
    private static readonly pb::FieldCodec<bool?> _single_ignoreMouth_codec = pb::FieldCodec.ForStructWrapper<bool>(82);
    private bool? ignoreMouth_;
    /// <summary>
    /// Disable Mouth when this BlendShapeGroup is enabled
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? IgnoreMouth {
      get { return ignoreMouth_; }
      set {
        ignoreMouth_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BlendShapeGroup);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BlendShapeGroup other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Preset != other.Preset) return false;
      if(!binds_.Equals(other.binds_)) return false;
      if(!materialValues_.Equals(other.materialValues_)) return false;
      if (IsBinary != other.IsBinary) return false;
      if (IgnoreBlink != other.IgnoreBlink) return false;
      if (IgnoreLookAt != other.IgnoreLookAt) return false;
      if (IgnoreMouth != other.IgnoreMouth) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Preset != global::VrmProtobuf.BlendShapeGroup.Types.BlendShapePreset.Custom) hash ^= Preset.GetHashCode();
      hash ^= binds_.GetHashCode();
      hash ^= materialValues_.GetHashCode();
      if (isBinary_ != null) hash ^= IsBinary.GetHashCode();
      if (ignoreBlink_ != null) hash ^= IgnoreBlink.GetHashCode();
      if (ignoreLookAt_ != null) hash ^= IgnoreLookAt.GetHashCode();
      if (ignoreMouth_ != null) hash ^= IgnoreMouth.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Preset != global::VrmProtobuf.BlendShapeGroup.Types.BlendShapePreset.Custom) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Preset);
      }
      binds_.WriteTo(output, _repeated_binds_codec);
      materialValues_.WriteTo(output, _repeated_materialValues_codec);
      if (isBinary_ != null) {
        _single_isBinary_codec.WriteTagAndValue(output, IsBinary);
      }
      if (ignoreBlink_ != null) {
        _single_ignoreBlink_codec.WriteTagAndValue(output, IgnoreBlink);
      }
      if (ignoreLookAt_ != null) {
        _single_ignoreLookAt_codec.WriteTagAndValue(output, IgnoreLookAt);
      }
      if (ignoreMouth_ != null) {
        _single_ignoreMouth_codec.WriteTagAndValue(output, IgnoreMouth);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Preset != global::VrmProtobuf.BlendShapeGroup.Types.BlendShapePreset.Custom) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Preset);
      }
      size += binds_.CalculateSize(_repeated_binds_codec);
      size += materialValues_.CalculateSize(_repeated_materialValues_codec);
      if (isBinary_ != null) {
        size += _single_isBinary_codec.CalculateSizeWithTag(IsBinary);
      }
      if (ignoreBlink_ != null) {
        size += _single_ignoreBlink_codec.CalculateSizeWithTag(IgnoreBlink);
      }
      if (ignoreLookAt_ != null) {
        size += _single_ignoreLookAt_codec.CalculateSizeWithTag(IgnoreLookAt);
      }
      if (ignoreMouth_ != null) {
        size += _single_ignoreMouth_codec.CalculateSizeWithTag(IgnoreMouth);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BlendShapeGroup other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Preset != global::VrmProtobuf.BlendShapeGroup.Types.BlendShapePreset.Custom) {
        Preset = other.Preset;
      }
      binds_.Add(other.binds_);
      materialValues_.Add(other.materialValues_);
      if (other.isBinary_ != null) {
        if (isBinary_ == null || other.IsBinary != false) {
          IsBinary = other.IsBinary;
        }
      }
      if (other.ignoreBlink_ != null) {
        if (ignoreBlink_ == null || other.IgnoreBlink != false) {
          IgnoreBlink = other.IgnoreBlink;
        }
      }
      if (other.ignoreLookAt_ != null) {
        if (ignoreLookAt_ == null || other.IgnoreLookAt != false) {
          IgnoreLookAt = other.IgnoreLookAt;
        }
      }
      if (other.ignoreMouth_ != null) {
        if (ignoreMouth_ == null || other.IgnoreMouth != false) {
          IgnoreMouth = other.IgnoreMouth;
        }
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
            Name = input.ReadString();
            break;
          }
          case 16: {
            Preset = (global::VrmProtobuf.BlendShapeGroup.Types.BlendShapePreset) input.ReadEnum();
            break;
          }
          case 26: {
            binds_.AddEntriesFrom(input, _repeated_binds_codec);
            break;
          }
          case 34: {
            materialValues_.AddEntriesFrom(input, _repeated_materialValues_codec);
            break;
          }
          case 58: {
            bool? value = _single_isBinary_codec.Read(input);
            if (isBinary_ == null || value != false) {
              IsBinary = value;
            }
            break;
          }
          case 66: {
            bool? value = _single_ignoreBlink_codec.Read(input);
            if (ignoreBlink_ == null || value != false) {
              IgnoreBlink = value;
            }
            break;
          }
          case 74: {
            bool? value = _single_ignoreLookAt_codec.Read(input);
            if (ignoreLookAt_ == null || value != false) {
              IgnoreLookAt = value;
            }
            break;
          }
          case 82: {
            bool? value = _single_ignoreMouth_codec.Read(input);
            if (ignoreMouth_ == null || value != false) {
              IgnoreMouth = value;
            }
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the BlendShapeGroup message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Functions of BlendShapeGroup
      /// </summary>
      public enum BlendShapePreset {
        [pbr::OriginalName("custom")] Custom = 0,
        [pbr::OriginalName("aa")] Aa = 1,
        [pbr::OriginalName("ih")] Ih = 2,
        [pbr::OriginalName("ou")] Ou = 3,
        [pbr::OriginalName("ee")] Ee = 4,
        [pbr::OriginalName("oh")] Oh = 5,
        [pbr::OriginalName("blink")] Blink = 6,
        [pbr::OriginalName("joy")] Joy = 7,
        [pbr::OriginalName("angry")] Angry = 8,
        [pbr::OriginalName("sorrow")] Sorrow = 9,
        [pbr::OriginalName("fun")] Fun = 10,
        [pbr::OriginalName("lookUp")] LookUp = 11,
        [pbr::OriginalName("lookDown")] LookDown = 12,
        [pbr::OriginalName("lookLeft")] LookLeft = 13,
        [pbr::OriginalName("lookRight")] LookRight = 14,
        [pbr::OriginalName("blinkLeft")] BlinkLeft = 15,
        [pbr::OriginalName("blinkRight")] BlinkRight = 16,
        [pbr::OriginalName("neutral")] Neutral = 17,
      }

      public enum MaterialValueTypes {
        [pbr::OriginalName("color")] Color = 0,
        [pbr::OriginalName("uvScale")] UvScale = 1,
        [pbr::OriginalName("uvOffset")] UvOffset = 2,
      }

      /// <summary>
      /// Specify a morph target. "required": [ "mesh", "index", "weight" ]
      /// </summary>
      public sealed partial class BlendShapeBind : pb::IMessage<BlendShapeBind> {
        private static readonly pb::MessageParser<BlendShapeBind> _parser = new pb::MessageParser<BlendShapeBind>(() => new BlendShapeBind());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<BlendShapeBind> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::VrmProtobuf.BlendShapeGroup.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public BlendShapeBind() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public BlendShapeBind(BlendShapeBind other) : this() {
          node_ = other.node_;
          index_ = other.index_;
          weight_ = other.weight_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public BlendShapeBind Clone() {
          return new BlendShapeBind(this);
        }

        /// <summary>Field number for the "node" field.</summary>
        public const int NodeFieldNumber = 1;
        private int node_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Node {
          get { return node_; }
          set {
            node_ = value;
          }
        }

        /// <summary>Field number for the "index" field.</summary>
        public const int IndexFieldNumber = 2;
        private int index_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Index {
          get { return index_; }
          set {
            index_ = value;
          }
        }

        /// <summary>Field number for the "weight" field.</summary>
        public const int WeightFieldNumber = 3;
        private float weight_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float Weight {
          get { return weight_; }
          set {
            weight_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as BlendShapeBind);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(BlendShapeBind other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Node != other.Node) return false;
          if (Index != other.Index) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Weight, other.Weight)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Node != 0) hash ^= Node.GetHashCode();
          if (Index != 0) hash ^= Index.GetHashCode();
          if (Weight != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Weight);
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
          if (Node != 0) {
            output.WriteRawTag(8);
            output.WriteInt32(Node);
          }
          if (Index != 0) {
            output.WriteRawTag(16);
            output.WriteInt32(Index);
          }
          if (Weight != 0F) {
            output.WriteRawTag(29);
            output.WriteFloat(Weight);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Node != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Node);
          }
          if (Index != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Index);
          }
          if (Weight != 0F) {
            size += 1 + 4;
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(BlendShapeBind other) {
          if (other == null) {
            return;
          }
          if (other.Node != 0) {
            Node = other.Node;
          }
          if (other.Index != 0) {
            Index = other.Index;
          }
          if (other.Weight != 0F) {
            Weight = other.Weight;
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
                Node = input.ReadInt32();
                break;
              }
              case 16: {
                Index = input.ReadInt32();
                break;
              }
              case 29: {
                Weight = input.ReadFloat();
                break;
              }
            }
          }
        }

      }

      /// <summary>
      /// Material animation references. "required": [ "material", "type", "targetValue" ]
      /// </summary>
      public sealed partial class MaterialValue : pb::IMessage<MaterialValue> {
        private static readonly pb::MessageParser<MaterialValue> _parser = new pb::MessageParser<MaterialValue>(() => new MaterialValue());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<MaterialValue> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::VrmProtobuf.BlendShapeGroup.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MaterialValue() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MaterialValue(MaterialValue other) : this() {
          material_ = other.material_;
          type_ = other.type_;
          targetValue_ = other.targetValue_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MaterialValue Clone() {
          return new MaterialValue(this);
        }

        /// <summary>Field number for the "material" field.</summary>
        public const int MaterialFieldNumber = 1;
        private int material_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Material {
          get { return material_; }
          set {
            material_ = value;
          }
        }

        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 2;
        private global::VrmProtobuf.BlendShapeGroup.Types.MaterialValueTypes type_ = global::VrmProtobuf.BlendShapeGroup.Types.MaterialValueTypes.Color;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::VrmProtobuf.BlendShapeGroup.Types.MaterialValueTypes Type {
          get { return type_; }
          set {
            type_ = value;
          }
        }

        /// <summary>Field number for the "targetValue" field.</summary>
        public const int TargetValueFieldNumber = 3;
        private static readonly pb::FieldCodec<float> _repeated_targetValue_codec
            = pb::FieldCodec.ForFloat(26);
        private readonly pbc::RepeatedField<float> targetValue_ = new pbc::RepeatedField<float>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<float> TargetValue {
          get { return targetValue_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as MaterialValue);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(MaterialValue other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Material != other.Material) return false;
          if (Type != other.Type) return false;
          if(!targetValue_.Equals(other.targetValue_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Material != 0) hash ^= Material.GetHashCode();
          if (Type != global::VrmProtobuf.BlendShapeGroup.Types.MaterialValueTypes.Color) hash ^= Type.GetHashCode();
          hash ^= targetValue_.GetHashCode();
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
          if (Material != 0) {
            output.WriteRawTag(8);
            output.WriteInt32(Material);
          }
          if (Type != global::VrmProtobuf.BlendShapeGroup.Types.MaterialValueTypes.Color) {
            output.WriteRawTag(16);
            output.WriteEnum((int) Type);
          }
          targetValue_.WriteTo(output, _repeated_targetValue_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Material != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Material);
          }
          if (Type != global::VrmProtobuf.BlendShapeGroup.Types.MaterialValueTypes.Color) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
          }
          size += targetValue_.CalculateSize(_repeated_targetValue_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(MaterialValue other) {
          if (other == null) {
            return;
          }
          if (other.Material != 0) {
            Material = other.Material;
          }
          if (other.Type != global::VrmProtobuf.BlendShapeGroup.Types.MaterialValueTypes.Color) {
            Type = other.Type;
          }
          targetValue_.Add(other.targetValue_);
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
                Material = input.ReadInt32();
                break;
              }
              case 16: {
                Type = (global::VrmProtobuf.BlendShapeGroup.Types.MaterialValueTypes) input.ReadEnum();
                break;
              }
              case 26:
              case 29: {
                targetValue_.AddEntriesFrom(input, _repeated_targetValue_codec);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
