using JetBrains.Annotations;
using NGM.Abacus.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace NGM.Abacus.Handlers {
    [UsedImplicitly]
    public class AbacusUserPartHandler : ContentHandler {
        public AbacusUserPartHandler(IRepository<AbacusUserPartRecord> repository) {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}