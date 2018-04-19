using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBinding.Rendering
{
    interface IBindingRenderer
    {
        string Render(object data);
    }
}
