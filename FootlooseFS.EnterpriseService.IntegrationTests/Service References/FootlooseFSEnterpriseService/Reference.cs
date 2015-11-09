﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonSearchColumn", Namespace="http://schemas.datacontract.org/2004/07/FootlooseFS.Service")]
    public enum PersonSearchColumn : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PersonID = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FirstName = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LastName = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        EmailAddress = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Phone = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        StreetAddress = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        City = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Zip = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        State = 9,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SortDirection", Namespace="http://schemas.datacontract.org/2004/07/FootlooseFS.Service")]
    public enum SortDirection : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Ascending = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Descending = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PageOfPersonDocuments", Namespace="http://schemas.datacontract.org/2004/07/FootlooseFS.EnterpriseService")]
    [System.SerializableAttribute()]
    public partial class PageOfPersonDocuments : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.PersonDocument[] DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PageIndexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PageSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalItemCountField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.PersonDocument[] Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageIndex {
            get {
                return this.PageIndexField;
            }
            set {
                if ((this.PageIndexField.Equals(value) != true)) {
                    this.PageIndexField = value;
                    this.RaisePropertyChanged("PageIndex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageSize {
            get {
                return this.PageSizeField;
            }
            set {
                if ((this.PageSizeField.Equals(value) != true)) {
                    this.PageSizeField = value;
                    this.RaisePropertyChanged("PageSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalItemCount {
            get {
                return this.TotalItemCountField;
            }
            set {
                if ((this.TotalItemCountField.Equals(value) != true)) {
                    this.TotalItemCountField = value;
                    this.RaisePropertyChanged("TotalItemCount");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonDocument", Namespace="http://schemas.datacontract.org/2004/07/FootlooseFS.Models")]
    [System.SerializableAttribute()]
    public partial class PersonDocument : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StreetAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ZipField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailAddress {
            get {
                return this.EmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailAddressField, value) != true)) {
                    this.EmailAddressField = value;
                    this.RaisePropertyChanged("EmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PersonID {
            get {
                return this.PersonIDField;
            }
            set {
                if ((this.PersonIDField.Equals(value) != true)) {
                    this.PersonIDField = value;
                    this.RaisePropertyChanged("PersonID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StreetAddress {
            get {
                return this.StreetAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.StreetAddressField, value) != true)) {
                    this.StreetAddressField = value;
                    this.RaisePropertyChanged("StreetAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Zip {
            get {
                return this.ZipField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipField, value) != true)) {
                    this.ZipField = value;
                    this.RaisePropertyChanged("Zip");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FootlooseFSEnterpriseService.IPersonService")]
    public interface IPersonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/SearchPersons", ReplyAction="http://tempuri.org/IPersonService/SearchPersonsResponse")]
        FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.PageOfPersonDocuments SearchPersons(int pageNumber, FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.PersonSearchColumn personSearchColumn, FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.SortDirection sortDirection, int numRecordsInPage, System.Collections.Generic.Dictionary<FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.PersonSearchColumn, string> criteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/SearchPersons", ReplyAction="http://tempuri.org/IPersonService/SearchPersonsResponse")]
        System.Threading.Tasks.Task<FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.PageOfPersonDocuments> SearchPersonsAsync(int pageNumber, FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.PersonSearchColumn personSearchColumn, FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.SortDirection sortDirection, int numRecordsInPage, System.Collections.Generic.Dictionary<FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.PersonSearchColumn, string> criteria);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonServiceChannel : FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.IPersonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonServiceClient : System.ServiceModel.ClientBase<FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.IPersonService>, FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.IPersonService {
        
        public PersonServiceClient() {
        }
        
        public PersonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.PageOfPersonDocuments SearchPersons(int pageNumber, FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.PersonSearchColumn personSearchColumn, FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.SortDirection sortDirection, int numRecordsInPage, System.Collections.Generic.Dictionary<FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.PersonSearchColumn, string> criteria) {
            return base.Channel.SearchPersons(pageNumber, personSearchColumn, sortDirection, numRecordsInPage, criteria);
        }
        
        public System.Threading.Tasks.Task<FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.PageOfPersonDocuments> SearchPersonsAsync(int pageNumber, FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.PersonSearchColumn personSearchColumn, FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.SortDirection sortDirection, int numRecordsInPage, System.Collections.Generic.Dictionary<FootlooseFS.EnterpriseService.IntegrationTests.FootlooseFSEnterpriseService.PersonSearchColumn, string> criteria) {
            return base.Channel.SearchPersonsAsync(pageNumber, personSearchColumn, sortDirection, numRecordsInPage, criteria);
        }
    }
}
