using ShopBags.Helpers;
using ShopBags.Views;

namespace ShopBags.Controllers
{
    internal class StoreController
    {
        private readonly StoreView _view;
        private PanelView _panelView;

        public StoreController(StoreView view)
        {
            _view = view;
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            _view.OpenPanel += OpenPanel;
        }

        private void OpenPanel(object sender, EventArgs e)
        {
            _panelView = new PanelView();
            PanelController panelController = new PanelController(_panelView);
            _panelView.Show();
        }
    }
}
