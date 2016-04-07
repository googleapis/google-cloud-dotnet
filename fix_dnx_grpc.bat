@echo off

rem This batch file is the workaround for
rem https://github.com/grpc/grpc/issues/4872

set DNX_PACKAGES_DIR="%USERPROFILE%\.dnx\packages"
set GRPC_CORE=%DNX_PACKAGES_DIR%\Grpc.Core\0.13.1
set GRPC_NATIVE=%DNX_PACKAGES_DIR%\grpc.native.csharp\0.13.1

if not exist %DNX_PACKAGES_DIR% (
  echo Expected to find %DNX_PACKAGES_DIR%
  echo Have you installed DNVM/DNX yet?
  goto :end
)

if exist %DNX_PACKAGES_DIR%\Grpc.Core\0.13.1\lib\net45\nativelibs\windows_x86\grpc_csharp_ext.dll (
  echo Plugin already in place. Exiting.
  goto :end
)

rem First make sure that gRPC is in the DNX package cache
if not exist %DNX_PACKAGES_DIR%\Grpc.Core\0.13.1 (
  echo Restoring gRPC packages via Google.Pubsub.V1
  call dnu restore --quiet src\Google.Pubsub.V1\project.json
)

echo Copying plugins from grpc.native.csharp to Grpc.Core
mkdir %GRPC_CORE%\lib\net45\nativelibs\windows_x86 > nul
mkdir %GRPC_CORE%\lib\net45\nativelibs\windows_x64 > nul
copy %GRPC_NATIVE%\build\native\bin\windows_x86\grpc_csharp_ext.dll %GRPC_CORE%\lib\net45\nativelibs\windows_x86 > nul
copy %GRPC_NATIVE%\build\native\bin\windows_x64\grpc_csharp_ext.dll %GRPC_CORE%\lib\net45\nativelibs\windows_x64 > nul

echo Done!

:end