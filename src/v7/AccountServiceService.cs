﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=1.1.4322.573.
// 
namespace com.google.api.adwords.v7 {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AccountServiceSoapBinding", Namespace="https://adwords.google.com/api/adwords/v7")]
    public class AccountServiceService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        public email emailValue;
        
        public clientEmail clientEmailValue;
        
        public clientCustomerId clientCustomerIdValue;
        
        public password passwordValue;
        
        public useragent useragentValue;
        
        public token tokenValue;
        
        public applicationToken applicationTokenValue;
        
        public developerToken developerTokenValue;
        
        public responseTime responseTimeValue;
        
        public operations operationsValue;
        
        public units unitsValue;
        
        public requestId requestIdValue;
        
        /// <remarks/>
        public AccountServiceService() {
            this.Url = "https://adwords.google.com/api/adwords/v7/AccountService";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v7", ResponseNamespace="https://adwords.google.com/api/adwords/v7", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void createAdWordsAccount(string loginEmail, string password, string languagePreference, EmailPromotionsPreferences emailPrefs, string currencyCode, CreditCard cardInfo, Address contactInfo, CoverageType defaultAdsCoverage, string timeZoneId) {
            this.Invoke("createAdWordsAccount", new object[] {
                        loginEmail,
                        password,
                        languagePreference,
                        emailPrefs,
                        currencyCode,
                        cardInfo,
                        contactInfo,
                        defaultAdsCoverage,
                        timeZoneId});
        }
        
