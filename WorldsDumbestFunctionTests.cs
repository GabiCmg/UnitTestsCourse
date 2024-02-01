using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsCourse
{
    internal class WorldsDumbestFunctionTests
    {
        // Naming Convention - ClassName_MethodName_ExpetedResult
        public static void WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnString()
        {
            try
            {
                //Arange = go get your variable, whatever you need, your classes, go get functions
                int num = 0;
                WorldsDumbestFunction worldsDumbest = new WorldsDumbestFunction();

                //Act = execute this function
                string result = worldsDumbest.ReturnsPikachuIfZero(num);

                //Assert = whatever ever is returned is it what you want
                if(result == "PIKACHU!")
                {
                    Console.WriteLine("PASSED: WorldsDumbestFunction.ReturnsPikachuIfZero_ReturnString");
                }
                else 
                {
                    Console.WriteLine("FAILED: WorldsDumbestFunction.ReturnsPikachuIfZero_ReturnString");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
