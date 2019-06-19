using System;

namespace Sol_Func_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Func<String,String> funcObj= (leStr) =>{

                return leStr.ToUpper();

            };

            Console.WriteLine(funcObj("kishor naik"));

            var funcDemoObj=new FuncDemo();
                funcDemoObj.FuncParameter("kishor naik",(leStr)=> leStr.ToUpper());
                funcDemoObj.FuncParameter("KISHOR NAIK",(leStr)=> leStr.ToLower());

                funcDemoObj.FuncParameter("Eshaan Naik",funcDemoObj.FuncReturn());
        }
    }

    public class FuncDemo{

        public void FuncParameter(String value, Func<String,String> funcStringOps){

            Console.WriteLine(funcStringOps(value));
        }

        public Func<String,String> FuncReturn(){
            return 
                (leStr)=> $"Hello {leStr}";
        }

    }

    
}
