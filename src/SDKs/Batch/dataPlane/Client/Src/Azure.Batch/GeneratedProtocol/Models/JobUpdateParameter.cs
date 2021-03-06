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
    /// The set of changes to be made to a job.
    /// </summary>
    public partial class JobUpdateParameter
    {
        /// <summary>
        /// Initializes a new instance of the JobUpdateParameter class.
        /// </summary>
        public JobUpdateParameter() { }

        /// <summary>
        /// Initializes a new instance of the JobUpdateParameter class.
        /// </summary>
        /// <param name="poolInfo">The pool on which the Batch service runs the
        /// job's tasks.</param>
        /// <param name="priority">The priority of the job.</param>
        /// <param name="constraints">The execution constraints for the
        /// job.</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// the job as metadata.</param>
        /// <param name="onAllTasksComplete">The action the Batch service
        /// should take when all tasks in the job are in the completed
        /// state.</param>
        public JobUpdateParameter(PoolInformation poolInfo, int? priority = default(int?), JobConstraints constraints = default(JobConstraints), System.Collections.Generic.IList<MetadataItem> metadata = default(System.Collections.Generic.IList<MetadataItem>), OnAllTasksComplete? onAllTasksComplete = default(OnAllTasksComplete?))
        {
            Priority = priority;
            Constraints = constraints;
            PoolInfo = poolInfo;
            Metadata = metadata;
            OnAllTasksComplete = onAllTasksComplete;
        }

        /// <summary>
        /// Gets or sets the priority of the job.
        /// </summary>
        /// <remarks>
        /// Priority values can range from -1000 to 1000, with -1000 being the
        /// lowest priority and 1000 being the highest priority. If omitted, it
        /// is set to the default value 0.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the execution constraints for the job.
        /// </summary>
        /// <remarks>
        /// If omitted, the constraints are cleared.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "constraints")]
        public JobConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets the pool on which the Batch service runs the job's
        /// tasks.
        /// </summary>
        /// <remarks>
        /// You may change the pool for a job only when the job is disabled.
        /// The Update Job call will fail if you include the poolInfo element
        /// and the job is not disabled. If you specify an
        /// autoPoolSpecification specification in the poolInfo, only the
        /// keepAlive property can be updated, and then only if the auto pool
        /// has a poolLifetimeOption of job.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "poolInfo")]
        public PoolInformation PoolInfo { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the job as
        /// metadata.
        /// </summary>
        /// <remarks>
        /// If omitted, it takes the default value of an empty list; in effect,
        /// any existing metadata is deleted.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Gets or sets the action the Batch service should take when all
        /// tasks in the job are in the completed state.
        /// </summary>
        /// <remarks>
        /// If omitted, the completion behavior is set to noAction. If the
        /// current value is terminateJob, this is an error because a job's
        /// completion behavior may not be changed from terminateJob to
        /// noAction. Possible values include: 'noAction', 'terminateJob'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "onAllTasksComplete")]
        public OnAllTasksComplete? OnAllTasksComplete { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PoolInfo == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "PoolInfo");
            }
            if (this.PoolInfo != null)
            {
                this.PoolInfo.Validate();
            }
            if (this.Metadata != null)
            {
                foreach (var element in this.Metadata)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
