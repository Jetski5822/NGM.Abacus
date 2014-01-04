using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NGM.Abacus.Models;
using Orchard;
using Orchard.ContentManagement;

namespace NGM.Abacus.Services {
    public interface IAbacusUserService : IDependency {
        IEnumerable<AbacusUserPart> Get(VersionOptions versionOptions);
    }

    public class AbacusUserService : IAbacusUserService {
        public IEnumerable<AbacusUserPart> Get(VersionOptions versionOptions) {
            throw new NotImplementedException();
        }
    }
}