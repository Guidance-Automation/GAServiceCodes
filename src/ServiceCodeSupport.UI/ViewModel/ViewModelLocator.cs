using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCodeSupport.UI.ViewModel
{
    public static class ViewModelLocator
    {
        public static ServiceCodeDictionaryViewModel ServiceCodeDictionaryViewModel { get; } = new ServiceCodeDictionaryViewModel();
    }
}
