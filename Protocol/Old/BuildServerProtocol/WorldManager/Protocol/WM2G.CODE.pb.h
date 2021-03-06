// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: WorldManager/Protocol/WM2G.CODE.proto

#ifndef PROTOBUF_WorldManager_2fProtocol_2fWM2G_2eCODE_2eproto__INCLUDED
#define PROTOBUF_WorldManager_2fProtocol_2fWM2G_2eCODE_2eproto__INCLUDED

#include <string>

#include <google/protobuf/stubs/common.h>

#if GOOGLE_PROTOBUF_VERSION < 3005000
#error This file was generated by a newer version of protoc which is
#error incompatible with your Protocol Buffer headers.  Please update
#error your headers.
#endif
#if 3005001 < GOOGLE_PROTOBUF_MIN_PROTOC_VERSION
#error This file was generated by an older version of protoc which is
#error incompatible with your Protocol Buffer headers.  Please
#error regenerate this file with a newer version of protoc.
#endif

#include <google/protobuf/io/coded_stream.h>
#include <google/protobuf/arena.h>
#include <google/protobuf/arenastring.h>
#include <google/protobuf/generated_message_table_driven.h>
#include <google/protobuf/generated_message_util.h>
#include <google/protobuf/metadata.h>
#include <google/protobuf/message.h>
#include <google/protobuf/repeated_field.h>  // IWYU pragma: export
#include <google/protobuf/extension_set.h>  // IWYU pragma: export
#include <google/protobuf/unknown_field_set.h>
// @@protoc_insertion_point(includes)

namespace protobuf_WorldManager_2fProtocol_2fWM2G_2eCODE_2eproto {
// Internal implementation detail -- do not use these members.
struct TableStruct {
  static const ::google::protobuf::internal::ParseTableField entries[];
  static const ::google::protobuf::internal::AuxillaryParseTableField aux[];
  static const ::google::protobuf::internal::ParseTable schema[2];
  static const ::google::protobuf::internal::FieldMetadata field_metadata[];
  static const ::google::protobuf::internal::SerializationTable serialization_table[];
  static const ::google::protobuf::uint32 offsets[];
};
void AddDescriptors();
void InitDefaultsMSG_WM2G_HeartbeatImpl();
void InitDefaultsMSG_WM2G_Heartbeat();
void InitDefaultsMSG_WM2G_RegisterImpl();
void InitDefaultsMSG_WM2G_Register();
inline void InitDefaults() {
  InitDefaultsMSG_WM2G_Heartbeat();
  InitDefaultsMSG_WM2G_Register();
}
}  // namespace protobuf_WorldManager_2fProtocol_2fWM2G_2eCODE_2eproto
namespace Protocol {
namespace WorldManager {
namespace WM2G {
class MSG_WM2G_Heartbeat;
class MSG_WM2G_HeartbeatDefaultTypeInternal;
extern MSG_WM2G_HeartbeatDefaultTypeInternal _MSG_WM2G_Heartbeat_default_instance_;
class MSG_WM2G_Register;
class MSG_WM2G_RegisterDefaultTypeInternal;
extern MSG_WM2G_RegisterDefaultTypeInternal _MSG_WM2G_Register_default_instance_;
}  // namespace WM2G
}  // namespace WorldManager
}  // namespace Protocol
namespace Protocol {
namespace WorldManager {
namespace WM2G {

// ===================================================================

class MSG_WM2G_Heartbeat : public ::google::protobuf::Message /* @@protoc_insertion_point(class_definition:Protocol.WorldManager.WM2G.MSG_WM2G_Heartbeat) */ {
 public:
  MSG_WM2G_Heartbeat();
  virtual ~MSG_WM2G_Heartbeat();

  MSG_WM2G_Heartbeat(const MSG_WM2G_Heartbeat& from);

  inline MSG_WM2G_Heartbeat& operator=(const MSG_WM2G_Heartbeat& from) {
    CopyFrom(from);
    return *this;
  }
  #if LANG_CXX11
  MSG_WM2G_Heartbeat(MSG_WM2G_Heartbeat&& from) noexcept
    : MSG_WM2G_Heartbeat() {
    *this = ::std::move(from);
  }

  inline MSG_WM2G_Heartbeat& operator=(MSG_WM2G_Heartbeat&& from) noexcept {
    if (GetArenaNoVirtual() == from.GetArenaNoVirtual()) {
      if (this != &from) InternalSwap(&from);
    } else {
      CopyFrom(from);
    }
    return *this;
  }
  #endif
  inline const ::google::protobuf::UnknownFieldSet& unknown_fields() const {
    return _internal_metadata_.unknown_fields();
  }
  inline ::google::protobuf::UnknownFieldSet* mutable_unknown_fields() {
    return _internal_metadata_.mutable_unknown_fields();
  }

