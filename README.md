########################################################################<br/>
      C# Postcode Address Finder<br/>                 
      Based on Royal Mail PAF CSV File<br/>            
      Prismiq  v1.0                          
########################################################################<br/><br/>

Requirements<br/>
############<br/>
SQLLite<br/>
EF Core<br/><br/>

README<br/>
############<br/>
ImportCsv = Imports the PAF CSV and loads it into an Address table<br/>

End Points<br/>
############<br/><br/>

<code>
[HttpPost]
/SearchForAddress/{address}
</code>
  Searches for address<br/><br/>

Example: /SearchForAddress/55%Fake%Street<br/><br/>

[HttpPost]<br/>
/SelectAddress/{id}<br/>
  Searches for specific address, pass Id (int)<br/><br/>

Example:  /SelectAddress/1