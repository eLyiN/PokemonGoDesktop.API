// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Requests/Messages/DownloadItemTemplatesMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Networking/Requests/Messages/DownloadItemTemplatesMessage.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class DownloadItemTemplatesMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Requests/Messages/DownloadItemTemplatesMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DownloadItemTemplatesMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9OZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL0Rvd25sb2FkSXRlbVRl",
            "bXBsYXRlc01lc3NhZ2UucHJvdG8SHE5ldHdvcmtpbmcuUmVxdWVzdHMuTWVz",
            "c2FnZXMiHgocRG93bmxvYWRJdGVtVGVtcGxhdGVzTWVzc2FnZUIdqgIaUG9r",
            "ZW1vbkdvRGVza3RvcC5BUEkuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.DownloadItemTemplatesMessage), global::PokemonGoDesktop.API.Proto.DownloadItemTemplatesMessage.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  No message needed.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class DownloadItemTemplatesMessage : pb::IMessage<DownloadItemTemplatesMessage> {
    private static readonly pb::MessageParser<DownloadItemTemplatesMessage> _parser = new pb::MessageParser<DownloadItemTemplatesMessage>(() => new DownloadItemTemplatesMessage());
    public static pb::MessageParser<DownloadItemTemplatesMessage> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.DownloadItemTemplatesMessageReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public DownloadItemTemplatesMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    public DownloadItemTemplatesMessage(DownloadItemTemplatesMessage other) : this() {
    }

    public DownloadItemTemplatesMessage Clone() {
      return new DownloadItemTemplatesMessage(this);
    }

    public override bool Equals(object other) {
      return Equals(other as DownloadItemTemplatesMessage);
    }

    public bool Equals(DownloadItemTemplatesMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
    }

    public int CalculateSize() {
      int size = 0;
      return size;
    }

    public void MergeFrom(DownloadItemTemplatesMessage other) {
      if (other == null) {
        return;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
