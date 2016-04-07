REM This is all ugly... we'll want to revisit this as soon as possible
call dnvm use 1.0.0-rc1-update1 -r clr

REM Temporary measure while we resolve oddities with the local feed
REM cache and version numbers. Basically, we want to fetch these from
REM nuget.org.
rmdir /s /q %USERPROFILE%\.dnx\packages\Google.Apis
rmdir /s /q %USERPROFILE%\.dnx\packages\Google.Apis.Core
rmdir /s /q %USERPROFILE%\.dnx\packages\Google.Apis.Auth

call dnu restore
IF ERRORLEVEL 1 EXIT /B 1

call dnu build src\Google.Storage.V1
IF ERRORLEVEL 1 EXIT /B 1
call dnu build test\Google.Storage.V1.Tests
IF ERRORLEVEL 1 EXIT /B 1
call dnu build test\Google.Storage.V1.IntegrationTests
IF ERRORLEVEL 1 EXIT /B 1
call dnu build demo\Google.Storage.V1.Demo
IF ERRORLEVEL 1 EXIT /B 1
call dnx -p test\Google.Storage.V1.Tests test
IF ERRORLEVEL 1 EXIT /B 1
call dnu pack src\Google.Storage.V1
IF ERRORLEVEL 1 EXIT /B 1

call dnu build src\Google.Pubsub.V1
IF ERRORLEVEL 1 EXIT /B 1
call dnu pack src\Google.Pubsub.V1
IF ERRORLEVEL 1 EXIT /B 1

call dnu build src\Google.Logging.Type
IF ERRORLEVEL 1 EXIT /B 1
call dnu pack src\Google.Logging.Type
IF ERRORLEVEL 1 EXIT /B 1

call dnu build src\Google.Logging.V2
IF ERRORLEVEL 1 EXIT /B 1
call dnu pack src\Google.Logging.V2
IF ERRORLEVEL 1 EXIT /B 1
