using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UZEM_PROJECT.Core.Entity;

namespace UZEM_PROJECT.Model
{
   public class MainTitleClass:BaseEntity
    {
        public string Name { get; set; }
        public virtual List<TopTitleClass> TopTitles { get; set; }
    }
}
