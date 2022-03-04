﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System.Threading.Tasks;
using NUnit.Framework;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources.Models;
using Azure.Core;
using Azure.ResourceManager.DnsResolver.Models;
using System.Linq;
using System.Collections.Generic;

namespace Azure.ResourceManager.DnsResolver.Tests
{
    public class VirtualNetworkLinkTests : DnsResolverTestBase
    {
        private DnsResolver dnsResolver;
        private DnsForwardingRulesetCollection dnsForwardingRulesetCollection;
        private DnsForwardingRuleset dnsForwardingRuleset;
        private ResourceIdentifier outboundEndpointId;
        private string vnetId;
        private string subnetId;
        private string dnsForwardingRulesetName;

        public VirtualNetworkLinkTests(bool async) : base(async)
        {
        }

        [SetUp]
        public async Task CreateDnsResolverCollection()
        {
            var dnsResolverName = Recording.GenerateAssetName("dnsResolver-");
            var vnetName = Recording.GenerateAssetName("dnsResolver-");
            var dnsResolverData = new DnsResolverData(this.DefaultLocation);

            vnetId = $"/subscriptions/{TestEnvironment.SubscriptionId}/resourceGroups/{TestEnvironment.ResourceGroup}/providers/Microsoft.Network/virtualNetworks/{vnetName}";
            subnetId = $"/subscriptions/{TestEnvironment.SubscriptionId}/resourceGroups/{TestEnvironment.ResourceGroup}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/snet-sim2";

            if (Mode == RecordedTestMode.Record)
            {
                await CreateVirtualNetworkAsync(vnetName);
                await CreateSubnetAsync(vnetName);
            }

            dnsResolverData.VirtualNetwork = new WritableSubResource()
            {
                Id = new ResourceIdentifier(vnetId)
            };

            var subscription = await Client.GetSubscriptions().GetAsync(TestEnvironment.SubscriptionId);
            var resourceGroup = await subscription.Value.GetResourceGroups().GetAsync(TestEnvironment.ResourceGroup);

            dnsResolver = (await resourceGroup.Value.GetDnsResolvers().CreateOrUpdateAsync(true, dnsResolverName, dnsResolverData)).Value;
            dnsForwardingRulesetCollection = resourceGroup.Value.GetDnsForwardingRulesets();

            var outboundEndpointData = new OutboundEndpointData(this.DefaultLocation);

            outboundEndpointData.Subnet = new WritableSubResource()
            {
                Id = new ResourceIdentifier(subnetId),
            };

            var outboundEndpointName = Recording.GenerateAssetName("outboundEndpoint-");
            var outboundEndpoint = await dnsResolver.GetOutboundEndpoints().CreateOrUpdateAsync(true, outboundEndpointName, outboundEndpointData);

            outboundEndpointId = outboundEndpoint.Value.Id;

            dnsForwardingRulesetName = Recording.GenerateAssetName("dnsForwardingRuleset-");
            dnsForwardingRuleset = await CreateDnsForwardingRuleset(dnsForwardingRulesetName);
        }

        private async Task<DnsForwardingRuleset> CreateDnsForwardingRuleset(string dnsForwardingRulesetName)
        {
            var dnsForwardingRulesetData = new DnsForwardingRulesetData(this.DefaultLocation);

            dnsForwardingRulesetData.DnsResolverOutboundEndpoints.Add(new WritableSubResource()
            {
                Id = outboundEndpointId,
            });

            return (await dnsForwardingRulesetCollection.CreateOrUpdateAsync(true, dnsForwardingRulesetName, dnsForwardingRulesetData)).Value;
        }

        [RecordedTest]
        public async Task CreateVirtualNetworkLink()
        {
            // ARRANGE
            var virtualNetworkLinkData = new VirtualNetworkLinkData();

            virtualNetworkLinkData.VirtualNetwork = new WritableSubResource()
            {
                Id = new ResourceIdentifier(vnetId),
            };

            var virtualNetworkLinkName = Recording.GenerateAssetName("virtualNetworkLink-");

            // ACT
            var createdVirtualNetworkLink = await dnsForwardingRuleset.GetVirtualNetworkLinks().CreateOrUpdateAsync(true, virtualNetworkLinkName, virtualNetworkLinkData);

            // ASSERT
            Assert.AreEqual(createdVirtualNetworkLink.Value.Data.ProvisioningState, ProvisioningState.Succeeded);
        }

        [RecordedTest]
        public async Task GetVirtualNetworkLink()
        {
            // ARRANGE
            var virtualNetworkLinkData = new VirtualNetworkLinkData();

            virtualNetworkLinkData.VirtualNetwork = new WritableSubResource()
            {
                Id = new ResourceIdentifier(vnetId),
            };

            var virtualNetworkLinkName = Recording.GenerateAssetName("virtualNetworkLink-");
            await dnsForwardingRuleset.GetVirtualNetworkLinks().CreateOrUpdateAsync(true, virtualNetworkLinkName, virtualNetworkLinkData);

            // ACT
            var retrievedVirtualNetworkLink = await dnsForwardingRuleset.GetVirtualNetworkLinks().GetAsync(virtualNetworkLinkName);

            // ASSERT
            Assert.AreEqual(retrievedVirtualNetworkLink.Value.Data.Name, virtualNetworkLinkName);
        }

        [RecordedTest]
        public async Task UpdateVirtualNetworkLink()
        {
            // ARRANGE
            var virtualNetworkLinkData = new VirtualNetworkLinkData();

            virtualNetworkLinkData.VirtualNetwork = new WritableSubResource()
            {
                Id = new ResourceIdentifier(vnetId),
            };

            var virtualNetworkLinkName = Recording.GenerateAssetName("virtualNetworkLink-");
            var createdVirtualNetworkLink = await dnsForwardingRuleset.GetVirtualNetworkLinks().CreateOrUpdateAsync(true, virtualNetworkLinkName, virtualNetworkLinkData);

            var newTagKey = Recording.GenerateAlphaNumericId("tagKey");
            var newTagValue = Recording.GenerateAlphaNumericId("tagValue");

            var virtualNetworkLinkPatch = new VirtualNetworkLinkUpdateOptions();
            virtualNetworkLinkPatch.Metadata.Add(newTagKey, newTagValue);

            // ACT
            var patchedVirtualNetworkLink = await createdVirtualNetworkLink.Value.UpdateAsync(true, virtualNetworkLinkPatch);

            // ASSERT
            CollectionAssert.AreEquivalent(patchedVirtualNetworkLink.Value.Data.Metadata, virtualNetworkLinkPatch.Metadata);
        }

        [RecordedTest]
        public async Task RemoveVirtualNetworkLink()
        {
            // ARRANGE
            var virtualNetworkLinkData = new VirtualNetworkLinkData();

            virtualNetworkLinkData.VirtualNetwork = new WritableSubResource()
            {
                Id = new ResourceIdentifier(vnetId),
            };

            var virtualNetworkLinkName = Recording.GenerateAssetName("virtualNetworkLink-");
            var createdVirtualNetworkLink = await dnsForwardingRuleset.GetVirtualNetworkLinks().CreateOrUpdateAsync(true, virtualNetworkLinkName, virtualNetworkLinkData);

            // ACT
            await createdVirtualNetworkLink.Value.DeleteAsync(true);

            // ASSERT
            var getVirtualNetworkLink = await dnsForwardingRuleset.GetVirtualNetworkLinks().ExistsAsync(virtualNetworkLinkName);
            Assert.AreEqual(getVirtualNetworkLink.Value, false);
        }
    }
}
