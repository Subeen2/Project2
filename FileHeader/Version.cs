using System.Collections;
using Newtonsoft.Json.Linq;

namespace FileHeader
{
    public class Version : Type
    {
        internal JObject level3 = new JObject();

        public Version() : base(4)
        {
            // TODO Auto-generated con	structor stub
        }


        public virtual string print()
        {
            string str1 = "";
            Stack stk = new Stack();
            for (int i = 0; i < Array_Conflict.Length; i++)
                stk.Push(Array_Conflict[i]);
            while (stk.Count != 0)
            {
                str1 = str1 + stk.Pop() + "";
                if (stk.Count != 0)
                    str1 += ".";
            }
            return str1;
        }

        public virtual void toJSON()
        {

            level3.Add("Version", print());


        }

    }
}