// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Who can change a shared folder's access control list (ACL). In other words, who
    /// can add, remove, or change the privileges of members.</para>
    /// </summary>
    public class AclUpdatePolicy
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AclUpdatePolicy> Encoder = new AclUpdatePolicyEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AclUpdatePolicy> Decoder = new AclUpdatePolicyDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AclUpdatePolicy" />
        /// class.</para>
        /// </summary>
        public AclUpdatePolicy()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Owner</para>
        /// </summary>
        public bool IsOwner
        {
            get
            {
                return this is Owner;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Owner, or <c>null</c>.</para>
        /// </summary>
        public Owner AsOwner
        {
            get
            {
                return this as Owner;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Editors</para>
        /// </summary>
        public bool IsEditors
        {
            get
            {
                return this is Editors;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Editors, or <c>null</c>.</para>
        /// </summary>
        public Editors AsEditors
        {
            get
            {
                return this as Editors;
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
        /// <para>Encoder for  <see cref="AclUpdatePolicy" />.</para>
        /// </summary>
        private class AclUpdatePolicyEncoder : enc.StructEncoder<AclUpdatePolicy>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AclUpdatePolicy value, enc.IJsonWriter writer)
            {
                if (value is Owner)
                {
                    WriteProperty(".tag", "owner", writer, enc.StringEncoder.Instance);
                    Owner.Encoder.EncodeFields((Owner)value, writer);
                    return;
                }
                if (value is Editors)
                {
                    WriteProperty(".tag", "editors", writer, enc.StringEncoder.Instance);
                    Editors.Encoder.EncodeFields((Editors)value, writer);
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
        /// <para>Decoder for  <see cref="AclUpdatePolicy" />.</para>
        /// </summary>
        private class AclUpdatePolicyDecoder : enc.UnionDecoder<AclUpdatePolicy>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="AclUpdatePolicy" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AclUpdatePolicy Create()
            {
                return new AclUpdatePolicy();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override AclUpdatePolicy Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "owner":
                        return Owner.Decoder.DecodeFields(reader);
                    case "editors":
                        return Editors.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Only the owner can update the ACL.</para>
        /// </summary>
        public sealed class Owner : AclUpdatePolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Owner> Encoder = new OwnerEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Owner> Decoder = new OwnerDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Owner" /> class.</para>
            /// </summary>
            private Owner()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Owner</para>
            /// </summary>
            public static readonly Owner Instance = new Owner();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Owner" />.</para>
            /// </summary>
            private class OwnerEncoder : enc.StructEncoder<Owner>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Owner value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Owner" />.</para>
            /// </summary>
            private class OwnerDecoder : enc.StructDecoder<Owner>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Owner" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Owner Create()
                {
                    return new Owner();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Owner DecodeFields(enc.IJsonReader reader)
                {
                    return Owner.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Any editor can update the ACL. This may be further restricted to editors on
        /// the same team.</para>
        /// </summary>
        public sealed class Editors : AclUpdatePolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Editors> Encoder = new EditorsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Editors> Decoder = new EditorsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Editors" /> class.</para>
            /// </summary>
            private Editors()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Editors</para>
            /// </summary>
            public static readonly Editors Instance = new Editors();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Editors" />.</para>
            /// </summary>
            private class EditorsEncoder : enc.StructEncoder<Editors>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Editors value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Editors" />.</para>
            /// </summary>
            private class EditorsDecoder : enc.StructDecoder<Editors>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Editors" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Editors Create()
                {
                    return new Editors();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Editors DecodeFields(enc.IJsonReader reader)
                {
                    return Editors.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : AclUpdatePolicy
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
