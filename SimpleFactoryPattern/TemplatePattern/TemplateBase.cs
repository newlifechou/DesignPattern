using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    abstract class TemplateBase
    {
        public abstract void One();
        public abstract void Two();
        public void TemplateMethod()
        {
            One();
            Two();
        }
    }
}
