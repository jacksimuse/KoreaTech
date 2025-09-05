using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class myClass
    {
        public int instanceNum = 0;
        public static int staticNum = 0;

        // static은 전부 입장 가능 / instance는 static에 입장 불가
        public void PlusInstance()
        {
            instanceNum++;
            staticNum++;
        }

        public static void PlusStatic()
        {
            //instanceNum++;
            staticNum++;
        }
    }
}
