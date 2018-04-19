using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBinding.Rendering
{
    class BaseRenderer : IBindingRenderer
    {
        public string Render(object data)
        {
            return data.ToString();
        }
    }
}
