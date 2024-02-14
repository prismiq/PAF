using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using PAFApi.Data;
using PAFApi.Models;

namespace PAFApi.Mappings
{
    public class AddressMap :   ClassMap<Address>
    {
        public AddressMap()
        {
            // Map CSV fields to Address properties
            Map(m => m.PostTown);
            Map(m => m.DependentLocality);
            Map(m => m.DoubleDependentLocality);
            Map(m => m.ThoroughfareDescriptor);
            Map(m => m.DependentThoroughfareDescriptor);
            Map(m => m.BuildingNumber);
            Map(m => m.BuildingName);
            Map(m => m.SubBuildingName);
            Map(m => m.POBox);
            Map(m => m.DepartmentName);
            Map(m => m.OrganisationName);
            Map(m => m.UDPRN);
            Map(m => m.PostcodeType);
            Map(m => m.SUOrganisationIndicator);
            Map(m => m.DeliveryPointSuffix);
            Map(m => m.AddressKey);
            Map(m => m.OrganisationKey);
            Map(m => m.NumberOfHouseholds);
            Map(m => m.LocalityKey);
        }
    }
}