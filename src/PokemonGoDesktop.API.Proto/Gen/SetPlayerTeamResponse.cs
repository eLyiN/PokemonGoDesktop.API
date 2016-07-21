// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Responses/SetPlayerTeamResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Networking.Responses {

  /// <summary>Holder for reflection information generated from Networking/Responses/SetPlayerTeamResponse.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class SetPlayerTeamResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Responses/SetPlayerTeamResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetPlayerTeamResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBOZXR3b3JraW5nL1Jlc3BvbnNlcy9TZXRQbGF5ZXJUZWFtUmVzcG9uc2Uu",
            "cHJvdG8SFE5ldHdvcmtpbmcuUmVzcG9uc2VzGhVEYXRhL1BsYXllckRhdGEu",
            "cHJvdG8ixwEKFVNldFBsYXllclRlYW1SZXNwb25zZRJCCgZzdGF0dXMYASAB",
            "KA4yMi5OZXR3b3JraW5nLlJlc3BvbnNlcy5TZXRQbGF5ZXJUZWFtUmVzcG9u",
            "c2UuU3RhdHVzEiUKC3BsYXllcl9kYXRhGAIgASgLMhAuRGF0YS5QbGF5ZXJE",
            "YXRhIkMKBlN0YXR1cxIJCgVVTlNFVBAAEgsKB1NVQ0NFU1MQARIUChBURUFN",
            "X0FMUkVBRFlfU0VUEAISCwoHRkFJTFVSRRADYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Data.PlayerDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Networking.Responses.SetPlayerTeamResponse), global::Networking.Responses.SetPlayerTeamResponse.Parser, new[]{ "Status", "PlayerData" }, null, new[]{ typeof(global::Networking.Responses.SetPlayerTeamResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class SetPlayerTeamResponse : pb::IMessage<SetPlayerTeamResponse> {
    private static readonly pb::MessageParser<SetPlayerTeamResponse> _parser = new pb::MessageParser<SetPlayerTeamResponse>(() => new SetPlayerTeamResponse());
    public static pb::MessageParser<SetPlayerTeamResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Networking.Responses.SetPlayerTeamResponseReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public SetPlayerTeamResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public SetPlayerTeamResponse(SetPlayerTeamResponse other) : this() {
      status_ = other.status_;
      PlayerData = other.playerData_ != null ? other.PlayerData.Clone() : null;
    }

    public SetPlayerTeamResponse Clone() {
      return new SetPlayerTeamResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::Networking.Responses.SetPlayerTeamResponse.Types.Status status_ = 0;
    public global::Networking.Responses.SetPlayerTeamResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "player_data" field.</summary>
    public const int PlayerDataFieldNumber = 2;
    private global::Data.PlayerData playerData_;
    public global::Data.PlayerData PlayerData {
      get { return playerData_; }
      set {
        playerData_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as SetPlayerTeamResponse);
    }

    public bool Equals(SetPlayerTeamResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (!object.Equals(PlayerData, other.PlayerData)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (playerData_ != null) hash ^= PlayerData.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (playerData_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PlayerData);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (playerData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerData);
      }
      return size;
    }

    public void MergeFrom(SetPlayerTeamResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.playerData_ != null) {
        if (playerData_ == null) {
          playerData_ = new global::Data.PlayerData();
        }
        PlayerData.MergeFrom(other.PlayerData);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            status_ = (global::Networking.Responses.SetPlayerTeamResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            if (playerData_ == null) {
              playerData_ = new global::Data.PlayerData();
            }
            input.ReadMessage(playerData_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SetPlayerTeamResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("TEAM_ALREADY_SET")] TeamAlreadySet = 2,
        [pbr::OriginalName("FAILURE")] Failure = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code