using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoBinding.Attributes;
using DemoBinding.Rendering;

namespace DemoBinding
{
    class Document
    {
        [Bind("MyName")]
        public string Name;

        [Bind("BetterName", RendererType = typeof(MyCustomRenderer))]
        public string Name2;

        public Document(Object model) {
            this.AssignProperties(this, model);
        }

        private void AssignProperties(Document document, object model)
        {
            Type docType = typeof(Document);
            IEnumerable<System.Reflection.FieldInfo> propinfos = docType.GetFields().Where(prop => Attribute.IsDefined(prop, typeof(Bind)));
            foreach (var info in propinfos) {
                Bind bindAttr = (Bind)Attribute.GetCustomAttribute(info, typeof(Bind));
                System.Reflection.FieldInfo modelProp = model.GetType().GetField(bindAttr.ModelProperty);
                object value = modelProp.GetValue(model);

                IBindingRenderer renderer = (IBindingRenderer)Activator.CreateInstance(bindAttr.RendererType);
                string res = renderer.Render(value);

                info.SetValue(document, res);
            }
        }

        public string Render() {
            return "Hello, " + Name + ", Fancy " + Name2;
        }
    }
}
