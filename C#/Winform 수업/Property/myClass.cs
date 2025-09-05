using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    internal class myClass
    {
        //string name { get; set; } / 필드를 선언하고 속성을 그대로 사용

        public string GetID()
        {
            return id;
        }

        // string data = "데이터";

        public void SetID(string get_data)
        {
            id = get_data;
        }
        // 메서드를 통해서 속성 제어
        // ---------------------------------------------------------------- 
        // 속성 자체로 제어
        private string id;
        public string Id
        {
           get { return "바꿈"; }
            set {
                if (value == "악성코드")
                {
                    id = "좋은코드";
                }
                else
                {
                    id = value;
                }
            }
        }

        public string Pw;
    }
}
