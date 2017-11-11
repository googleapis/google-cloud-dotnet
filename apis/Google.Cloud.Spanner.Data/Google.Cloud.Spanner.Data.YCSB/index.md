{{title}}

`Spanner YCSB` is .net core command line performance test for C# Spanner.

# Getting started

To install this app, you must:
1. Obtain a GCE Ubuntu 16.04 instance with full API permission on Google Cloud platform.
2. SSH to the VM and [install dotnet core](https://www.microsoft.com/net/learn/get-started/linuxubuntu)
3. Open this project locally and run 'dotnet publish' to create a publish directory.
4. copy all files under `publish` to the destination machine (via tar or some other method)
5. run as below.

## Running and command line options.
Typical execution will be:  
**dotnet** Google.Cloud.Spanner.Data.YCSB.dll run -P workload_template [-p optionName=value]...

"run" is required and means to run the test
"workload_template" provides a path to a config file (sample is above) with option values.
Any value in the config file will override the command line.

Following the template file is a variable sized list of option name and values which
can be any of the below:

* **table**=[name]  
   *The Cloud Spanner table*
* **cloudspanner.instance**=[name]  
   *The Cloud Spanner Instance name*
* **cloudspanner.database**=[name]  
   *The Cloud Spanner Database name*
* **cloudspanner.project**=[name]  
   *The Cloud Spanner Project name*
* **client_type**=dotnet  
   *Must be **dotnet***
* **num_worker**=[workercount]  
   *The number of parallel operations executed*
* **operationcount**=[totalcount]  
   *The total number of operations to execute*
* **cloudspanner.boundedstaleness**=[secondsofstaleness]  
   *If set, uses MaxStaleness read instead of Strong*
* **cloudspanner.numchannels**=[numberofchannels]  
   *The number of grpc channels to use*
* **cloudspanner.prewarm**=[numberofsessions]  
   *The number of Spanner sessions to prewarm before the test*
* **cloudspanner.qpstarget**=[QPS]  
   *If set, an attempt is made to process operations at this QPS instead*
* **cloudspanner.qpstesttime**=[testtimeseconds]  
   *If set, the amount of time in seconds to run the QPS test.*
* **debugmode**=[1 or 2]  
   *If set to '1', then internal performance statistics and some progress indication is logged.*  
   *If set to '2', the full debug messages are displayed*

A sample is below:  
 dotnet Google.Cloud.Spanner.Data.YCSB.dll run -P workload_template -p table=usertable -p cloudspanner.instance=ycsb-32520798 -p cloudspanner.database=ycsb -p client_type=dotnet -p operationcount=50000 -p cloudspanner.project=REDACTED -p num_worker=32 -p debugmode=1