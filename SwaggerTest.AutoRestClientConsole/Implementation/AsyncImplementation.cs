using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwaggerTest.RestApiRef;
using SwaggerTest.RestApiRef.Models;

namespace SwaggerTest.AutoRestClientConsole.Implementation
{
    public class AsyncImplementation : AbstractImplementation
    {
        public AsyncImplementation(SwaggerSampleAPI apiRef) : base(apiRef)
        {
        }

        public override void execute()
        {
            List<ValueViewModel> list = new List<ValueViewModel>();

            Task.Run(() =>
            {
                var response = ApiRef.ApiValuesGetAsync();
                list = response.Result.ToList();
            }).Wait();

            ImplUtil.PrintList(list);

            Console.WriteLine("Getting Value By Id (2)");
            ValueViewModel model = new ValueViewModel();
            Task.Run(() =>
            {
                var response = ApiRef.ApiValuesByIdGetAsync(2);
                model = response.Result;
            }).Wait();

            Console.WriteLine("Id: " + model.Id + " Name: " + model.Name + " Value: " + model.Value);

            Console.WriteLine("Creating New Value");
            ValueViewModel tmpModel = new ValueViewModel { Id = 6, Name = "Test", Value = 6 };

            Task.Run(() =>
            {
                var response = ApiRef.ApiValuesPostAsync(tmpModel);
            }).Wait();

            list = ApiRef.ApiValuesGet().ToList();
            ImplUtil.PrintList(list);

            Console.WriteLine("Updating Value (3)");
            model.Name = "Ten";
            model.Value = 10;
            Task.Run(() =>
            {
                var response = ApiRef.ApiValuesByIdPutAsync(2, model);
            }).Wait();

            
            list = ApiRef.ApiValuesGet().ToList();
            ImplUtil.PrintList(list);

            Console.WriteLine("Deleting Value (4)");
            Task.Run(() =>
            {
                var response = ApiRef.ApiValuesByIdDeleteAsync(4);
            }).Wait();
            
            list = ApiRef.ApiValuesGet().ToList();
            ImplUtil.PrintList(list);

        }

    }
}
