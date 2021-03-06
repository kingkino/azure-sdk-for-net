// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Options for disabling scheduling on a compute node.
    /// </summary>
    public partial class NodeDisableSchedulingParameter
    {
        /// <summary>
        /// Initializes a new instance of the NodeDisableSchedulingParameter
        /// class.
        /// </summary>
        public NodeDisableSchedulingParameter() { }

        /// <summary>
        /// Initializes a new instance of the NodeDisableSchedulingParameter
        /// class.
        /// </summary>
        /// <param name="nodeDisableSchedulingOption">What to do with currently
        /// running tasks when disabling task scheduling on the compute
        /// node.</param>
        public NodeDisableSchedulingParameter(DisableComputeNodeSchedulingOption? nodeDisableSchedulingOption = default(DisableComputeNodeSchedulingOption?))
        {
            NodeDisableSchedulingOption = nodeDisableSchedulingOption;
        }

        /// <summary>
        /// Gets or sets what to do with currently running tasks when disabling
        /// task scheduling on the compute node.
        /// </summary>
        /// <remarks>
        /// The default value is requeue. Possible values include: 'requeue',
        /// 'terminate', 'taskCompletion'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nodeDisableSchedulingOption")]
        public DisableComputeNodeSchedulingOption? NodeDisableSchedulingOption { get; set; }

    }
}
