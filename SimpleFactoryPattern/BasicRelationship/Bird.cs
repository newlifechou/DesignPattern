using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRelationship
{
    /// <summary>
    /// 组合关系
    /// </summary>
    class Bird
    {
        private Leg leg_1;
        public Bird()
        {
            leg_1 = new Leg();
        }
    }
}
