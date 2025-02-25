// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The SubscriptionResourceGetCatalogOptions. </summary>
    public partial class SubscriptionResourceGetCatalogOptions
    {
        /// <summary> Initializes a new instance of SubscriptionResourceGetCatalogOptions. </summary>
        public SubscriptionResourceGetCatalogOptions()
        {
        }

        /// <summary> The type of the resource for which the skus should be provided. </summary>
        public string ReservedResourceType { get; set; }
        /// <summary> Filters the skus based on the location specified in this parameter. This can be an Azure region or global. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Publisher id used to get the third party products. </summary>
        public string PublisherId { get; set; }
        /// <summary> Offer id used to get the third party products. </summary>
        public string OfferId { get; set; }
        /// <summary> Plan id used to get the third party products. </summary>
        public string PlanId { get; set; }
        /// <summary> May be used to filter by Catalog properties. The filter supports 'eq', 'or', and 'and'. </summary>
        public string Filter { get; set; }
        /// <summary> The number of reservations to skip from the list before returning results. </summary>
        public float? Skip { get; set; }
        /// <summary> To number of reservations to return. </summary>
        public float? Take { get; set; }
    }
}
