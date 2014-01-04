using System.Linq;
using System.Web.Mvc;
using NGM.Abacus.Services;
using Orchard;
using Orchard.ContentManagement;
using Orchard.DisplayManagement;
using Orchard.Localization;
using Orchard.Settings;
using Orchard.UI.Admin;

namespace NGM.Abacus.Controllers {
    [ValidateInput(false), Admin]
    public class AbacusUserAdminController : Controller, IUpdateModel {
        private readonly IOrchardServices _orchardServices;
        private readonly IAbacusUserService _abacusUserService;
        private readonly ISiteService _siteService;
        private readonly IContentManager _contentManager;

        public AbacusUserAdminController(IOrchardServices orchardServices, 
            IAbacusUserService abacusUserService,
            ISiteService siteService,
            IContentManager contentManager,
            IShapeFactory shapeFactory) {
            _orchardServices = orchardServices;
            _abacusUserService = abacusUserService;
            _siteService = siteService;
            _contentManager = contentManager;

            T = NullLocalizer.Instance;
            Shape = shapeFactory;
        }

        dynamic Shape { get; set; }
        public Localizer T { get; set; }

        public ActionResult List() {
            var list = _orchardServices.New.List();

            list.AddRange(_abacusUserService.Get(VersionOptions.Latest)
                .Select(b => _contentManager.BuildDisplay(b, "SummaryAdmin")));

            dynamic viewModel = _orchardServices.New.ViewModel()
                .ContentItems(list);

            return View(viewModel);
        }

        bool IUpdateModel.TryUpdateModel<TModel>(TModel model, string prefix, string[] includeProperties, string[] excludeProperties) {
            return TryUpdateModel(model, prefix, includeProperties, excludeProperties);
        }

        void IUpdateModel.AddModelError(string key, LocalizedString errorMessage) {
            ModelState.AddModelError(key, errorMessage.ToString());
        }
    }
}