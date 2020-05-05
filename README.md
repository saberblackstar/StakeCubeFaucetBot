# StakeCube Faucet Bot

Hello and welcome to my StakeCube faucet bot project!<br>
This is just a small bot that is designed to collect all faucets on StakeCube for you.<br>

It is programmed in C# ASP.NET Core as console application.<br>
You need Visual Studio 2019 to open it.<br>
Or you can simply download the released portable version from the releases.

You only need to enter your current __cfduid and your phpsessid to grant the bot access.

The bot then will automatically send the necessary requests to StakeCube to keep itself updated and informed.<br>
When a claim possibility is detected the bot will send the according request to claim the faucet for you.<br>
<br>
<br>


<h3>Usage instructions:</h3>
Enter your cfduid and phpsessid when promted for them.<br>
After this confirm that the bot shall start.<br>
Keep the console window open to keep the bot running.<br>
<br>
The refresh rate is fixxed at one minute.<br>
Do not panic when you do not see refreshs more often.<br>
The closer the bot gets to claiming the higher the refresh rate will become automatically.<br>
<br>
Best is to keep the bot running 24/7.<br>
<br>

<h3>To acquire your __cfduid and your phpsessid:</h3>
<h4>For Chrome:</h4>
Press F12 to open the console and reload the StakeCube page while being logged in.<br>
In the console window navigate to "Application" under the small extension arrow (http://prntscr.com/sb69px).<br>
In the left menu select "cookies" and then "https://stakecube.net".<br>
Here you'll find both - your __cfduid and your phpsessid.<br>
<br>

<h4>For Firefox:</h4>
Activate the "Web Developer" extension of firefox in the firefox addons. (may need firefox restart)<br>
Press F12 to open the console and reload the StakeCube page while being logged in.<br>
Go to "Networkanalysis" in the console window.<br>
Click any entry.<br>
In the small info window to the right switch to "cookies".<br>
Here you'll find both - your __cfduid and your phpsessid.<br>
<br><br><br>

<h4>Donations</h4>
If you like this bot please consider a small donation to one of my donation addresses:<br>
BTC:35eGdwAwKRw1zy7xBi2gXd7N8eBPemGdQE<br>
SCC:sPkPptzng1DGXWndsJc8X9BA3CZZpTKp2F<br>
DASH:Xr2EXioHGVqxrJY7ULqsjkT7xfmr29h4Kq<br>
LTC:MPD4n6YxkaUhjQs9s1jsFjbA948SS2KU45<br>
DOGE:DC8x7fvrA6cm2gQF9FcJoqDg62tLE5wmAM<br>
ESBC:eL7fu5vSk3hcq8L2y9fGUdgcnpNz7iK9xz<br>
TRBO:TDiJhpGjFVvebhtmpQD1uc1tP5zwfbkV3R<br>
RPD:Rav3JhC1UfTsssPEp14K6MNphja3SYoyGN<br>

<br><br><br><br><br>
<h4>Disclaimer</h4>
The code is crap but it works, there's many that could be done better.
Once started the bot does not provide the possibility to be stopped except when you close the console window itself.
