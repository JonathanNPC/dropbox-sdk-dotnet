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
    /// <para>Permissions for actions that can be performed on a link.</para>
    /// </summary>
    public class LinkPermission
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LinkPermission> Encoder = new LinkPermissionEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LinkPermission> Decoder = new LinkPermissionDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LinkPermission" /> class.</para>
        /// </summary>
        /// <param name="action">The action</param>
        /// <param name="allow">The allow</param>
        /// <param name="reason">The reason</param>
        public LinkPermission(LinkAction action,
                              bool allow,
                              PermissionDeniedReason reason = null)
        {
            if (action == null)
            {
                throw new sys.ArgumentNullException("action");
            }

            this.Action = action;
            this.Allow = allow;
            this.Reason = reason;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LinkPermission" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public LinkPermission()
        {
        }

        /// <summary>
        /// <para>Gets the action of the link permission</para>
        /// </summary>
        public LinkAction Action { get; protected set; }

        /// <summary>
        /// <para>Gets the allow of the link permission</para>
        /// </summary>
        public bool Allow { get; protected set; }

        /// <summary>
        /// <para>Gets the reason of the link permission</para>
        /// </summary>
        public PermissionDeniedReason Reason { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="LinkPermission" />.</para>
        /// </summary>
        private class LinkPermissionEncoder : enc.StructEncoder<LinkPermission>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LinkPermission value, enc.IJsonWriter writer)
            {
                WriteProperty("action", value.Action, writer, Dropbox.Api.Sharing.LinkAction.Encoder);
                WriteProperty("allow", value.Allow, writer, enc.BooleanEncoder.Instance);
                if (value.Reason != null)
                {
                    WriteProperty("reason", value.Reason, writer, Dropbox.Api.Sharing.PermissionDeniedReason.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="LinkPermission" />.</para>
        /// </summary>
        private class LinkPermissionDecoder : enc.StructDecoder<LinkPermission>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="LinkPermission" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LinkPermission Create()
            {
                return new LinkPermission();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(LinkPermission value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "action":
                        value.Action = Dropbox.Api.Sharing.LinkAction.Decoder.Decode(reader);
                        break;
                    case "allow":
                        value.Allow = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "reason":
                        value.Reason = Dropbox.Api.Sharing.PermissionDeniedReason.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