        /// <remarks/>
        public System.IAsyncResult BegincreateAdWordsAccount(string loginEmail, string password, string languagePreference, EmailPromotionsPreferences emailPrefs, string currencyCode, CreditCard cardInfo, Address contactInfo, CoverageType defaultAdsCoverage, string timeZoneId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("createAdWordsAccount", new object[] {
                        loginEmail,
                        password,
                        languagePreference,
                        emailPrefs,
                        currencyCode,
                        cardInfo,
                        contactInfo,
                        defaultAdsCoverage,
                        timeZoneId}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndcreateAdWordsAccount(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v7", ResponseNamespace="https://adwords.google.com/api/adwords/v7", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void setLoginInfo(string login, string newPassword) {
            this.Invoke("setLoginInfo", new object[] {
                        login,
                        newPassword});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginsetLoginInfo(string login, string newPassword, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("setLoginInfo", new object[] {
                        login,
                        newPassword}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndsetLoginInfo(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v7", ResponseNamespace="https://adwords.google.com/api/adwords/v7", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getCreditCardReturn")]
        public CreditCard getCreditCard() {
            object[] results = this.Invoke("getCreditCard", new object[0]);
            return ((CreditCard)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetCreditCard(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getCreditCard", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public CreditCard EndgetCreditCard(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((CreditCard)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v7", ResponseNamespace="https://adwords.google.com/api/adwords/v7", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getClientAccountsReturn")]
        public string[] getClientAccounts() {
            object[] results = this.Invoke("getClientAccounts", new object[0]);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetClientAccounts(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getClientAccounts", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string[] EndgetClientAccounts(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v7", ResponseNamespace="https://adwords.google.com/api/adwords/v7", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getAccountInfoReturn")]
        public AccountInfo getAccountInfo() {
            object[] results = this.Invoke("getAccountInfo", new object[0]);
            return ((AccountInfo)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetAccountInfo(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getAccountInfo", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public AccountInfo EndgetAccountInfo(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((AccountInfo)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("tokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v7", ResponseNamespace="https://adwords.google.com/api/adwords/v7", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void updateAccountInfo(AccountInfo accountInfo) {
            this.Invoke("updateAccountInfo", new object[] {
                        accountInfo});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginupdateAccountInfo(AccountInfo accountInfo, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("updateAccountInfo", new object[] {
                        accountInfo}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndupdateAccountInfo(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://adwords.google.com/api/adwords/v7", IsNullable=false)]
    public class token : System.Web.Services.Protocols.SoapHeader {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://adwords.google.com/api/adwords/v7", IsNullable=false)]
    public class password : System.Web.Services.Protocols.SoapHeader {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://adwords.google.com/api/adwords/v7", IsNullable=false)]
    public class operations : System.Web.Services.Protocols.SoapHeader {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://adwords.google.com/api/adwords/v7", IsNullable=false)]
    public class clientCustomerId : System.Web.Services.Protocols.SoapHeader {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://adwords.google.com/api/adwords/v7", IsNullable=false)]
    public class developerToken : System.Web.Services.Protocols.SoapHeader {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://adwords.google.com/api/adwords/v7", IsNullable=false)]
    public class units : System.Web.Services.Protocols.SoapHeader {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://adwords.google.com/api/adwords/v7", IsNullable=false)]
    public class responseTime : System.Web.Services.Protocols.SoapHeader {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://adwords.google.com/api/adwords/v7", IsNullable=false)]
    public class applicationToken : System.Web.Services.Protocols.SoapHeader {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://adwords.google.com/api/adwords/v7", IsNullable=false)]
    public class useragent : System.Web.Services.Protocols.SoapHeader {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://adwords.google.com/api/adwords/v7", IsNullable=false)]
    public class requestId : System.Web.Services.Protocols.SoapHeader {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://adwords.google.com/api/adwords/v7", IsNullable=false)]
    public class email : System.Web.Services.Protocols.SoapHeader {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://adwords.google.com/api/adwords/v7", IsNullable=false)]
    public class clientEmail : System.Web.Services.Protocols.SoapHeader {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    public class EmailPromotionsPreferences {
        
        /// <remarks/>
        public bool marketResearchEnabled;
        
        /// <remarks/>
        public bool newsletterEnabled;
        
        /// <remarks/>
        public bool promotionsEnabled;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    public class AccountInfo {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string currencyCode;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Address billingAddress;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Address primaryAddress;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public EmailPromotionsPreferences emailPromotionsPreferences;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string languagePreference;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string timeZoneId;
        
        /// <remarks/>
        public long timeZoneEffectiveDate;
        
        /// <remarks/>
        public long customerId;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string descriptiveName;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string termsAndConditions;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string primaryBusinessCategory;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CoverageType defaultAdsCoverage;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    public class Address {
        
        /// <remarks/>
        public string addressLine1;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string addressLine2;
        
        /// <remarks/>
        public string city;
        
        /// <remarks/>
        public string companyName;
        
        /// <remarks/>
        public string countryCode;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string faxNumber;
        
        /// <remarks/>
        public string name;
        
        /// <remarks/>
        public string phoneNumber;
        
        /// <remarks/>
        public string postalCode;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string state;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string emailAddress;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    public class CoverageType {
        
        /// <remarks/>
        public bool optInContentNetwork;
        
        /// <remarks/>
        public bool optInSearchNetwork;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    public class CreditCard {
        
        /// <remarks/>
        public string cardNumber;
        
        /// <remarks/>
        public CreditCardType cardType;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string cardVerificationNumber;
        
        /// <remarks/>
        public int expirationMonth;
        
        /// <remarks/>
        public int expirationYear;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string issueNumber;
        
        /// <remarks/>
        public int startMonth;
        
        /// <remarks/>
        public int startYear;
        
        /// <remarks/>
        public TaxStatus status;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string taxNumber;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    public enum CreditCardType {
        
        /// <remarks/>
        VISA,
        
        /// <remarks/>
        MasterCard,
        
        /// <remarks/>
        AmericanExpress,
        
        /// <remarks/>
        JCB,
        
        /// <remarks/>
        Switch,
        
        /// <remarks/>
        SOLO,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v7")]
    public enum TaxStatus {
        
        /// <remarks/>
        SubjectToTax,
        
        /// <remarks/>
        Charity,
        
        /// <remarks/>
        ExtraTerritorial,
        
        /// <remarks/>
        ZeroRated,
        
        /// <remarks/>
        Other,
    }
}
