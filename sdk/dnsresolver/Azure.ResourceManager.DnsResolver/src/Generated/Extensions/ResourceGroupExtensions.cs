// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Azure;
using Azure.ResourceManager.DnsResolver.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DnsResolver
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region DnsResolver
        /// <summary> Gets an object representing a DnsResolverCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="DnsResolverCollection" /> object. </returns>
        public static DnsResolverCollection GetDnsResolvers(this ResourceGroup resourceGroup)
        {
            return new DnsResolverCollection(resourceGroup);
        }
        #endregion

        #region DnsForwardingRuleset
        /// <summary> Gets an object representing a DnsForwardingRulesetCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="DnsForwardingRulesetCollection" /> object. </returns>
        public static DnsForwardingRulesetCollection GetDnsForwardingRulesets(this ResourceGroup resourceGroup)
        {
            return new DnsForwardingRulesetCollection(resourceGroup);
        }
        #endregion

        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((armClient) =>
            {
                return new ResourceGroupExtensionClient(armClient, resourceGroup.Id);
            }
            );
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/listDnsResolvers
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DnsResolvers_ListByVirtualNetwork
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="System.ArgumentException"> <paramref name="virtualNetworkName"/> is empty. </exception>
        /// <exception cref="System.ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<WritableSubResource> GetDnsResolversByVirtualNetworkAsync(this ResourceGroup resourceGroup, string virtualNetworkName, int? top = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroup).GetDnsResolversByVirtualNetworkAsync(virtualNetworkName, top, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/listDnsResolvers
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DnsResolvers_ListByVirtualNetwork
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="System.ArgumentException"> <paramref name="virtualNetworkName"/> is empty. </exception>
        /// <exception cref="System.ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<WritableSubResource> GetDnsResolversByVirtualNetwork(this ResourceGroup resourceGroup, string virtualNetworkName, int? top = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroup).GetDnsResolversByVirtualNetwork(virtualNetworkName, top, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/listDnsForwardingRulesets
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DnsForwardingRulesets_ListByVirtualNetwork
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="System.ArgumentException"> <paramref name="virtualNetworkName"/> is empty. </exception>
        /// <exception cref="System.ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<VirtualNetworkDnsForwardingRuleset> GetDnsForwardingRulesetsByVirtualNetworkAsync(this ResourceGroup resourceGroup, string virtualNetworkName, int? top = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroup).GetDnsForwardingRulesetsByVirtualNetworkAsync(virtualNetworkName, top, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/listDnsForwardingRulesets
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DnsForwardingRulesets_ListByVirtualNetwork
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="top"> The maximum number of results to return. If not specified, returns up to 100 results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="System.ArgumentException"> <paramref name="virtualNetworkName"/> is empty. </exception>
        /// <exception cref="System.ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<VirtualNetworkDnsForwardingRuleset> GetDnsForwardingRulesetsByVirtualNetwork(this ResourceGroup resourceGroup, string virtualNetworkName, int? top = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroup).GetDnsForwardingRulesetsByVirtualNetwork(virtualNetworkName, top, cancellationToken);
        }
    }
}
