# Version history

## Version 1.0.0-beta07, released 2025-04-14

### New features

- Introduce QuotaService for CSS API ([commit 7969a13](https://github.com/googleapis/google-cloud-dotnet/commit/7969a13a6f0cdd19962976b9c9a0a8bb99db8c29))

### Documentation improvements

- A comment for field `name` in message `.google.shopping.css.v1.CssProductInput` is changed ([commit 7969a13](https://github.com/googleapis/google-cloud-dotnet/commit/7969a13a6f0cdd19962976b9c9a0a8bb99db8c29))
- A comment for field `name` in message `.google.shopping.css.v1.DeleteCssProductInputRequest` is changed ([commit 7969a13](https://github.com/googleapis/google-cloud-dotnet/commit/7969a13a6f0cdd19962976b9c9a0a8bb99db8c29))
- Added a clarifying note to the description of the parent field in the Account resource ([commit 95a25d1](https://github.com/googleapis/google-cloud-dotnet/commit/95a25d1e19375b1f1ceb45308d1aba704b746a97))

## Version 1.0.0-beta06, released 2025-01-06

### New features

- UpdateCssProduct is added to CssProductInput proto ([commit 76bc3bd](https://github.com/googleapis/google-cloud-dotnet/commit/76bc3bd61adbf4a1793ae1ff8f708ecf932ad259))

### Documentation improvements

- Mark `freshness_time` as deprecated ([commit 76bc3bd](https://github.com/googleapis/google-cloud-dotnet/commit/76bc3bd61adbf4a1793ae1ff8f708ecf932ad259))
- A comment for field `page_size` in message `.google.shopping.css.v1.ListChildAccountsRequest` is changed ([commit 76bc3bd](https://github.com/googleapis/google-cloud-dotnet/commit/76bc3bd61adbf4a1793ae1ff8f708ecf932ad259))
- A comment for field `low_price` in message `.google.shopping.css.v1.Attributes` is changed ([commit 76bc3bd](https://github.com/googleapis/google-cloud-dotnet/commit/76bc3bd61adbf4a1793ae1ff8f708ecf932ad259))
- A comment for field `high_price` in message `.google.shopping.css.v1.Attributes` is changed ([commit 76bc3bd](https://github.com/googleapis/google-cloud-dotnet/commit/76bc3bd61adbf4a1793ae1ff8f708ecf932ad259))
- A comment for field `number_of_offers` in message `.google.shopping.css.v1.Attributes` is changed ([commit 76bc3bd](https://github.com/googleapis/google-cloud-dotnet/commit/76bc3bd61adbf4a1793ae1ff8f708ecf932ad259))
- A comment for field `headline_offer_price` in message `.google.shopping.css.v1.Attributes` is changed ([commit 76bc3bd](https://github.com/googleapis/google-cloud-dotnet/commit/76bc3bd61adbf4a1793ae1ff8f708ecf932ad259))
- A comment for field `headline_offer_shipping_price` in message `.google.shopping.css.v1.Attributes` is changed ([commit 76bc3bd](https://github.com/googleapis/google-cloud-dotnet/commit/76bc3bd61adbf4a1793ae1ff8f708ecf932ad259))
- A comment for field `approved_countries` in message `.google.shopping.css.v1.CssProductStatus` is changed ([commit 76bc3bd](https://github.com/googleapis/google-cloud-dotnet/commit/76bc3bd61adbf4a1793ae1ff8f708ecf932ad259))
- A comment for field `pending_countries` in message `.google.shopping.css.v1.CssProductStatus` is changed ([commit 76bc3bd](https://github.com/googleapis/google-cloud-dotnet/commit/76bc3bd61adbf4a1793ae1ff8f708ecf932ad259))
- A comment for field `disapproved_countries` in message `.google.shopping.css.v1.CssProductStatus` is changed ([commit 76bc3bd](https://github.com/googleapis/google-cloud-dotnet/commit/76bc3bd61adbf4a1793ae1ff8f708ecf932ad259))
- A comment for field `servability` in message `.google.shopping.css.v1.CssProductStatus` is changed ([commit 76bc3bd](https://github.com/googleapis/google-cloud-dotnet/commit/76bc3bd61adbf4a1793ae1ff8f708ecf932ad259))
- A comment for field `applicable_countries` in message `.google.shopping.css.v1.CssProductStatus` is changed ([commit 76bc3bd](https://github.com/googleapis/google-cloud-dotnet/commit/76bc3bd61adbf4a1793ae1ff8f708ecf932ad259))
- A comment for field `feed_id` in message`.google.shopping.css.v1.InsertCssProductInputRequest` is changed ([commit 76bc3bd](https://github.com/googleapis/google-cloud-dotnet/commit/76bc3bd61adbf4a1793ae1ff8f708ecf932ad259))
- A comment for message `CssProduct` is changed ([commit 76bc3bd](https://github.com/googleapis/google-cloud-dotnet/commit/76bc3bd61adbf4a1793ae1ff8f708ecf932ad259))
- Fix comment on list account labels ([commit 4c15ac9](https://github.com/googleapis/google-cloud-dotnet/commit/4c15ac9c65d0e308b2806eea7da13a2eef4903a3))

## Version 1.0.0-beta05, released 2024-10-29

### New features

- A new field `headline_offer_installment` is added to message `.google.shopping.css.v1.Attributes` ([commit 24d5896](https://github.com/googleapis/google-cloud-dotnet/commit/24d5896684e471248ecbdf09b29409260e1fba49))
- A new field `headline_offer_subscription_cost` is added to message `.google.shopping.css.v1.Attributes` ([commit 24d5896](https://github.com/googleapis/google-cloud-dotnet/commit/24d5896684e471248ecbdf09b29409260e1fba49))
- A new message `HeadlineOfferSubscriptionCost` is added ([commit 24d5896](https://github.com/googleapis/google-cloud-dotnet/commit/24d5896684e471248ecbdf09b29409260e1fba49))
- A new message `HeadlineOfferInstallment` is added ([commit 24d5896](https://github.com/googleapis/google-cloud-dotnet/commit/24d5896684e471248ecbdf09b29409260e1fba49))
- A new enum `SubscriptionPeriod` is added ([commit 24d5896](https://github.com/googleapis/google-cloud-dotnet/commit/24d5896684e471248ecbdf09b29409260e1fba49))

### Documentation improvements

- Update `Certification` field descriptions ([commit d53568a](https://github.com/googleapis/google-cloud-dotnet/commit/d53568a61cd098cd82443a9063263a51e8a94f80))
- Remove "in Google Shopping" from documentation comments ([commit ed8f693](https://github.com/googleapis/google-cloud-dotnet/commit/ed8f6939daaf50f6cffc8e911c7d03440da5a570))

## Version 1.0.0-beta04, released 2024-05-08

### New features

- Add IServiceCollection extension methods for client registration where an IServiceProvider is required. ([commit 022fab2](https://github.com/googleapis/google-cloud-dotnet/commit/022fab203f28fb9c608972af7f8b83f571ae5694))

## Version 1.0.0-beta03, released 2024-03-27

### New features

- Change netstandard2.1 target to netstandard2.0 ([commit 7707366](https://github.com/googleapis/google-cloud-dotnet/commit/77073662b153c73c7f9a869ede1376f4c7a12661))

## Version 1.0.0-beta02, released 2024-02-29

No API surface changes; just dependency updates.

## Version 1.0.0-beta01, released 2023-12-12

Initial release.
