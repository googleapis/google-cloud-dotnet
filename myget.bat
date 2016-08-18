@echo on

dotnet restore || goto error

for /D %%P in (src\Google*) do (
  echo Building %%P
  dotnet build --version-suffix %PrereleaseTag% --configuration %Configuration% %%P || goto error
)

for /D %%P in (snippets\Google*) do (
  echo Building %%P
  dotnet build --configuration %Configuration% %%P || goto error
)

REM We don't build/run the integration tests
for /D %%P in (test\Google*.Tests) do (
  echo Testing %%P
  dotnet test --configuration %Configuration% %%P || goto error
)

for /D %%P in (src\Google*) do (
  echo Packing %%P
  dotnet pack --version-suffix %PrereleaseTag% --configuration %Configuration% %%P || goto error
)

echo Done!

goto end

:error
echo Build failed due to error.
exit /b 1

:end
