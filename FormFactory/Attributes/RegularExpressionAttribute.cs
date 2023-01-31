using System;

namespace FormFactory.Attributes
{
    public class RegularExpressionAttribute : Attribute {
        public RegularExpressionAttribute(
            string pattern,
            string friendlyFormat = null)
        {
            Pattern = pattern;
            FriendlyFormat = friendlyFormat;
        }

        public string FormatErrorMessage(string propertyVmDisplayName)
        {
            var msg = !string.IsNullOrWhiteSpace(FriendlyFormat)
                ? string.Format(Resources.RegularExpression_friendlyformat, FriendlyFormat)
                : string.Format(Resources.RegularExpression_pattern, Pattern);

            return string.Format(Resources.RegularExpression, propertyVmDisplayName, msg);
        }

        public string FriendlyFormat { get; set; }
        public string Pattern { get;  }
    }
}
