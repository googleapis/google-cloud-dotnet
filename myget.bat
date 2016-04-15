REM This is all ugly... we'll want to revisit this as soon as possible
call dnvm use 1.0.0-rc1-update1 -r clr

REM We've found some oddities when using our own feed.
REM Basically, we want to fetch everything from nuget.org.
rmdir /s /q %USERPROFILE%\.dnx\packages

call dnu restore
IF ERRORLEVEL 1 EXIT /B 1

REM We want to build and package everthing under src.
REM We're not building any tests etc; that's what Travis is for.
call dnu pack src\*
IF ERRORLEVEL 1 EXIT /B 1
