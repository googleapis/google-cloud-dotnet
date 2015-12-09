@echo off

REM TODO: Shell script version of this :)

if "%TEST_PROJECT%" == "" (
  echo Please set TEST_PROJECT before setting up
  goto end
)

call clean.bat

FOR /D %%D in (data\*) DO (
  call gsutil mb gs://%TEST_PROJECT%_%%~nD
  pushd %%D
  call gsutil -m cp -r . gs://%TEST_PROJECT%_%%~nD
  popd

)

REM UploadObjectsTest requires versioning on bucket 2
call gsutil versioning set on gs://%TEST_PROJECT%_integrationtests-2

REM ListObjectsTest requires versioning on bucket 0, and a
REM multiversion file
SET MV_BUCKET=gs://%TEST_PROJECT%_integrationtests-0
call gsutil versioning set on %MV_BUCKET%
call gsutil cp %MV_BUCKET%/updated.txt %MV_BUCKET%/multiversion.txt

echo Done!

:end
