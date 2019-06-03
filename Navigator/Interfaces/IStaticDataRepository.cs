using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Navigator.Interfaces
{
    public interface IStaticDataRepository  
    {
        IEnumerable<SelectListItem> GetAllSystems();
    }
}