// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Paper
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The paper api cursor error object</para>
    /// </summary>
    public class PaperApiCursorError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PaperApiCursorError> Encoder = new PaperApiCursorErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PaperApiCursorError> Decoder = new PaperApiCursorErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PaperApiCursorError" />
        /// class.</para>
        /// </summary>
        public PaperApiCursorError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is ExpiredCursor</para>
        /// </summary>
        public bool IsExpiredCursor
        {
            get
            {
                return this is ExpiredCursor;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a ExpiredCursor, or <c>null</c>.</para>
        /// </summary>
        public ExpiredCursor AsExpiredCursor
        {
            get
            {
                return this as ExpiredCursor;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InvalidCursor</para>
        /// </summary>
        public bool IsInvalidCursor
        {
            get
            {
                return this is InvalidCursor;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InvalidCursor, or <c>null</c>.</para>
        /// </summary>
        public InvalidCursor AsInvalidCursor
        {
            get
            {
                return this as InvalidCursor;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is WrongUserInCursor</para>
        /// </summary>
        public bool IsWrongUserInCursor
        {
            get
            {
                return this is WrongUserInCursor;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a WrongUserInCursor, or <c>null</c>.</para>
        /// </summary>
        public WrongUserInCursor AsWrongUserInCursor
        {
            get
            {
                return this as WrongUserInCursor;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Reset</para>
        /// </summary>
        public bool IsReset
        {
            get
            {
                return this is Reset;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Reset, or <c>null</c>.</para>
        /// </summary>
        public Reset AsReset
        {
            get
            {
                return this as Reset;
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
        /// <para>Encoder for  <see cref="PaperApiCursorError" />.</para>
        /// </summary>
        private class PaperApiCursorErrorEncoder : enc.StructEncoder<PaperApiCursorError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PaperApiCursorError value, enc.IJsonWriter writer)
            {
                if (value is ExpiredCursor)
                {
                    WriteProperty(".tag", "expired_cursor", writer, enc.StringEncoder.Instance);
                    ExpiredCursor.Encoder.EncodeFields((ExpiredCursor)value, writer);
                    return;
                }
                if (value is InvalidCursor)
                {
                    WriteProperty(".tag", "invalid_cursor", writer, enc.StringEncoder.Instance);
                    InvalidCursor.Encoder.EncodeFields((InvalidCursor)value, writer);
                    return;
                }
                if (value is WrongUserInCursor)
                {
                    WriteProperty(".tag", "wrong_user_in_cursor", writer, enc.StringEncoder.Instance);
                    WrongUserInCursor.Encoder.EncodeFields((WrongUserInCursor)value, writer);
                    return;
                }
                if (value is Reset)
                {
                    WriteProperty(".tag", "reset", writer, enc.StringEncoder.Instance);
                    Reset.Encoder.EncodeFields((Reset)value, writer);
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
        /// <para>Decoder for  <see cref="PaperApiCursorError" />.</para>
        /// </summary>
        private class PaperApiCursorErrorDecoder : enc.UnionDecoder<PaperApiCursorError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PaperApiCursorError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PaperApiCursorError Create()
            {
                return new PaperApiCursorError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override PaperApiCursorError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "expired_cursor":
                        return ExpiredCursor.Decoder.DecodeFields(reader);
                    case "invalid_cursor":
                        return InvalidCursor.Decoder.DecodeFields(reader);
                    case "wrong_user_in_cursor":
                        return WrongUserInCursor.Decoder.DecodeFields(reader);
                    case "reset":
                        return Reset.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The provided cursor is expired.</para>
        /// </summary>
        public sealed class ExpiredCursor : PaperApiCursorError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<ExpiredCursor> Encoder = new ExpiredCursorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<ExpiredCursor> Decoder = new ExpiredCursorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="ExpiredCursor" />
            /// class.</para>
            /// </summary>
            private ExpiredCursor()
            {
            }

            /// <summary>
            /// <para>A singleton instance of ExpiredCursor</para>
            /// </summary>
            public static readonly ExpiredCursor Instance = new ExpiredCursor();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="ExpiredCursor" />.</para>
            /// </summary>
            private class ExpiredCursorEncoder : enc.StructEncoder<ExpiredCursor>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(ExpiredCursor value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="ExpiredCursor" />.</para>
            /// </summary>
            private class ExpiredCursorDecoder : enc.StructDecoder<ExpiredCursor>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="ExpiredCursor" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override ExpiredCursor Create()
                {
                    return new ExpiredCursor();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override ExpiredCursor DecodeFields(enc.IJsonReader reader)
                {
                    return ExpiredCursor.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The provided cursor is invalid.</para>
        /// </summary>
        public sealed class InvalidCursor : PaperApiCursorError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InvalidCursor> Encoder = new InvalidCursorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InvalidCursor> Decoder = new InvalidCursorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvalidCursor" />
            /// class.</para>
            /// </summary>
            private InvalidCursor()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InvalidCursor</para>
            /// </summary>
            public static readonly InvalidCursor Instance = new InvalidCursor();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InvalidCursor" />.</para>
            /// </summary>
            private class InvalidCursorEncoder : enc.StructEncoder<InvalidCursor>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InvalidCursor value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InvalidCursor" />.</para>
            /// </summary>
            private class InvalidCursorDecoder : enc.StructDecoder<InvalidCursor>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InvalidCursor" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InvalidCursor Create()
                {
                    return new InvalidCursor();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override InvalidCursor DecodeFields(enc.IJsonReader reader)
                {
                    return InvalidCursor.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The provided cursor contains invalid user.</para>
        /// </summary>
        public sealed class WrongUserInCursor : PaperApiCursorError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<WrongUserInCursor> Encoder = new WrongUserInCursorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<WrongUserInCursor> Decoder = new WrongUserInCursorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="WrongUserInCursor" />
            /// class.</para>
            /// </summary>
            private WrongUserInCursor()
            {
            }

            /// <summary>
            /// <para>A singleton instance of WrongUserInCursor</para>
            /// </summary>
            public static readonly WrongUserInCursor Instance = new WrongUserInCursor();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="WrongUserInCursor" />.</para>
            /// </summary>
            private class WrongUserInCursorEncoder : enc.StructEncoder<WrongUserInCursor>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(WrongUserInCursor value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="WrongUserInCursor" />.</para>
            /// </summary>
            private class WrongUserInCursorDecoder : enc.StructDecoder<WrongUserInCursor>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="WrongUserInCursor"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override WrongUserInCursor Create()
                {
                    return new WrongUserInCursor();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override WrongUserInCursor DecodeFields(enc.IJsonReader reader)
                {
                    return WrongUserInCursor.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Indicates that the cursor has been invalidated. Call the corresponding
        /// non-continue endpoint to obtain a new cursor.</para>
        /// </summary>
        public sealed class Reset : PaperApiCursorError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Reset> Encoder = new ResetEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Reset> Decoder = new ResetDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Reset" /> class.</para>
            /// </summary>
            private Reset()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Reset</para>
            /// </summary>
            public static readonly Reset Instance = new Reset();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Reset" />.</para>
            /// </summary>
            private class ResetEncoder : enc.StructEncoder<Reset>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Reset value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Reset" />.</para>
            /// </summary>
            private class ResetDecoder : enc.StructDecoder<Reset>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Reset" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Reset Create()
                {
                    return new Reset();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Reset DecodeFields(enc.IJsonReader reader)
                {
                    return Reset.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : PaperApiCursorError
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
