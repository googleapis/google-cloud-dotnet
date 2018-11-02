// Copyright 2018 Google LLC
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

namespace Google.Cloud.Vision.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Vision.V1;
    using Google.LongRunning;
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
    public class GeneratedProductSearchClientSnippets
    {
        /// <summary>Snippet for CreateProductAsync</summary>
        public async Task CreateProductAsync()
        {
            // Snippet: CreateProductAsync(string,Product,string,CallSettings)
            // Additional: CreateProductAsync(string,Product,string,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            Product product = new Product();
            string productId = "";
            // Make the request
            Product response = await productSearchClient.CreateProductAsync(formattedParent, product, productId);
            // End snippet
        }

        /// <summary>Snippet for CreateProduct</summary>
        public void CreateProduct()
        {
            // Snippet: CreateProduct(string,Product,string,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            Product product = new Product();
            string productId = "";
            // Make the request
            Product response = productSearchClient.CreateProduct(formattedParent, product, productId);
            // End snippet
        }

        /// <summary>Snippet for CreateProductAsync</summary>
        public async Task CreateProductAsync_RequestObject()
        {
            // Snippet: CreateProductAsync(CreateProductRequest,CallSettings)
            // Additional: CreateProductAsync(CreateProductRequest,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            CreateProductRequest request = new CreateProductRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                Product = new Product(),
            };
            // Make the request
            Product response = await productSearchClient.CreateProductAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProduct</summary>
        public void CreateProduct_RequestObject()
        {
            // Snippet: CreateProduct(CreateProductRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            CreateProductRequest request = new CreateProductRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                Product = new Product(),
            };
            // Make the request
            Product response = productSearchClient.CreateProduct(request);
            // End snippet
        }

        /// <summary>Snippet for ListProductsAsync</summary>
        public async Task ListProductsAsync()
        {
            // Snippet: ListProductsAsync(string,string,int?,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            // Make the request
            PagedAsyncEnumerable<ListProductsResponse, Product> response =
                productSearchClient.ListProductsAsync(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Product item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProducts</summary>
        public void ListProducts()
        {
            // Snippet: ListProducts(string,string,int?,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            // Make the request
            PagedEnumerable<ListProductsResponse, Product> response =
                productSearchClient.ListProducts(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Product item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductsAsync</summary>
        public async Task ListProductsAsync_RequestObject()
        {
            // Snippet: ListProductsAsync(ListProductsRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ListProductsRequest request = new ListProductsRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            // Make the request
            PagedAsyncEnumerable<ListProductsResponse, Product> response =
                productSearchClient.ListProductsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Product item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProducts</summary>
        public void ListProducts_RequestObject()
        {
            // Snippet: ListProducts(ListProductsRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ListProductsRequest request = new ListProductsRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            // Make the request
            PagedEnumerable<ListProductsResponse, Product> response =
                productSearchClient.ListProducts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Product item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetProductAsync</summary>
        public async Task GetProductAsync()
        {
            // Snippet: GetProductAsync(string,CallSettings)
            // Additional: GetProductAsync(string,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]").ToString();
            // Make the request
            Product response = await productSearchClient.GetProductAsync(formattedName);
            // End snippet
        }

        /// <summary>Snippet for GetProduct</summary>
        public void GetProduct()
        {
            // Snippet: GetProduct(string,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string formattedName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]").ToString();
            // Make the request
            Product response = productSearchClient.GetProduct(formattedName);
            // End snippet
        }

        /// <summary>Snippet for GetProductAsync</summary>
        public async Task GetProductAsync_RequestObject()
        {
            // Snippet: GetProductAsync(GetProductRequest,CallSettings)
            // Additional: GetProductAsync(GetProductRequest,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            GetProductRequest request = new GetProductRequest
            {
                Name = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]").ToString(),
            };
            // Make the request
            Product response = await productSearchClient.GetProductAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProduct</summary>
        public void GetProduct_RequestObject()
        {
            // Snippet: GetProduct(GetProductRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            GetProductRequest request = new GetProductRequest
            {
                Name = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]").ToString(),
            };
            // Make the request
            Product response = productSearchClient.GetProduct(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProductAsync</summary>
        public async Task UpdateProductAsync()
        {
            // Snippet: UpdateProductAsync(Product,FieldMask,CallSettings)
            // Additional: UpdateProductAsync(Product,FieldMask,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            Product product = new Product();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Product response = await productSearchClient.UpdateProductAsync(product, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateProduct</summary>
        public void UpdateProduct()
        {
            // Snippet: UpdateProduct(Product,FieldMask,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            Product product = new Product();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Product response = productSearchClient.UpdateProduct(product, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateProductAsync</summary>
        public async Task UpdateProductAsync_RequestObject()
        {
            // Snippet: UpdateProductAsync(UpdateProductRequest,CallSettings)
            // Additional: UpdateProductAsync(UpdateProductRequest,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            UpdateProductRequest request = new UpdateProductRequest
            {
                Product = new Product(),
            };
            // Make the request
            Product response = await productSearchClient.UpdateProductAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProduct</summary>
        public void UpdateProduct_RequestObject()
        {
            // Snippet: UpdateProduct(UpdateProductRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            UpdateProductRequest request = new UpdateProductRequest
            {
                Product = new Product(),
            };
            // Make the request
            Product response = productSearchClient.UpdateProduct(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductAsync</summary>
        public async Task DeleteProductAsync()
        {
            // Snippet: DeleteProductAsync(string,CallSettings)
            // Additional: DeleteProductAsync(string,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]").ToString();
            // Make the request
            await productSearchClient.DeleteProductAsync(formattedName);
            // End snippet
        }

        /// <summary>Snippet for DeleteProduct</summary>
        public void DeleteProduct()
        {
            // Snippet: DeleteProduct(string,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string formattedName = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]").ToString();
            // Make the request
            productSearchClient.DeleteProduct(formattedName);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductAsync</summary>
        public async Task DeleteProductAsync_RequestObject()
        {
            // Snippet: DeleteProductAsync(DeleteProductRequest,CallSettings)
            // Additional: DeleteProductAsync(DeleteProductRequest,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            DeleteProductRequest request = new DeleteProductRequest
            {
                Name = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]").ToString(),
            };
            // Make the request
            await productSearchClient.DeleteProductAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteProduct</summary>
        public void DeleteProduct_RequestObject()
        {
            // Snippet: DeleteProduct(DeleteProductRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            DeleteProductRequest request = new DeleteProductRequest
            {
                Name = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]").ToString(),
            };
            // Make the request
            productSearchClient.DeleteProduct(request);
            // End snippet
        }

        /// <summary>Snippet for ListReferenceImagesAsync</summary>
        public async Task ListReferenceImagesAsync()
        {
            // Snippet: ListReferenceImagesAsync(string,string,int?,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]").ToString();
            // Make the request
            PagedAsyncEnumerable<ListReferenceImagesResponse, ReferenceImage> response =
                productSearchClient.ListReferenceImagesAsync(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReferenceImage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReferenceImagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReferenceImage item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReferenceImage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReferenceImage item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReferenceImages</summary>
        public void ListReferenceImages()
        {
            // Snippet: ListReferenceImages(string,string,int?,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string formattedParent = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]").ToString();
            // Make the request
            PagedEnumerable<ListReferenceImagesResponse, ReferenceImage> response =
                productSearchClient.ListReferenceImages(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReferenceImage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReferenceImagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReferenceImage item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReferenceImage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReferenceImage item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReferenceImagesAsync</summary>
        public async Task ListReferenceImagesAsync_RequestObject()
        {
            // Snippet: ListReferenceImagesAsync(ListReferenceImagesRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ListReferenceImagesRequest request = new ListReferenceImagesRequest
            {
                Parent = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]").ToString(),
            };
            // Make the request
            PagedAsyncEnumerable<ListReferenceImagesResponse, ReferenceImage> response =
                productSearchClient.ListReferenceImagesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReferenceImage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReferenceImagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReferenceImage item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReferenceImage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReferenceImage item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReferenceImages</summary>
        public void ListReferenceImages_RequestObject()
        {
            // Snippet: ListReferenceImages(ListReferenceImagesRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ListReferenceImagesRequest request = new ListReferenceImagesRequest
            {
                Parent = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]").ToString(),
            };
            // Make the request
            PagedEnumerable<ListReferenceImagesResponse, ReferenceImage> response =
                productSearchClient.ListReferenceImages(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReferenceImage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReferenceImagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReferenceImage item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReferenceImage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReferenceImage item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetReferenceImageAsync</summary>
        public async Task GetReferenceImageAsync()
        {
            // Snippet: GetReferenceImageAsync(string,CallSettings)
            // Additional: GetReferenceImageAsync(string,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new ImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[IMAGE]").ToString();
            // Make the request
            ReferenceImage response = await productSearchClient.GetReferenceImageAsync(formattedName);
            // End snippet
        }

        /// <summary>Snippet for GetReferenceImage</summary>
        public void GetReferenceImage()
        {
            // Snippet: GetReferenceImage(string,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string formattedName = new ImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[IMAGE]").ToString();
            // Make the request
            ReferenceImage response = productSearchClient.GetReferenceImage(formattedName);
            // End snippet
        }

        /// <summary>Snippet for GetReferenceImageAsync</summary>
        public async Task GetReferenceImageAsync_RequestObject()
        {
            // Snippet: GetReferenceImageAsync(GetReferenceImageRequest,CallSettings)
            // Additional: GetReferenceImageAsync(GetReferenceImageRequest,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            GetReferenceImageRequest request = new GetReferenceImageRequest
            {
                Name = new ImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[IMAGE]").ToString(),
            };
            // Make the request
            ReferenceImage response = await productSearchClient.GetReferenceImageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetReferenceImage</summary>
        public void GetReferenceImage_RequestObject()
        {
            // Snippet: GetReferenceImage(GetReferenceImageRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            GetReferenceImageRequest request = new GetReferenceImageRequest
            {
                Name = new ImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[IMAGE]").ToString(),
            };
            // Make the request
            ReferenceImage response = productSearchClient.GetReferenceImage(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteReferenceImageAsync</summary>
        public async Task DeleteReferenceImageAsync()
        {
            // Snippet: DeleteReferenceImageAsync(string,CallSettings)
            // Additional: DeleteReferenceImageAsync(string,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new ImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[IMAGE]").ToString();
            // Make the request
            await productSearchClient.DeleteReferenceImageAsync(formattedName);
            // End snippet
        }

        /// <summary>Snippet for DeleteReferenceImage</summary>
        public void DeleteReferenceImage()
        {
            // Snippet: DeleteReferenceImage(string,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string formattedName = new ImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[IMAGE]").ToString();
            // Make the request
            productSearchClient.DeleteReferenceImage(formattedName);
            // End snippet
        }

        /// <summary>Snippet for DeleteReferenceImageAsync</summary>
        public async Task DeleteReferenceImageAsync_RequestObject()
        {
            // Snippet: DeleteReferenceImageAsync(DeleteReferenceImageRequest,CallSettings)
            // Additional: DeleteReferenceImageAsync(DeleteReferenceImageRequest,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            DeleteReferenceImageRequest request = new DeleteReferenceImageRequest
            {
                Name = new ImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[IMAGE]").ToString(),
            };
            // Make the request
            await productSearchClient.DeleteReferenceImageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteReferenceImage</summary>
        public void DeleteReferenceImage_RequestObject()
        {
            // Snippet: DeleteReferenceImage(DeleteReferenceImageRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            DeleteReferenceImageRequest request = new DeleteReferenceImageRequest
            {
                Name = new ImageName("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[IMAGE]").ToString(),
            };
            // Make the request
            productSearchClient.DeleteReferenceImage(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReferenceImageAsync</summary>
        public async Task CreateReferenceImageAsync()
        {
            // Snippet: CreateReferenceImageAsync(string,ReferenceImage,string,CallSettings)
            // Additional: CreateReferenceImageAsync(string,ReferenceImage,string,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]").ToString();
            ReferenceImage referenceImage = new ReferenceImage();
            string referenceImageId = "";
            // Make the request
            ReferenceImage response = await productSearchClient.CreateReferenceImageAsync(formattedParent, referenceImage, referenceImageId);
            // End snippet
        }

        /// <summary>Snippet for CreateReferenceImage</summary>
        public void CreateReferenceImage()
        {
            // Snippet: CreateReferenceImage(string,ReferenceImage,string,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string formattedParent = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]").ToString();
            ReferenceImage referenceImage = new ReferenceImage();
            string referenceImageId = "";
            // Make the request
            ReferenceImage response = productSearchClient.CreateReferenceImage(formattedParent, referenceImage, referenceImageId);
            // End snippet
        }

        /// <summary>Snippet for CreateReferenceImageAsync</summary>
        public async Task CreateReferenceImageAsync_RequestObject()
        {
            // Snippet: CreateReferenceImageAsync(CreateReferenceImageRequest,CallSettings)
            // Additional: CreateReferenceImageAsync(CreateReferenceImageRequest,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            CreateReferenceImageRequest request = new CreateReferenceImageRequest
            {
                Parent = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]").ToString(),
                ReferenceImage = new ReferenceImage(),
            };
            // Make the request
            ReferenceImage response = await productSearchClient.CreateReferenceImageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReferenceImage</summary>
        public void CreateReferenceImage_RequestObject()
        {
            // Snippet: CreateReferenceImage(CreateReferenceImageRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            CreateReferenceImageRequest request = new CreateReferenceImageRequest
            {
                Parent = new ProductName("[PROJECT]", "[LOCATION]", "[PRODUCT]").ToString(),
                ReferenceImage = new ReferenceImage(),
            };
            // Make the request
            ReferenceImage response = productSearchClient.CreateReferenceImage(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProductSetAsync</summary>
        public async Task CreateProductSetAsync()
        {
            // Snippet: CreateProductSetAsync(string,ProductSet,string,CallSettings)
            // Additional: CreateProductSetAsync(string,ProductSet,string,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            ProductSet productSet = new ProductSet();
            string productSetId = "";
            // Make the request
            ProductSet response = await productSearchClient.CreateProductSetAsync(formattedParent, productSet, productSetId);
            // End snippet
        }

        /// <summary>Snippet for CreateProductSet</summary>
        public void CreateProductSet()
        {
            // Snippet: CreateProductSet(string,ProductSet,string,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            ProductSet productSet = new ProductSet();
            string productSetId = "";
            // Make the request
            ProductSet response = productSearchClient.CreateProductSet(formattedParent, productSet, productSetId);
            // End snippet
        }

        /// <summary>Snippet for CreateProductSetAsync</summary>
        public async Task CreateProductSetAsync_RequestObject()
        {
            // Snippet: CreateProductSetAsync(CreateProductSetRequest,CallSettings)
            // Additional: CreateProductSetAsync(CreateProductSetRequest,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            CreateProductSetRequest request = new CreateProductSetRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                ProductSet = new ProductSet(),
            };
            // Make the request
            ProductSet response = await productSearchClient.CreateProductSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProductSet</summary>
        public void CreateProductSet_RequestObject()
        {
            // Snippet: CreateProductSet(CreateProductSetRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            CreateProductSetRequest request = new CreateProductSetRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                ProductSet = new ProductSet(),
            };
            // Make the request
            ProductSet response = productSearchClient.CreateProductSet(request);
            // End snippet
        }

        /// <summary>Snippet for ListProductSetsAsync</summary>
        public async Task ListProductSetsAsync()
        {
            // Snippet: ListProductSetsAsync(string,string,int?,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            // Make the request
            PagedAsyncEnumerable<ListProductSetsResponse, ProductSet> response =
                productSearchClient.ListProductSetsAsync(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProductSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProductSet item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProductSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProductSet item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductSets</summary>
        public void ListProductSets()
        {
            // Snippet: ListProductSets(string,string,int?,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            // Make the request
            PagedEnumerable<ListProductSetsResponse, ProductSet> response =
                productSearchClient.ListProductSets(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProductSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProductSet item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProductSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProductSet item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductSetsAsync</summary>
        public async Task ListProductSetsAsync_RequestObject()
        {
            // Snippet: ListProductSetsAsync(ListProductSetsRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ListProductSetsRequest request = new ListProductSetsRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            // Make the request
            PagedAsyncEnumerable<ListProductSetsResponse, ProductSet> response =
                productSearchClient.ListProductSetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProductSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProductSet item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProductSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProductSet item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductSets</summary>
        public void ListProductSets_RequestObject()
        {
            // Snippet: ListProductSets(ListProductSetsRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ListProductSetsRequest request = new ListProductSetsRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            // Make the request
            PagedEnumerable<ListProductSetsResponse, ProductSet> response =
                productSearchClient.ListProductSets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProductSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProductSet item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProductSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProductSet item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetProductSetAsync</summary>
        public async Task GetProductSetAsync()
        {
            // Snippet: GetProductSetAsync(string,CallSettings)
            // Additional: GetProductSetAsync(string,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString();
            // Make the request
            ProductSet response = await productSearchClient.GetProductSetAsync(formattedName);
            // End snippet
        }

        /// <summary>Snippet for GetProductSet</summary>
        public void GetProductSet()
        {
            // Snippet: GetProductSet(string,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string formattedName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString();
            // Make the request
            ProductSet response = productSearchClient.GetProductSet(formattedName);
            // End snippet
        }

        /// <summary>Snippet for GetProductSetAsync</summary>
        public async Task GetProductSetAsync_RequestObject()
        {
            // Snippet: GetProductSetAsync(GetProductSetRequest,CallSettings)
            // Additional: GetProductSetAsync(GetProductSetRequest,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            GetProductSetRequest request = new GetProductSetRequest
            {
                Name = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString(),
            };
            // Make the request
            ProductSet response = await productSearchClient.GetProductSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProductSet</summary>
        public void GetProductSet_RequestObject()
        {
            // Snippet: GetProductSet(GetProductSetRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            GetProductSetRequest request = new GetProductSetRequest
            {
                Name = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString(),
            };
            // Make the request
            ProductSet response = productSearchClient.GetProductSet(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProductSetAsync</summary>
        public async Task UpdateProductSetAsync()
        {
            // Snippet: UpdateProductSetAsync(ProductSet,FieldMask,CallSettings)
            // Additional: UpdateProductSetAsync(ProductSet,FieldMask,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ProductSet productSet = new ProductSet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ProductSet response = await productSearchClient.UpdateProductSetAsync(productSet, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateProductSet</summary>
        public void UpdateProductSet()
        {
            // Snippet: UpdateProductSet(ProductSet,FieldMask,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ProductSet productSet = new ProductSet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ProductSet response = productSearchClient.UpdateProductSet(productSet, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateProductSetAsync</summary>
        public async Task UpdateProductSetAsync_RequestObject()
        {
            // Snippet: UpdateProductSetAsync(UpdateProductSetRequest,CallSettings)
            // Additional: UpdateProductSetAsync(UpdateProductSetRequest,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            UpdateProductSetRequest request = new UpdateProductSetRequest
            {
                ProductSet = new ProductSet(),
            };
            // Make the request
            ProductSet response = await productSearchClient.UpdateProductSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProductSet</summary>
        public void UpdateProductSet_RequestObject()
        {
            // Snippet: UpdateProductSet(UpdateProductSetRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            UpdateProductSetRequest request = new UpdateProductSetRequest
            {
                ProductSet = new ProductSet(),
            };
            // Make the request
            ProductSet response = productSearchClient.UpdateProductSet(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductSetAsync</summary>
        public async Task DeleteProductSetAsync()
        {
            // Snippet: DeleteProductSetAsync(string,CallSettings)
            // Additional: DeleteProductSetAsync(string,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString();
            // Make the request
            await productSearchClient.DeleteProductSetAsync(formattedName);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductSet</summary>
        public void DeleteProductSet()
        {
            // Snippet: DeleteProductSet(string,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string formattedName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString();
            // Make the request
            productSearchClient.DeleteProductSet(formattedName);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductSetAsync</summary>
        public async Task DeleteProductSetAsync_RequestObject()
        {
            // Snippet: DeleteProductSetAsync(DeleteProductSetRequest,CallSettings)
            // Additional: DeleteProductSetAsync(DeleteProductSetRequest,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            DeleteProductSetRequest request = new DeleteProductSetRequest
            {
                Name = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString(),
            };
            // Make the request
            await productSearchClient.DeleteProductSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductSet</summary>
        public void DeleteProductSet_RequestObject()
        {
            // Snippet: DeleteProductSet(DeleteProductSetRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            DeleteProductSetRequest request = new DeleteProductSetRequest
            {
                Name = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString(),
            };
            // Make the request
            productSearchClient.DeleteProductSet(request);
            // End snippet
        }

        /// <summary>Snippet for AddProductToProductSetAsync</summary>
        public async Task AddProductToProductSetAsync()
        {
            // Snippet: AddProductToProductSetAsync(string,string,CallSettings)
            // Additional: AddProductToProductSetAsync(string,string,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString();
            string product = "";
            // Make the request
            await productSearchClient.AddProductToProductSetAsync(formattedName, product);
            // End snippet
        }

        /// <summary>Snippet for AddProductToProductSet</summary>
        public void AddProductToProductSet()
        {
            // Snippet: AddProductToProductSet(string,string,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string formattedName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString();
            string product = "";
            // Make the request
            productSearchClient.AddProductToProductSet(formattedName, product);
            // End snippet
        }

        /// <summary>Snippet for AddProductToProductSetAsync</summary>
        public async Task AddProductToProductSetAsync_RequestObject()
        {
            // Snippet: AddProductToProductSetAsync(AddProductToProductSetRequest,CallSettings)
            // Additional: AddProductToProductSetAsync(AddProductToProductSetRequest,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            AddProductToProductSetRequest request = new AddProductToProductSetRequest
            {
                Name = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString(),
                Product = "",
            };
            // Make the request
            await productSearchClient.AddProductToProductSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddProductToProductSet</summary>
        public void AddProductToProductSet_RequestObject()
        {
            // Snippet: AddProductToProductSet(AddProductToProductSetRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            AddProductToProductSetRequest request = new AddProductToProductSetRequest
            {
                Name = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString(),
                Product = "",
            };
            // Make the request
            productSearchClient.AddProductToProductSet(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveProductFromProductSetAsync</summary>
        public async Task RemoveProductFromProductSetAsync()
        {
            // Snippet: RemoveProductFromProductSetAsync(string,string,CallSettings)
            // Additional: RemoveProductFromProductSetAsync(string,string,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString();
            string product = "";
            // Make the request
            await productSearchClient.RemoveProductFromProductSetAsync(formattedName, product);
            // End snippet
        }

        /// <summary>Snippet for RemoveProductFromProductSet</summary>
        public void RemoveProductFromProductSet()
        {
            // Snippet: RemoveProductFromProductSet(string,string,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string formattedName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString();
            string product = "";
            // Make the request
            productSearchClient.RemoveProductFromProductSet(formattedName, product);
            // End snippet
        }

        /// <summary>Snippet for RemoveProductFromProductSetAsync</summary>
        public async Task RemoveProductFromProductSetAsync_RequestObject()
        {
            // Snippet: RemoveProductFromProductSetAsync(RemoveProductFromProductSetRequest,CallSettings)
            // Additional: RemoveProductFromProductSetAsync(RemoveProductFromProductSetRequest,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            RemoveProductFromProductSetRequest request = new RemoveProductFromProductSetRequest
            {
                Name = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString(),
                Product = "",
            };
            // Make the request
            await productSearchClient.RemoveProductFromProductSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveProductFromProductSet</summary>
        public void RemoveProductFromProductSet_RequestObject()
        {
            // Snippet: RemoveProductFromProductSet(RemoveProductFromProductSetRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            RemoveProductFromProductSetRequest request = new RemoveProductFromProductSetRequest
            {
                Name = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString(),
                Product = "",
            };
            // Make the request
            productSearchClient.RemoveProductFromProductSet(request);
            // End snippet
        }

        /// <summary>Snippet for ListProductsInProductSetAsync</summary>
        public async Task ListProductsInProductSetAsync()
        {
            // Snippet: ListProductsInProductSetAsync(string,string,int?,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString();
            // Make the request
            PagedAsyncEnumerable<ListProductsInProductSetResponse, Product> response =
                productSearchClient.ListProductsInProductSetAsync(formattedName);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Product item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductsInProductSetResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductsInProductSet</summary>
        public void ListProductsInProductSet()
        {
            // Snippet: ListProductsInProductSet(string,string,int?,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string formattedName = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString();
            // Make the request
            PagedEnumerable<ListProductsInProductSetResponse, Product> response =
                productSearchClient.ListProductsInProductSet(formattedName);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Product item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductsInProductSetResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductsInProductSetAsync</summary>
        public async Task ListProductsInProductSetAsync_RequestObject()
        {
            // Snippet: ListProductsInProductSetAsync(ListProductsInProductSetRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ListProductsInProductSetRequest request = new ListProductsInProductSetRequest
            {
                Name = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString(),
            };
            // Make the request
            PagedAsyncEnumerable<ListProductsInProductSetResponse, Product> response =
                productSearchClient.ListProductsInProductSetAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Product item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductsInProductSetResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductsInProductSet</summary>
        public void ListProductsInProductSet_RequestObject()
        {
            // Snippet: ListProductsInProductSet(ListProductsInProductSetRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ListProductsInProductSetRequest request = new ListProductsInProductSetRequest
            {
                Name = new ProductSetName("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]").ToString(),
            };
            // Make the request
            PagedEnumerable<ListProductsInProductSetResponse, Product> response =
                productSearchClient.ListProductsInProductSet(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Product item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductsInProductSetResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ImportProductSetsAsync</summary>
        public async Task ImportProductSetsAsync()
        {
            // Snippet: ImportProductSetsAsync(string,ImportProductSetsInputConfig,CallSettings)
            // Additional: ImportProductSetsAsync(string,ImportProductSetsInputConfig,CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            ImportProductSetsInputConfig inputConfig = new ImportProductSetsInputConfig();
            // Make the request
            Operation<ImportProductSetsResponse, BatchOperationMetadata> response =
                await productSearchClient.ImportProductSetsAsync(formattedParent, inputConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportProductSetsResponse, BatchOperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportProductSetsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportProductSetsResponse, BatchOperationMetadata> retrievedResponse =
                await productSearchClient.PollOnceImportProductSetsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportProductSetsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportProductSets</summary>
        public void ImportProductSets()
        {
            // Snippet: ImportProductSets(string,ImportProductSetsInputConfig,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            ImportProductSetsInputConfig inputConfig = new ImportProductSetsInputConfig();
            // Make the request
            Operation<ImportProductSetsResponse, BatchOperationMetadata> response =
                productSearchClient.ImportProductSets(formattedParent, inputConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportProductSetsResponse, BatchOperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            ImportProductSetsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportProductSetsResponse, BatchOperationMetadata> retrievedResponse =
                productSearchClient.PollOnceImportProductSets(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportProductSetsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportProductSetsAsync</summary>
        public async Task ImportProductSetsAsync_RequestObject()
        {
            // Snippet: ImportProductSetsAsync(ImportProductSetsRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ImportProductSetsRequest request = new ImportProductSetsRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                InputConfig = new ImportProductSetsInputConfig(),
            };
            // Make the request
            Operation<ImportProductSetsResponse, BatchOperationMetadata> response =
                await productSearchClient.ImportProductSetsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportProductSetsResponse, BatchOperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportProductSetsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportProductSetsResponse, BatchOperationMetadata> retrievedResponse =
                await productSearchClient.PollOnceImportProductSetsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportProductSetsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportProductSets</summary>
        public void ImportProductSets_RequestObject()
        {
            // Snippet: ImportProductSets(ImportProductSetsRequest,CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ImportProductSetsRequest request = new ImportProductSetsRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                InputConfig = new ImportProductSetsInputConfig(),
            };
            // Make the request
            Operation<ImportProductSetsResponse, BatchOperationMetadata> response =
                productSearchClient.ImportProductSets(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportProductSetsResponse, BatchOperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            ImportProductSetsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportProductSetsResponse, BatchOperationMetadata> retrievedResponse =
                productSearchClient.PollOnceImportProductSets(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportProductSetsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

    }
}
