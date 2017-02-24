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
    /// <para>The doc lookup error object</para>
    /// </summary>
    public class DocLookupError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DocLookupError> Encoder = new DocLookupErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DocLookupError> Decoder = new DocLookupErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DocLookupError" /> class.</para>
        /// </summary>
        public DocLookupError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is DocNotFound</para>
        /// </summary>
        public bool IsDocNotFound
        {
            get
            {
                return this is DocNotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a DocNotFound, or <c>null</c>.</para>
        /// </summary>
        public DocNotFound AsDocNotFound
        {
            get
            {
                return this as DocNotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// InsufficientPermissions</para>
        /// </summary>
        public bool IsInsufficientPermissions
        {
            get
            {
                return this is InsufficientPermissions;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InsufficientPermissions, or <c>null</c>.</para>
        /// </summary>
        public InsufficientPermissions AsInsufficientPermissions
        {
            get
            {
                return this as InsufficientPermissions;
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
        /// <para>Encoder for  <see cref="DocLookupError" />.</para>
        /// </summary>
        private class DocLookupErrorEncoder : enc.StructEncoder<DocLookupError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DocLookupError value, enc.IJsonWriter writer)
            {
                if (value is DocNotFound)
                {
                    WriteProperty(".tag", "doc_not_found", writer, enc.StringEncoder.Instance);
                    DocNotFound.Encoder.EncodeFields((DocNotFound)value, writer);
                    return;
                }
                if (value is InsufficientPermissions)
                {
                    WriteProperty(".tag", "insufficient_permissions", writer, enc.StringEncoder.Instance);
                    InsufficientPermissions.Encoder.EncodeFields((InsufficientPermissions)value, writer);
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
        /// <para>Decoder for  <see cref="DocLookupError" />.</para>
        /// </summary>
        private class DocLookupErrorDecoder : enc.UnionDecoder<DocLookupError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="DocLookupError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DocLookupError Create()
            {
                return new DocLookupError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override DocLookupError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "doc_not_found":
                        return DocNotFound.Decoder.DecodeFields(reader);
                    case "insufficient_permissions":
                        return InsufficientPermissions.Decoder.DecodeFields(reader);
                    case "other":
                        return Other.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The required doc was not found.</para>
        /// </summary>
        public sealed class DocNotFound : DocLookupError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<DocNotFound> Encoder = new DocNotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<DocNotFound> Decoder = new DocNotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="DocNotFound" />
            /// class.</para>
            /// </summary>
            private DocNotFound()
            {
            }

            /// <summary>
            /// <para>A singleton instance of DocNotFound</para>
            /// </summary>
            public static readonly DocNotFound Instance = new DocNotFound();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="DocNotFound" />.</para>
            /// </summary>
            private class DocNotFoundEncoder : enc.StructEncoder<DocNotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(DocNotFound value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="DocNotFound" />.</para>
            /// </summary>
            private class DocNotFoundDecoder : enc.StructDecoder<DocNotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="DocNotFound" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override DocNotFound Create()
                {
                    return new DocNotFound();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override DocNotFound DecodeFields(enc.IJsonReader reader)
                {
                    return DocNotFound.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Your account does not have permissions to perform this action.</para>
        /// </summary>
        public sealed class InsufficientPermissions : DocLookupError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InsufficientPermissions> Encoder = new InsufficientPermissionsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InsufficientPermissions> Decoder = new InsufficientPermissionsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InsufficientPermissions" />
            /// class.</para>
            /// </summary>
            private InsufficientPermissions()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InsufficientPermissions</para>
            /// </summary>
            public static readonly InsufficientPermissions Instance = new InsufficientPermissions();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InsufficientPermissions" />.</para>
            /// </summary>
            private class InsufficientPermissionsEncoder : enc.StructEncoder<InsufficientPermissions>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InsufficientPermissions value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InsufficientPermissions" />.</para>
            /// </summary>
            private class InsufficientPermissionsDecoder : enc.StructDecoder<InsufficientPermissions>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InsufficientPermissions"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InsufficientPermissions Create()
                {
                    return new InsufficientPermissions();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override InsufficientPermissions DecodeFields(enc.IJsonReader reader)
                {
                    return InsufficientPermissions.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : DocLookupError
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
