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

namespace PAFApi.Controller
{
    public class AddressController : ControllerBase
    {
        private readonly DBContext _db;

        public AddressController(DBContext dbContext) {
            _db = dbContext;
        }

        /// <summary>
        /// Find Addresses
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/SearchForAddress/{address}")]
        public IActionResult SearchForAddress(string? address) {
            
            if (string.IsNullOrEmpty(address)) throw new Exception();

            //Search for String
           var result = _db.Address.Where(  a =>
                                            a.PostTown.Contains(address) == true ||
                                            a.BuildingName.ToLower().Contains(address) == true ||
                                            a.OrganisationName.ToLower().Contains(address) == true ||
                                            a.PostcodeType.ToLower().Contains(address) == true ||
                                            a.DeliveryPointSuffix.ToLower().Contains(address) == true ||
                                            a.ThoroughfareDescriptor.ToLower().Contains(address) == true ||
                                            a.DependentThoroughfareDescriptor.ToLower().Contains(address) == true ||
                                            a.SubBuildingName.ToLower().Contains(address) == true ||
                                            (a.BuildingNumber != null && a.BuildingNumber.ToString().Contains(address))
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
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/SelectAddress/{id}")]
        public IActionResult SelectAddress (int? id) {
            
            if (id.HasValue) throw new Exception();
            var result = _db.Address.Find(id);

            if (result == null) {
                //No Records return NotFound
                return NotFound();
            } else {
                //Return OK
                return Ok(new JsonArray {result});
            }
            
        }

    }
}