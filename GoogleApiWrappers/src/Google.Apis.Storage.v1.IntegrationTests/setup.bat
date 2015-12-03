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

echo Done!

:end
