// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Cloud.Asset.V1.Snippets
{
    using Google.Api.Gax;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAssetServiceClientSnippets
    {
        /// <summary>Snippet for ExportAssets</summary>
        public void ExportAssetsRequestObject()
        {
            // Snippet: ExportAssets(ExportAssetsRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            ExportAssetsRequest request = new ExportAssetsRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                ReadTime = new Timestamp(),
                AssetTypes = { "", },
                ContentType = ContentType.Unspecified,
                OutputConfig = new OutputConfig(),
            };
            // Make the request
            Operation<ExportAssetsResponse, ExportAssetsRequest> response = assetServiceClient.ExportAssets(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportAssetsResponse, ExportAssetsRequest> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportAssetsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAssetsResponse, ExportAssetsRequest> retrievedResponse = assetServiceClient.PollOnceExportAssets(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAssetsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportAssetsAsync</summary>
        public async Task ExportAssetsRequestObjectAsync()
        {
            // Snippet: ExportAssetsAsync(ExportAssetsRequest, CallSettings)
            // Additional: ExportAssetsAsync(ExportAssetsRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExportAssetsRequest request = new ExportAssetsRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                ReadTime = new Timestamp(),
                AssetTypes = { "", },
                ContentType = ContentType.Unspecified,
                OutputConfig = new OutputConfig(),
            };
            // Make the request
            Operation<ExportAssetsResponse, ExportAssetsRequest> response = await assetServiceClient.ExportAssetsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportAssetsResponse, ExportAssetsRequest> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportAssetsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAssetsResponse, ExportAssetsRequest> retrievedResponse = await assetServiceClient.PollOnceExportAssetsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAssetsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchGetAssetsHistory</summary>
        public void BatchGetAssetsHistoryRequestObject()
        {
            // Snippet: BatchGetAssetsHistory(BatchGetAssetsHistoryRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            BatchGetAssetsHistoryRequest request = new BatchGetAssetsHistoryRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                AssetNames = { "", },
                ContentType = ContentType.Unspecified,
                ReadTimeWindow = new TimeWindow(),
            };
            // Make the request
            BatchGetAssetsHistoryResponse response = assetServiceClient.BatchGetAssetsHistory(request);
            // End snippet
        }

        /// <summary>Snippet for BatchGetAssetsHistoryAsync</summary>
        public async Task BatchGetAssetsHistoryRequestObjectAsync()
        {
            // Snippet: BatchGetAssetsHistoryAsync(BatchGetAssetsHistoryRequest, CallSettings)
            // Additional: BatchGetAssetsHistoryAsync(BatchGetAssetsHistoryRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchGetAssetsHistoryRequest request = new BatchGetAssetsHistoryRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                AssetNames = { "", },
                ContentType = ContentType.Unspecified,
                ReadTimeWindow = new TimeWindow(),
            };
            // Make the request
            BatchGetAssetsHistoryResponse response = await assetServiceClient.BatchGetAssetsHistoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFeed</summary>
        public void CreateFeedRequestObject()
        {
            // Snippet: CreateFeed(CreateFeedRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            CreateFeedRequest request = new CreateFeedRequest
            {
                Parent = "",
                FeedId = "",
                Feed = new Feed(),
            };
            // Make the request
            Feed response = assetServiceClient.CreateFeed(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFeedAsync</summary>
        public async Task CreateFeedRequestObjectAsync()
        {
            // Snippet: CreateFeedAsync(CreateFeedRequest, CallSettings)
            // Additional: CreateFeedAsync(CreateFeedRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateFeedRequest request = new CreateFeedRequest
            {
                Parent = "",
                FeedId = "",
                Feed = new Feed(),
            };
            // Make the request
            Feed response = await assetServiceClient.CreateFeedAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFeed</summary>
        public void CreateFeed()
        {
            // Snippet: CreateFeed(string, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            Feed response = assetServiceClient.CreateFeed(parent);
            // End snippet
        }

        /// <summary>Snippet for CreateFeedAsync</summary>
        public async Task CreateFeedAsync()
        {
            // Snippet: CreateFeedAsync(string, CallSettings)
            // Additional: CreateFeedAsync(string, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            Feed response = await assetServiceClient.CreateFeedAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for GetFeed</summary>
        public void GetFeedRequestObject()
        {
            // Snippet: GetFeed(GetFeedRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            GetFeedRequest request = new GetFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            // Make the request
            Feed response = assetServiceClient.GetFeed(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeedAsync</summary>
        public async Task GetFeedRequestObjectAsync()
        {
            // Snippet: GetFeedAsync(GetFeedRequest, CallSettings)
            // Additional: GetFeedAsync(GetFeedRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeedRequest request = new GetFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            // Make the request
            Feed response = await assetServiceClient.GetFeedAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeed</summary>
        public void GetFeed()
        {
            // Snippet: GetFeed(string, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/feeds/[FEED]";
            // Make the request
            Feed response = assetServiceClient.GetFeed(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeedAsync</summary>
        public async Task GetFeedAsync()
        {
            // Snippet: GetFeedAsync(string, CallSettings)
            // Additional: GetFeedAsync(string, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/feeds/[FEED]";
            // Make the request
            Feed response = await assetServiceClient.GetFeedAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeed</summary>
        public void GetFeedResourceNames()
        {
            // Snippet: GetFeed(FeedName, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            FeedName name = FeedName.FromProjectFeed("[PROJECT]", "[FEED]");
            // Make the request
            Feed response = assetServiceClient.GetFeed(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeedAsync</summary>
        public async Task GetFeedResourceNamesAsync()
        {
            // Snippet: GetFeedAsync(FeedName, CallSettings)
            // Additional: GetFeedAsync(FeedName, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeedName name = FeedName.FromProjectFeed("[PROJECT]", "[FEED]");
            // Make the request
            Feed response = await assetServiceClient.GetFeedAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFeeds</summary>
        public void ListFeedsRequestObject()
        {
            // Snippet: ListFeeds(ListFeedsRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            ListFeedsRequest request = new ListFeedsRequest { Parent = "", };
            // Make the request
            ListFeedsResponse response = assetServiceClient.ListFeeds(request);
            // End snippet
        }

        /// <summary>Snippet for ListFeedsAsync</summary>
        public async Task ListFeedsRequestObjectAsync()
        {
            // Snippet: ListFeedsAsync(ListFeedsRequest, CallSettings)
            // Additional: ListFeedsAsync(ListFeedsRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFeedsRequest request = new ListFeedsRequest { Parent = "", };
            // Make the request
            ListFeedsResponse response = await assetServiceClient.ListFeedsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListFeeds</summary>
        public void ListFeeds()
        {
            // Snippet: ListFeeds(string, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            ListFeedsResponse response = assetServiceClient.ListFeeds(parent);
            // End snippet
        }

        /// <summary>Snippet for ListFeedsAsync</summary>
        public async Task ListFeedsAsync()
        {
            // Snippet: ListFeedsAsync(string, CallSettings)
            // Additional: ListFeedsAsync(string, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            ListFeedsResponse response = await assetServiceClient.ListFeedsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for UpdateFeed</summary>
        public void UpdateFeedRequestObject()
        {
            // Snippet: UpdateFeed(UpdateFeedRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            UpdateFeedRequest request = new UpdateFeedRequest
            {
                Feed = new Feed(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Feed response = assetServiceClient.UpdateFeed(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFeedAsync</summary>
        public async Task UpdateFeedRequestObjectAsync()
        {
            // Snippet: UpdateFeedAsync(UpdateFeedRequest, CallSettings)
            // Additional: UpdateFeedAsync(UpdateFeedRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFeedRequest request = new UpdateFeedRequest
            {
                Feed = new Feed(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Feed response = await assetServiceClient.UpdateFeedAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFeed</summary>
        public void UpdateFeed()
        {
            // Snippet: UpdateFeed(Feed, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            Feed feed = new Feed();
            // Make the request
            Feed response = assetServiceClient.UpdateFeed(feed);
            // End snippet
        }

        /// <summary>Snippet for UpdateFeedAsync</summary>
        public async Task UpdateFeedAsync()
        {
            // Snippet: UpdateFeedAsync(Feed, CallSettings)
            // Additional: UpdateFeedAsync(Feed, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            Feed feed = new Feed();
            // Make the request
            Feed response = await assetServiceClient.UpdateFeedAsync(feed);
            // End snippet
        }

        /// <summary>Snippet for DeleteFeed</summary>
        public void DeleteFeedRequestObject()
        {
            // Snippet: DeleteFeed(DeleteFeedRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            DeleteFeedRequest request = new DeleteFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            // Make the request
            assetServiceClient.DeleteFeed(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFeedAsync</summary>
        public async Task DeleteFeedRequestObjectAsync()
        {
            // Snippet: DeleteFeedAsync(DeleteFeedRequest, CallSettings)
            // Additional: DeleteFeedAsync(DeleteFeedRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFeedRequest request = new DeleteFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            // Make the request
            await assetServiceClient.DeleteFeedAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFeed</summary>
        public void DeleteFeed()
        {
            // Snippet: DeleteFeed(string, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/feeds/[FEED]";
            // Make the request
            assetServiceClient.DeleteFeed(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFeedAsync</summary>
        public async Task DeleteFeedAsync()
        {
            // Snippet: DeleteFeedAsync(string, CallSettings)
            // Additional: DeleteFeedAsync(string, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/feeds/[FEED]";
            // Make the request
            await assetServiceClient.DeleteFeedAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFeed</summary>
        public void DeleteFeedResourceNames()
        {
            // Snippet: DeleteFeed(FeedName, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            FeedName name = FeedName.FromProjectFeed("[PROJECT]", "[FEED]");
            // Make the request
            assetServiceClient.DeleteFeed(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFeedAsync</summary>
        public async Task DeleteFeedResourceNamesAsync()
        {
            // Snippet: DeleteFeedAsync(FeedName, CallSettings)
            // Additional: DeleteFeedAsync(FeedName, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeedName name = FeedName.FromProjectFeed("[PROJECT]", "[FEED]");
            // Make the request
            await assetServiceClient.DeleteFeedAsync(name);
            // End snippet
        }
    }
}
