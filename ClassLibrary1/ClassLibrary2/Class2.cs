using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class2
    {
        //electron-edge规定.net暴露给它的方法必须是Func<object,Task<object>>
        public async Task<object> GetPerson(dynamic input)
        {
            Console.WriteLine("Execute C# code success !");
            Person person = new Person();
            return person;
        }
    }
}
