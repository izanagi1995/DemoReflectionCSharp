using DemoBinding.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBinding.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    class Bind : Attribute
    {
        public string ModelProperty;
        public Type RendererType;

        public Bind(string modelProp) {
            this.ModelProperty = modelProp;
            this.RendererType = typeof(BaseRenderer);
        }
    }
}
