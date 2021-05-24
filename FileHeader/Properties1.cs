
using java.lang;
using Newtonsoft.Json.Linq;

namespace FileHeader
{

    public class Properties1 : Type
    {

        private string str2 = "";
        internal JObject level3 = new JObject();
        public Properties1() : base(4)
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
                            level3.Add("압축여부", str2[i] == '1' ? "o" : "x");
                            break;
                        case 6:
                            level3.Add("암호설정여부", str2[i] == '1' ? "o" : "x");
                            break;
                        case 5:
                            level3.Add("배포용문서여부", str2[i] == '1' ? "o" : "x");
                            break;
                        case 4:
                            level3.Add("스크립트저장여부", str2[i] == '1' ? "o" : "x");
                            break;
                        case 3:
                            level3.Add("DRM보안문서여부", str2[i] == '1' ? "o" : "x");
                            break;
                        case 2:
                            level3.Add("XMLTemplate스토리지존재여부", str2[i] == '1' ? "o" : "x");
                            break;
                        case 1:
                            level3.Add("문서 이력 관리 존재 여부", str2[i] == '1' ? "o" : "x");
                            break;
                        case 0:
                            level3.Add("전자 서명 정보 존재 여부", str2[i] == '1' ? "o" : "x");
                            break;
                        case 15:
                            level3.Add("공인 인증서 암호화 여부", str2[i] == '1' ? "o" : "x");
                            break;
                        case 14:
                            level3.Add("전자 서명 예비 저장 여부", str2[i] == '1' ? "o" : "x");
                            break;
                        case 13:
                            level3.Add("공인 인증서 DRM 보안 문서 여부", str2[i] == '1' ? "o" : "x");
                            break;
                        case 12:
                            level3.Add("CCL 문서 여부", str2[i] == '1' ? "o" : "x");
                            break;
                        case 11:
                            level3.Add("모바일 최적화 여부", str2[i] == '1' ? "o" : "x");
                            break;
                        case 10:
                            level3.Add("개인 정보 보안 문서 여부", str2[i] == '1' ? "o" : "x");
                            break;
                        case 9:
                            level3.Add("변경 추적 문서 여부", str2[i] == '1' ? "o" : "x");
                            break;
                        case 8:
                            level3.Add("공공누리 저작권 문서", str2[i] == '1' ? "o" : "x");
                            break;
                        case 23:
                            level3.Add("비디오 컨트롤 포함 여부", str2[i] == '1' ? "o" : "x");
                            break;
                        case 22:
                            level3.Add("차례 필드 컨트롤 포함 여부", str2[i] == '1' ? "o" : "x");
                            break;


                    }

                }
            }

        }

    }
}