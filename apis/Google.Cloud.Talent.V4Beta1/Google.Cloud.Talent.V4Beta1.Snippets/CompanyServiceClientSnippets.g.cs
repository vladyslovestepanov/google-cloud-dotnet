// Copyright 2019 Google LLC
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

namespace Google.Cloud.Talent.V4Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Talent.V4Beta1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedCompanyServiceClientSnippets
    {
        /// <summary>Snippet for CreateCompanyAsync</summary>
        public async Task CreateCompanyAsync()
        {
            // Snippet: CreateCompanyAsync(string,Company,CallSettings)
            // Additional: CreateCompanyAsync(string,Company,CancellationToken)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString();
            Company company = new Company();
            // Make the request
            Company response = await companyServiceClient.CreateCompanyAsync(formattedParent, company);
            // End snippet
        }

        /// <summary>Snippet for CreateCompany</summary>
        public void CreateCompany()
        {
            // Snippet: CreateCompany(string,Company,CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            string formattedParent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString();
            Company company = new Company();
            // Make the request
            Company response = companyServiceClient.CreateCompany(formattedParent, company);
            // End snippet
        }

        /// <summary>Snippet for CreateCompanyAsync</summary>
        public async Task CreateCompanyAsync_RequestObject()
        {
            // Snippet: CreateCompanyAsync(CreateCompanyRequest,CallSettings)
            // Additional: CreateCompanyAsync(CreateCompanyRequest,CancellationToken)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCompanyRequest request = new CreateCompanyRequest
            {
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
                Company = new Company(),
            };
            // Make the request
            Company response = await companyServiceClient.CreateCompanyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCompany</summary>
        public void CreateCompany_RequestObject()
        {
            // Snippet: CreateCompany(CreateCompanyRequest,CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            CreateCompanyRequest request = new CreateCompanyRequest
            {
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
                Company = new Company(),
            };
            // Make the request
            Company response = companyServiceClient.CreateCompany(request);
            // End snippet
        }

        /// <summary>Snippet for GetCompanyAsync</summary>
        public async Task GetCompanyAsync()
        {
            // Snippet: GetCompanyAsync(string,CallSettings)
            // Additional: GetCompanyAsync(string,CancellationToken)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new CompanyName("[PROJECT]", "[COMPANY]").ToString();
            // Make the request
            Company response = await companyServiceClient.GetCompanyAsync(formattedName);
            // End snippet
        }

        /// <summary>Snippet for GetCompany</summary>
        public void GetCompany()
        {
            // Snippet: GetCompany(string,CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = new CompanyName("[PROJECT]", "[COMPANY]").ToString();
            // Make the request
            Company response = companyServiceClient.GetCompany(formattedName);
            // End snippet
        }

        /// <summary>Snippet for GetCompanyAsync</summary>
        public async Task GetCompanyAsync_RequestObject()
        {
            // Snippet: GetCompanyAsync(GetCompanyRequest,CallSettings)
            // Additional: GetCompanyAsync(GetCompanyRequest,CancellationToken)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCompanyRequest request = new GetCompanyRequest
            {
                Name = new CompanyName("[PROJECT]", "[COMPANY]").ToString(),
            };
            // Make the request
            Company response = await companyServiceClient.GetCompanyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCompany</summary>
        public void GetCompany_RequestObject()
        {
            // Snippet: GetCompany(GetCompanyRequest,CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            GetCompanyRequest request = new GetCompanyRequest
            {
                Name = new CompanyName("[PROJECT]", "[COMPANY]").ToString(),
            };
            // Make the request
            Company response = companyServiceClient.GetCompany(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCompanyAsync</summary>
        public async Task UpdateCompanyAsync()
        {
            // Snippet: UpdateCompanyAsync(Company,CallSettings)
            // Additional: UpdateCompanyAsync(Company,CancellationToken)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            Company company = new Company();
            // Make the request
            Company response = await companyServiceClient.UpdateCompanyAsync(company);
            // End snippet
        }

        /// <summary>Snippet for UpdateCompany</summary>
        public void UpdateCompany()
        {
            // Snippet: UpdateCompany(Company,CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            Company company = new Company();
            // Make the request
            Company response = companyServiceClient.UpdateCompany(company);
            // End snippet
        }

        /// <summary>Snippet for UpdateCompanyAsync</summary>
        public async Task UpdateCompanyAsync_RequestObject()
        {
            // Snippet: UpdateCompanyAsync(UpdateCompanyRequest,CallSettings)
            // Additional: UpdateCompanyAsync(UpdateCompanyRequest,CancellationToken)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCompanyRequest request = new UpdateCompanyRequest
            {
                Company = new Company(),
            };
            // Make the request
            Company response = await companyServiceClient.UpdateCompanyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCompany</summary>
        public void UpdateCompany_RequestObject()
        {
            // Snippet: UpdateCompany(UpdateCompanyRequest,CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            UpdateCompanyRequest request = new UpdateCompanyRequest
            {
                Company = new Company(),
            };
            // Make the request
            Company response = companyServiceClient.UpdateCompany(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCompanyAsync</summary>
        public async Task DeleteCompanyAsync()
        {
            // Snippet: DeleteCompanyAsync(string,CallSettings)
            // Additional: DeleteCompanyAsync(string,CancellationToken)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new CompanyName("[PROJECT]", "[COMPANY]").ToString();
            // Make the request
            await companyServiceClient.DeleteCompanyAsync(formattedName);
            // End snippet
        }

        /// <summary>Snippet for DeleteCompany</summary>
        public void DeleteCompany()
        {
            // Snippet: DeleteCompany(string,CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = new CompanyName("[PROJECT]", "[COMPANY]").ToString();
            // Make the request
            companyServiceClient.DeleteCompany(formattedName);
            // End snippet
        }

        /// <summary>Snippet for DeleteCompanyAsync</summary>
        public async Task DeleteCompanyAsync_RequestObject()
        {
            // Snippet: DeleteCompanyAsync(DeleteCompanyRequest,CallSettings)
            // Additional: DeleteCompanyAsync(DeleteCompanyRequest,CancellationToken)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCompanyRequest request = new DeleteCompanyRequest
            {
                Name = new CompanyName("[PROJECT]", "[COMPANY]").ToString(),
            };
            // Make the request
            await companyServiceClient.DeleteCompanyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCompany</summary>
        public void DeleteCompany_RequestObject()
        {
            // Snippet: DeleteCompany(DeleteCompanyRequest,CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            DeleteCompanyRequest request = new DeleteCompanyRequest
            {
                Name = new CompanyName("[PROJECT]", "[COMPANY]").ToString(),
            };
            // Make the request
            companyServiceClient.DeleteCompany(request);
            // End snippet
        }

        /// <summary>Snippet for ListCompaniesAsync</summary>
        public async Task ListCompaniesAsync()
        {
            // Snippet: ListCompaniesAsync(string,string,int?,CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString();
            // Make the request
            PagedAsyncEnumerable<ListCompaniesResponse, Company> response =
                companyServiceClient.ListCompaniesAsync(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Company item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCompaniesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Company item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Company> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Company item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCompanies</summary>
        public void ListCompanies()
        {
            // Snippet: ListCompanies(string,string,int?,CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            string formattedParent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString();
            // Make the request
            PagedEnumerable<ListCompaniesResponse, Company> response =
                companyServiceClient.ListCompanies(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Company item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCompaniesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Company item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Company> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Company item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCompaniesAsync</summary>
        public async Task ListCompaniesAsync_RequestObject()
        {
            // Snippet: ListCompaniesAsync(ListCompaniesRequest,CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = await CompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCompaniesRequest request = new ListCompaniesRequest
            {
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
            };
            // Make the request
            PagedAsyncEnumerable<ListCompaniesResponse, Company> response =
                companyServiceClient.ListCompaniesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Company item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCompaniesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Company item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Company> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Company item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCompanies</summary>
        public void ListCompanies_RequestObject()
        {
            // Snippet: ListCompanies(ListCompaniesRequest,CallSettings)
            // Create client
            CompanyServiceClient companyServiceClient = CompanyServiceClient.Create();
            // Initialize request argument(s)
            ListCompaniesRequest request = new ListCompaniesRequest
            {
                Parent = new Google.Api.Gax.ResourceNames.ProjectName("[PROJECT]").ToString(),
            };
            // Make the request
            PagedEnumerable<ListCompaniesResponse, Company> response =
                companyServiceClient.ListCompanies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Company item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCompaniesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Company item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Company> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Company item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

    }
}