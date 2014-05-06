// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute
{
    /// <summary>
    /// The Service Management API includes operations for managing the virtual
    /// machine templates in your subscription.
    /// </summary>
    public partial interface IVirtualMachineVMImageOperations
    {
        /// <summary>
        /// The Begin Deleting Virtual Machine Image operation deletes the
        /// specified virtual machine image.
        /// </summary>
        /// <param name='vmImageName'>
        /// The name of the virtual machine image to delete.
        /// </param>
        /// <param name='deleteFromStorage'>
        /// Specifies that the source blob for the image should also be deleted
        /// from storage.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> BeginDeletingAsync(string vmImageName, bool deleteFromStorage, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Delete Virtual Machine Image operation deletes the specified
        /// virtual machine image.
        /// </summary>
        /// <param name='vmImageName'>
        /// The name of the virtual machine image to delete.
        /// </param>
        /// <param name='deleteFromStorage'>
        /// Specifies that the source blob for the image should also be deleted
        /// from storage.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<OperationStatusResponse> DeleteAsync(string vmImageName, bool deleteFromStorage, CancellationToken cancellationToken);
        
        /// <summary>
        /// The List Virtual Machine Images operation retrieves a list of the
        /// virtual machine images.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List VM Images operation response.
        /// </returns>
        Task<VirtualMachineVMImageListResponse> ListAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// The Update VM Image operation updates a VM image that in your image
        /// repository.
        /// </summary>
        /// <param name='imageName'>
        /// The name of the virtual machine image to be updated.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Virtual Machine Image operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> UpdateAsync(string imageName, VirtualMachineVMImageUpdateParameters parameters, CancellationToken cancellationToken);
    }
}
