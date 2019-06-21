using System;
namespace HelloWorldEnterprise.Repositories
{
    public class HelloWorld : IRepo, IWriter
    {
        private string str = "Hello World";

        public string Read()
        {
            return str;
        }

        public void Write()
        {
            Console.WriteLine(str);
        }
    }
}
