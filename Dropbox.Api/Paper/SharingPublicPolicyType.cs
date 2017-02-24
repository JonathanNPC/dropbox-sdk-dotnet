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
    /// <para>The sharing public policy type object</para>
    /// </summary>
    public class SharingPublicPolicyType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharingPublicPolicyType> Encoder = new SharingPublicPolicyTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharingPublicPolicyType> Decoder = new SharingPublicPolicyTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharingPublicPolicyType" />
        /// class.</para>
        /// </summary>
        public SharingPublicPolicyType()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Disabled</para>
        /// </summary>
        public bool IsDisabled
        {
            get
            {
                return this is Disabled;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Disabled, or <c>null</c>.</para>
        /// </summary>
        public Disabled AsDisabled
        {
            get
            {
                return this as Disabled;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is PeopleWithLinkCanEdit</para>
        /// </summary>
        public bool IsPeopleWithLinkCanEdit
        {
            get
            {
                return this is PeopleWithLinkCanEdit;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a PeopleWithLinkCanEdit, or <c>null</c>.</para>
        /// </summary>
        public PeopleWithLinkCanEdit AsPeopleWithLinkCanEdit
        {
            get
            {
                return this as PeopleWithLinkCanEdit;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// PeopleWithLinkCanViewAndComment</para>
        /// </summary>
        public bool IsPeopleWithLinkCanViewAndComment
        {
            get
            {
                return this is PeopleWithLinkCanViewAndComment;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a PeopleWithLinkCanViewAndComment, or
        /// <c>null</c>.</para>
        /// </summary>
        public PeopleWithLinkCanViewAndComment AsPeopleWithLinkCanViewAndComment
        {
            get
            {
                return this as PeopleWithLinkCanViewAndComment;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InviteOnly</para>
        /// </summary>
        public bool IsInviteOnly
        {
            get
            {
                return this is InviteOnly;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InviteOnly, or <c>null</c>.</para>
        /// </summary>
        public InviteOnly AsInviteOnly
        {
            get
            {
                return this as InviteOnly;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharingPublicPolicyType" />.</para>
        /// </summary>
        private class SharingPublicPolicyTypeEncoder : enc.StructEncoder<SharingPublicPolicyType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharingPublicPolicyType value, enc.IJsonWriter writer)
            {
                if (value is Disabled)
                {
                    WriteProperty(".tag", "disabled", writer, enc.StringEncoder.Instance);
                    Disabled.Encoder.EncodeFields((Disabled)value, writer);
                    return;
                }
                if (value is PeopleWithLinkCanEdit)
                {
                    WriteProperty(".tag", "people_with_link_can_edit", writer, enc.StringEncoder.Instance);
                    PeopleWithLinkCanEdit.Encoder.EncodeFields((PeopleWithLinkCanEdit)value, writer);
                    return;
                }
                if (value is PeopleWithLinkCanViewAndComment)
                {
                    WriteProperty(".tag", "people_with_link_can_view_and_comment", writer, enc.StringEncoder.Instance);
                    PeopleWithLinkCanViewAndComment.Encoder.EncodeFields((PeopleWithLinkCanViewAndComment)value, writer);
                    return;
                }
                if (value is InviteOnly)
                {
                    WriteProperty(".tag", "invite_only", writer, enc.StringEncoder.Instance);
                    InviteOnly.Encoder.EncodeFields((InviteOnly)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharingPublicPolicyType" />.</para>
        /// </summary>
        private class SharingPublicPolicyTypeDecoder : enc.UnionDecoder<SharingPublicPolicyType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharingPublicPolicyType"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharingPublicPolicyType Create()
            {
                return new SharingPublicPolicyType();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override SharingPublicPolicyType Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "disabled":
                        return Disabled.Decoder.DecodeFields(reader);
                    case "people_with_link_can_edit":
                        return PeopleWithLinkCanEdit.Decoder.DecodeFields(reader);
                    case "people_with_link_can_view_and_comment":
                        return PeopleWithLinkCanViewAndComment.Decoder.DecodeFields(reader);
                    case "invite_only":
                        return InviteOnly.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Value used to indicate that doc sharing is enabled only within team.</para>
        /// </summary>
        public sealed class Disabled : SharingPublicPolicyType
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Disabled> Encoder = new DisabledEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Disabled> Decoder = new DisabledDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Disabled" /> class.</para>
            /// </summary>
            private Disabled()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Disabled</para>
            /// </summary>
            public static readonly Disabled Instance = new Disabled();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Disabled" />.</para>
            /// </summary>
            private class DisabledEncoder : enc.StructEncoder<Disabled>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Disabled value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Disabled" />.</para>
            /// </summary>
            private class DisabledDecoder : enc.StructDecoder<Disabled>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Disabled" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Disabled Create()
                {
                    return new Disabled();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Disabled DecodeFields(enc.IJsonReader reader)
                {
                    return Disabled.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Users who have a link to this doc can edit it.</para>
        /// </summary>
        public sealed class PeopleWithLinkCanEdit : SharingPublicPolicyType
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<PeopleWithLinkCanEdit> Encoder = new PeopleWithLinkCanEditEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<PeopleWithLinkCanEdit> Decoder = new PeopleWithLinkCanEditDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PeopleWithLinkCanEdit" />
            /// class.</para>
            /// </summary>
            private PeopleWithLinkCanEdit()
            {
            }

            /// <summary>
            /// <para>A singleton instance of PeopleWithLinkCanEdit</para>
            /// </summary>
            public static readonly PeopleWithLinkCanEdit Instance = new PeopleWithLinkCanEdit();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="PeopleWithLinkCanEdit" />.</para>
            /// </summary>
            private class PeopleWithLinkCanEditEncoder : enc.StructEncoder<PeopleWithLinkCanEdit>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(PeopleWithLinkCanEdit value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="PeopleWithLinkCanEdit" />.</para>
            /// </summary>
            private class PeopleWithLinkCanEditDecoder : enc.StructDecoder<PeopleWithLinkCanEdit>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="PeopleWithLinkCanEdit"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override PeopleWithLinkCanEdit Create()
                {
                    return new PeopleWithLinkCanEdit();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override PeopleWithLinkCanEdit DecodeFields(enc.IJsonReader reader)
                {
                    return PeopleWithLinkCanEdit.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Users who have a link to this doc can view and comment on it.</para>
        /// </summary>
        public sealed class PeopleWithLinkCanViewAndComment : SharingPublicPolicyType
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<PeopleWithLinkCanViewAndComment> Encoder = new PeopleWithLinkCanViewAndCommentEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<PeopleWithLinkCanViewAndComment> Decoder = new PeopleWithLinkCanViewAndCommentDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see
            /// cref="PeopleWithLinkCanViewAndComment" /> class.</para>
            /// </summary>
            private PeopleWithLinkCanViewAndComment()
            {
            }

            /// <summary>
            /// <para>A singleton instance of PeopleWithLinkCanViewAndComment</para>
            /// </summary>
            public static readonly PeopleWithLinkCanViewAndComment Instance = new PeopleWithLinkCanViewAndComment();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="PeopleWithLinkCanViewAndComment" />.</para>
            /// </summary>
            private class PeopleWithLinkCanViewAndCommentEncoder : enc.StructEncoder<PeopleWithLinkCanViewAndComment>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(PeopleWithLinkCanViewAndComment value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="PeopleWithLinkCanViewAndComment" />.</para>
            /// </summary>
            private class PeopleWithLinkCanViewAndCommentDecoder : enc.StructDecoder<PeopleWithLinkCanViewAndComment>
            {
                /// <summary>
                /// <para>Create a new instance of type <see
                /// cref="PeopleWithLinkCanViewAndComment" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override PeopleWithLinkCanViewAndComment Create()
                {
                    return new PeopleWithLinkCanViewAndComment();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override PeopleWithLinkCanViewAndComment DecodeFields(enc.IJsonReader reader)
                {
                    return PeopleWithLinkCanViewAndComment.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Users must be explicitly invited to this doc.</para>
        /// </summary>
        public sealed class InviteOnly : SharingPublicPolicyType
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InviteOnly> Encoder = new InviteOnlyEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InviteOnly> Decoder = new InviteOnlyDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InviteOnly" /> class.</para>
            /// </summary>
            private InviteOnly()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InviteOnly</para>
            /// </summary>
            public static readonly InviteOnly Instance = new InviteOnly();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InviteOnly" />.</para>
            /// </summary>
            private class InviteOnlyEncoder : enc.StructEncoder<InviteOnly>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InviteOnly value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InviteOnly" />.</para>
            /// </summary>
            private class InviteOnlyDecoder : enc.StructDecoder<InviteOnly>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InviteOnly" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InviteOnly Create()
                {
                    return new InviteOnly();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override InviteOnly DecodeFields(enc.IJsonReader reader)
                {
                    return InviteOnly.Instance;
                }
            }

            #endregion
        }
    }
}
