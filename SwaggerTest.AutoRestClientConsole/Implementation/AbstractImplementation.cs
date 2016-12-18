using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwaggerTest.RestApiRef;

namespace SwaggerTest.AutoRestClientConsole.Implementation
{
    public abstract class AbstractImplementation : IApiImplementation
    {
        private SwaggerSampleAPI _apiRef;

        public AbstractImplementation(SwaggerSampleAPI apiRef)
        {
            ApiRef = apiRef;
        }

        public SwaggerSampleAPI ApiRef
        {
            get
            {
                return _apiRef;
            }

            set
            {
                _apiRef = value;
            }
        }

        public abstract void execute();

    }
}
