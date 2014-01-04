using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace NGM.Abacus {
    public class Migrations : DataMigrationImpl {
        public int Create() {
            SchemaBuilder.CreateTable("AbacusUserPartRecord",
                table => table
                    .ContentPartRecord()
                    .Column<string>("FirstName")
                    .Column<string>("LastName")
                    .Column<string>("CompanyName")
                    .Column<string>("EmailAddress")
                    .Column<string>("PhoneMobile")
                    .Column<string>("PhoneHome")
                    .Column<string>("PhoneWork")
                    .Column<string>("AddressLine1")
                    .Column<string>("AddressLine2")
                    .Column<string>("AddressLine3")
                    .Column<string>("AddressLine4")
                    .Column<string>("AddressLine5")
                    .Column<string>("PostalCode")
                    //.Column<string>("Country") // Taxonomy?
                );

            ContentDefinitionManager.AlterPartDefinition("AbacusUserPart", builder => builder
                .WithDescription("The part used to store information about your Abacus user"));

            ContentDefinitionManager.AlterTypeDefinition("AbacusUser", cfg => cfg
                .WithPart("AbacusUserPart")
                .WithPart("CommonPart")
            );

            return 1;
        }
    }
}