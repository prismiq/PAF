using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using Db;
using Microsoft.EntityFrameworkCore;
using PAFApi.Models;

namespace PAFApi
{
    public class ImportCsv
    {   
        private readonly DBContext _db;

        public ImportCsv(DBContext dbContext) {
            _db = dbContext;
        }

        public void Main() {
            List<Address> addressList;

            using (var reader = new StreamReader("PAF.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                
                addressList = csv.GetRecords<Address>().ToList(); // Removed re-declaration
            }

            // Add the records to the database inside the using block
            _db.Address.AddRange(addressList);
            _db.SaveChanges(); // Save changes to the database
        }
    }
}
