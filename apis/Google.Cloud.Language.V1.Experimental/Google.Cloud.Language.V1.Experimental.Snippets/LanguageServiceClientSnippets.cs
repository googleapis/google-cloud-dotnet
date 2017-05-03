// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Xunit;
using static Google.Cloud.Language.V1.AnnotateTextRequest.Types;
using static Google.Cloud.Language.V1.PartOfSpeech.Types;

namespace Google.Cloud.Language.V1.Snippets
{
    public class LanguageServiceClientSnippets
    {
        [Fact]
        public void AnalyzeEntities()
        {
            // Sample: AnalyzeEntities
            // Additional: AnalyzeEntities(Document,*)
            LanguageServiceClient client = LanguageServiceClient.Create();
            Document document = Document.FromPlainText("Richard of York gave battle in vain.");
            AnalyzeEntitiesResponse response = client.AnalyzeEntities(document);
            Console.WriteLine($"Detected language: {response.Language}");
            Console.WriteLine("Detected entities:");
            foreach (Entity entity in response.Entities)
            {
                Console.WriteLine($"  {entity.Name} ({(int) (entity.Salience * 100)}%)");
            }
            // End sample

            Assert.Equal(3, response.Entities.Count);
            Assert.Equal("Richard of York", response.Entities[0].Name);
        }

        [Fact]
        public void AnalyzeSentiment()
        {
            // Sample: AnalyzeSentiment
            // Additional: AnalyzeSentiment(Document,*)
            LanguageServiceClient client = LanguageServiceClient.Create();
            Document document = Document.FromPlainText("You're simply the best - better than all the rest.");
            AnalyzeSentimentResponse response = client.AnalyzeSentiment(document);
            Console.WriteLine($"Detected language: {response.Language}");
            Console.WriteLine($"Sentiment score: {response.DocumentSentiment.Score}");
            Console.WriteLine($"Sentiment magnitude: {response.DocumentSentiment.Magnitude}");
            // End sample

            // This is fairly positive...
            Assert.True(response.DocumentSentiment.Score > 0.5);
        }

        [Fact]
        public void AnalyzeSyntax()
        {
            // Sample: AnalyzeSyntax
            // Additional: AnalyzeSyntax(Document,*)
            LanguageServiceClient client = LanguageServiceClient.Create();
            Document document = Document.FromPlainText(
                "This is a simple sentence. This sentence, while not very complicated, is still more complicated than the first");
            AnalyzeSyntaxResponse response = client.AnalyzeSyntax(document);
            Console.WriteLine($"Detected language: {response.Language}");
            Console.WriteLine($"Number of sentences: {response.Sentences.Count}");
            Console.WriteLine($"Number of tokens: {response.Tokens.Count}");
            // End sample

            Assert.Equal(2, response.Sentences.Count);
            Assert.Equal(21, response.Tokens.Count);
        }

        [Fact]
        public void AnnotateText()
        {
            // Sample: AnnotateText
            // Additional: AnnotateText(Document,Features,CallSettings)
            LanguageServiceClient client = LanguageServiceClient.Create();
            Document document = Document.FromPlainText("Richard of York gave battle in vain.");
            // "Features" selects which features you wish to enable. Here we want to extract syntax
            // and entities - you can also extract document sentiment and entity sentiment.
            AnnotateTextResponse response = client.AnnotateText(document,
                new Features { ExtractSyntax = true, ExtractEntities = true });
            Console.WriteLine($"Detected language: {response.Language}");
            // The Sentences and Tokens properties provide all kinds of information
            // about the parsed text.
            Console.WriteLine($"Number of sentences: {response.Sentences.Count}");
            Console.WriteLine($"Number of tokens: {response.Tokens.Count}");
            Console.WriteLine("Detected entities:");
            foreach (Entity entity in response.Entities)
            {
                Console.WriteLine($"  {entity.Name} ({(int)(entity.Salience * 100)}%)");
            }
            // End sample

            Assert.Equal(1, response.Sentences.Count);
            Assert.Equal(8, response.Tokens.Count);
            Assert.Equal("Richard", response.Tokens[0].Text.Content);
            Assert.Equal(Tag.Noun, response.Tokens[0].PartOfSpeech.Tag);
            Assert.Equal(".", response.Tokens[7].Text.Content);
            Assert.Equal(Tag.Punct, response.Tokens[7].PartOfSpeech.Tag);
            Assert.Equal(3, response.Entities.Count);
            Assert.Equal("Richard of York", response.Entities[0].Name);
        }

        [Fact]
        public void AnalyzeEntitySentiment()
        {
            // Sample: AnalyzeEntitySentiment
            // Additional: AnalyzeEntitySentiment(Document,CallSettings)
            LanguageServiceClient client = LanguageServiceClient.Create();
            Document document = Document.FromPlainText("Jennifer is clever and witty, but Robert is rude.");
            AnalyzeEntitySentimentResponse response = client.AnalyzeEntitySentiment(document);
            foreach (Entity entity in response.Entities)
            {
                Console.WriteLine($"{entity.Name} ({(int)(entity.Salience * 100)}%)");
                Console.WriteLine($"  Sentiment score: {entity.Sentiment.Score}; magnitude: {entity.Sentiment.Magnitude}");
            }
            // End sample
        }
    }
}
