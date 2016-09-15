﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.libraryService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/Library.DataContract")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long BookIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PublisherField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubjectField;
        
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
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long BookId {
            get {
                return this.BookIdField;
            }
            set {
                if ((this.BookIdField.Equals(value) != true)) {
                    this.BookIdField = value;
                    this.RaisePropertyChanged("BookId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Publisher {
            get {
                return this.PublisherField;
            }
            set {
                if ((object.ReferenceEquals(this.PublisherField, value) != true)) {
                    this.PublisherField = value;
                    this.RaisePropertyChanged("Publisher");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Subject {
            get {
                return this.SubjectField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectField, value) != true)) {
                    this.SubjectField = value;
                    this.RaisePropertyChanged("Subject");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="libraryService.ILibraryManager")]
    public interface ILibraryManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryManager/AddNewBook", ReplyAction="http://tempuri.org/ILibraryManager/AddNewBookResponse")]
        System.Collections.Generic.List<Library.libraryService.Book> AddNewBook(Library.libraryService.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryManager/AddNewBook", ReplyAction="http://tempuri.org/ILibraryManager/AddNewBookResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Library.libraryService.Book>> AddNewBookAsync(Library.libraryService.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryManager/RetriveBooks", ReplyAction="http://tempuri.org/ILibraryManager/RetriveBooksResponse")]
        System.Collections.Generic.List<Library.libraryService.Book> RetriveBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryManager/RetriveBooks", ReplyAction="http://tempuri.org/ILibraryManager/RetriveBooksResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Library.libraryService.Book>> RetriveBooksAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILibraryManagerChannel : Library.libraryService.ILibraryManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LibraryManagerClient : System.ServiceModel.ClientBase<Library.libraryService.ILibraryManager>, Library.libraryService.ILibraryManager {
        
        public LibraryManagerClient() {
        }
        
        public LibraryManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LibraryManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Library.libraryService.Book> AddNewBook(Library.libraryService.Book book) {
            return base.Channel.AddNewBook(book);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Library.libraryService.Book>> AddNewBookAsync(Library.libraryService.Book book) {
            return base.Channel.AddNewBookAsync(book);
        }
        
        public System.Collections.Generic.List<Library.libraryService.Book> RetriveBooks() {
            return base.Channel.RetriveBooks();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Library.libraryService.Book>> RetriveBooksAsync() {
            return base.Channel.RetriveBooksAsync();
        }
    }
}