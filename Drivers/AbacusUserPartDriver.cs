using System.Collections.Generic;
using JetBrains.Annotations;
using NGM.Abacus.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;

namespace NGM.Abacus.Drivers {
    [UsedImplicitly]
    public class AbacusUserPartDriver : ContentPartDriver<AbacusUserPart> {
        protected override DriverResult Editor(AbacusUserPart abacusUserPart, dynamic shapeHelper) {

            var results = new List<DriverResult> {
                CreateField(abacusUserPart, shapeHelper, "FirstName"),
                CreateField(abacusUserPart, shapeHelper, "LastName"),
                CreateField(abacusUserPart, shapeHelper, "CompanyName"),
                CreateField(abacusUserPart, shapeHelper, "EmailAddress"),
                CreateField(abacusUserPart, shapeHelper, "PhoneMobile"),
                CreateField(abacusUserPart, shapeHelper, "PhoneHome"),
                CreateField(abacusUserPart, shapeHelper, "PhoneWork"),
                CreateField(abacusUserPart, shapeHelper, "AddressLine1"),
                CreateField(abacusUserPart, shapeHelper, "AddressLine2"),
                CreateField(abacusUserPart, shapeHelper, "AddressLine3"),
                CreateField(abacusUserPart, shapeHelper, "AddressLine4"),
                CreateField(abacusUserPart, shapeHelper, "AddressLine5"),
                CreateField(abacusUserPart, shapeHelper, "PostalCode"),
            };

            return Combined(results.ToArray());
        }

        protected override DriverResult Editor(AbacusUserPart abacusUserPart, IUpdateModel updater, dynamic shapeHelper) {
            updater.TryUpdateModel(abacusUserPart, Prefix, null, null);
            return Editor(abacusUserPart, shapeHelper);
        }

        private ContentShapeResult CreateField(AbacusUserPart abacusUserPart, dynamic shapeHelper, string name) {
            var shapeName = "Parts_Abacus_User_Fields_" + name;
            var templateName = "Parts.Abacus.User.Fields." + name;
            return ContentShape(shapeName, () => {
                return shapeHelper.EditorTemplate(TemplateName: templateName, Model: abacusUserPart,
                    Prefix: Prefix);
            });
        }
    }
}