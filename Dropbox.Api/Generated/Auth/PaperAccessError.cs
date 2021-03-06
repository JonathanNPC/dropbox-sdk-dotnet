// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Auth
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The paper access error object</para>
    /// </summary>
    public class PaperAccessError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PaperAccessError> Encoder = new PaperAccessErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PaperAccessError> Decoder = new PaperAccessErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PaperAccessError" />
        /// class.</para>
        /// </summary>
        public PaperAccessError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is PaperDisabled</para>
        /// </summary>
        public bool IsPaperDisabled
        {
            get
            {
                return this is PaperDisabled;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a PaperDisabled, or <c>null</c>.</para>
        /// </summary>
        public PaperDisabled AsPaperDisabled
        {
            get
            {
                return this as PaperDisabled;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NotPaperUser</para>
        /// </summary>
        public bool IsNotPaperUser
        {
            get
            {
                return this is NotPaperUser;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotPaperUser, or <c>null</c>.</para>
        /// </summary>
        public NotPaperUser AsNotPaperUser
        {
            get
            {
                return this as NotPaperUser;
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
        /// <para>Encoder for  <see cref="PaperAccessError" />.</para>
        /// </summary>
        private class PaperAccessErrorEncoder : enc.StructEncoder<PaperAccessError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PaperAccessError value, enc.IJsonWriter writer)
            {
                if (value is PaperDisabled)
                {
                    WriteProperty(".tag", "paper_disabled", writer, enc.StringEncoder.Instance);
                    PaperDisabled.Encoder.EncodeFields((PaperDisabled)value, writer);
                    return;
                }
                if (value is NotPaperUser)
                {
                    WriteProperty(".tag", "not_paper_user", writer, enc.StringEncoder.Instance);
                    NotPaperUser.Encoder.EncodeFields((NotPaperUser)value, writer);
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
        /// <para>Decoder for  <see cref="PaperAccessError" />.</para>
        /// </summary>
        private class PaperAccessErrorDecoder : enc.UnionDecoder<PaperAccessError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PaperAccessError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PaperAccessError Create()
            {
                return new PaperAccessError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override PaperAccessError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "paper_disabled":
                        return PaperDisabled.Decoder.DecodeFields(reader);
                    case "not_paper_user":
                        return NotPaperUser.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Paper is disabled.</para>
        /// </summary>
        public sealed class PaperDisabled : PaperAccessError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<PaperDisabled> Encoder = new PaperDisabledEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<PaperDisabled> Decoder = new PaperDisabledDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PaperDisabled" />
            /// class.</para>
            /// </summary>
            private PaperDisabled()
            {
            }

            /// <summary>
            /// <para>A singleton instance of PaperDisabled</para>
            /// </summary>
            public static readonly PaperDisabled Instance = new PaperDisabled();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="PaperDisabled" />.</para>
            /// </summary>
            private class PaperDisabledEncoder : enc.StructEncoder<PaperDisabled>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(PaperDisabled value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="PaperDisabled" />.</para>
            /// </summary>
            private class PaperDisabledDecoder : enc.StructDecoder<PaperDisabled>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="PaperDisabled" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override PaperDisabled Create()
                {
                    return new PaperDisabled();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override PaperDisabled DecodeFields(enc.IJsonReader reader)
                {
                    return PaperDisabled.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The provided user has not used Paper yet.</para>
        /// </summary>
        public sealed class NotPaperUser : PaperAccessError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NotPaperUser> Encoder = new NotPaperUserEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NotPaperUser> Decoder = new NotPaperUserDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotPaperUser" />
            /// class.</para>
            /// </summary>
            private NotPaperUser()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotPaperUser</para>
            /// </summary>
            public static readonly NotPaperUser Instance = new NotPaperUser();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NotPaperUser" />.</para>
            /// </summary>
            private class NotPaperUserEncoder : enc.StructEncoder<NotPaperUser>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NotPaperUser value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NotPaperUser" />.</para>
            /// </summary>
            private class NotPaperUserDecoder : enc.StructDecoder<NotPaperUser>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NotPaperUser" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NotPaperUser Create()
                {
                    return new NotPaperUser();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override NotPaperUser DecodeFields(enc.IJsonReader reader)
                {
                    return NotPaperUser.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : PaperAccessError
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
