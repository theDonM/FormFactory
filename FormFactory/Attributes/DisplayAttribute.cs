using System;

namespace FormFactory.Attributes
{
    public class DisplayAttribute : Attribute
    {
        public DisplayAttribute(
            string name = null,
            string prompt = null)
        {
            Name = name;
            Prompt = prompt;
        }

        public string Name { get; set; }
        public string Prompt { get; set; }
    }
}