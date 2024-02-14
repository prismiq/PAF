<h1>Postcode Address Finder API C# .NET</h1>

<h2>Requirements</h2>
SQLLite<br/>
EF Core<br/><br/>

<h2>Initial Import</h2>
ImportCsv = Imports the PAF CSV and loads it into an Address table<br/>

<h2>End Points</h2>

<code>[HttpPost]</code><br/>
<code>/SearchForAddress/{address}</code><br/><br/>
Searches for address<br/>
Example: /SearchForAddress/55%Fake%Street<br/><br/>

<code>[HttpPost]</code><br/>
<code>/SelectAddress/{id}</code><br/><br/>
Searches for specific address, pass Id (int)<br/>
Example:  /SelectAddress/1