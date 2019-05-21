using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EVEAsset.Navigator.Interfaces
{
    internal interface IStaticDataRepository  
    {
        IEnumerable<SelectListItem> GetAllSystems();
    }
}