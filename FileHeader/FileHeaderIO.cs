using System;
using System.Collections.Generic;

using Newtonsoft.Json.Linq;
using FileHeader;
using System.IO;

public class FileIO
{

    private string readpath = Directory.GetCurrentDirectory() + @"\FileHeader.txt";

    private string savepath = Directory.GetCurrentDirectory() + @"\JSONFileHeader.json";
    internal sbyte[] Arbyte;
	internal Queue<sbyte> arrays = new Queue<sbyte>();
	internal Signature sig = new Signature();
	internal FileHeader.Version ver = new FileHeader.Version();
	internal Properties1 pro1 = new Properties1();
	internal Properties2 pro2 = new Properties2();
	internal FileHeader.EncryptVersion enc = new FileHeader.EncryptVersion();

	internal JObject level1 = new JObject();
	internal string json;

	public virtual void Read()
	{
        using (StreamReader rdr = new StreamReader(readpath))
        {
            // 한 문자 읽기
            int ch = 0;
            while (!rdr.EndOfStream) {
                ch = rdr.Read();
                arrays.Enqueue((sbyte) ch);
            }
           
        }

        sig.Array = send(sig.Array, sig.Size);
		ver.Array = send(ver.Array, ver.Size);
		pro1.Array = send(pro1.Array, pro1.Size);
		pro2.Array = send(pro2.Array, pro2.Size);
		enc.Array = send(enc.Array, enc.Size);

	}

	public virtual sbyte[] send(sbyte[] bt, int length)
	{
		for (int i = 0; i < length; i++)
		{
            bt[i] = arrays.Dequeue();

		}
		return bt;

	}

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in C#:
//ORIGINAL LINE: public void out() throws java.text.ParseException
	public virtual void @out()
	{

		JObject level2 = new JObject();

		sig.toJSON(); ver.toJSON(); pro1.toJSON(); pro2.toJSON(); enc.toJSON();

		level2.Add("EncryptVersion", enc.level3);
		level2.Add("Properties2", pro2.level3);
		level2.Add("Properties1", pro1.level3);
		level2.Add("Version", ver.level3);
		level2.Add("Signature", sig.level3);

		level1.Add("FileHeader", level2);
        json = level1.ToString();
		Console.Write(json);

	}

    public virtual void write() => File.WriteAllText(savepath, json);


}
