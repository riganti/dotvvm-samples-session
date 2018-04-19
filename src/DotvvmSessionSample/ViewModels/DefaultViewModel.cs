using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;

namespace DotvvmSessionSample.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {


        public string Value { get; set; }

        public void Write()
        {
            HttpContext.Current.Session["Value"] = Value;
        }

        public void Read()
        {
            Value = HttpContext.Current.Session["Value"] as string;
        }

    }
}
