using System;

namespace FormFactory.Attributes
{
    public class DisplayFormatAttribute : Attribute
    {
        public string DataFormatString { get; set; }

        public DisplayFormatAttribute(string dataFormatString = null)
        {
            DataFormatString = dataFormatString; 
        }
    }
}