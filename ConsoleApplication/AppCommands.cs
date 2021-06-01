using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace CshConsoleAPI
{
	public class AppCommands
	{
		public const string CMD_PROMPED = "\n>";
		public const string CMD_ECHO = "echo";
		public const string CMD_EXIT = "exit";
        public const string CMD_ADD = "add";
        public const string CMD_SUB = "sub";
        public const string CMD_MULT = "mult";
        public const string CMD_DIV = "div";




        /***
		* Echo demonstrates a command execution function.
		* the command prints the parameters it receives.
		*/
        public static bool CommandEcho(string[] parameters)
		{
			foreach (string param in parameters){
				Console.WriteLine(param);
			}
			return (true);
		}


		/***
		* Exit terminates the application.
		* the command prints the exit messsage.
		*/
		public static bool CommandExit(string[] parameters)
		{
			Console.WriteLine(CMD_EXIT);
			return (false);
		}


        public static bool CommandAdd(string[] parameters)
        {
            int add_value = 0;
            foreach (string param in parameters)
            {
                
                add_value += Int32.Parse(param);
            }
            Console.WriteLine(add_value);
            return true;
            
        }


        public static bool CommandSub(string[] parameters)
        {
            int sub_value = Int32.Parse(parameters[0]);
            int first = Int32.Parse(parameters[0]);

            foreach (string param in parameters)
            {
                
                sub_value -= Int32.Parse(param);
               
            }
            sub_value = sub_value + first;
            Console.WriteLine(sub_value);
            return true;
        }


        public static bool CommandMult(string[] parameters)
        {
            int mult_value = 1;
          
            foreach (string param in parameters)
            {

                mult_value = mult_value * Int32.Parse(param);

            }
            
            Console.WriteLine(mult_value);
            return true;

        }


        public static bool CommandDiv(string[] parameters)
        {
            double div_value = Convert.ToDouble(parameters[0]);
            double first = Convert.ToDouble(parameters[0]);

            foreach (string param in parameters)
            {

                div_value = div_value / Convert.ToDouble(param);

            }
            div_value = div_value * first;
            Console.WriteLine(div_value);
            return true; ;
        }
    }
}
