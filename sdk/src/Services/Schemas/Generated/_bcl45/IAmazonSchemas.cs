/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the schemas-2019-12-02.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Schemas.Model;

namespace Amazon.Schemas
{
    /// <summary>
    /// Interface for accessing Schemas
    ///
    /// Amazon EventBridge Schema Registry
    /// </summary>
    public partial interface IAmazonSchemas : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISchemasPaginatorFactory Paginators { get; }

        
        #region  CreateDiscoverer


        /// <summary>
        /// Creates a discoverer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDiscoverer service method.</param>
        /// 
        /// <returns>The response from the CreateDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateDiscoverer">REST API Reference for CreateDiscoverer Operation</seealso>
        CreateDiscovererResponse CreateDiscoverer(CreateDiscovererRequest request);



        /// <summary>
        /// Creates a discoverer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDiscoverer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateDiscoverer">REST API Reference for CreateDiscoverer Operation</seealso>
        Task<CreateDiscovererResponse> CreateDiscovererAsync(CreateDiscovererRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRegistry


        /// <summary>
        /// Creates a registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistry service method.</param>
        /// 
        /// <returns>The response from the CreateRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateRegistry">REST API Reference for CreateRegistry Operation</seealso>
        CreateRegistryResponse CreateRegistry(CreateRegistryRequest request);



        /// <summary>
        /// Creates a registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateRegistry">REST API Reference for CreateRegistry Operation</seealso>
        Task<CreateRegistryResponse> CreateRegistryAsync(CreateRegistryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSchema


        /// <summary>
        /// Creates a schema definition.
        /// 
        ///  <note>
        /// <para>
        /// Inactive schemas will be deleted after two years.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchema service method.</param>
        /// 
        /// <returns>The response from the CreateSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        CreateSchemaResponse CreateSchema(CreateSchemaRequest request);



        /// <summary>
        /// Creates a schema definition.
        /// 
        ///  <note>
        /// <para>
        /// Inactive schemas will be deleted after two years.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/CreateSchema">REST API Reference for CreateSchema Operation</seealso>
        Task<CreateSchemaResponse> CreateSchemaAsync(CreateSchemaRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDiscoverer


        /// <summary>
        /// Deletes a discoverer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDiscoverer service method.</param>
        /// 
        /// <returns>The response from the DeleteDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteDiscoverer">REST API Reference for DeleteDiscoverer Operation</seealso>
        DeleteDiscovererResponse DeleteDiscoverer(DeleteDiscovererRequest request);



        /// <summary>
        /// Deletes a discoverer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDiscoverer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteDiscoverer">REST API Reference for DeleteDiscoverer Operation</seealso>
        Task<DeleteDiscovererResponse> DeleteDiscovererAsync(DeleteDiscovererRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRegistry


        /// <summary>
        /// Deletes a Registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistry service method.</param>
        /// 
        /// <returns>The response from the DeleteRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteRegistry">REST API Reference for DeleteRegistry Operation</seealso>
        DeleteRegistryResponse DeleteRegistry(DeleteRegistryRequest request);



        /// <summary>
        /// Deletes a Registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteRegistry">REST API Reference for DeleteRegistry Operation</seealso>
        Task<DeleteRegistryResponse> DeleteRegistryAsync(DeleteRegistryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Delete the resource-based policy attached to the specified registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);



        /// <summary>
        /// Delete the resource-based policy attached to the specified registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSchema


        /// <summary>
        /// Delete a schema definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchema service method.</param>
        /// 
        /// <returns>The response from the DeleteSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        DeleteSchemaResponse DeleteSchema(DeleteSchemaRequest request);



        /// <summary>
        /// Delete a schema definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteSchema">REST API Reference for DeleteSchema Operation</seealso>
        Task<DeleteSchemaResponse> DeleteSchemaAsync(DeleteSchemaRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSchemaVersion


        /// <summary>
        /// Delete the schema version definition
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchemaVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteSchemaVersion service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteSchemaVersion">REST API Reference for DeleteSchemaVersion Operation</seealso>
        DeleteSchemaVersionResponse DeleteSchemaVersion(DeleteSchemaVersionRequest request);



        /// <summary>
        /// Delete the schema version definition
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchemaVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSchemaVersion service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DeleteSchemaVersion">REST API Reference for DeleteSchemaVersion Operation</seealso>
        Task<DeleteSchemaVersionResponse> DeleteSchemaVersionAsync(DeleteSchemaVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCodeBinding


        /// <summary>
        /// Describe the code binding URI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeBinding service method.</param>
        /// 
        /// <returns>The response from the DescribeCodeBinding service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeCodeBinding">REST API Reference for DescribeCodeBinding Operation</seealso>
        DescribeCodeBindingResponse DescribeCodeBinding(DescribeCodeBindingRequest request);



        /// <summary>
        /// Describe the code binding URI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeBinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCodeBinding service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeCodeBinding">REST API Reference for DescribeCodeBinding Operation</seealso>
        Task<DescribeCodeBindingResponse> DescribeCodeBindingAsync(DescribeCodeBindingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDiscoverer


        /// <summary>
        /// Describes the discoverer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDiscoverer service method.</param>
        /// 
        /// <returns>The response from the DescribeDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeDiscoverer">REST API Reference for DescribeDiscoverer Operation</seealso>
        DescribeDiscovererResponse DescribeDiscoverer(DescribeDiscovererRequest request);



        /// <summary>
        /// Describes the discoverer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDiscoverer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeDiscoverer">REST API Reference for DescribeDiscoverer Operation</seealso>
        Task<DescribeDiscovererResponse> DescribeDiscovererAsync(DescribeDiscovererRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRegistry


        /// <summary>
        /// Describes the registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistry service method.</param>
        /// 
        /// <returns>The response from the DescribeRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeRegistry">REST API Reference for DescribeRegistry Operation</seealso>
        DescribeRegistryResponse DescribeRegistry(DescribeRegistryRequest request);



        /// <summary>
        /// Describes the registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeRegistry">REST API Reference for DescribeRegistry Operation</seealso>
        Task<DescribeRegistryResponse> DescribeRegistryAsync(DescribeRegistryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSchema


        /// <summary>
        /// Retrieve the schema definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchema service method.</param>
        /// 
        /// <returns>The response from the DescribeSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeSchema">REST API Reference for DescribeSchema Operation</seealso>
        DescribeSchemaResponse DescribeSchema(DescribeSchemaRequest request);



        /// <summary>
        /// Retrieve the schema definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/DescribeSchema">REST API Reference for DescribeSchema Operation</seealso>
        Task<DescribeSchemaResponse> DescribeSchemaAsync(DescribeSchemaRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExportSchema


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportSchema service method.</param>
        /// 
        /// <returns>The response from the ExportSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ExportSchema">REST API Reference for ExportSchema Operation</seealso>
        ExportSchemaResponse ExportSchema(ExportSchemaRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ExportSchema">REST API Reference for ExportSchema Operation</seealso>
        Task<ExportSchemaResponse> ExportSchemaAsync(ExportSchemaRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCodeBindingSource


        /// <summary>
        /// Get the code binding source URI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeBindingSource service method.</param>
        /// 
        /// <returns>The response from the GetCodeBindingSource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetCodeBindingSource">REST API Reference for GetCodeBindingSource Operation</seealso>
        GetCodeBindingSourceResponse GetCodeBindingSource(GetCodeBindingSourceRequest request);



        /// <summary>
        /// Get the code binding source URI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeBindingSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCodeBindingSource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetCodeBindingSource">REST API Reference for GetCodeBindingSource Operation</seealso>
        Task<GetCodeBindingSourceResponse> GetCodeBindingSourceAsync(GetCodeBindingSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDiscoveredSchema


        /// <summary>
        /// Get the discovered schema that was generated based on sampled events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoveredSchema service method.</param>
        /// 
        /// <returns>The response from the GetDiscoveredSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetDiscoveredSchema">REST API Reference for GetDiscoveredSchema Operation</seealso>
        GetDiscoveredSchemaResponse GetDiscoveredSchema(GetDiscoveredSchemaRequest request);



        /// <summary>
        /// Get the discovered schema that was generated based on sampled events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoveredSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDiscoveredSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetDiscoveredSchema">REST API Reference for GetDiscoveredSchema Operation</seealso>
        Task<GetDiscoveredSchemaResponse> GetDiscoveredSchemaAsync(GetDiscoveredSchemaRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Retrieves the resource-based policy attached to a given registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);



        /// <summary>
        /// Retrieves the resource-based policy attached to a given registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDiscoverers


        /// <summary>
        /// List the discoverers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoverers service method.</param>
        /// 
        /// <returns>The response from the ListDiscoverers service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListDiscoverers">REST API Reference for ListDiscoverers Operation</seealso>
        ListDiscoverersResponse ListDiscoverers(ListDiscoverersRequest request);



        /// <summary>
        /// List the discoverers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoverers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDiscoverers service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListDiscoverers">REST API Reference for ListDiscoverers Operation</seealso>
        Task<ListDiscoverersResponse> ListDiscoverersAsync(ListDiscoverersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRegistries


        /// <summary>
        /// List the registries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistries service method.</param>
        /// 
        /// <returns>The response from the ListRegistries service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListRegistries">REST API Reference for ListRegistries Operation</seealso>
        ListRegistriesResponse ListRegistries(ListRegistriesRequest request);



        /// <summary>
        /// List the registries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegistries service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListRegistries">REST API Reference for ListRegistries Operation</seealso>
        Task<ListRegistriesResponse> ListRegistriesAsync(ListRegistriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSchemas


        /// <summary>
        /// List the schemas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas service method.</param>
        /// 
        /// <returns>The response from the ListSchemas service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        ListSchemasResponse ListSchemas(ListSchemasRequest request);



        /// <summary>
        /// List the schemas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchemas service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        Task<ListSchemasResponse> ListSchemasAsync(ListSchemasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSchemaVersions


        /// <summary>
        /// Provides a list of the schema versions and related information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaVersions service method.</param>
        /// 
        /// <returns>The response from the ListSchemaVersions service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListSchemaVersions">REST API Reference for ListSchemaVersions Operation</seealso>
        ListSchemaVersionsResponse ListSchemaVersions(ListSchemaVersionsRequest request);



        /// <summary>
        /// Provides a list of the schema versions and related information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchemaVersions service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListSchemaVersions">REST API Reference for ListSchemaVersions Operation</seealso>
        Task<ListSchemaVersionsResponse> ListSchemaVersionsAsync(ListSchemaVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Get tags for resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Get tags for resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutCodeBinding


        /// <summary>
        /// Put code binding URI
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCodeBinding service method.</param>
        /// 
        /// <returns>The response from the PutCodeBinding service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.GoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/PutCodeBinding">REST API Reference for PutCodeBinding Operation</seealso>
        PutCodeBindingResponse PutCodeBinding(PutCodeBindingRequest request);



        /// <summary>
        /// Put code binding URI
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCodeBinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutCodeBinding service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.GoneException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/PutCodeBinding">REST API Reference for PutCodeBinding Operation</seealso>
        Task<PutCodeBindingResponse> PutCodeBindingAsync(PutCodeBindingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// The name of the policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);



        /// <summary>
        /// The name of the policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchSchemas


        /// <summary>
        /// Search the schemas
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSchemas service method.</param>
        /// 
        /// <returns>The response from the SearchSchemas service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/SearchSchemas">REST API Reference for SearchSchemas Operation</seealso>
        SearchSchemasResponse SearchSchemas(SearchSchemasRequest request);



        /// <summary>
        /// Search the schemas
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSchemas service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchSchemas service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/SearchSchemas">REST API Reference for SearchSchemas Operation</seealso>
        Task<SearchSchemasResponse> SearchSchemasAsync(SearchSchemasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartDiscoverer


        /// <summary>
        /// Starts the discoverer
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDiscoverer service method.</param>
        /// 
        /// <returns>The response from the StartDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/StartDiscoverer">REST API Reference for StartDiscoverer Operation</seealso>
        StartDiscovererResponse StartDiscoverer(StartDiscovererRequest request);



        /// <summary>
        /// Starts the discoverer
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDiscoverer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/StartDiscoverer">REST API Reference for StartDiscoverer Operation</seealso>
        Task<StartDiscovererResponse> StartDiscovererAsync(StartDiscovererRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopDiscoverer


        /// <summary>
        /// Stops the discoverer
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDiscoverer service method.</param>
        /// 
        /// <returns>The response from the StopDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/StopDiscoverer">REST API Reference for StopDiscoverer Operation</seealso>
        StopDiscovererResponse StopDiscoverer(StopDiscovererRequest request);



        /// <summary>
        /// Stops the discoverer
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDiscoverer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/StopDiscoverer">REST API Reference for StopDiscoverer Operation</seealso>
        Task<StopDiscovererResponse> StopDiscovererAsync(StopDiscovererRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Add tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Add tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDiscoverer


        /// <summary>
        /// Updates the discoverer
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDiscoverer service method.</param>
        /// 
        /// <returns>The response from the UpdateDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateDiscoverer">REST API Reference for UpdateDiscoverer Operation</seealso>
        UpdateDiscovererResponse UpdateDiscoverer(UpdateDiscovererRequest request);



        /// <summary>
        /// Updates the discoverer
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDiscoverer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDiscoverer service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateDiscoverer">REST API Reference for UpdateDiscoverer Operation</seealso>
        Task<UpdateDiscovererResponse> UpdateDiscovererAsync(UpdateDiscovererRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRegistry


        /// <summary>
        /// Updates a registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistry service method.</param>
        /// 
        /// <returns>The response from the UpdateRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateRegistry">REST API Reference for UpdateRegistry Operation</seealso>
        UpdateRegistryResponse UpdateRegistry(UpdateRegistryRequest request);



        /// <summary>
        /// Updates a registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRegistry service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.UnauthorizedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateRegistry">REST API Reference for UpdateRegistry Operation</seealso>
        Task<UpdateRegistryResponse> UpdateRegistryAsync(UpdateRegistryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSchema


        /// <summary>
        /// Updates the schema definition
        /// 
        ///  <note>
        /// <para>
        /// Inactive schemas will be deleted after two years.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchema service method.</param>
        /// 
        /// <returns>The response from the UpdateSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        UpdateSchemaResponse UpdateSchema(UpdateSchemaRequest request);



        /// <summary>
        /// Updates the schema definition
        /// 
        ///  <note>
        /// <para>
        /// Inactive schemas will be deleted after two years.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSchema service method, as returned by Schemas.</returns>
        /// <exception cref="Amazon.Schemas.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.InternalServerErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Schemas.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/schemas-2019-12-02/UpdateSchema">REST API Reference for UpdateSchema Operation</seealso>
        Task<UpdateSchemaResponse> UpdateSchemaAsync(UpdateSchemaRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}