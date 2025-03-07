// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Graph.Rbac.Models;

namespace Azure.Graph.Rbac
{
    internal partial class ObjectsRestOperations
    {
        private string tenantID;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ObjectsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="tenantID"> The tenant ID. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantID"/> or <paramref name="apiVersion"/> is null. </exception>
        public ObjectsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string tenantID, Uri endpoint = null, string apiVersion = "1.6")
        {
            if (tenantID == null)
            {
                throw new ArgumentNullException(nameof(tenantID));
            }
            endpoint ??= new Uri("https://graph.windows.net");
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.tenantID = tenantID;
            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetObjectsByObjectIdsRequest(GetObjectsParameters parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(tenantID, true);
            uri.AppendPath("/getObjectsByObjectIds", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            return message;
        }

        /// <summary> Gets the directory objects specified in a list of object IDs. You can also specify which resource collections (users, groups, etc.) should be searched by specifying the optional types parameter. </summary>
        /// <param name="parameters"> Objects filtering parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async Task<Response<DirectoryObjectListResult>> GetObjectsByObjectIdsAsync(GetObjectsParameters parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateGetObjectsByObjectIdsRequest(parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DirectoryObjectListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DirectoryObjectListResult.DeserializeDirectoryObjectListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the directory objects specified in a list of object IDs. You can also specify which resource collections (users, groups, etc.) should be searched by specifying the optional types parameter. </summary>
        /// <param name="parameters"> Objects filtering parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public Response<DirectoryObjectListResult> GetObjectsByObjectIds(GetObjectsParameters parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateGetObjectsByObjectIdsRequest(parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DirectoryObjectListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DirectoryObjectListResult.DeserializeDirectoryObjectListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetObjectsByObjectIdsNextRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(tenantID, true);
            uri.AppendPath("/", false);
            uri.AppendRawNextLink(nextLink, false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Gets AD group membership for the specified AD object IDs. </summary>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<DirectoryObjectListResult>> GetObjectsByObjectIdsNextAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetObjectsByObjectIdsNextRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DirectoryObjectListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DirectoryObjectListResult.DeserializeDirectoryObjectListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets AD group membership for the specified AD object IDs. </summary>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<DirectoryObjectListResult> GetObjectsByObjectIdsNext(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetObjectsByObjectIdsNextRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DirectoryObjectListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DirectoryObjectListResult.DeserializeDirectoryObjectListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetObjectsByObjectIdsNextNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> Gets AD group membership for the specified AD object IDs. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<DirectoryObjectListResult>> GetObjectsByObjectIdsNextNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetObjectsByObjectIdsNextNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DirectoryObjectListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DirectoryObjectListResult.DeserializeDirectoryObjectListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets AD group membership for the specified AD object IDs. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<DirectoryObjectListResult> GetObjectsByObjectIdsNextNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetObjectsByObjectIdsNextNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DirectoryObjectListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DirectoryObjectListResult.DeserializeDirectoryObjectListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
