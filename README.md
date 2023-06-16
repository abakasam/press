# press

Compress and extract *.tgz, *.tar, and *.tar.gz . Needed for Windows without 7-Zip or WinZip.

-- Installation
--- Dependencies
---- .NET
----- Running Application
------ Packages
----- Adding Library
------ TarTool
----- Build Executable

## Installation
### Dependencies
#### .NET
##### Running Application
###### Packages
https://learn.microsoft.com/en-us/dotnet/core/install/linux-centos#dependencies

	sudo su -c "yum install dotnet-sdk-7.0 --downloadonly --downloaddir=".""
	sudo su -c "yum install aspnetcore-runtime-7.0 --downloadonly --downloaddir=".""
	sudo su -c "yum install dotnet-runtime-7.0 --downloadonly --downloaddir=".""
	sudo su -c "yum install *.rpm"

	CentOS Linux release 7.2.1511 (Core) 
	openssl-1.1.0
	openldap-2.4.40
	openssh-clients-6.6.1
	openssh-server-6.6.1

https://learn.microsoft.com/en-us/dotnet/core/install/linux-scripted-manual#manual-install

	mkdir dotnet
	mv dotnet-sdk-7.0.302-linux-x64.tar.gz dotnet
	cd dotnet
	tar -xvf dotnet-sdk-7.0.302-linux-x64.tar.gz
	dotnet

https://learn.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-7-0

	aspnetcore-runtime-7.0.5
	aspnetcore-targeting-pack-7.0.5
	dotnet-apphost-pack-7.0.5
	dotnet-host-7.0.5
	dotnet-hostfxr-7.0.5
	dotnet-runtime-7.0.5
	dotnet-runtime-deps-7.0.5-centos
	dotnet-sdk-7.0.302
	dotnet-targeting-pack-7.0.5
	libicu-50.2
	netstandard-targeting-pack-2.1.0
	dotnet-centos-1.0.16
	dotnet-dev-centos-1.1.14

	dotnet-centos (runtime)
	dotnet-dev-centos (SDK)
	
https://learn.microsoft.com/en-us/dotnet/core/tools/

	dotnet new console --framework net7.0 
	dotnet run


###### .NET (dotnet for CentOS and Linux)

	https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core#cadence
	https://dotnet.microsoft.com/en-us/download/dotnet/<#>.0
	https://dotnet.microsoft.com/en-us/learn/dotnet/hello-world-tutorial/install

###### SDK (Build ASP.NET and .NET)

	https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-1.1.14-linux-centos-x64-binaries
	https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-1.1.14-windows-x64-installer
	https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-1.1.14-windows-x64-binaries

###### ASP.NET (Run ASP.NET)
	
	https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-aspnetcore-1.0.16-windows-hosting-bundle-installer	

###### .NET Runtime (Run .NET)
	
	https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-1.0.16-windows-x64-binaries
	https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-1.0.16-windows-x64-installer
	https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-1.0.16-linux-centos-x64-binaries



##### Adding Library

###### TarTool

# TODO: Download http://icsharpcode.github.io/SharpZipLib/ with httrack

	http://icsharpcode.github.io/SharpZipLib/ 
	https://github.com/icsharpcode/SharpZipLib/releases/download/v1.4.2/SharpZipLib.1.4.2.nupkg
	https://github.com/icsharpcode/SharpZipLib/archive/refs/tags/v1.4.2.tar.gz
	https://github.com/senthilrajasek/tartool
	https://github.com/senthilrajasek/tartool/releases/download/1.0.0/TarTool.zip
	https://github.com/senthilrajasek/tartool/archive/refs/tags/1.0.0.tar.gz

https://learn.microsoft.com/en-us/dotnet/core/tutorials/testing-with-cli

	pwd
	/home/cabox/workspace/desktop/press/WinTar
	mkdir ICSharpCode
	cd ICSharpCode
	mkdir SharpZipLib
	cd SharpZipLib
	mkdir Core
	mkdir Tar
	
	ICSharpCode/SharpZipLib/Tar
	ICSharpCode/SharpZipLib/Core

##### Building Executable

https://learn.microsoft.com/en-us/dotnet/core/tools/#cli-commands

	dotnet build --output ./wintar