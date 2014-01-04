using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;

namespace NGM.Abacus.Models {
    public class AbacusUserPart : ContentPart<AbacusUserPartRecord> {
        public string Title {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }

        public string FirstName {
            get { return Retrieve(x => x.FirstName); }
            set { Store(x => x.FirstName, value); }
        }

        public string LastName {
            get { return Retrieve(x => x.LastName); }
            set { Store(x => x.LastName, value); }
        }

        public string CompanyName {
            get { return Retrieve(x => x.CompanyName); }
            set { Store(x => x.CompanyName, value); }
        }

        public string EmailAddress {
            get { return Retrieve(x => x.EmailAddress); }
            set { Store(x => x.EmailAddress, value); }
        }

        public string PhoneMobile {
            get { return Retrieve(x => x.PhoneMobile); }
            set { Store(x => x.PhoneMobile, value); }
        }

        public string PhoneHome {
            get { return Retrieve(x => x.PhoneHome); }
            set { Store(x => x.PhoneHome, value); }
        }

        public string PhoneWork {
            get { return Retrieve(x => x.PhoneWork); }
            set { Store(x => x.PhoneWork, value); }
        }

        public string AddressLine1 {
            get { return Retrieve(x => x.AddressLine1); }
            set { Store(x => x.AddressLine1, value); }
        }

        public string AddressLine2 {
            get { return Retrieve(x => x.AddressLine2); }
            set { Store(x => x.AddressLine2, value); }
        }

        public string AddressLine3 {
            get { return Retrieve(x => x.AddressLine3); }
            set { Store(x => x.AddressLine3, value); }
        }

        public string AddressLine4 {
            get { return Retrieve(x => x.AddressLine4); }
            set { Store(x => x.AddressLine4, value); }
        }

        public string AddressLine5 {
            get { return Retrieve(x => x.AddressLine5); }
            set { Store(x => x.AddressLine5, value); }
        }

        public string PostalCode {
            get { return Retrieve(x => x.PostalCode); }
            set { Store(x => x.PostalCode, value); }
        }
    
    }

    public class AbacusUserPartRecord : ContentPartRecord {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual string PhoneMobile { get; set; }
        public virtual string PhoneHome { get; set; }
        public virtual string PhoneWork { get; set; }
        public virtual string AddressLine1 { get; set; }
        public virtual string AddressLine2 { get; set; }
        public virtual string AddressLine3 { get; set; }
        public virtual string AddressLine4 { get; set; }
        public virtual string AddressLine5 { get; set; }
        public virtual string PostalCode { get; set; }
    }
}