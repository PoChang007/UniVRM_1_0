// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: meta.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace VrmProtobuf {

  /// <summary>Holder for reflection information generated from meta.proto</summary>
  public static partial class MetaReflection {

    #region Descriptor
    /// <summary>File descriptor for meta.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MetaReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgptZXRhLnByb3RvEgtWcm1Qcm90b2J1ZhoeZ29vZ2xlL3Byb3RvYnVmL3dy",
            "YXBwZXJzLnByb3RvIqwHCgRNZXRhEgwKBG5hbWUYASABKAkSDwoHdmVyc2lv",
            "bhgCIAEoCRIPCgdhdXRob3JzGAMgAygJEhIKCmNvcHlyaWdodHMYBCABKAkS",
            "GgoSY29udGFjdEluZm9ybWF0aW9uGAUgASgJEhEKCXJlZmVyZW5jZRgGIAEo",
            "CRIzCg50aHVtYm5haWxJbWFnZRgHIAEoCzIbLmdvb2dsZS5wcm90b2J1Zi5J",
            "bnQzMlZhbHVlEkAKEGF2YXRhclBlcm1pc3Npb24YCCABKA4yJi5Wcm1Qcm90",
            "b2J1Zi5NZXRhLkF2YXRhclBlcm1pc3Npb25UeXBlEhQKDHZpb2xlbnRVc2Fn",
            "ZRgJIAEoCBITCgtzZXh1YWxVc2FnZRgKIAEoCBIRCglnYW1lVXNhZ2UYCyAB",
            "KAgSPgoPY29tbWVyY2lhbFVzYWdlGAwgASgOMiUuVnJtUHJvdG9idWYuTWV0",
            "YS5Db21tZXJjaWFsVXNhZ2VUeXBlEiEKGXBvbGl0aWNhbE9yUmVsaWdpb3Vz",
            "VXNhZ2UYDSABKAgSGgoSb3RoZXJQZXJtaXNzaW9uVXJsGA4gASgJEjwKDmNy",
            "ZWRpdE5vdGF0aW9uGA8gASgOMiQuVnJtUHJvdG9idWYuTWV0YS5DcmVkaXRO",
            "b3RhdGlvblR5cGUSGwoTYWxsb3dSZWRpc3RyaWJ1dGlvbhgQIAEoCBIsCgZt",
            "b2RpZnkYESABKA4yHC5Wcm1Qcm90b2J1Zi5NZXRhLk1vZGlmeVR5cGUSFwoP",
            "b3RoZXJMaWNlbnNlVXJsGBIgASgJIlIKFEF2YXRhclBlcm1pc3Npb25UeXBl",
            "Eg4KCk9ubHlBdXRob3IQABIcChhFeHBsaWNpdGx5TGljZW5zZWRQZXJzb24Q",
            "ARIMCghFdmVyeW9uZRACIoMBChNDb21tZXJjaWFsVXNhZ2VUeXBlEiIKHlBl",
            "cnNvbmFsTm9uQ29tbWVyY2lhbE5vblByb2ZpdBAAEh8KG1BlcnNvbmFsTm9u",
            "Q29tbWVyY2lhbFByb2ZpdBABEhYKElBlcnNvbmFsQ29tbWVyY2lhbBACEg8K",
            "C0NvcnBvcmF0aW9uEAMiQgoSQ3JlZGl0Tm90YXRpb25UeXBlEgwKCFJlcXVp",
            "cmVkEAASDwoLVW5uZWNlc3NhcnkQARINCglBYmFuZG9uZWQQAiI9CgpNb2Rp",
            "ZnlUeXBlEg4KClByb2hpYml0ZWQQABINCglJbmhlcml0ZWQQARIQCgxOb3RJ",
            "bmhlcml0ZWQQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::VrmProtobuf.Meta), global::VrmProtobuf.Meta.Parser, new[]{ "Name", "Version", "Authors", "Copyrights", "ContactInformation", "Reference", "ThumbnailImage", "AvatarPermission", "ViolentUsage", "SexualUsage", "GameUsage", "CommercialUsage", "PoliticalOrReligiousUsage", "OtherPermissionUrl", "CreditNotation", "AllowRedistribution", "Modify", "OtherLicenseUrl" }, null, new[]{ typeof(global::VrmProtobuf.Meta.Types.AvatarPermissionType), typeof(global::VrmProtobuf.Meta.Types.CommercialUsageType), typeof(global::VrmProtobuf.Meta.Types.CreditNotationType), typeof(global::VrmProtobuf.Meta.Types.ModifyType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Meta : pb::IMessage<Meta> {
    private static readonly pb::MessageParser<Meta> _parser = new pb::MessageParser<Meta>(() => new Meta());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Meta> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::VrmProtobuf.MetaReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Meta() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Meta(Meta other) : this() {
      name_ = other.name_;
      version_ = other.version_;
      authors_ = other.authors_.Clone();
      copyrights_ = other.copyrights_;
      contactInformation_ = other.contactInformation_;
      reference_ = other.reference_;
      ThumbnailImage = other.ThumbnailImage;
      avatarPermission_ = other.avatarPermission_;
      violentUsage_ = other.violentUsage_;
      sexualUsage_ = other.sexualUsage_;
      gameUsage_ = other.gameUsage_;
      commercialUsage_ = other.commercialUsage_;
      politicalOrReligiousUsage_ = other.politicalOrReligiousUsage_;
      otherPermissionUrl_ = other.otherPermissionUrl_;
      creditNotation_ = other.creditNotation_;
      allowRedistribution_ = other.allowRedistribution_;
      modify_ = other.modify_;
      otherLicenseUrl_ = other.otherLicenseUrl_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Meta Clone() {
      return new Meta(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Describe the name of the avatar model
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 2;
    private string version_ = "";
    /// <summary>
    /// Describe the version that creates the model
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Version {
      get { return version_; }
      set {
        version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "authors" field.</summary>
    public const int AuthorsFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_authors_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> authors_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Describe the name of the author of the model
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Authors {
      get { return authors_; }
    }

    /// <summary>Field number for the "copyrights" field.</summary>
    public const int CopyrightsFieldNumber = 4;
    private string copyrights_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Copyrights {
      get { return copyrights_; }
      set {
        copyrights_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "contactInformation" field.</summary>
    public const int ContactInformationFieldNumber = 5;
    private string contactInformation_ = "";
    /// <summary>
    /// Describe the contact information of the author
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ContactInformation {
      get { return contactInformation_; }
      set {
        contactInformation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "reference" field.</summary>
    public const int ReferenceFieldNumber = 6;
    private string reference_ = "";
    /// <summary>
    /// Describe original / related works of the avatar (URL), if any
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Reference {
      get { return reference_; }
      set {
        reference_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "thumbnailImage" field.</summary>
    public const int ThumbnailImageFieldNumber = 7;
    private static readonly pb::FieldCodec<int?> _single_thumbnailImage_codec = pb::FieldCodec.ForStructWrapper<int>(58);
    private int? thumbnailImage_;
    /// <summary>
    /// The index to access the thumbnail image of the avatar model in gltf.images. The texture resolution of 2048x2048 is recommended
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int? ThumbnailImage {
      get { return thumbnailImage_; }
      set {
        thumbnailImage_ = value;
      }
    }


    /// <summary>Field number for the "avatarPermission" field.</summary>
    public const int AvatarPermissionFieldNumber = 8;
    private global::VrmProtobuf.Meta.Types.AvatarPermissionType avatarPermission_ = global::VrmProtobuf.Meta.Types.AvatarPermissionType.OnlyAuthor;
    /// <summary>
    /// A person who can perform with this avatars
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::VrmProtobuf.Meta.Types.AvatarPermissionType AvatarPermission {
      get { return avatarPermission_; }
      set {
        avatarPermission_ = value;
      }
    }

    /// <summary>Field number for the "violentUsage" field.</summary>
    public const int ViolentUsageFieldNumber = 9;
    private bool violentUsage_;
    /// <summary>
    /// Perform violent acts with this avatar
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ViolentUsage {
      get { return violentUsage_; }
      set {
        violentUsage_ = value;
      }
    }

    /// <summary>Field number for the "sexualUsage" field.</summary>
    public const int SexualUsageFieldNumber = 10;
    private bool sexualUsage_;
    /// <summary>
    /// Perform sexual acts with this avatar
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool SexualUsage {
      get { return sexualUsage_; }
      set {
        sexualUsage_ = value;
      }
    }

    /// <summary>Field number for the "gameUsage" field.</summary>
    public const int GameUsageFieldNumber = 11;
    private bool gameUsage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool GameUsage {
      get { return gameUsage_; }
      set {
        gameUsage_ = value;
      }
    }

    /// <summary>Field number for the "commercialUsage" field.</summary>
    public const int CommercialUsageFieldNumber = 12;
    private global::VrmProtobuf.Meta.Types.CommercialUsageType commercialUsage_ = global::VrmProtobuf.Meta.Types.CommercialUsageType.PersonalNonCommercialNonProfit;
    /// <summary>
    /// Commercial use
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::VrmProtobuf.Meta.Types.CommercialUsageType CommercialUsage {
      get { return commercialUsage_; }
      set {
        commercialUsage_ = value;
      }
    }

    /// <summary>Field number for the "politicalOrReligiousUsage" field.</summary>
    public const int PoliticalOrReligiousUsageFieldNumber = 13;
    private bool politicalOrReligiousUsage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool PoliticalOrReligiousUsage {
      get { return politicalOrReligiousUsage_; }
      set {
        politicalOrReligiousUsage_ = value;
      }
    }

    /// <summary>Field number for the "otherPermissionUrl" field.</summary>
    public const int OtherPermissionUrlFieldNumber = 14;
    private string otherPermissionUrl_ = "";
    /// <summary>
    /// Describe the URL links of license with regard to other permissions
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OtherPermissionUrl {
      get { return otherPermissionUrl_; }
      set {
        otherPermissionUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "creditNotation" field.</summary>
    public const int CreditNotationFieldNumber = 15;
    private global::VrmProtobuf.Meta.Types.CreditNotationType creditNotation_ = global::VrmProtobuf.Meta.Types.CreditNotationType.Required;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::VrmProtobuf.Meta.Types.CreditNotationType CreditNotation {
      get { return creditNotation_; }
      set {
        creditNotation_ = value;
      }
    }

    /// <summary>Field number for the "allowRedistribution" field.</summary>
    public const int AllowRedistributionFieldNumber = 16;
    private bool allowRedistribution_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool AllowRedistribution {
      get { return allowRedistribution_; }
      set {
        allowRedistribution_ = value;
      }
    }

    /// <summary>Field number for the "modify" field.</summary>
    public const int ModifyFieldNumber = 17;
    private global::VrmProtobuf.Meta.Types.ModifyType modify_ = global::VrmProtobuf.Meta.Types.ModifyType.Prohibited;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::VrmProtobuf.Meta.Types.ModifyType Modify {
      get { return modify_; }
      set {
        modify_ = value;
      }
    }

    /// <summary>Field number for the "otherLicenseUrl" field.</summary>
    public const int OtherLicenseUrlFieldNumber = 18;
    private string otherLicenseUrl_ = "";
    /// <summary>
    /// Describe the URL links of other license
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OtherLicenseUrl {
      get { return otherLicenseUrl_; }
      set {
        otherLicenseUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Meta);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Meta other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Version != other.Version) return false;
      if(!authors_.Equals(other.authors_)) return false;
      if (Copyrights != other.Copyrights) return false;
      if (ContactInformation != other.ContactInformation) return false;
      if (Reference != other.Reference) return false;
      if (ThumbnailImage != other.ThumbnailImage) return false;
      if (AvatarPermission != other.AvatarPermission) return false;
      if (ViolentUsage != other.ViolentUsage) return false;
      if (SexualUsage != other.SexualUsage) return false;
      if (GameUsage != other.GameUsage) return false;
      if (CommercialUsage != other.CommercialUsage) return false;
      if (PoliticalOrReligiousUsage != other.PoliticalOrReligiousUsage) return false;
      if (OtherPermissionUrl != other.OtherPermissionUrl) return false;
      if (CreditNotation != other.CreditNotation) return false;
      if (AllowRedistribution != other.AllowRedistribution) return false;
      if (Modify != other.Modify) return false;
      if (OtherLicenseUrl != other.OtherLicenseUrl) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Version.Length != 0) hash ^= Version.GetHashCode();
      hash ^= authors_.GetHashCode();
      if (Copyrights.Length != 0) hash ^= Copyrights.GetHashCode();
      if (ContactInformation.Length != 0) hash ^= ContactInformation.GetHashCode();
      if (Reference.Length != 0) hash ^= Reference.GetHashCode();
      if (thumbnailImage_ != null) hash ^= ThumbnailImage.GetHashCode();
      if (AvatarPermission != global::VrmProtobuf.Meta.Types.AvatarPermissionType.OnlyAuthor) hash ^= AvatarPermission.GetHashCode();
      if (ViolentUsage != false) hash ^= ViolentUsage.GetHashCode();
      if (SexualUsage != false) hash ^= SexualUsage.GetHashCode();
      if (GameUsage != false) hash ^= GameUsage.GetHashCode();
      if (CommercialUsage != global::VrmProtobuf.Meta.Types.CommercialUsageType.PersonalNonCommercialNonProfit) hash ^= CommercialUsage.GetHashCode();
      if (PoliticalOrReligiousUsage != false) hash ^= PoliticalOrReligiousUsage.GetHashCode();
      if (OtherPermissionUrl.Length != 0) hash ^= OtherPermissionUrl.GetHashCode();
      if (CreditNotation != global::VrmProtobuf.Meta.Types.CreditNotationType.Required) hash ^= CreditNotation.GetHashCode();
      if (AllowRedistribution != false) hash ^= AllowRedistribution.GetHashCode();
      if (Modify != global::VrmProtobuf.Meta.Types.ModifyType.Prohibited) hash ^= Modify.GetHashCode();
      if (OtherLicenseUrl.Length != 0) hash ^= OtherLicenseUrl.GetHashCode();
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
      if (Version.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Version);
      }
      authors_.WriteTo(output, _repeated_authors_codec);
      if (Copyrights.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Copyrights);
      }
      if (ContactInformation.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ContactInformation);
      }
      if (Reference.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Reference);
      }
      if (thumbnailImage_ != null) {
        _single_thumbnailImage_codec.WriteTagAndValue(output, ThumbnailImage);
      }
      if (AvatarPermission != global::VrmProtobuf.Meta.Types.AvatarPermissionType.OnlyAuthor) {
        output.WriteRawTag(64);
        output.WriteEnum((int) AvatarPermission);
      }
      if (ViolentUsage != false) {
        output.WriteRawTag(72);
        output.WriteBool(ViolentUsage);
      }
      if (SexualUsage != false) {
        output.WriteRawTag(80);
        output.WriteBool(SexualUsage);
      }
      if (GameUsage != false) {
        output.WriteRawTag(88);
        output.WriteBool(GameUsage);
      }
      if (CommercialUsage != global::VrmProtobuf.Meta.Types.CommercialUsageType.PersonalNonCommercialNonProfit) {
        output.WriteRawTag(96);
        output.WriteEnum((int) CommercialUsage);
      }
      if (PoliticalOrReligiousUsage != false) {
        output.WriteRawTag(104);
        output.WriteBool(PoliticalOrReligiousUsage);
      }
      if (OtherPermissionUrl.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(OtherPermissionUrl);
      }
      if (CreditNotation != global::VrmProtobuf.Meta.Types.CreditNotationType.Required) {
        output.WriteRawTag(120);
        output.WriteEnum((int) CreditNotation);
      }
      if (AllowRedistribution != false) {
        output.WriteRawTag(128, 1);
        output.WriteBool(AllowRedistribution);
      }
      if (Modify != global::VrmProtobuf.Meta.Types.ModifyType.Prohibited) {
        output.WriteRawTag(136, 1);
        output.WriteEnum((int) Modify);
      }
      if (OtherLicenseUrl.Length != 0) {
        output.WriteRawTag(146, 1);
        output.WriteString(OtherLicenseUrl);
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
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      size += authors_.CalculateSize(_repeated_authors_codec);
      if (Copyrights.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Copyrights);
      }
      if (ContactInformation.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ContactInformation);
      }
      if (Reference.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Reference);
      }
      if (thumbnailImage_ != null) {
        size += _single_thumbnailImage_codec.CalculateSizeWithTag(ThumbnailImage);
      }
      if (AvatarPermission != global::VrmProtobuf.Meta.Types.AvatarPermissionType.OnlyAuthor) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AvatarPermission);
      }
      if (ViolentUsage != false) {
        size += 1 + 1;
      }
      if (SexualUsage != false) {
        size += 1 + 1;
      }
      if (GameUsage != false) {
        size += 1 + 1;
      }
      if (CommercialUsage != global::VrmProtobuf.Meta.Types.CommercialUsageType.PersonalNonCommercialNonProfit) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CommercialUsage);
      }
      if (PoliticalOrReligiousUsage != false) {
        size += 1 + 1;
      }
      if (OtherPermissionUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OtherPermissionUrl);
      }
      if (CreditNotation != global::VrmProtobuf.Meta.Types.CreditNotationType.Required) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CreditNotation);
      }
      if (AllowRedistribution != false) {
        size += 2 + 1;
      }
      if (Modify != global::VrmProtobuf.Meta.Types.ModifyType.Prohibited) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) Modify);
      }
      if (OtherLicenseUrl.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(OtherLicenseUrl);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Meta other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Version.Length != 0) {
        Version = other.Version;
      }
      authors_.Add(other.authors_);
      if (other.Copyrights.Length != 0) {
        Copyrights = other.Copyrights;
      }
      if (other.ContactInformation.Length != 0) {
        ContactInformation = other.ContactInformation;
      }
      if (other.Reference.Length != 0) {
        Reference = other.Reference;
      }
      if (other.thumbnailImage_ != null) {
        if (thumbnailImage_ == null || other.ThumbnailImage != 0) {
          ThumbnailImage = other.ThumbnailImage;
        }
      }
      if (other.AvatarPermission != global::VrmProtobuf.Meta.Types.AvatarPermissionType.OnlyAuthor) {
        AvatarPermission = other.AvatarPermission;
      }
      if (other.ViolentUsage != false) {
        ViolentUsage = other.ViolentUsage;
      }
      if (other.SexualUsage != false) {
        SexualUsage = other.SexualUsage;
      }
      if (other.GameUsage != false) {
        GameUsage = other.GameUsage;
      }
      if (other.CommercialUsage != global::VrmProtobuf.Meta.Types.CommercialUsageType.PersonalNonCommercialNonProfit) {
        CommercialUsage = other.CommercialUsage;
      }
      if (other.PoliticalOrReligiousUsage != false) {
        PoliticalOrReligiousUsage = other.PoliticalOrReligiousUsage;
      }
      if (other.OtherPermissionUrl.Length != 0) {
        OtherPermissionUrl = other.OtherPermissionUrl;
      }
      if (other.CreditNotation != global::VrmProtobuf.Meta.Types.CreditNotationType.Required) {
        CreditNotation = other.CreditNotation;
      }
      if (other.AllowRedistribution != false) {
        AllowRedistribution = other.AllowRedistribution;
      }
      if (other.Modify != global::VrmProtobuf.Meta.Types.ModifyType.Prohibited) {
        Modify = other.Modify;
      }
      if (other.OtherLicenseUrl.Length != 0) {
        OtherLicenseUrl = other.OtherLicenseUrl;
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
          case 18: {
            Version = input.ReadString();
            break;
          }
          case 26: {
            authors_.AddEntriesFrom(input, _repeated_authors_codec);
            break;
          }
          case 34: {
            Copyrights = input.ReadString();
            break;
          }
          case 42: {
            ContactInformation = input.ReadString();
            break;
          }
          case 50: {
            Reference = input.ReadString();
            break;
          }
          case 58: {
            int? value = _single_thumbnailImage_codec.Read(input);
            if (thumbnailImage_ == null || value != 0) {
              ThumbnailImage = value;
            }
            break;
          }
          case 64: {
            AvatarPermission = (global::VrmProtobuf.Meta.Types.AvatarPermissionType) input.ReadEnum();
            break;
          }
          case 72: {
            ViolentUsage = input.ReadBool();
            break;
          }
          case 80: {
            SexualUsage = input.ReadBool();
            break;
          }
          case 88: {
            GameUsage = input.ReadBool();
            break;
          }
          case 96: {
            CommercialUsage = (global::VrmProtobuf.Meta.Types.CommercialUsageType) input.ReadEnum();
            break;
          }
          case 104: {
            PoliticalOrReligiousUsage = input.ReadBool();
            break;
          }
          case 114: {
            OtherPermissionUrl = input.ReadString();
            break;
          }
          case 120: {
            CreditNotation = (global::VrmProtobuf.Meta.Types.CreditNotationType) input.ReadEnum();
            break;
          }
          case 128: {
            AllowRedistribution = input.ReadBool();
            break;
          }
          case 136: {
            Modify = (global::VrmProtobuf.Meta.Types.ModifyType) input.ReadEnum();
            break;
          }
          case 146: {
            OtherLicenseUrl = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Meta message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum AvatarPermissionType {
        [pbr::OriginalName("OnlyAuthor")] OnlyAuthor = 0,
        [pbr::OriginalName("ExplicitlyLicensedPerson")] ExplicitlyLicensedPerson = 1,
        [pbr::OriginalName("Everyone")] Everyone = 2,
      }

      public enum CommercialUsageType {
        [pbr::OriginalName("PersonalNonCommercialNonProfit")] PersonalNonCommercialNonProfit = 0,
        [pbr::OriginalName("PersonalNonCommercialProfit")] PersonalNonCommercialProfit = 1,
        [pbr::OriginalName("PersonalCommercial")] PersonalCommercial = 2,
        [pbr::OriginalName("Corporation")] Corporation = 3,
      }

      public enum CreditNotationType {
        [pbr::OriginalName("Required")] Required = 0,
        [pbr::OriginalName("Unnecessary")] Unnecessary = 1,
        [pbr::OriginalName("Abandoned")] Abandoned = 2,
      }

      public enum ModifyType {
        [pbr::OriginalName("Prohibited")] Prohibited = 0,
        [pbr::OriginalName("Inherited")] Inherited = 1,
        [pbr::OriginalName("NotInherited")] NotInherited = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
