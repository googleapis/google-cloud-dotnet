// Copyright 2026 Google LLC
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

#pragma warning disable CS8981

namespace Google.DevicesAndServices.Health.V4
{
    public partial class NutritionLog
    {
        /// <summary>
        /// <see cref="DataPointName"/>-typed view over the <see cref="Food"/> resource name property.
        /// </summary>
        public DataPointName FoodAsDataPointName
        {
            get => string.IsNullOrEmpty(Food) ? null : DataPointName.Parse(Food, allowUnparsed: true);
            set => Food = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class Serving
            {
                /// <summary>
                /// <see cref="DataPointName"/>-typed view over the <see cref="FoodMeasurementUnit"/> resource name
                /// property.
                /// </summary>
                public DataPointName FoodMeasurementUnitAsDataPointName
                {
                    get => string.IsNullOrEmpty(FoodMeasurementUnit) ? null : DataPointName.Parse(FoodMeasurementUnit, allowUnparsed: true);
                    set => FoodMeasurementUnit = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class Food
    {
        public partial class Types
        {
            public partial class FoodServing
            {
                /// <summary>
                /// <see cref="DataPointName"/>-typed view over the <see cref="FoodMeasurementUnit"/> resource name
                /// property.
                /// </summary>
                public DataPointName FoodMeasurementUnitAsDataPointName
                {
                    get => string.IsNullOrEmpty(FoodMeasurementUnit) ? null : DataPointName.Parse(FoodMeasurementUnit, allowUnparsed: true);
                    set => FoodMeasurementUnit = value?.ToString() ?? "";
                }
            }
        }
    }
}