  static const ::google::protobuf::Descriptor* descriptor();
  static const MSG_WM2G_Heartbeat& default_instance();

  static void InitAsDefaultInstance();  // FOR INTERNAL USE ONLY
  static inline const MSG_WM2G_Heartbeat* internal_default_instance() {
    return reinterpret_cast<const MSG_WM2G_Heartbeat*>(
               &_MSG_WM2G_Heartbeat_default_instance_);
  }
  static PROTOBUF_CONSTEXPR int const kIndexInFileMessages =
    0;

  void Swap(MSG_WM2G_Heartbeat* other);
  friend void swap(MSG_WM2G_Heartbeat& a, MSG_WM2G_Heartbeat& b) {
    a.Swap(&b);
  }

  // implements Message ----------------------------------------------

  inline MSG_WM2G_Heartbeat* New() const PROTOBUF_FINAL { return New(NULL); }

  MSG_WM2G_Heartbeat* New(::google::protobuf::Arena* arena) const PROTOBUF_FINAL;
  void CopyFrom(const ::google::protobuf::Message& from) PROTOBUF_FINAL;
  void MergeFrom(const ::google::protobuf::Message& from) PROTOBUF_FINAL;
  void CopyFrom(const MSG_WM2G_Heartbeat& from);
  void MergeFrom(const MSG_WM2G_Heartbeat& from);
  void Clear() PROTOBUF_FINAL;
  bool IsInitialized() const PROTOBUF_FINAL;

  size_t ByteSizeLong() const PROTOBUF_FINAL;
  bool MergePartialFromCodedStream(
      ::google::protobuf::io::CodedInputStream* input) PROTOBUF_FINAL;
  void SerializeWithCachedSizes(
      ::google::protobuf::io::CodedOutputStream* output) const PROTOBUF_FINAL;
  ::google::protobuf::uint8* InternalSerializeWithCachedSizesToArray(
      bool deterministic, ::google::protobuf::uint8* target) const PROTOBUF_FINAL;
  int GetCachedSize() const PROTOBUF_FINAL { return _cached_size_; }
  private:
  void SharedCtor();
  void SharedDtor();
  void SetCachedSize(int size) const PROTOBUF_FINAL;
  void InternalSwap(MSG_WM2G_Heartbeat* other);
  private:
  inline ::google::protobuf::Arena* GetArenaNoVirtual() const {
    return NULL;
  }
  inline void* MaybeArenaPtr() const {
    return NULL;
  }
  public:

  ::google::protobuf::Metadata GetMetadata() const PROTOBUF_FINAL;

  // nested types ----------------------------------------------------

  // accessors -------------------------------------------------------

  // required int32 GroupId = 1;
  bool has_groupid() const;
  void clear_groupid();
  static const int kGroupIdFieldNumber = 1;
  ::google::protobuf::int32 groupid() const;
  void set_groupid(::google::protobuf::int32 value);

  // required int32 SubId = 2;
  bool has_subid() const;
  void clear_subid();
  static const int kSubIdFieldNumber = 2;
  ::google::protobuf::int32 subid() const;
  void set_subid(::google::protobuf::int32 value);

  // @@protoc_insertion_point(class_scope:Protocol.WorldManager.WM2G.MSG_WM2G_Heartbeat)
 private:
  void set_has_groupid();
  void clear_has_groupid();
  void set_has_subid();
  void clear_has_subid();

  // helper for ByteSizeLong()
  size_t RequiredFieldsByteSizeFallback() const;

  ::google::protobuf::internal::InternalMetadataWithArena _internal_metadata_;
  ::google::protobuf::internal::HasBits<1> _has_bits_;
  mutable int _cached_size_;
  ::google::protobuf::int32 groupid_;
  ::google::protobuf::int32 subid_;
  friend struct ::protobuf_WorldManager_2fProtocol_2fWM2G_2eCODE_2eproto::TableStruct;
  friend void ::protobuf_WorldManager_2fProtocol_2fWM2G_2eCODE_2eproto::InitDefaultsMSG_WM2G_HeartbeatImpl();
};
// -------------------------------------------------------------------

class MSG_WM2G_Register : public ::google::protobuf::Message /* @@protoc_insertion_point(class_definition:Protocol.WorldManager.WM2G.MSG_WM2G_Register) */ {
 public:
  MSG_WM2G_Register();
  virtual ~MSG_WM2G_Register();

  MSG_WM2G_Register(const MSG_WM2G_Register& from);

  inline MSG_WM2G_Register& operator=(const MSG_WM2G_Register& from) {
    CopyFrom(from);
    return *this;
  }
  #if LANG_CXX11
  MSG_WM2G_Register(MSG_WM2G_Register&& from) noexcept
    : MSG_WM2G_Register() {
    *this = ::std::move(from);
  }

