########################################################################
######          C# Postcode Address Finder                  ############
######          Based on Royal Mail PAF CSV File            ############
######          Prismiq  v1.0                               ############
########################################################################

Requirements /n
############
SQLLite
EF Core

README
############
ImportCsv = Imports the PAF CSV and loads it into an Address table

End Points
############

[HttpPost]
/SearchForAddress/{address}
  Searches for address

Example: /SearchForAddress/55%Fake%Street

[HttpPost]
/SelectAddress/{id}
  Searches for specific address, pass Id (int)

Example:  /SelectAddress/1

