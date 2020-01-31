// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: firstPerson.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace VrmProtobuf {

  /// <summary>Holder for reflection information generated from firstPerson.proto</summary>
  public static partial class FirstPersonReflection {

    #region Descriptor
    /// <summary>File descriptor for firstPerson.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FirstPersonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFmaXJzdFBlcnNvbi5wcm90bxILVnJtUHJvdG9idWYaHmdvb2dsZS9wcm90",
            "b2J1Zi93cmFwcGVycy5wcm90byKTAgoLRmlyc3RQZXJzb24SQAoPbWVzaEFu",
            "bm90YXRpb25zGAEgAygLMicuVnJtUHJvdG9idWYuRmlyc3RQZXJzb24uTWVz",
            "aEFubm90YXRpb24awQEKDk1lc2hBbm5vdGF0aW9uEgwKBG1lc2gYASABKAUS",
            "UAoPZmlyc3RQZXJzb25UeXBlGAIgASgOMjcuVnJtUHJvdG9idWYuRmlyc3RQ",
            "ZXJzb24uTWVzaEFubm90YXRpb24uRmlyc3RQZXJzb25UeXBlIk8KD0ZpcnN0",
            "UGVyc29uVHlwZRIICgRhdXRvEAASCAoEYm90aBABEhMKD3RoaXJkUGVyc29u",
            "T25seRACEhMKD2ZpcnN0UGVyc29uT25seRADYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::VrmProtobuf.FirstPerson), global::VrmProtobuf.FirstPerson.Parser, new[]{ "MeshAnnotations" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::VrmProtobuf.FirstPerson.Types.MeshAnnotation), global::VrmProtobuf.FirstPerson.Types.MeshAnnotation.Parser, new[]{ "Mesh", "FirstPersonType" }, null, new[]{ typeof(global::VrmProtobuf.FirstPerson.Types.MeshAnnotation.Types.FirstPersonType) }, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// First-person perspective settings
  /// </summary>
  public sealed partial class FirstPerson : pb::IMessage<FirstPerson> {
    private static readonly pb::MessageParser<FirstPerson> _parser = new pb::MessageParser<FirstPerson>(() => new FirstPerson());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FirstPerson> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::VrmProtobuf.FirstPersonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FirstPerson() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FirstPerson(FirstPerson other) : this() {
      meshAnnotations_ = other.meshAnnotations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FirstPerson Clone() {
      return new FirstPerson(this);
    }

    /// <summary>Field number for the "meshAnnotations" field.</summary>
    public const int MeshAnnotationsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::VrmProtobuf.FirstPerson.Types.MeshAnnotation> _repeated_meshAnnotations_codec
        = pb::FieldCodec.ForMessage(10, global::VrmProtobuf.FirstPerson.Types.MeshAnnotation.Parser);
    private readonly pbc::RepeatedField<global::VrmProtobuf.FirstPerson.Types.MeshAnnotation> meshAnnotations_ = new pbc::RepeatedField<global::VrmProtobuf.FirstPerson.Types.MeshAnnotation>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::VrmProtobuf.FirstPerson.Types.MeshAnnotation> MeshAnnotations {
      get { return meshAnnotations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FirstPerson);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FirstPerson other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!meshAnnotations_.Equals(other.meshAnnotations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= meshAnnotations_.GetHashCode();
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
      meshAnnotations_.WriteTo(output, _repeated_meshAnnotations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += meshAnnotations_.CalculateSize(_repeated_meshAnnotations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FirstPerson other) {
      if (other == null) {
        return;
      }
      meshAnnotations_.Add(other.meshAnnotations_);
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
            meshAnnotations_.AddEntriesFrom(input, _repeated_meshAnnotations_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the FirstPerson message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Mesh rendering annotation for cameras. "required": [ "mesh", "firstPersonType" ]
      /// </summary>
      public sealed partial class MeshAnnotation : pb::IMessage<MeshAnnotation> {
        private static readonly pb::MessageParser<MeshAnnotation> _parser = new pb::MessageParser<MeshAnnotation>(() => new MeshAnnotation());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<MeshAnnotation> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::VrmProtobuf.FirstPerson.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MeshAnnotation() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MeshAnnotation(MeshAnnotation other) : this() {
          mesh_ = other.mesh_;
          firstPersonType_ = other.firstPersonType_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MeshAnnotation Clone() {
          return new MeshAnnotation(this);
        }

        /// <summary>Field number for the "mesh" field.</summary>
        public const int MeshFieldNumber = 1;
        private int mesh_;
        /// <summary>
        /// Specify mesh
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Mesh {
          get { return mesh_; }
          set {
            mesh_ = value;
          }
        }

        /// <summary>Field number for the "firstPersonType" field.</summary>
        public const int FirstPersonTypeFieldNumber = 2;
        private global::VrmProtobuf.FirstPerson.Types.MeshAnnotation.Types.FirstPersonType firstPersonType_ = global::VrmProtobuf.FirstPerson.Types.MeshAnnotation.Types.FirstPersonType.Auto;
        /// <summary>
        /// Mesh rendering mode
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::VrmProtobuf.FirstPerson.Types.MeshAnnotation.Types.FirstPersonType FirstPersonType {
          get { return firstPersonType_; }
          set {
            firstPersonType_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as MeshAnnotation);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(MeshAnnotation other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Mesh != other.Mesh) return false;
          if (FirstPersonType != other.FirstPersonType) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Mesh != 0) hash ^= Mesh.GetHashCode();
          if (FirstPersonType != global::VrmProtobuf.FirstPerson.Types.MeshAnnotation.Types.FirstPersonType.Auto) hash ^= FirstPersonType.GetHashCode();
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
          if (Mesh != 0) {
            output.WriteRawTag(8);
            output.WriteInt32(Mesh);
          }
          if (FirstPersonType != global::VrmProtobuf.FirstPerson.Types.MeshAnnotation.Types.FirstPersonType.Auto) {
            output.WriteRawTag(16);
            output.WriteEnum((int) FirstPersonType);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Mesh != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Mesh);
          }
          if (FirstPersonType != global::VrmProtobuf.FirstPerson.Types.MeshAnnotation.Types.FirstPersonType.Auto) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FirstPersonType);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(MeshAnnotation other) {
          if (other == null) {
            return;
          }
          if (other.Mesh != 0) {
            Mesh = other.Mesh;
          }
          if (other.FirstPersonType != global::VrmProtobuf.FirstPerson.Types.MeshAnnotation.Types.FirstPersonType.Auto) {
            FirstPersonType = other.FirstPersonType;
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
                Mesh = input.ReadInt32();
                break;
              }
              case 16: {
                FirstPersonType = (global::VrmProtobuf.FirstPerson.Types.MeshAnnotation.Types.FirstPersonType) input.ReadEnum();
                break;
              }
            }
          }
        }

        #region Nested types
        /// <summary>Container for nested types declared in the MeshAnnotation message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static partial class Types {
          public enum FirstPersonType {
            [pbr::OriginalName("auto")] Auto = 0,
            [pbr::OriginalName("both")] Both = 1,
            [pbr::OriginalName("thirdPersonOnly")] ThirdPersonOnly = 2,
            [pbr::OriginalName("firstPersonOnly")] FirstPersonOnly = 3,
          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
