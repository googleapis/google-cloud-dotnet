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

REM We want to build and package everthing under src.
REM We're not building any tests etc; that's what Travis is for.
call dnu pack src\*
IF ERRORLEVEL 1 EXIT /B 1
