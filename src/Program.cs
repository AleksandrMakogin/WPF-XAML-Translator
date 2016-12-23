using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Count() < 4)
            {
                Console.WriteLine("Input parameters error!");
                Console.WriteLine("Usage: \r\n" +
                                  "Translater.exe -inputFile -outputFile -srcLang -dstLang \r\n" +
                                  "Language Codes: https://developers.google.com/recaptcha/docs/language");
            }
            else
            {
                try {
                    Translator translator = new Translator(args[0], args[1], args[2], args[3]);
                    translator.StartTranslate();
                }
                catch(System.Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            Console.ReadKey();
        }
    }
}
