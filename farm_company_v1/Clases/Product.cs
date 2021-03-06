using System;
using System.Collections.Generic;
using System.Text;

namespace farm_company_v1.Clases
{
    public class Product
    {
        public string Name;// (e.g. potatoes, tomatoes... etc)
        public float UnitPrice; //lb
        public float UnitPerKilometer;
        public float CropExtensionKms;
        public float TaxPerUnitPercentage; //Tax per each produced crop unit.
    }
}
