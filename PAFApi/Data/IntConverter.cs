using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace PAFApi.Data
{
    public class NullableInt32Converter : DefaultTypeConverter
    {
        public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
        {
            // Handle empty strings by returning null
            if (string.IsNullOrWhiteSpace(text))
            {
                return null;
            }

            // Convert non-empty strings to int?
            return base.ConvertFromString(text, row, memberMapData);
        }
    }
}