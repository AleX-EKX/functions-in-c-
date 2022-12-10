using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtorization
{
    
        public enum animate
        {
            Скольжение_слева_направо = 0x00040000 | 0x0000001,
            скольжение_сверху_вниз = 0x00040000 | 0x00000004,
            Скольжение_снизу_вверх = 0x00040000 | 0x00000008,
            Скольжение_сверху_направо = 0x00040000 | 0x00000004,
            появление_затухание = 0x00080000,
            раскрытие_скрытие = 0x0000010,
        }
       

    
}
