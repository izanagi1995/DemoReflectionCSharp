using DemoBinding.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBinding
{
    class MyCustomRenderer : IBindingRenderer
    {
        public string Render(object data)
        {
            string line = (string)data;
            return "(using MyCustomRenderer) " + data;
        }
    }
}
