﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34209.
// 
#pragma warning disable 1591

namespace termProject.cardProcessing {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="verifyCardSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(object[]))]
    public partial class verifyCard : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddCustomerOperationCompleted;
        
        private System.Threading.SendOrPostCallback addNewCardOperationCompleted;
        
        private System.Threading.SendOrPostCallback makeTransactionOperationCompleted;
        
        private System.Threading.SendOrPostCallback findCreditCardOperationCompleted;
        
        private System.Threading.SendOrPostCallback testOperationCompleted;
        
        private System.Threading.SendOrPostCallback showCardsOperationCompleted;
        
        private System.Threading.SendOrPostCallback removeCardOperationCompleted;
        
        private System.Threading.SendOrPostCallback cardExistsOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateCardInfoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public verifyCard() {
            this.Url = global::termProject.Properties.Settings.Default.termProject_cardProcessing_verifyCard;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event AddCustomerCompletedEventHandler AddCustomerCompleted;
        
        /// <remarks/>
        public event addNewCardCompletedEventHandler addNewCardCompleted;
        
        /// <remarks/>
        public event makeTransactionCompletedEventHandler makeTransactionCompleted;
        
        /// <remarks/>
        public event findCreditCardCompletedEventHandler findCreditCardCompleted;
        
        /// <remarks/>
        public event testCompletedEventHandler testCompleted;
        
        /// <remarks/>
        public event showCardsCompletedEventHandler showCardsCompleted;
        
        /// <remarks/>
        public event removeCardCompletedEventHandler removeCardCompleted;
        
        /// <remarks/>
        public event cardExistsCompletedEventHandler cardExistsCompleted;
        
        /// <remarks/>
        public event updateCardInfoCompletedEventHandler updateCardInfoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddCustomer", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddCustomer(object[] cust) {
            this.Invoke("AddCustomer", new object[] {
                        cust});
        }
        
        /// <remarks/>
        public void AddCustomerAsync(object[] cust) {
            this.AddCustomerAsync(cust, null);
        }
        
