using SwaggerTest.RestApiRef.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerTest.AutoRestClientConsole.Implementation
{
    public class ImplUtil
    {
        public static void PrintList(List<ValueViewModel> modelList)
        {
            foreach (ValueViewModel item in modelList)
            {
                Console.WriteLine("Id: " + item.Id + " Name: " + item.Name + " Value: " + item.Value);
            }
        }

        
    }
}
