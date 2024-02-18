# SimpleVectorGraphicViewer
code challenge WSCAD

In simple turns:
----------------
Figures:
1) 1-dimensional - have not a shape that lie in one plane and have length in at least one direction;
2) 2-dimensional - have a shape with 2 dimensions of space that are, length and width;
3) 3-dimensional - have a shape with 3 dimensions of space that are, length, width, and depth as height.
----------------
a)closed shape:
	- have vertices;
 	- have not vertices;
b)open shape:
	- have vertices;
 	- have not vertices;
----------------
Total:
interfaces - 42;
classes - 40;
enums - 1;

#RabbitMQ is a message-queueing software also known as a message broker or queue manager. 
#Simply said, it is software where queues are defined.

First: 
Go to (https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell-on-windows?view=powershell-7.3)
Install PowerShell on Windows:
1)winget search Microsoft.PowerShell
2)winget install --id Microsoft.Powershell --source winget
Second:
Go to (https://stackoverflow.com/questions/47861537/choco-command-not-recognized-when-run-as-administrator-on-windows)
Install chocolatey:
1)Microsoft.Powershell run as administrator
2)Set-ExecutionPolicy Bypass -Scope Process -Force; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))
Check version:
1)choco -v
Third:
Go to https://www.rabbitmq.com/install-windows.html#chocolatey or https://community.chocolatey.org/packages/rabbitmq#install
Install RabbitMQ:
1)choco install rabbitmq
And next->next->next->.....
Do you want to run the script?([Y]es/[A]ll - yes to all/[N]o/[P]rint): y
...............
Chocolatey installed 2/2 packages.
 See the log for details (C:\ProgramData\chocolatey\logs\chocolatey.log).
 
#RabbitMQ API (http://localhost:15672/api/index.html)
curl -i -u guest:guest -H "content-type:application/json" -XPUT http://localhost:15672/api/vhosts/testvhost
curl -i -u guest:guest -H "content-type:application/json" -XDELETE http://localhost:15672/api/vhosts/testvhost