  inline MSG_WM2G_Register& operator=(MSG_WM2G_Register&& from) noexcept {
    if (GetArenaNoVirtual() == from.GetArenaNoVirtual()) {
      if (this != &from) InternalSwap(&from);
    } else {
      CopyFrom(from);
    }
    return *this;
  }
  #endif
  inline const ::google::protobuf::UnknownFieldSet& unknown_fields() const {
    return _internal_metadata_.unknown_fields();
  }
  inline ::google::protobuf::UnknownFieldSet* mutable_unknown_fields() {
    return _internal_metadata_.mutable_unknown_fields();
  }

  static const ::google::protobuf::Descriptor* descriptor();
  static const MSG_WM2G_Register& default_instance();

  static void InitAsDefaultInstance();  // FOR INTERNAL USE ONLY
  static inline const MSG_WM2G_Register* internal_default_instance() {
    return reinterpret_cast<const MSG_WM2G_Register*>(
               &_MSG_WM2G_Register_default_instance_);
  }
  static PROTOBUF_CONSTEXPR int const kIndexInFileMessages =
    1;

  void Swap(MSG_WM2G_Register* other);
  friend void swap(MSG_WM2G_Register& a, MSG_WM2G_Register& b) {
    a.Swap(&b);
  }

  // implements Message ----------------------------------------------

  inline MSG_WM2G_Register* New() const PROTOBUF_FINAL { return New(NULL); }

  MSG_WM2G_Register* New(::google::protobuf::Arena* arena) const PROTOBUF_FINAL;
  void CopyFrom(const ::google::protobuf::Message& from) PROTOBUF_FINAL;
  void MergeFrom(const ::google::protobuf::Message& from) PROTOBUF_FINAL;
  void CopyFrom(const MSG_WM2G_Register& from);
  void MergeFrom(const MSG_WM2G_Register& from);
  void Clear() PROTOBUF_FINAL;
  bool IsInitialized() const PROTOBUF_FINAL;

  size_t ByteSizeLong() const PROTOBUF_FINAL;
  bool MergePartialFromCodedStream(
      ::google::protobuf::io::CodedInputStream* input) PROTOBUF_FINAL;
  void SerializeWithCachedSizes(
      ::google::protobuf::io::CodedOutputStream* output) const PROTOBUF_FINAL;
  ::google::protobuf::uint8* InternalSerializeWithCachedSizesToArray(
      bool deterministic, ::google::protobuf::uint8* target) const PROTOBUF_FINAL;
  int GetCachedSize() const PROTOBUF_FINAL { return _cached_size_; }
  private:
  void SharedCtor();
  void SharedDtor();
  void SetCachedSize(int size) const PROTOBUF_FINAL;
  void InternalSwap(MSG_WM2G_Register* other);
  private:
  inline ::google::protobuf::Arena* GetArenaNoVirtual() const {
    return NULL;
  }
  inline void* MaybeArenaPtr() const {
    return NULL;
  }
  public:

  ::google::protobuf::Metadata GetMetadata() const PROTOBUF_FINAL;

  // nested types ----------------------------------------------------

  // accessors -------------------------------------------------------

  // required int32 GroupId = 1;
  bool has_groupid() const;
  void clear_groupid();
  static const int kGroupIdFieldNumber = 1;
  ::google::protobuf::int32 groupid() const;
  void set_groupid(::google::protobuf::int32 value);

  // required int32 SubId = 2;
  bool has_subid() const;
  void clear_subid();
  static const int kSubIdFieldNumber = 2;
  ::google::protobuf::int32 subid() const;
  void set_subid(::google::protobuf::int32 value);

  // @@protoc_insertion_point(class_scope:Protocol.WorldManager.WM2G.MSG_WM2G_Register)
 private:
  void set_has_groupid();
  void clear_has_groupid();
  void set_has_subid();
  void clear_has_subid();

  // helper for ByteSizeLong()
  size_t RequiredFieldsByteSizeFallback() const;

