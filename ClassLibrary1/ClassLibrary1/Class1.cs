using System;
using System.Threading.Tasks;
namespace ClassLibrary1
{
    public class Class1
    {
        //electron-edge规定.net暴露给它的方法必须是Func<object,Task<object>>
        public async Task<object> Add(object input)
        {
            int v = (int)input;
            return AddSeven(v);
        }

        private static int AddSeven(int v)
        {
            return v + 7;
        }

        public async Task<object> AddOne(object input)
        {
            int v = (int)input;
            return v + 1;
        }

        //以下两种方式都无用
        /*
        public static int AddTwo(int a)
        {
            return a + 2;
        }
        public int AddThree(object input)
        {
            int v = (int)input;
            return v + 1;
        }
        */
    }
}
