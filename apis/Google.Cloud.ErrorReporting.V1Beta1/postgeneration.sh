#!/bin/bash

# The parameter name "event" is unfortunate :(
sed -i 's/ event/ @event/g' Google.Cloud.ErrorReporting.V1Beta1/ReportErrorsServiceClient.g.cs
sed -i 's/ event/ @event/g' Google.Cloud.ErrorReporting.V1Beta1.Snippets/ReportErrorsServiceClientSnippets.g.cs
sed -i 's/(event/(@event/g' Google.Cloud.ErrorReporting.V1Beta1/ReportErrorsServiceClient.g.cs
