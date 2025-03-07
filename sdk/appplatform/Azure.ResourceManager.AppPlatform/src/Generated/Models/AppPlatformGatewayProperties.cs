// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Spring Cloud Gateway properties payload. </summary>
    public partial class AppPlatformGatewayProperties
    {
        /// <summary> Initializes a new instance of AppPlatformGatewayProperties. </summary>
        public AppPlatformGatewayProperties()
        {
            Instances = new ChangeTrackingList<AppPlatformGatewayInstance>();
        }

        /// <summary> Initializes a new instance of AppPlatformGatewayProperties. </summary>
        /// <param name="provisioningState"> State of the Spring Cloud Gateway. </param>
        /// <param name="isPublic"> Indicates whether the Spring Cloud Gateway exposes endpoint. </param>
        /// <param name="uri"> URL of the Spring Cloud Gateway, exposed when &apos;public&apos; is true. </param>
        /// <param name="isHttpsOnly"> Indicate if only https is allowed. </param>
        /// <param name="ssoProperties"> Single sign-on related configuration. </param>
        /// <param name="apiMetadataProperties"> API metadata property for Spring Cloud Gateway. </param>
        /// <param name="corsProperties"> Cross-Origin Resource Sharing property. </param>
        /// <param name="resourceRequests"> The requested resource quantity for required CPU and Memory. </param>
        /// <param name="instances"> Collection of instances belong to Spring Cloud Gateway. </param>
        /// <param name="operatorProperties"> Properties of the Spring Cloud Gateway Operator. </param>
        internal AppPlatformGatewayProperties(AppPlatformGatewayProvisioningState? provisioningState, bool? isPublic, Uri uri, bool? isHttpsOnly, AppPlatformSsoProperties ssoProperties, AppPlatformGatewayApiMetadataProperties apiMetadataProperties, AppPlatformGatewayCorsProperties corsProperties, AppPlatformGatewayResourceRequirements resourceRequests, IReadOnlyList<AppPlatformGatewayInstance> instances, AppPlatformGatewayOperatorProperties operatorProperties)
        {
            ProvisioningState = provisioningState;
            IsPublic = isPublic;
            Uri = uri;
            IsHttpsOnly = isHttpsOnly;
            SsoProperties = ssoProperties;
            ApiMetadataProperties = apiMetadataProperties;
            CorsProperties = corsProperties;
            ResourceRequests = resourceRequests;
            Instances = instances;
            OperatorProperties = operatorProperties;
        }

        /// <summary> State of the Spring Cloud Gateway. </summary>
        public AppPlatformGatewayProvisioningState? ProvisioningState { get; }
        /// <summary> Indicates whether the Spring Cloud Gateway exposes endpoint. </summary>
        public bool? IsPublic { get; set; }
        /// <summary> URL of the Spring Cloud Gateway, exposed when &apos;public&apos; is true. </summary>
        public Uri Uri { get; }
        /// <summary> Indicate if only https is allowed. </summary>
        public bool? IsHttpsOnly { get; set; }
        /// <summary> Single sign-on related configuration. </summary>
        public AppPlatformSsoProperties SsoProperties { get; set; }
        /// <summary> API metadata property for Spring Cloud Gateway. </summary>
        public AppPlatformGatewayApiMetadataProperties ApiMetadataProperties { get; set; }
        /// <summary> Cross-Origin Resource Sharing property. </summary>
        public AppPlatformGatewayCorsProperties CorsProperties { get; set; }
        /// <summary> The requested resource quantity for required CPU and Memory. </summary>
        public AppPlatformGatewayResourceRequirements ResourceRequests { get; set; }
        /// <summary> Collection of instances belong to Spring Cloud Gateway. </summary>
        public IReadOnlyList<AppPlatformGatewayInstance> Instances { get; }
        /// <summary> Properties of the Spring Cloud Gateway Operator. </summary>
        public AppPlatformGatewayOperatorProperties OperatorProperties { get; }
    }
}
