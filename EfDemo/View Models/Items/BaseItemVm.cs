using EfDemo.Models.Items;

namespace EfDemo.View_Models.Items
{
    public class BaseItemVm<TModel, TVm> where TVm : IItemVm
                                         where TModel : IItemModel
    {
        #region Private Vars

        private TModel _model;

        #endregion

        #region GUI Vars

        public string Name { get; set; }
        public int Id { get; set; }

        #endregion

        #region C'Tor

        public BaseItemVm(TModel model)
        {
            _model = model;

            Name = _model.Name;
            Id = _model.Id;
        }

        #endregion
    }
}
