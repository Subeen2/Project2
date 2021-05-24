
namespace FileHeader
{
    public abstract class Type
    {
        public int size;
        public const int DWORD = 4;
        //JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods of the current type:
        public sbyte[] Array_Conflict;

        public Type(int size)
        {
            // TODO Auto-generated constructor stub
            this.size = size;
            this.Array_Conflict = new sbyte[size];
        }
        public virtual sbyte[] Array
        {
            get
            {
                return Array_Conflict;
            }
            set
            {
                Array_Conflict = value;
            }
        }

        public virtual int Size
        {
            get
            {
                return size;
            }
            set
            {
                this.size = value;
            }
        }



    }
}