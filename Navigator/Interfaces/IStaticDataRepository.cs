using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Navigator.Interfaces
{
    internal interface IStaticDataRepository  
    {
        IEnumerable<SelectListItem> GetAllSystems();
    }
}