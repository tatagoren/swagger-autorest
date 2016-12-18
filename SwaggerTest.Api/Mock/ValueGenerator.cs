using SwaggerTest.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerTest.Api.Mock
{
    public static class ValueGenerator
    {

        static List<ValueViewModel> valuesList = new List<ValueViewModel> {
            new ValueViewModel { Id=1,Name="One",Value=1},
            new ValueViewModel { Id=2,Name="Two",Value=2},
            new ValueViewModel { Id=3,Name="Three",Value=3},
            new ValueViewModel { Id=4,Name="Four",Value=4},
            new ValueViewModel { Id=5,Name="Five",Value=5},
        };

        public static List<ValueViewModel> GetAll()
        {
            return valuesList;
        }

        public static ValueViewModel GetById(int id)
        {
            return valuesList.First(v => v.Id == id);
        }

        public static void Insert(ValueViewModel model)
        {
            model.Id = valuesList.Count+1;
            valuesList.Add(model);
        }

        public static bool Update(int id, ValueViewModel model)
        {
            int index = valuesList.IndexOf(valuesList.First(V => V.Id == id));
            if (index >= 0)
            {
                valuesList[index].Name = model.Name;
                valuesList[index].Value = model.Value;
                return true;
            }
            return false;

        }
        public static bool Delete(int id)
        {
            return valuesList.Remove(valuesList.First(v => v.Id == id));
        }
    }
}
