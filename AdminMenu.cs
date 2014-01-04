using NGM.Abacus.Extensions;
using Orchard.Localization;
using Orchard.UI.Navigation;

namespace NGM.Abacus {
    public class AdminMenu : INavigationProvider {
        public Localizer T { get; set; }

        public string MenuName {
            get { return "admin"; }
        }

        public void GetNavigation(NavigationBuilder builder) {
            builder.Add(T("Abacus"), "5", item => item
                .Add(T("Leads"), "6", i => i.Action("Index", "LeadsAdmin", new {area = Constants.LocalArea})));
        }
    }
}
