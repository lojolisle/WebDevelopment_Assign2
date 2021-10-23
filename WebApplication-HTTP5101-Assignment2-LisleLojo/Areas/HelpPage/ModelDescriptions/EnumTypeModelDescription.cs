using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WebApplication_HTTP5101_Assignment2_LisleLojo.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}