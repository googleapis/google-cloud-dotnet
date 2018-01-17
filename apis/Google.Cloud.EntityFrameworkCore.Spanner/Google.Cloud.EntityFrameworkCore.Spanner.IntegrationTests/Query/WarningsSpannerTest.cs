// Copyright 2017 Google Inc. All Rights Reserved.
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
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Query;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Query
{
    public class WarningsSpannerTest : WarningsTestBase<WarningsSpannerFixture>
    {
        public WarningsSpannerTest(WarningsSpannerFixture fixture)
            : base(fixture)
        {
            fixture.TestSqlLoggerFactory.Clear();
        }

        public override void Paging_operation_without_orderby_issues_warning()
        {
            base.Paging_operation_without_orderby_issues_warning();

            Assert.Contains(CoreStrings.LogRowLimitingOperationWithoutOrderBy.GenerateMessage(
                    "(from Customer <generated>_2 in DbSet<Customer> select [<generated>_2]).Skip(__p_0).Take(__p_1)"),
                Fixture.TestSqlLoggerFactory.Log);
        }

        public override void FirstOrDefault_without_orderby_and_filter_issues_warning_subquery()
        {
            base.FirstOrDefault_without_orderby_and_filter_issues_warning_subquery();

            Assert.Contains(CoreStrings.LogFirstWithoutOrderByAndFilter.GenerateMessage(
                    "(from Order <generated>_1 in [c].Orders select [<generated>_1].OrderID).FirstOrDefault()"),
                Fixture.TestSqlLoggerFactory.Log);
        }

        public override void FirstOrDefault_without_orderby_but_with_filter_doesnt_issue_warning()
        {
            base.FirstOrDefault_without_orderby_but_with_filter_doesnt_issue_warning();

            Assert.DoesNotContain(CoreStrings.LogFirstWithoutOrderByAndFilter.GenerateMessage(
                    @"(from Customer c in DbSet<Customer> where c.CustomerID == ""ALFKI"" select c).FirstOrDefault()"),
                Fixture.TestSqlLoggerFactory.Log);
        }

        public override void Single_SingleOrDefault_without_orderby_doesnt_issue_warning()
        {
            base.Single_SingleOrDefault_without_orderby_doesnt_issue_warning();

            Assert.DoesNotContain(CoreStrings.LogFirstWithoutOrderByAndFilter.GenerateMessage(
                    @"(from Customer c in DbSet<Customer> where c.CustomerID == ""ALFKI"" select c).Single()"),
                Fixture.TestSqlLoggerFactory.Log);
        }

        public override void Comparing_collection_navigation_to_null_issues_possible_unintended_consequences_warning()
        {
            base.Comparing_collection_navigation_to_null_issues_possible_unintended_consequences_warning();

            Assert.Contains(
                CoreStrings.LogPossibleUnintendedCollectionNavigationNullComparison.GenerateMessage("Orders"),
                Fixture.TestSqlLoggerFactory.Log);
        }

        public override void
            Comparing_two_collections_together_issues_possible_unintended_reference_comparison_warning()
        {
            base.Comparing_two_collections_together_issues_possible_unintended_reference_comparison_warning();

            Assert.Contains(
                CoreStrings.LogPossibleUnintendedReferenceComparison.GenerateMessage("[c].Orders", "[c].Orders"),
                Fixture.TestSqlLoggerFactory.Log);
        }

        private const string FileLineEnding = @"
";

        private string Sql => Fixture.TestSqlLoggerFactory.Sql.Replace(Environment.NewLine, FileLineEnding);
    }
}