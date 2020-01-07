using System.Collections.Generic;

namespace Dvelop.Sdk.Dms.Dto
{
    public class DmsObjectExtensionsDto
    {
        public DmsObjectExtensionsDto()
        {
            Extensions = new List<DmsObjectExtensionDto>();
        }

        public List<DmsObjectExtensionDto> Extensions { get; set; }
    }
}
