using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcProyectoAlmacen.Models.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        //Pagiancion del inicio
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }
    }
}
