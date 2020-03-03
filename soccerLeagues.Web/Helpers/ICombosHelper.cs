using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace soccerLeagues.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboTeams();

    }
}