        /// <remarks/>
        public void AddCustomerAsync(object[] cust, object userState) {
            if ((this.AddCustomerOperationCompleted == null)) {
                this.AddCustomerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddCustomerOperationCompleted);
            }
            this.InvokeAsync("AddCustomer", new object[] {
                        cust}, this.AddCustomerOperationCompleted, userState);
        }
        
        private void OnAddCustomerOperationCompleted(object arg) {
            if ((this.AddCustomerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddCustomerCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/addNewCard", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void addNewCard(object[] card) {
            this.Invoke("addNewCard", new object[] {
                        card});
        }
        
        /// <remarks/>
        public void addNewCardAsync(object[] card) {
            this.addNewCardAsync(card, null);
        }
        
        /// <remarks/>
        public void addNewCardAsync(object[] card, object userState) {
            if ((this.addNewCardOperationCompleted == null)) {
                this.addNewCardOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddNewCardOperationCompleted);
            }
            this.InvokeAsync("addNewCard", new object[] {
                        card}, this.addNewCardOperationCompleted, userState);
        }
        
        private void OnaddNewCardOperationCompleted(object arg) {
            if ((this.addNewCardCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addNewCardCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/makeTransaction", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void makeTransaction(object[] trans) {
            this.Invoke("makeTransaction", new object[] {
                        trans});
        }
        
        /// <remarks/>
        public void makeTransactionAsync(object[] trans) {
            this.makeTransactionAsync(trans, null);
        }
        
        /// <remarks/>
        public void makeTransactionAsync(object[] trans, object userState) {
            if ((this.makeTransactionOperationCompleted == null)) {
                this.makeTransactionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmakeTransactionOperationCompleted);
            }
            this.InvokeAsync("makeTransaction", new object[] {
                        trans}, this.makeTransactionOperationCompleted, userState);
        }
        
        private void OnmakeTransactionOperationCompleted(object arg) {
            if ((this.makeTransactionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.makeTransactionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/findCreditCard", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet findCreditCard(long cardNum) {
            object[] results = this.Invoke("findCreditCard", new object[] {
                        cardNum});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void findCreditCardAsync(long cardNum) {
            this.findCreditCardAsync(cardNum, null);
        }
        
        /// <remarks/>
        public void findCreditCardAsync(long cardNum, object userState) {
            if ((this.findCreditCardOperationCompleted == null)) {
                this.findCreditCardOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfindCreditCardOperationCompleted);
            }
            this.InvokeAsync("findCreditCard", new object[] {
                        cardNum}, this.findCreditCardOperationCompleted, userState);
        }
        
        private void OnfindCreditCardOperationCompleted(object arg) {
            if ((this.findCreditCardCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.findCreditCardCompleted(this, new findCreditCardCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/test", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int test() {
            object[] results = this.Invoke("test", new object[0]);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void testAsync() {
            this.testAsync(null);
        }
        
        /// <remarks/>
        public void testAsync(object userState) {
            if ((this.testOperationCompleted == null)) {
                this.testOperationCompleted = new System.Threading.SendOrPostCallback(this.OntestOperationCompleted);
            }
            this.InvokeAsync("test", new object[0], this.testOperationCompleted, userState);
        }
        
        private void OntestOperationCompleted(object arg) {
            if ((this.testCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.testCompleted(this, new testCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/showCards", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet showCards(int loginID) {
            object[] results = this.Invoke("showCards", new object[] {
                        loginID});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void showCardsAsync(int loginID) {
            this.showCardsAsync(loginID, null);
        }
        
        /// <remarks/>
        public void showCardsAsync(int loginID, object userState) {
            if ((this.showCardsOperationCompleted == null)) {
                this.showCardsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnshowCardsOperationCompleted);
            }
            this.InvokeAsync("showCards", new object[] {
                        loginID}, this.showCardsOperationCompleted, userState);
        }
        
        private void OnshowCardsOperationCompleted(object arg) {
            if ((this.showCardsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.showCardsCompleted(this, new showCardsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/removeCard", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void removeCard(long cardNum) {
            this.Invoke("removeCard", new object[] {
                        cardNum});
        }
        
        /// <remarks/>
        public void removeCardAsync(long cardNum) {
            this.removeCardAsync(cardNum, null);
        }
        
        /// <remarks/>
        public void removeCardAsync(long cardNum, object userState) {
            if ((this.removeCardOperationCompleted == null)) {
                this.removeCardOperationCompleted = new System.Threading.SendOrPostCallback(this.OnremoveCardOperationCompleted);
            }
            this.InvokeAsync("removeCard", new object[] {
                        cardNum}, this.removeCardOperationCompleted, userState);
        }
        
        private void OnremoveCardOperationCompleted(object arg) {
            if ((this.removeCardCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.removeCardCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/cardExists", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet cardExists(long cardNum) {
            object[] results = this.Invoke("cardExists", new object[] {
                        cardNum});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void cardExistsAsync(long cardNum) {
            this.cardExistsAsync(cardNum, null);
        }
        
        /// <remarks/>
        public void cardExistsAsync(long cardNum, object userState) {
            if ((this.cardExistsOperationCompleted == null)) {
                this.cardExistsOperationCompleted = new System.Threading.SendOrPostCallback(this.OncardExistsOperationCompleted);
            }
            this.InvokeAsync("cardExists", new object[] {
                        cardNum}, this.cardExistsOperationCompleted, userState);
        }
        
        private void OncardExistsOperationCompleted(object arg) {
            if ((this.cardExistsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.cardExistsCompleted(this, new cardExistsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/updateCardInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void updateCardInfo(object[] update) {
            this.Invoke("updateCardInfo", new object[] {
                        update});
        }
        
        /// <remarks/>
        public void updateCardInfoAsync(object[] update) {
            this.updateCardInfoAsync(update, null);
        }
        
        /// <remarks/>
        public void updateCardInfoAsync(object[] update, object userState) {
            if ((this.updateCardInfoOperationCompleted == null)) {
                this.updateCardInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateCardInfoOperationCompleted);
            }
            this.InvokeAsync("updateCardInfo", new object[] {
                        update}, this.updateCardInfoOperationCompleted, userState);
        }
        
        private void OnupdateCardInfoOperationCompleted(object arg) {
            if ((this.updateCardInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateCardInfoCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void AddCustomerCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void addNewCardCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void makeTransactionCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void findCreditCardCompletedEventHandler(object sender, findCreditCardCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class findCreditCardCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal findCreditCardCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void testCompletedEventHandler(object sender, testCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class testCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal testCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void showCardsCompletedEventHandler(object sender, showCardsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class showCardsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal showCardsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void removeCardCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void cardExistsCompletedEventHandler(object sender, cardExistsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class cardExistsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal cardExistsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void updateCardInfoCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591