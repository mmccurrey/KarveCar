﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KarveDataServices.DataObjects;
namespace DataAccessLayer.DataObjects
{
    public class CountryDataObject : ICountryDataObject
    {
        public object CountryCode { get; set ; }
        public object Name { get; set; }
    }
}
