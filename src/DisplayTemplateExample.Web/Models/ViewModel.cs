using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DisplayTemplateExample.Web.Models
{
    public class ViewModel
    {
        public ICollection<ITile> Tiles { get; set; }
    }
}