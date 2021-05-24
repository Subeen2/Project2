using Newtonsoft.Json.Linq;

namespace FileHeader
{
    public class EncryptVersion : Type
    {

        internal JObject level3 = new JObject();
        public EncryptVersion() : base(DWORD)
        {
            // TODO Auto-generated constructor stub
        }
        public virtual int byteToint(sbyte[] arr)
        {
            return (arr[0] & 0xff) << 24 | (arr[1] & 0xff) << 16 | (arr[2] & 0xff) << 8 | (arr[3] & 0xff);

        }


        public virtual void toJSON()
        {

            // int i = Array.GetValue;

            int i = byteToint(Array);


            switch (i)
            {
                case 0:
                    level3.Add("EncryptVersion", "None");
                    break;
                case 1:
                    level3.Add("EncryptVersion", "~ 2.5 version");
                    break;
                case 2:
                    level3.Add("EncryptVersion", "3.0versiong enhanced");
                    break;
                case 3:
                    level3.Add("EncryptVersion", "3.0versiong old");
                    break;
                case 4:
                    level3.Add("EncryptVersion", "7.0versiong over");
                    break;




            }








        }

    }
}