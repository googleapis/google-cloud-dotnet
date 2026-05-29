# Version history

## Version 1.0.0-beta02, released 2026-05-29

### New features

- Introduce MedicalDeviceInfo message for Software as Medical Device (SaMD) metadata tracking
- Add core health data types and rollups for nutrition, core body temperature, ECG, irregular rhythm notifications (IRN), blood glucose, and active energy burned
- Expand DataPoint and DataPoint.Value messages with optional fields and rollups for new health metrics
- Add CreateSubscription, ListSubscriptions, UpdateSubscription, and DeleteSubscription RPCs alongside the Subscription resource definition
- Add GetIrnProfile, GetPairedDevice, and ListPairedDevices RPCs alongside PairedDevice and IrnProfile messages
- Introduce OAuth scopes for ECG, IRN readonly access
- Add User root resource message
- Introduce Data Subscription Service for managing webhook notifications
- Add GetDataPoint and GetIdentity methods to DataPointsService
- Enable filtering Electrocardiogram data by start time

### Bug fixes

- Changed proto3 optional flag of an existing field `active_zone_minutes` in message `.google.devicesandservices.health.v4.ActiveZoneMinutes`
- Changed proto3 optional flag of an existing field `sum_in_cardio_heart_zone` in message `.google.devicesandservices.health.v4.ActiveZoneMinutesRollupValue`
- Changed proto3 optional flag of an existing field `sum_in_peak_heart_zone` in message `.google.devicesandservices.health.v4.ActiveZoneMinutesRollupValue`
- Changed proto3 optional flag of an existing field `sum_in_fat_burn_heart_zone` in message `.google.devicesandservices.health.v4.ActiveZoneMinutesRollupValue`
- Changed proto3 optional flag of an existing field `active_minutes` in message `.google.devicesandservices.health.v4.ActiveMinutes`
- Changed proto3 optional flag of an existing field `active_minutes_sum` in message `.google.devicesandservices.health.v4.ActiveMinutesRollupValue`
- Changed proto3 optional flag of an existing field `gain_millimeters` in message `.google.devicesandservices.health.v4.Altitude`
- Changed proto3 optional flag of an existing field `kcal` in message `.google.devicesandservices.health.v4.BasalEnergyBurned`
- Changed proto3 optional flag of an existing field `percentage` in message `.google.devicesandservices.health.v4.BodyFat`
- Changed proto3 optional flag of an existing field `body_fat_percentage_avg` in message `.google.devicesandservices.health.v4.BodyFatRollupValue`
- Changed proto3 optional flag of an existing field `kcal` in message `.google.devicesandservices.health.v4.CaloriesInHeartRateZoneRollupValue`
- Changed proto3 optional flag of an existing field `min_beats_per_minute` in message `.google.devicesandservices.health.v4.DailyHeartRateZones`
- Changed proto3 optional flag of an existing field `max_beats_per_minute` in message `.google.devicesandservices.health.v4.DailyHeartRateZones`
- Changed proto3 optional flag of an existing field `breaths_per_minute` in message `.google.devicesandservices.health.v4.DailyRespiratoryRate`
- Changed proto3 optional flag of an existing field `average_percentage` in message `.google.devicesandservices.health.v4.DailyOxygenSaturation`
- Changed proto3 optional flag of an existing field `lower_bound_percentage` in message `.google.devicesandservices.health.v4.DailyOxygenSaturation`
- Changed proto3 optional flag of an existing field `upper_bound_percentage` in message `.google.devicesandservices.health.v4.DailyOxygenSaturation`
- Changed proto3 optional flag of an existing field `standard_deviation_percentage` in message `.google.devicesandservices.health.v4.DailyOxygenSaturation`
- Changed proto3 optional flag of an existing field `beats_per_minute` in message `.google.devicesandservices.health.v4.DailyRestingHeartRate`
- Changed proto3 optional flag of an existing field `nightly_temperature_celsius` in message `.google.devicesandservices.health.v4.DailySleepTemperatureDerivations`
- Changed proto3 optional flag of an existing field `baseline_temperature_celsius` in message `.google.devicesandservices.health.v4.DailySleepTemperatureDerivations`
- Changed proto3 optional flag of an existing field `relative_nightly_stddev_30d_celsius` in message `.google.devicesandservices.health.v4.DailySleepTemperatureDerivations`
- Changed proto3 optional flag of an existing field `vo2_max` in message `.google.devicesandservices.health.v4.DailyVO2Max`
- Changed proto3 optional flag of an existing field `vo2_max_covariance` in message `.google.devicesandservices.health.v4.DailyVO2Max`
- Changed proto3 optional flag of an existing field `millimeters` in message `.google.devicesandservices.health.v4.Distance`
- Changed proto3 optional flag of an existing field `millimeters_sum` in message `.google.devicesandservices.health.v4.DistanceRollupValue`
- Changed proto3 optional flag of an existing field `pool_length_millimeters` in message `.google.devicesandservices.health.v4.Exercise`
- Changed proto3 optional flag of an existing field `count` in message `.google.devicesandservices.health.v4.Floors`
- Changed proto3 optional flag of an existing field `count_sum` in message `.google.devicesandservices.health.v4.FloorsRollupValue`
- Changed proto3 optional flag of an existing field `gain_millimeters_sum` in message `.google.devicesandservices.health.v4.AltitudeRollupValue`
- Changed proto3 optional flag of an existing field `beats_per_minute` in message `.google.devicesandservices.health.v4.HeartRate`
- Changed proto3 optional flag of an existing field `rate_min` in message `.google.devicesandservices.health.v4.RunVO2MaxRollupValue`
- Changed proto3 optional flag of an existing field `rate_max` in message `.google.devicesandservices.health.v4.RunVO2MaxRollupValue`
- Changed proto3 optional flag of an existing field `rate_avg` in message `.google.devicesandservices.health.v4.RunVO2MaxRollupValue`
- Changed proto3 optional flag of an existing field `run_vo2_max` in message `.google.devicesandservices.health.v4.RunVO2Max`
- Changed proto3 optional flag of an existing field `height_millimeters` in message `.google.devicesandservices.health.v4.Height`
- Changed proto3 optional flag of an existing field `root_mean_square_of_successive_differences_milliseconds` in message `.google.devicesandservices.health.v4.HeartRateVariability`
- Changed proto3 optional flag of an existing field `standard_deviation_milliseconds` in message `.google.devicesandservices.health.v4.HeartRateVariability`
- Changed proto3 optional flag of an existing field `milliliters` in message `.google.devicesandservices.health.v4.VolumeQuantity`
- Changed proto3 optional flag of an existing field `milliliters_sum` in message `.google.devicesandservices.health.v4.HydrationLogRollupValue`
- Changed proto3 optional flag of an existing field `percentage` in message `.google.devicesandservices.health.v4.OxygenSaturation`
- Changed proto3 optional flag of an existing field `breaths_per_minute` in message `.google.devicesandservices.health.v4.RespiratoryRateSleepSummary`
- Changed proto3 optional flag of an existing field `standard_deviation` in message `.google.devicesandservices.health.v4.RespiratoryRateSleepSummary`
- Changed proto3 optional flag of an existing field `signal_to_noise` in message `.google.devicesandservices.health.v4.RespiratoryRateSleepSummary`
- Changed proto3 optional flag of an existing field `minutes` in message `.google.devicesandservices.health.v4.Sleep`
- Changed proto3 optional flag of an existing field `count` in message `.google.devicesandservices.health.v4.Sleep`
- Changed proto3 optional flag of an existing field `count` in message `.google.devicesandservices.health.v4.Steps`
- Changed proto3 optional flag of an existing field `count_sum` in message `.google.devicesandservices.health.v4.StepsRollupValue`
- Changed proto3 optional flag of an existing field `stroke_count` in message `.google.devicesandservices.health.v4.SwimLengthsData`
- Changed proto3 optional flag of an existing field `stroke_count_sum` in message `.google.devicesandservices.health.v4.SwimLengthsDataRollupValue`
- Changed proto3 optional flag of an existing field `kcal_sum` in message `.google.devicesandservices.health.v4.TotalCaloriesRollupValue`
- Changed proto3 optional flag of an existing field `vo2_max` in message `.google.devicesandservices.health.v4.VO2Max`
- Changed proto3 optional flag of an existing field `weight_grams` in message `.google.devicesandservices.health.v4.Weight`
- Changed proto3 optional flag of an existing field `weight_grams_avg` in message `.google.devicesandservices.health.v4.WeightRollupValue`

### Documentation improvements

- Update ListDataPointsRequest filter documentation clarifying session start time comparison rules for ECG and Sleep
- Update ExportExerciseTcx documentation for direct download via HTTP

## Version 1.0.0-beta01, released 2026-05-11

### New features

- Add support for basal energy, height, and swimming metrics
- Add GetDataPoint RPC for individual data point retrieval
- Add WebhookNotificationCloudLog for logging webhook notifications
- Initial generation for Google.DevicesAndServices.Health.V4

### Documentation improvements

- Update user ID reference in DataPoint and ReconciledDataPoint comments

