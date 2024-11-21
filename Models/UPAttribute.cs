// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class UPAttribute : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The annotations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttribute_annotations? Annotations { get; set; }
#nullable restore
#else
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttribute_annotations Annotations { get; set; }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The group property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Group { get; set; }
#nullable restore
#else
        public string Group { get; set; }
#endif
        /// <summary>The multivalued property</summary>
        public bool? Multivalued { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The permissions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttributePermissions? Permissions { get; set; }
#nullable restore
#else
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttributePermissions Permissions { get; set; }
#endif
        /// <summary>The required property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttributeRequired? Required { get; set; }
#nullable restore
#else
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttributeRequired Required { get; set; }
#endif
        /// <summary>The selector property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttributeSelector? Selector { get; set; }
#nullable restore
#else
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttributeSelector Selector { get; set; }
#endif
        /// <summary>The validations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttribute_validations? Validations { get; set; }
#nullable restore
#else
        public global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttribute_validations Validations { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttribute"/> and sets the default values.
        /// </summary>
        public UPAttribute()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttribute"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttribute CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttribute();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "annotations", n => { Annotations = n.GetObjectValue<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttribute_annotations>(global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttribute_annotations.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "group", n => { Group = n.GetStringValue(); } },
                { "multivalued", n => { Multivalued = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "permissions", n => { Permissions = n.GetObjectValue<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttributePermissions>(global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttributePermissions.CreateFromDiscriminatorValue); } },
                { "required", n => { Required = n.GetObjectValue<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttributeRequired>(global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttributeRequired.CreateFromDiscriminatorValue); } },
                { "selector", n => { Selector = n.GetObjectValue<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttributeSelector>(global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttributeSelector.CreateFromDiscriminatorValue); } },
                { "validations", n => { Validations = n.GetObjectValue<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttribute_validations>(global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttribute_validations.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttribute_annotations>("annotations", Annotations);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("group", Group);
            writer.WriteBoolValue("multivalued", Multivalued);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttributePermissions>("permissions", Permissions);
            writer.WriteObjectValue<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttributeRequired>("required", Required);
            writer.WriteObjectValue<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttributeSelector>("selector", Selector);
            writer.WriteObjectValue<global::Keycloak.AuthServices.Sdk.Kiota.Admin.Models.UPAttribute_validations>("validations", Validations);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618