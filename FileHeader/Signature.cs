using Newtonsoft.Json.Linq;
namespace FileHeader
{
    public class Signature : Type
    {

        internal JObject level3 = new JObject();
        public Signature() : base(32)
        {
            // TODO Auto-generated constructor stub

        }
        public virtual string String
        {
            get
            {
                string str = StringHelper.NewString(Array);
                return str;
            }
        }
        public override string ToString()
        {
            // TODO Auto-generated method stub
            return "size : " + Size + "byte : " + Array.ToString();
        }
        public virtual void toJSON()
        {

            level3.Add("Signature", String);


        }

    }
 }