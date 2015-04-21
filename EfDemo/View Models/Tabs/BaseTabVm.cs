using System.Collections.ObjectModel;

namespace EfDemo.View_Models.Tabs
{
    public class BaseTabVm<TVm>
    {
        public ObservableCollection<TVm> Items { get; set; }

        public BaseTabVm()
        {
            Items = new ObservableCollection<TVm>();
        }
    }
}
