using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrSt
{
    internal class PrClass
    {
        // 여러 객체를 만들어도 하나의 객체처럼 사용하는 Singleton클래스를 사용하기 위함
        // static 멤버, 외부에서 new 사용으로 새로운 객체 생성 불가
        private static PrClass instance;
        public string color; 

        private PrClass()
        {

        }

        // 한정자 (static) 반환형 메서드명(인자)
        public static PrClass GetObject()
        {
            if (instance == null) 
            {
                instance = new PrClass();
            }
            return instance;
        }
    }
}
