using System;
using System.Threading.Tasks;
using Tutorial.Common.Extensions;

namespace RefStructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            "Ref-Structs".DumpAsTitle();
            "Ref structs cannot be referenced from heap, its not allowed".Dump();
            "Because of that we have limitations :".Dump();
            "They cannot implement interfaces".Dump();
            "They cannot be used in async methods,iterators,lambda expressions or local functions".Dump();

            Keys keys = new Keys("dq3234cr23r24", "fwe4cfwfrfrwerfckq");

            //Cant do this because class allocated on the head,to check uncomment
            //Object value = keys;

            "We can use them as parameter,return type or local variable".Dump();

            PrintValues(ref keys);

            keys.Dispose();
        }

        static void PrintValues(ref Keys keys)
        {
            "Private key :".Dump();
            keys.PrivateKey.Dump();
            "Public key  :".Dump();
            keys.PublicKey.Dump();
        }

        static Keys GenerateKey()
        {
            return new Keys(Guid.NewGuid().ToString(),Guid.NewGuid().ToString());
        }
    }

    public ref struct Keys
    {
        public string PublicKey;
        public string PrivateKey;

        public Keys(string privateKey, string publicKey)
        {
            PublicKey = publicKey;
            PrivateKey = privateKey;
        }
         
        /// <summary>
        /// Ref sturcts cannot implement an interface and therefore IDisposable
        /// To use disposable feature we can use public void Dispose method for read-only ref structs and ref structs
        /// </summary>
        public void Dispose()
        {
            "Disposed".Dump();
        }
    }

    public class KeyContainer
    {
        //Cannot use ref struct as a class field beacuse its not allowed allocate them on the heap
        //to check uncomment
        //public Keys Keys;

        //Not allowed in async methods
        //public async Task PrintKeys(Keys keys)
        //{
        //    return await Task.FromResult<Keys>(keys);
        //}
    }

   


}
