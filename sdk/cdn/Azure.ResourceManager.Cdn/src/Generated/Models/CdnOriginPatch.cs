// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Origin properties needed for origin update. </summary>
    public partial class CdnOriginPatch
    {
        /// <summary> Initializes a new instance of CdnOriginPatch. </summary>
        public CdnOriginPatch()
        {
        }

        /// <summary> The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across all origins in an endpoint. </summary>
        public string HostName { get; set; }
        /// <summary> The value of the HTTP port. Must be between 1 and 65535. </summary>
        public int? HttpPort { get; set; }
        /// <summary> The value of the HTTPS port. Must be between 1 and 65535. </summary>
        public int? HttpsPort { get; set; }
        /// <summary> The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default. This overrides the host header defined at Endpoint. </summary>
        public string OriginHostHeader { get; set; }
        /// <summary> Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if any lower priority origin is healthy.Must be between 1 and 5. </summary>
        public int? Priority { get; set; }
        /// <summary> Weight of the origin in given origin group for load balancing. Must be between 1 and 1000. </summary>
        public int? Weight { get; set; }
        /// <summary> Origin is enabled for load balancing or not. </summary>
        public bool? Enabled { get; set; }
        /// <summary> The Alias of the Private Link resource. Populating this optional field indicates that this origin is 'Private'. </summary>
        public string PrivateLinkAlias { get; set; }
        /// <summary> The Resource Id of the Private Link resource. Populating this optional field indicates that this backend is 'Private'. </summary>
        public ResourceIdentifier PrivateLinkResourceId { get; set; }
        /// <summary> The location of the Private Link resource. Required only if 'privateLinkResourceId' is populated. </summary>
        public string PrivateLinkLocation { get; set; }
        /// <summary> A custom message to be included in the approval request to connect to the Private Link. </summary>
        public string PrivateLinkApprovalMessage { get; set; }
    }
}
