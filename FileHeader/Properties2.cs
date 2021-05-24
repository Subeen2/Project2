using java.lang;
using Newtonsoft.Json.Linq;

namespace FileHeader
{
    public class Properties2 : Type
    {
        public string str2 = "";
        internal JObject level3 = new JObject();
        public Properties2() : base(4)
        {
            // TODO Auto-generated constructor stub
        }
        public override string ToString()
        {
            // TODO Auto-generated method stub
            return "size : " + Size + "byte : " + Array.ToString();
        }
        public virtual void bit()
        {
            string str1 = "";

            for (int i = 0; i < Array_Conflict.Length; i++)
            {
                str1 = Integer.toBinaryString(Array_Conflict[i]);
                str2 = str2 + string.Format("{0:D8}", int.Parse(str1));


            }


        }
        public virtual void toJSON()
        {
            bit();
            level3 = new JObject();
            for (int i = 0; i < str2.Length; i++)
            {
                if (i < size * 8)
                {
                    switch (i)
                    {
                        case 7:
                            level3.Add("CCL 공공누리라이선스정보", str2[i] == '1' ? "o" : "x");
                            break;
                        case 6:
                            level3.Add("복제 제한 여부", str2[i] == '1' ? "o" : "x");
                            break;
                        case 5:
                            level3.Add("동일 조건 하에 복제 허가 여부", str2[i] == '1' ? "o" : "x");
                            break;




                    }


                }

            }

        }
    }

}