  ::google::protobuf::internal::InternalMetadataWithArena _internal_metadata_;
  ::google::protobuf::internal::HasBits<1> _has_bits_;
  mutable int _cached_size_;
  ::google::protobuf::int32 groupid_;
  ::google::protobuf::int32 subid_;
  friend struct ::protobuf_WorldManager_2fProtocol_2fWM2G_2eCODE_2eproto::TableStruct;
  friend void ::protobuf_WorldManager_2fProtocol_2fWM2G_2eCODE_2eproto::InitDefaultsMSG_WM2G_RegisterImpl();
};
// ===================================================================


// ===================================================================

#ifdef __GNUC__
  #pragma GCC diagnostic push
  #pragma GCC diagnostic ignored "-Wstrict-aliasing"
#endif  // __GNUC__
// MSG_WM2G_Heartbeat

// required int32 GroupId = 1;
inline bool MSG_WM2G_Heartbeat::has_groupid() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void MSG_WM2G_Heartbeat::set_has_groupid() {
  _has_bits_[0] |= 0x00000001u;
}
inline void MSG_WM2G_Heartbeat::clear_has_groupid() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void MSG_WM2G_Heartbeat::clear_groupid() {
  groupid_ = 0;
  clear_has_groupid();
}
inline ::google::protobuf::int32 MSG_WM2G_Heartbeat::groupid() const {
  // @@protoc_insertion_point(field_get:Protocol.WorldManager.WM2G.MSG_WM2G_Heartbeat.GroupId)
  return groupid_;
}
inline void MSG_WM2G_Heartbeat::set_groupid(::google::protobuf::int32 value) {
  set_has_groupid();
  groupid_ = value;
  // @@protoc_insertion_point(field_set:Protocol.WorldManager.WM2G.MSG_WM2G_Heartbeat.GroupId)
}

// required int32 SubId = 2;
inline bool MSG_WM2G_Heartbeat::has_subid() const {
  return (_has_bits_[0] & 0x00000002u) != 0;
}
inline void MSG_WM2G_Heartbeat::set_has_subid() {
  _has_bits_[0] |= 0x00000002u;
}
inline void MSG_WM2G_Heartbeat::clear_has_subid() {
  _has_bits_[0] &= ~0x00000002u;
}
inline void MSG_WM2G_Heartbeat::clear_subid() {
  subid_ = 0;
  clear_has_subid();
}
inline ::google::protobuf::int32 MSG_WM2G_Heartbeat::subid() const {
  // @@protoc_insertion_point(field_get:Protocol.WorldManager.WM2G.MSG_WM2G_Heartbeat.SubId)
  return subid_;
}
inline void MSG_WM2G_Heartbeat::set_subid(::google::protobuf::int32 value) {
  set_has_subid();
  subid_ = value;
  // @@protoc_insertion_point(field_set:Protocol.WorldManager.WM2G.MSG_WM2G_Heartbeat.SubId)
}

// -------------------------------------------------------------------

// MSG_WM2G_Register

// required int32 GroupId = 1;
inline bool MSG_WM2G_Register::has_groupid() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void MSG_WM2G_Register::set_has_groupid() {
  _has_bits_[0] |= 0x00000001u;
}
inline void MSG_WM2G_Register::clear_has_groupid() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void MSG_WM2G_Register::clear_groupid() {
  groupid_ = 0;
  clear_has_groupid();
}
inline ::google::protobuf::int32 MSG_WM2G_Register::groupid() const {
  // @@protoc_insertion_point(field_get:Protocol.WorldManager.WM2G.MSG_WM2G_Register.GroupId)
  return groupid_;
}
inline void MSG_WM2G_Register::set_groupid(::google::protobuf::int32 value) {
  set_has_groupid();
  groupid_ = value;
  // @@protoc_insertion_point(field_set:Protocol.WorldManager.WM2G.MSG_WM2G_Register.GroupId)
}

// required int32 SubId = 2;
inline bool MSG_WM2G_Register::has_subid() const {
  return (_has_bits_[0] & 0x00000002u) != 0;
}
inline void MSG_WM2G_Register::set_has_subid() {
  _has_bits_[0] |= 0x00000002u;
}
inline void MSG_WM2G_Register::clear_has_subid() {
  _has_bits_[0] &= ~0x00000002u;
}
inline void MSG_WM2G_Register::clear_subid() {
  subid_ = 0;
  clear_has_subid();
}
inline ::google::protobuf::int32 MSG_WM2G_Register::subid() const {
  // @@protoc_insertion_point(field_get:Protocol.WorldManager.WM2G.MSG_WM2G_Register.SubId)
  return subid_;
}
inline void MSG_WM2G_Register::set_subid(::google::protobuf::int32 value) {
  set_has_subid();
  subid_ = value;
  // @@protoc_insertion_point(field_set:Protocol.WorldManager.WM2G.MSG_WM2G_Register.SubId)
}

#ifdef __GNUC__
  #pragma GCC diagnostic pop
#endif  // __GNUC__
// -------------------------------------------------------------------


// @@protoc_insertion_point(namespace_scope)

}  // namespace WM2G
}  // namespace WorldManager
}  // namespace Protocol

// @@protoc_insertion_point(global_scope)

#endif  // PROTOBUF_WorldManager_2fProtocol_2fWM2G_2eCODE_2eproto__INCLUDED
