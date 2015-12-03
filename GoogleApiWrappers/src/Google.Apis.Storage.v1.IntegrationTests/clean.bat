@echo off

REM TODO: Shell script version of this :)

if "%TEST_PROJECT%" == "" (
  echo Please set TEST_PROJECT before cleaning up
  goto end
)

call gsutil -m rm -r gs://%TEST_PROJECT%_integrationtests-*

:end
