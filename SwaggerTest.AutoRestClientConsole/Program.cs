using Newtonsoft.Json;
using SwaggerTest.AutoRestClientConsole.Implementation;
using SwaggerTest.RestApiRef;
using SwaggerTest.RestApiRef.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerTest.AutoRestClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var apiRef = new SwaggerSampleAPI(new Uri("http://localhost:52759"));
            //AbstractImplementation syncImplementation = new SyncImplementation(apiRef);
            //syncImplementation.execute();

            AbstractImplementation asyncImplementation = new AsyncImplementation(apiRef);
            asyncImplementation.execute();

            Console.ReadLine();
        }

        

    }
}
