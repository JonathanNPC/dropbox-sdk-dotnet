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
    /// <para>The team folder archive error object</para>
    /// </summary>
    public class TeamFolderArchiveError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamFolderArchiveError> Encoder = new TeamFolderArchiveErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamFolderArchiveError> Decoder = new TeamFolderArchiveErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamFolderArchiveError" />
        /// class.</para>
        /// </summary>
        public TeamFolderArchiveError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is AccessError</para>
        /// </summary>
        public bool IsAccessError
        {
            get
            {
                return this is AccessError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a AccessError, or <c>null</c>.</para>
        /// </summary>
        public AccessError AsAccessError
        {
            get
            {
                return this as AccessError;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is StatusError</para>
        /// </summary>
        public bool IsStatusError
        {
            get
            {
                return this is StatusError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a StatusError, or <c>null</c>.</para>
        /// </summary>
        public StatusError AsStatusError
        {
            get
            {
                return this as StatusError;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamFolderArchiveError" />.</para>
        /// </summary>
        private class TeamFolderArchiveErrorEncoder : enc.StructEncoder<TeamFolderArchiveError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamFolderArchiveError value, enc.IJsonWriter writer)
            {
                if (value is AccessError)
                {
                    WriteProperty(".tag", "access_error", writer, enc.StringEncoder.Instance);
                    AccessError.Encoder.EncodeFields((AccessError)value, writer);
                    return;
                }
                if (value is StatusError)
                {
                    WriteProperty(".tag", "status_error", writer, enc.StringEncoder.Instance);
                    StatusError.Encoder.EncodeFields((StatusError)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamFolderArchiveError" />.</para>
        /// </summary>
        private class TeamFolderArchiveErrorDecoder : enc.UnionDecoder<TeamFolderArchiveError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TeamFolderArchiveError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamFolderArchiveError Create()
            {
                return new TeamFolderArchiveError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override TeamFolderArchiveError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "access_error":
                        return AccessError.Decoder.DecodeFields(reader);
                    case "status_error":
                        return StatusError.Decoder.DecodeFields(reader);
                    case "other":
                        return Other.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The access error object</para>
        /// </summary>
        public sealed class AccessError : TeamFolderArchiveError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<AccessError> Encoder = new AccessErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<AccessError> Decoder = new AccessErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AccessError" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public AccessError(TeamFolderAccessError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AccessError" />
            /// class.</para>
            /// </summary>
            private AccessError()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public TeamFolderAccessError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="AccessError" />.</para>
            /// </summary>
            private class AccessErrorEncoder : enc.StructEncoder<AccessError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(AccessError value, enc.IJsonWriter writer)
                {
                    Dropbox.Api.Team.TeamFolderAccessError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="AccessError" />.</para>
            /// </summary>
            private class AccessErrorDecoder : enc.StructDecoder<AccessError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="AccessError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override AccessError Create()
                {
                    return new AccessError();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(AccessError value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "access_error":
                            value.Value = Dropbox.Api.Team.TeamFolderAccessError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The status error object</para>
        /// </summary>
        public sealed class StatusError : TeamFolderArchiveError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<StatusError> Encoder = new StatusErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<StatusError> Decoder = new StatusErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="StatusError" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public StatusError(TeamFolderInvalidStatusError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="StatusError" />
            /// class.</para>
            /// </summary>
            private StatusError()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public TeamFolderInvalidStatusError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="StatusError" />.</para>
            /// </summary>
            private class StatusErrorEncoder : enc.StructEncoder<StatusError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(StatusError value, enc.IJsonWriter writer)
                {
                    Dropbox.Api.Team.TeamFolderInvalidStatusError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="StatusError" />.</para>
            /// </summary>
            private class StatusErrorDecoder : enc.StructDecoder<StatusError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="StatusError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override StatusError Create()
                {
                    return new StatusError();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(StatusError value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "status_error":
                            value.Value = Dropbox.Api.Team.TeamFolderInvalidStatusError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : TeamFolderArchiveError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}
