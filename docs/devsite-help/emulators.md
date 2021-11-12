# Emulator support

## ClientBuilder dedicated support

Some APIs (such as Datastore and PubSub) provide emulators in the
[Cloud SDK](https://cloud.google.com/sdk/). Client libraries in some
other languages automatically use emulators if specific environment
variables are set, but the Google Cloud Libraries for .NET
deliberately do not do this, to avoid accidentally using an emulator
when production was expected or vice versa.

Where emulators are directly supported by the libraries, the client
builder type has an `EmulatorDetection` property which can be set to
one of the following values:

- `None` (the default): Ignores the presence or absence of emulator configuration.
- `ProductionOnly`: Always connects to the production servers, but
   throws an exception if an emulator configuration is detected that would suggest connecting to
   an emulator is expected.
- `EmulatorOnly`: Always connect to the emulator, throwing an exception if no emulator
   configuration is detected.
- `EmulatorOrProduction`: Connect to the emulator if an emulator configuration is detected,
  or production otherwise. This is a convenient option, but risks damage to
  production databases or running up unexpected bills if tests are accidentally
  run in production due to the emulator configuration being absent unexpectedly.
  (Using separate projects for production and testing is a best practice for
  preventing the first issue, but may be unrealistic for small or hobby projects.)

Here emulator configuration presence is usually interpreted as
"appropriate environment variables being set", but it is possible
that in the future there will be other conventions for
configuring emulators.

For example, the following code creates a PubSub `SubscriberApiClient`
that will connect to the PubSub emulator if the
`PUBSUB_EMULATOR_HOST` environment variable is set, but will
otherwise connect to the production environment.

[!code-cs[](../examples/help.Emulator.txt#ClientBuilderSupport)]

Note that the PubSub `SubscriberClient` and `PublisherClient`
classes don't have builders. Instead, they have nested
`ClientCreationSettings` with emulator detection. The following code
connects to the PubSub emulator for a `SubscriberClient`:

[!code-cs[](../examples/help.Emulator.txt#SubscriberClient)]

## Manually connecting to an emulator

If you need to connect to an emulator directly (for example because
it is not yet supported in the library for the API you're using),
simply use the appropriate client builder, set the endpoint to the
host and port the emulator is listening on, and set the credentials to
to `ChannelCredentials.Insecure`.

Example for PubSub (although the techniques above are preferred):

[!code-cs[](../examples/help.Faq.txt#Emulator)]