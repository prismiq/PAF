using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using PAFApi.Models;
using Db;
using CsvHelper;
using System.Globalization;

namespace PAFApi.Controller
{
    public class AddressController : ControllerBase
    {
        private readonly ApplicationDb _db;

        public AddressController(ApplicationDb dbContext) {
            _db = dbContext;
        }

        /// <summary>
        /// Find Addresses
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/SearchForAddress/")]
        public IActionResult SearchForAddress(string? address) {
            
            if (string.IsNullOrEmpty(address)) throw new Exception();

            //Search for String
            var result = _db.Address.Take(25).Where( a =>
                                            a.PostTown.Contains(address) == true ||
                                            a.BuildingName.ToLower().Contains(address) == true ||
                                            a.BuildingNumber.ToLower().Contains(address) == true ||
                                            a.OrganisationName.ToLower().Contains(address) == true ||
                                            a.DeliveryPointSuffix.ToLower().Contains(address) == true ||
                                            a.ThoroughfareDescriptor.ToLower().Contains(address) == true ||
                                            a.DependentThoroughfareDescriptor.ToLower().Contains(address) == true ||
                                            a.SubBuildingName.ToLower().Contains(address) == true ||
                                            a.PostCode.ToLower().Contains(address) == true ||
                                            a.BuildingNumber != null && a.BuildingNumber.ToString().Contains(address)
                                        );
            var addresses = result.ToList();
            
            if (addresses.Count == 0) {
                //No Records return NotFound
                return NotFound();
            } else {
                //OK Return Result
                return Ok(new JsonArray {addresses});
            }
        }

        /// <summary>
        /// Select Specific Address
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/SelectAddress")]
        public IActionResult SelectAddress (int Id) {
            var result = _db.Address.Find(Id);

            if (result == null) {
                //No Records return NotFound
                return NotFound();
            } else {
                //Return OK
                return Ok(new JsonArray {result});
            }
        }

        /// <summary>
        /// Import Addresses from PAF CSV File
        /// Requires Headers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/ImportAddressData")]
        public IActionResult ImportAddressData() {
            string CsvPath = "/Users/admin/PAF/PAFApi/";
            string DataFileName = "SampleData.csv";
            
            //Remove Current Data
            _db.Database.ExecuteSqlRaw("DELETE FROM Address");

            using (var reader = new StreamReader($"{CsvPath}{DataFileName}"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {                
                // Loop through each record in the CSV and add it to the database
                while (csv.Read())
                {
                    try {
                        var record = csv.GetRecord<Address>();
                        _db.Address.Add(record);
                        _db.SaveChanges();
                        _db.Entry(record).State = EntityState.Detached; //Detach after Adding
                    } catch (Exception ex) {
                        Console.WriteLine($"Error:{csv.GetField(0)}");
                    }
                }
            }

            return Ok();
        }
    }
}