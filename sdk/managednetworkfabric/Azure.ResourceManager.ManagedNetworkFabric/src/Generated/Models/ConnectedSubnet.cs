// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Connected Subnet properties. </summary>
    public partial class ConnectedSubnet : AnnotationResource
    {
        /// <summary> Initializes a new instance of ConnectedSubnet. </summary>
        public ConnectedSubnet()
        {
        }

        /// <summary> Initializes a new instance of ConnectedSubnet. </summary>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="prefix"> Prefix of the connected Subnet. </param>
        internal ConnectedSubnet(string annotation, string prefix) : base(annotation)
        {
            Prefix = prefix;
        }

        /// <summary> Prefix of the connected Subnet. </summary>
        public string Prefix { get; set; }
    }
}
