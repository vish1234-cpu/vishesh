using BlazorAdvanceAssignment.Interface;
using BlazorAdvanceAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdvanceAssignment.Service
{
    public class Navbar:INavbar 
    {
        private readonly AdvanceBlazorContext _adc;
        public Navbar(AdvanceBlazorContext advanceBlazorContext)
        {
            _adc = advanceBlazorContext; 
        }

        public List<Menu> GetMenus() 
        {
            try
            {
                var result = _adc.Menu.Select(m => m).ToList();
                return result;
            }
            catch(Exception ex)
            {
                throw ex; 
            }
           
        }
    }
}
