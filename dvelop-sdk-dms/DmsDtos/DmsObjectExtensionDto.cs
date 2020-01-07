using System.Collections.Generic;

namespace Dvelop.Sdk.Dms.Dto
{
    public class DmsObjectExtensionDto
    {
        public DmsObjectExtensionDto()
        {
            ActivationConditions = new List<DmsObjectExtensionActivationCondition>();
        }

        public string Id { get; set; }
        public List<DmsObjectExtensionActivationCondition> ActivationConditions { get; set; }
        
        //captions
        public string Context { get; set; }
        //DmsObjectListContextAction or DmsObjectDetailsPreview
        
        public string UriTemplate { get; set; }
        
        //iconUri
    }
}
