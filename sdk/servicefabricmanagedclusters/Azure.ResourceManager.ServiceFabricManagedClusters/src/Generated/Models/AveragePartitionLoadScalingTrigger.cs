// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Represents a scaling trigger related to an average load of a metric/resource of a partition. </summary>
    public partial class AveragePartitionLoadScalingTrigger : ManagedServiceScalingTrigger
    {
        /// <summary> Initializes a new instance of AveragePartitionLoadScalingTrigger. </summary>
        /// <param name="metricName"> The name of the metric for which usage should be tracked. </param>
        /// <param name="lowerLoadThreshold"> The lower limit of the load below which a scale in operation should be performed. </param>
        /// <param name="upperLoadThreshold"> The upper limit of the load beyond which a scale out operation should be performed. </param>
        /// <param name="scaleInterval"> The period in seconds on which a decision is made whether to scale or not. This property should come in ISO 8601 format &quot;hh:mm:ss&quot;. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metricName"/> or <paramref name="scaleInterval"/> is null. </exception>
        public AveragePartitionLoadScalingTrigger(string metricName, double lowerLoadThreshold, double upperLoadThreshold, string scaleInterval)
        {
            Argument.AssertNotNull(metricName, nameof(metricName));
            Argument.AssertNotNull(scaleInterval, nameof(scaleInterval));

            MetricName = metricName;
            LowerLoadThreshold = lowerLoadThreshold;
            UpperLoadThreshold = upperLoadThreshold;
            ScaleInterval = scaleInterval;
            Kind = ServiceScalingTriggerKind.AveragePartitionLoadTrigger;
        }

        /// <summary> Initializes a new instance of AveragePartitionLoadScalingTrigger. </summary>
        /// <param name="kind"> Specifies the trigger associated with this scaling policy. </param>
        /// <param name="metricName"> The name of the metric for which usage should be tracked. </param>
        /// <param name="lowerLoadThreshold"> The lower limit of the load below which a scale in operation should be performed. </param>
        /// <param name="upperLoadThreshold"> The upper limit of the load beyond which a scale out operation should be performed. </param>
        /// <param name="scaleInterval"> The period in seconds on which a decision is made whether to scale or not. This property should come in ISO 8601 format &quot;hh:mm:ss&quot;. </param>
        internal AveragePartitionLoadScalingTrigger(ServiceScalingTriggerKind kind, string metricName, double lowerLoadThreshold, double upperLoadThreshold, string scaleInterval) : base(kind)
        {
            MetricName = metricName;
            LowerLoadThreshold = lowerLoadThreshold;
            UpperLoadThreshold = upperLoadThreshold;
            ScaleInterval = scaleInterval;
            Kind = kind;
        }

        /// <summary> The name of the metric for which usage should be tracked. </summary>
        public string MetricName { get; set; }
        /// <summary> The lower limit of the load below which a scale in operation should be performed. </summary>
        public double LowerLoadThreshold { get; set; }
        /// <summary> The upper limit of the load beyond which a scale out operation should be performed. </summary>
        public double UpperLoadThreshold { get; set; }
        /// <summary> The period in seconds on which a decision is made whether to scale or not. This property should come in ISO 8601 format &quot;hh:mm:ss&quot;. </summary>
        public string ScaleInterval { get; set; }
    }
}
