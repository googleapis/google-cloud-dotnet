REM This is all ugly... we'll want to revisit this as soon as possible
call dnvm use 1.0.0-rc1-update2 -r clr
IF ERRORLEVEL 1 goto error

REM We've found some oddities when using our own feed.
REM Basically, we want to fetch everything from nuget.org.
REM rmdir /s /q %USERPROFILE%\.dnx\packages

call dnu restore src test snippets
IF ERRORLEVEL 1 EXIT /B 1

for /D %%P in (src\Google*) do (
  echo Building %%P
  call dnu build --configuration %Configuration% %%P
  IF ERRORLEVEL 1 goto error
)

for /D %%P in (snippets\Google*) do (
  echo Building %%P
  call dnu build --configuration %Configuration% %%P
  IF ERRORLEVEL 1 goto error
)

REM We don't build/run the integration tests
for /D %%P in (test\Google*.Tests) do (
  echo Testing %%P
  call dnu build --configuration %Configuration% %%P
  IF ERRORLEVEL 1 goto error
  dnx --configuration %Configuration% -p %%P test
  IF ERRORLEVEL 1 goto error
)

for /D %%P in (src\Google*) do (
  echo Packing %%P
  call dnu pack --configuration %Configuration% %%P
  IF ERRORLEVEL 1 goto error
)

echo Done!

goto end

:error
echo Build failed due to error.
exit /b 1

:end
