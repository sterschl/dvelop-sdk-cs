using System.Collections.Generic;

namespace Dvelop.Sdk.Dms.Dto
{
    public class DmsObjectExtensionActivationCondition
    {
        public DmsObjectExtensionActivationCondition()
        {
            Values = new List<string>();
        }
        
        public string PropertyId { get; set; }
        public string Operator { get; set; } 
        public List<string> Values { get; set; }
    }
}