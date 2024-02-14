using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PAFApi.Models
{
    public class Address
    {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? PostCode { get; set; }
    public string? PostTown { get; set; }
    public string? DependentLocality { get; set; }
    public string? DoubleDependentLocality { get; set; }
    public string? ThoroughfareDescriptor { get; set; }
    public string? DependentThoroughfareDescriptor { get; set; }
    public string? BuildingNumber { get; set; }
    public string? BuildingName { get; set; }
    public string? SubBuildingName { get; set; }
    public string? POBox { get; set; }
    public string? DepartmentName { get; set; }
    public string? OrganisationName { get; set; }
    public string? UDPRN { get; set; }
    public string? PostcodeType { get; set; }
    public string? SUOrganisationIndicator { get; set; }
    public string? DeliveryPointSuffix { get; set; }
    public int? AddressKey { get; set; }
    public int? OrganisationKey { get; set; }
    public int? NumberOfHouseholds { get; set; }
    public int? LocalityKey { get; set; }
    }
}