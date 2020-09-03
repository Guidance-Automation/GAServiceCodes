using GACore;
using ServiceCodeSupport.APICommon.Dtos;
using ServiceCodeSupport.Architecture;

namespace ServiceCodeSupport.UI.ViewModel
{
    public class ServiceCodeDictionaryViewModel : AbstractViewModel<IServiceCodeDictionary>
    {
        internal ServiceCodeDictionaryViewModel()
        {
        }

        private ServiceCodeDefinitionDto entry = null;

        public ServiceCodeDefinitionDto Entry
        {
            get { return entry; }
            private set
            {
                if (entry != value)
                {
                    entry = value;
                    OnNotifyPropertyChanged();
                }
            }
        }
    }
}
