// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Responses/SetAvatarResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Networking/Responses/SetAvatarResponse.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class SetAvatarResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Responses/SetAvatarResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetAvatarResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixOZXR3b3JraW5nL1Jlc3BvbnNlcy9TZXRBdmF0YXJSZXNwb25zZS5wcm90",
            "bxIUTmV0d29ya2luZy5SZXNwb25zZXMaFURhdGEvUGxheWVyRGF0YS5wcm90",
            "byLBAQoRU2V0QXZhdGFyUmVzcG9uc2USPgoGc3RhdHVzGAEgASgOMi4uTmV0",
            "d29ya2luZy5SZXNwb25zZXMuU2V0QXZhdGFyUmVzcG9uc2UuU3RhdHVzEiUK",
            "C3BsYXllcl9kYXRhGAIgASgLMhAuRGF0YS5QbGF5ZXJEYXRhIkUKBlN0YXR1",
            "cxIJCgVVTlNFVBAAEgsKB1NVQ0NFU1MQARIWChJBVkFUQVJfQUxSRUFEWV9T",
            "RVQQAhILCgdGQUlMVVJFEANCHaoCGlBva2Vtb25Hb0Rlc2t0b3AuQVBJLlBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PokemonGoDesktop.API.Proto.PlayerDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.SetAvatarResponse), global::PokemonGoDesktop.API.Proto.SetAvatarResponse.Parser, new[]{ "Status", "PlayerData" }, null, new[]{ typeof(global::PokemonGoDesktop.API.Proto.SetAvatarResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class SetAvatarResponse : pb::IMessage<SetAvatarResponse> {
    private static readonly pb::MessageParser<SetAvatarResponse> _parser = new pb::MessageParser<SetAvatarResponse>(() => new SetAvatarResponse());
    public static pb::MessageParser<SetAvatarResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.SetAvatarResponseReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public SetAvatarResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public SetAvatarResponse(SetAvatarResponse other) : this() {
      status_ = other.status_;
      PlayerData = other.playerData_ != null ? other.PlayerData.Clone() : null;
    }

    public SetAvatarResponse Clone() {
      return new SetAvatarResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::PokemonGoDesktop.API.Proto.SetAvatarResponse.Types.Status status_ = 0;
    public global::PokemonGoDesktop.API.Proto.SetAvatarResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "player_data" field.</summary>
    public const int PlayerDataFieldNumber = 2;
    private global::PokemonGoDesktop.API.Proto.PlayerData playerData_;
    public global::PokemonGoDesktop.API.Proto.PlayerData PlayerData {
      get { return playerData_; }
      set {
        playerData_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as SetAvatarResponse);
    }

    public bool Equals(SetAvatarResponse other) {
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

    public void MergeFrom(SetAvatarResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.playerData_ != null) {
        if (playerData_ == null) {
          playerData_ = new global::PokemonGoDesktop.API.Proto.PlayerData();
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
            status_ = (global::PokemonGoDesktop.API.Proto.SetAvatarResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            if (playerData_ == null) {
              playerData_ = new global::PokemonGoDesktop.API.Proto.PlayerData();
            }
            input.ReadMessage(playerData_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SetAvatarResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("AVATAR_ALREADY_SET")] AvatarAlreadySet = 2,
        [pbr::OriginalName("FAILURE")] Failure = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
