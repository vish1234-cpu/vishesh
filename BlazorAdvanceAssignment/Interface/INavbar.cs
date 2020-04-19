using BlazorAdvanceAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdvanceAssignment.Interface
{
    public interface INavbar
    {
        List<Menu> GetMenus(); 
    }
}
