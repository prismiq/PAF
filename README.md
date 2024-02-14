<h1>Postcode Address Finder API C# .NET</h1>

<h2>Requirements</h2>
<b>EF Core</b><br/>
<code>dotnet add package Microsoft.EntityFrameworkCore</code><br/><br/>

<b>SQLLite</b><br/>
<code>dotnet add package Microsoft.EntityFrameworkCore.SQLite</code><br/><br/>

<b>Initial Creation</b><br/>
<code>dotnet ef migrations add InitialCreation</code><br/>
<code>dotnet ef database update</code><br/><br/>

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