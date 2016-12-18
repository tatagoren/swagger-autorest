using SwaggerTest.RestApiRef;
using SwaggerTest.RestApiRef.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerTest.AutoRestClientConsole.Implementation
{
    public class SyncImplementation : AbstractImplementation
    {
        public SyncImplementation(SwaggerSampleAPI apiRef) : base(apiRef)
        {
        }

        public override void execute()
        {
            List<ValueViewModel> list = ApiRef.ApiValuesGet().ToList();
            ImplUtil.PrintList(list);

            Console.WriteLine("Getting Value By Id (2)");
            ValueViewModel model = ApiRef.ApiValuesByIdGet(2);
            Console.WriteLine("Id: " + model.Id + " Name: " + model.Name + " Value: " + model.Value);


            Console.WriteLine("Creating New Value");
            ValueViewModel tmpModel = new ValueViewModel { Id = 6, Name = "Test", Value = 6 };

            ApiRef.ApiValuesPost(tmpModel);
            list = ApiRef.ApiValuesGet().ToList();
            ImplUtil.PrintList(list);

            Console.WriteLine("Updating Value (3)");
            model.Name = "Ten";
            model.Value = 10;
            ApiRef.ApiValuesByIdPut(2, model);
            list = ApiRef.ApiValuesGet().ToList();
            ImplUtil.PrintList(list);


            Console.WriteLine("Deleting Value (4)");
            ApiRef.ApiValuesByIdDelete(4);
            list = ApiRef.ApiValuesGet().ToList();
            ImplUtil.PrintList(list);
        }
    }
}
