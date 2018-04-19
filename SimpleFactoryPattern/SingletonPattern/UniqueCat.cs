using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 利用只读特性只能第一次初始化的特征。
    /// </summary>
    class UniqueCat
    {
        public static readonly UniqueCat cat;
        static UniqueCat()
        {
            cat = new UniqueCat();
        }
        public static UniqueCat GetCat()
        {
            return cat;
        }
    }
}
