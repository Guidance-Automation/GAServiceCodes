using ServiceCodeSupport.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceCodeSupport.UI.ViewModel;

namespace ServiceCodeSupport.DemoApp
{
    internal static class BootStrapper
    {
        public static void Activate()
        {
            ServiceCodeDictionary dictionary = new ServiceCodeDictionary();
            ViewModelLocator.ServiceCodeDictionaryViewModel.Model = dictionary;
        }
    }
}
