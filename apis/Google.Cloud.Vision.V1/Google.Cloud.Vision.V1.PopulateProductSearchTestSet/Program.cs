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

using Google.Cloud.Storage.V1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Vision.V1.PopulateProductSearchTestSet
{
    /// <summary>
    /// Application to populate a sample set of products for tests and snippets.
    /// TODO: Handle the set (and maybe the bucket) already existing.
    /// </summary>
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Arguments: <directory containing product.json> <project ID>");
                return 1;
            }
            string directory = args[0];
            var json = File.ReadAllText(Path.Combine(directory, "products.json"));
            var products = JsonConvert.DeserializeObject<List<JsonProduct>>(json);

            // Default the location and bucket so it's easily predictable in tests.
            string projectId = args[1];
            string locationId = "us-west1";
            string bucketName = $"{projectId}_product_search_test";
            string bucketUri= $"gs://{bucketName}";
            string productSetId = $"{projectId}_product_search_test";
            var location = new LocationName(projectId, locationId);

            var storageClient = StorageClient.Create();
            var productSearchClient = ProductSearchClient.Create();

            // Create the GCS bucket and upload the images
            storageClient.CreateBucket(projectId, bucketName);
            foreach (var product in products)
            {
                using (var stream = File.OpenRead(Path.Combine(directory, product.Image)))
                {
                    // TODO: Autodetect the mime type if we ever have non-JPEG images
                    storageClient.UploadObject(bucketName, product.Image, "image/jpeg", stream);
                }
            }

            // Create the product set
            var createProductSetRequest = new CreateProductSetRequest
            {
                ParentAsLocationName = location,
                ProductSetId = productSetId,
                ProductSet = new ProductSet
                {
                    DisplayName = "Product set for testing"
                }
            };
            
            // Add the products. Each product needs to be:
            // - Created
            // - Added to the product set
            // - Associated with a reference image
            var productSetResource = productSearchClient.CreateProductSet(createProductSetRequest);
            foreach (var product in products)
            {
                var createProductRequest = new CreateProductRequest
                {
                    ParentAsLocationName = location,
                    ProductId = product.Id,
                    Product = new Product
                    {
                        Description = product.Description,
                        DisplayName = product.DisplayName,
                        ProductCategory = product.Category,
                        ProductLabels = { product.Labels.Select(kvp => new Product.Types.KeyValue { Key = kvp.Key, Value = kvp.Value }) }                        
                    }
                };
                var productResource = productSearchClient.CreateProduct(createProductRequest);
                productSearchClient.AddProductToProductSet(productSetResource.ProductSetName, productResource.ProductName);

                productSearchClient.CreateReferenceImage(productResource.ProductName, new ReferenceImage { Uri = $"{bucketUri}/{product.Image}" }, product.Image);
            }
            return 0;
        }
    }
}
