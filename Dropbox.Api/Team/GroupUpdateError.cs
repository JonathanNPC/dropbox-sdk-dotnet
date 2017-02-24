// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The group update error object</para>
    /// </summary>
    public class GroupUpdateError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupUpdateError> Encoder = new GroupUpdateErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupUpdateError> Decoder = new GroupUpdateErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupUpdateError" />
        /// class.</para>
        /// </summary>
        public GroupUpdateError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is GroupNameAlreadyUsed</para>
        /// </summary>
        public bool IsGroupNameAlreadyUsed
        {
            get
            {
                return this is GroupNameAlreadyUsed;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a GroupNameAlreadyUsed, or <c>null</c>.</para>
        /// </summary>
        public GroupNameAlreadyUsed AsGroupNameAlreadyUsed
        {
            get
            {
                return this as GroupNameAlreadyUsed;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is GroupNameInvalid</para>
        /// </summary>
        public bool IsGroupNameInvalid
        {
            get
            {
                return this is GroupNameInvalid;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a GroupNameInvalid, or <c>null</c>.</para>
        /// </summary>
        public GroupNameInvalid AsGroupNameInvalid
        {
            get
            {
                return this as GroupNameInvalid;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// ExternalIdAlreadyInUse</para>
        /// </summary>
        public bool IsExternalIdAlreadyInUse
        {
            get
            {
                return this is ExternalIdAlreadyInUse;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a ExternalIdAlreadyInUse, or <c>null</c>.</para>
        /// </summary>
        public ExternalIdAlreadyInUse AsExternalIdAlreadyInUse
        {
            get
            {
                return this as ExternalIdAlreadyInUse;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// SystemManagedGroupDisallowed</para>
        /// </summary>
        public bool IsSystemManagedGroupDisallowed
        {
            get
            {
                return this is SystemManagedGroupDisallowed;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a SystemManagedGroupDisallowed, or <c>null</c>.</para>
        /// </summary>
        public SystemManagedGroupDisallowed AsSystemManagedGroupDisallowed
        {
            get
            {
                return this as SystemManagedGroupDisallowed;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupUpdateError" />.</para>
        /// </summary>
        private class GroupUpdateErrorEncoder : enc.StructEncoder<GroupUpdateError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupUpdateError value, enc.IJsonWriter writer)
            {
                if (value is GroupNameAlreadyUsed)
                {
                    WriteProperty(".tag", "group_name_already_used", writer, enc.StringEncoder.Instance);
                    GroupNameAlreadyUsed.Encoder.EncodeFields((GroupNameAlreadyUsed)value, writer);
                    return;
                }
                if (value is GroupNameInvalid)
                {
                    WriteProperty(".tag", "group_name_invalid", writer, enc.StringEncoder.Instance);
                    GroupNameInvalid.Encoder.EncodeFields((GroupNameInvalid)value, writer);
                    return;
                }
                if (value is ExternalIdAlreadyInUse)
                {
                    WriteProperty(".tag", "external_id_already_in_use", writer, enc.StringEncoder.Instance);
                    ExternalIdAlreadyInUse.Encoder.EncodeFields((ExternalIdAlreadyInUse)value, writer);
                    return;
                }
                if (value is SystemManagedGroupDisallowed)
                {
                    WriteProperty(".tag", "system_managed_group_disallowed", writer, enc.StringEncoder.Instance);
                    SystemManagedGroupDisallowed.Encoder.EncodeFields((SystemManagedGroupDisallowed)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupUpdateError" />.</para>
        /// </summary>
        private class GroupUpdateErrorDecoder : enc.UnionDecoder<GroupUpdateError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupUpdateError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupUpdateError Create()
            {
                return new GroupUpdateError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override GroupUpdateError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "group_name_already_used":
                        return GroupNameAlreadyUsed.Decoder.DecodeFields(reader);
                    case "group_name_invalid":
                        return GroupNameInvalid.Decoder.DecodeFields(reader);
                    case "external_id_already_in_use":
                        return ExternalIdAlreadyInUse.Decoder.DecodeFields(reader);
                    case "system_managed_group_disallowed":
                        return SystemManagedGroupDisallowed.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The requested group name is already being used by another group.</para>
        /// </summary>
        public sealed class GroupNameAlreadyUsed : GroupUpdateError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<GroupNameAlreadyUsed> Encoder = new GroupNameAlreadyUsedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<GroupNameAlreadyUsed> Decoder = new GroupNameAlreadyUsedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="GroupNameAlreadyUsed" />
            /// class.</para>
            /// </summary>
            private GroupNameAlreadyUsed()
            {
            }

            /// <summary>
            /// <para>A singleton instance of GroupNameAlreadyUsed</para>
            /// </summary>
            public static readonly GroupNameAlreadyUsed Instance = new GroupNameAlreadyUsed();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="GroupNameAlreadyUsed" />.</para>
            /// </summary>
            private class GroupNameAlreadyUsedEncoder : enc.StructEncoder<GroupNameAlreadyUsed>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(GroupNameAlreadyUsed value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="GroupNameAlreadyUsed" />.</para>
            /// </summary>
            private class GroupNameAlreadyUsedDecoder : enc.StructDecoder<GroupNameAlreadyUsed>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="GroupNameAlreadyUsed"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override GroupNameAlreadyUsed Create()
                {
                    return new GroupNameAlreadyUsed();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override GroupNameAlreadyUsed DecodeFields(enc.IJsonReader reader)
                {
                    return GroupNameAlreadyUsed.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Group name is empty or has invalid characters.</para>
        /// </summary>
        public sealed class GroupNameInvalid : GroupUpdateError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<GroupNameInvalid> Encoder = new GroupNameInvalidEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<GroupNameInvalid> Decoder = new GroupNameInvalidDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="GroupNameInvalid" />
            /// class.</para>
            /// </summary>
            private GroupNameInvalid()
            {
            }

            /// <summary>
            /// <para>A singleton instance of GroupNameInvalid</para>
            /// </summary>
            public static readonly GroupNameInvalid Instance = new GroupNameInvalid();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="GroupNameInvalid" />.</para>
            /// </summary>
            private class GroupNameInvalidEncoder : enc.StructEncoder<GroupNameInvalid>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(GroupNameInvalid value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="GroupNameInvalid" />.</para>
            /// </summary>
            private class GroupNameInvalidDecoder : enc.StructDecoder<GroupNameInvalid>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="GroupNameInvalid" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override GroupNameInvalid Create()
                {
                    return new GroupNameInvalid();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override GroupNameInvalid DecodeFields(enc.IJsonReader reader)
                {
                    return GroupNameInvalid.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The requested external ID is already being used by another group.</para>
        /// </summary>
        public sealed class ExternalIdAlreadyInUse : GroupUpdateError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<ExternalIdAlreadyInUse> Encoder = new ExternalIdAlreadyInUseEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<ExternalIdAlreadyInUse> Decoder = new ExternalIdAlreadyInUseDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="ExternalIdAlreadyInUse" />
            /// class.</para>
            /// </summary>
            private ExternalIdAlreadyInUse()
            {
            }

            /// <summary>
            /// <para>A singleton instance of ExternalIdAlreadyInUse</para>
            /// </summary>
            public static readonly ExternalIdAlreadyInUse Instance = new ExternalIdAlreadyInUse();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="ExternalIdAlreadyInUse" />.</para>
            /// </summary>
            private class ExternalIdAlreadyInUseEncoder : enc.StructEncoder<ExternalIdAlreadyInUse>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(ExternalIdAlreadyInUse value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="ExternalIdAlreadyInUse" />.</para>
            /// </summary>
            private class ExternalIdAlreadyInUseDecoder : enc.StructDecoder<ExternalIdAlreadyInUse>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="ExternalIdAlreadyInUse"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override ExternalIdAlreadyInUse Create()
                {
                    return new ExternalIdAlreadyInUse();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override ExternalIdAlreadyInUse DecodeFields(enc.IJsonReader reader)
                {
                    return ExternalIdAlreadyInUse.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>This operation is not supported on system-managed groups.</para>
        /// </summary>
        public sealed class SystemManagedGroupDisallowed : GroupUpdateError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<SystemManagedGroupDisallowed> Encoder = new SystemManagedGroupDisallowedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<SystemManagedGroupDisallowed> Decoder = new SystemManagedGroupDisallowedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see
            /// cref="SystemManagedGroupDisallowed" /> class.</para>
            /// </summary>
            private SystemManagedGroupDisallowed()
            {
            }

            /// <summary>
            /// <para>A singleton instance of SystemManagedGroupDisallowed</para>
            /// </summary>
            public static readonly SystemManagedGroupDisallowed Instance = new SystemManagedGroupDisallowed();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="SystemManagedGroupDisallowed" />.</para>
            /// </summary>
            private class SystemManagedGroupDisallowedEncoder : enc.StructEncoder<SystemManagedGroupDisallowed>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(SystemManagedGroupDisallowed value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="SystemManagedGroupDisallowed" />.</para>
            /// </summary>
            private class SystemManagedGroupDisallowedDecoder : enc.StructDecoder<SystemManagedGroupDisallowed>
            {
                /// <summary>
                /// <para>Create a new instance of type <see
                /// cref="SystemManagedGroupDisallowed" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override SystemManagedGroupDisallowed Create()
                {
                    return new SystemManagedGroupDisallowed();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override SystemManagedGroupDisallowed DecodeFields(enc.IJsonReader reader)
                {
                    return SystemManagedGroupDisallowed.Instance;
                }
            }

            #endregion
        }
    }
}
