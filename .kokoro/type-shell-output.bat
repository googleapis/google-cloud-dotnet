:: This takes the name of a shell script located in this directory
:: runs the script, output the results to a file and then
:: types the file back to the user.
::
:: This is needed to be able to see shell output on the
:: Windows Kokoro machines.

del %~dp0%1.txt

%~dp0write-output-to-file.sh %~dp0%1

type %~dp0%1.txt
del %~dp0%1.txt