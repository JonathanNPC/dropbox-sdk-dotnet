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
    /// <para>The user info with permission level object</para>
    /// </summary>
    public class UserInfoWithPermissionLevel
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UserInfoWithPermissionLevel> Encoder = new UserInfoWithPermissionLevelEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UserInfoWithPermissionLevel> Decoder = new UserInfoWithPermissionLevelDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UserInfoWithPermissionLevel" />
        /// class.</para>
        /// </summary>
        /// <param name="user">User shared on the Paper doc.</param>
        /// <param name="permissionLevel">Permission level for the user.</param>
        public UserInfoWithPermissionLevel(Dropbox.Api.Sharing.UserInfo user,
                                           PaperDocPermissionLevel permissionLevel)
        {
            if (user == null)
            {
                throw new sys.ArgumentNullException("user");
            }

            if (permissionLevel == null)
            {
                throw new sys.ArgumentNullException("permissionLevel");
            }

            this.User = user;
            this.PermissionLevel = permissionLevel;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UserInfoWithPermissionLevel" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public UserInfoWithPermissionLevel()
        {
        }

        /// <summary>
        /// <para>User shared on the Paper doc.</para>
        /// </summary>
        public Dropbox.Api.Sharing.UserInfo User { get; protected set; }

        /// <summary>
        /// <para>Permission level for the user.</para>
        /// </summary>
        public PaperDocPermissionLevel PermissionLevel { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UserInfoWithPermissionLevel" />.</para>
        /// </summary>
        private class UserInfoWithPermissionLevelEncoder : enc.StructEncoder<UserInfoWithPermissionLevel>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UserInfoWithPermissionLevel value, enc.IJsonWriter writer)
            {
                WriteProperty("user", value.User, writer, Dropbox.Api.Sharing.UserInfo.Encoder);
                WriteProperty("permission_level", value.PermissionLevel, writer, Dropbox.Api.Paper.PaperDocPermissionLevel.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UserInfoWithPermissionLevel" />.</para>
        /// </summary>
        private class UserInfoWithPermissionLevelDecoder : enc.StructDecoder<UserInfoWithPermissionLevel>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UserInfoWithPermissionLevel"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UserInfoWithPermissionLevel Create()
            {
                return new UserInfoWithPermissionLevel();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UserInfoWithPermissionLevel value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "user":
                        value.User = Dropbox.Api.Sharing.UserInfo.Decoder.Decode(reader);
                        break;
                    case "permission_level":
                        value.PermissionLevel = Dropbox.Api.Paper.PaperDocPermissionLevel.Decoder.Decode(reader);
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
