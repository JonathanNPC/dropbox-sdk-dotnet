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
    /// <para>The list docs cursor error object</para>
    /// </summary>
    public class ListDocsCursorError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ListDocsCursorError> Encoder = new ListDocsCursorErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ListDocsCursorError> Decoder = new ListDocsCursorErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListDocsCursorError" />
        /// class.</para>
        /// </summary>
        public ListDocsCursorError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is CursorError</para>
        /// </summary>
        public bool IsCursorError
        {
            get
            {
                return this is CursorError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a CursorError, or <c>null</c>.</para>
        /// </summary>
        public CursorError AsCursorError
        {
            get
            {
                return this as CursorError;
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
        /// <para>Encoder for  <see cref="ListDocsCursorError" />.</para>
        /// </summary>
        private class ListDocsCursorErrorEncoder : enc.StructEncoder<ListDocsCursorError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ListDocsCursorError value, enc.IJsonWriter writer)
            {
                if (value is CursorError)
                {
                    WriteProperty(".tag", "cursor_error", writer, enc.StringEncoder.Instance);
                    CursorError.Encoder.EncodeFields((CursorError)value, writer);
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
        /// <para>Decoder for  <see cref="ListDocsCursorError" />.</para>
        /// </summary>
        private class ListDocsCursorErrorDecoder : enc.UnionDecoder<ListDocsCursorError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ListDocsCursorError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ListDocsCursorError Create()
            {
                return new ListDocsCursorError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override ListDocsCursorError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "cursor_error":
                        return CursorError.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The cursor error object</para>
        /// </summary>
        public sealed class CursorError : ListDocsCursorError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<CursorError> Encoder = new CursorErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<CursorError> Decoder = new CursorErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="CursorError" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public CursorError(PaperApiCursorError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="CursorError" />
            /// class.</para>
            /// </summary>
            private CursorError()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public PaperApiCursorError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="CursorError" />.</para>
            /// </summary>
            private class CursorErrorEncoder : enc.StructEncoder<CursorError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(CursorError value, enc.IJsonWriter writer)
                {
                    Dropbox.Api.Paper.PaperApiCursorError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="CursorError" />.</para>
            /// </summary>
            private class CursorErrorDecoder : enc.StructDecoder<CursorError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="CursorError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override CursorError Create()
                {
                    return new CursorError();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(CursorError value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "cursor_error":
                            value.Value = Dropbox.Api.Paper.PaperApiCursorError.Decoder.Decode(reader);
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
        public sealed class Other : ListDocsCursorError
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
