﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantManagerClient.RestaurantService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RestaurantService.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name username from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        RestaurantManagerClient.RestaurantService.LoginResponse Login(RestaurantManagerClient.RestaurantService.LoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        System.Threading.Tasks.Task<RestaurantManagerClient.RestaurantService.LoginResponse> LoginAsync(RestaurantManagerClient.RestaurantService.LoginRequest request);
        
        // CODEGEN: Generating message contract since element name getReservationsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getReservations", ReplyAction="*")]
        RestaurantManagerClient.RestaurantService.getReservationsResponse getReservations(RestaurantManagerClient.RestaurantService.getReservationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getReservations", ReplyAction="*")]
        System.Threading.Tasks.Task<RestaurantManagerClient.RestaurantService.getReservationsResponse> getReservationsAsync(RestaurantManagerClient.RestaurantService.getReservationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deleteReservation", ReplyAction="*")]
        void deleteReservation(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deleteReservation", ReplyAction="*")]
        System.Threading.Tasks.Task deleteReservationAsync(int id);
        
        // CODEGEN: Generating message contract since element name Firstname from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addReservation", ReplyAction="*")]
        RestaurantManagerClient.RestaurantService.addReservationResponse addReservation(RestaurantManagerClient.RestaurantService.addReservationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addReservation", ReplyAction="*")]
        System.Threading.Tasks.Task<RestaurantManagerClient.RestaurantService.addReservationResponse> addReservationAsync(RestaurantManagerClient.RestaurantService.addReservationRequest request);
        
        // CODEGEN: Generating message contract since element name Firstname from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/editReservation", ReplyAction="*")]
        RestaurantManagerClient.RestaurantService.editReservationResponse editReservation(RestaurantManagerClient.RestaurantService.editReservationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/editReservation", ReplyAction="*")]
        System.Threading.Tasks.Task<RestaurantManagerClient.RestaurantService.editReservationResponse> editReservationAsync(RestaurantManagerClient.RestaurantService.editReservationRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Login", Namespace="http://tempuri.org/", Order=0)]
        public RestaurantManagerClient.RestaurantService.LoginRequestBody Body;
        
        public LoginRequest() {
        }
        
        public LoginRequest(RestaurantManagerClient.RestaurantService.LoginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public LoginRequestBody() {
        }
        
        public LoginRequestBody(string username, string password) {
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoginResponse", Namespace="http://tempuri.org/", Order=0)]
        public RestaurantManagerClient.RestaurantService.LoginResponseBody Body;
        
        public LoginResponse() {
        }
        
        public LoginResponse(RestaurantManagerClient.RestaurantService.LoginResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string LoginResult;
        
        public LoginResponseBody() {
        }
        
        public LoginResponseBody(string LoginResult) {
            this.LoginResult = LoginResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getReservationsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getReservations", Namespace="http://tempuri.org/", Order=0)]
        public RestaurantManagerClient.RestaurantService.getReservationsRequestBody Body;
        
        public getReservationsRequest() {
        }
        
        public getReservationsRequest(RestaurantManagerClient.RestaurantService.getReservationsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getReservationsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public getReservationsRequestBody() {
        }
        
        public getReservationsRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getReservationsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getReservationsResponse", Namespace="http://tempuri.org/", Order=0)]
        public RestaurantManagerClient.RestaurantService.getReservationsResponseBody Body;
        
        public getReservationsResponse() {
        }
        
        public getReservationsResponse(RestaurantManagerClient.RestaurantService.getReservationsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getReservationsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getReservationsResult;
        
        public getReservationsResponseBody() {
        }
        
        public getReservationsResponseBody(string getReservationsResult) {
            this.getReservationsResult = getReservationsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addReservationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="addReservation", Namespace="http://tempuri.org/", Order=0)]
        public RestaurantManagerClient.RestaurantService.addReservationRequestBody Body;
        
        public addReservationRequest() {
        }
        
        public addReservationRequest(RestaurantManagerClient.RestaurantService.addReservationRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class addReservationRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Firstname;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Lastname;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Phonenumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int PartySize;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public System.DateTime Date;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int Hour;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public int Minute;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Description;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public int RestaurantId;
        
        public addReservationRequestBody() {
        }
        
        public addReservationRequestBody(string Firstname, string Lastname, string Phonenumber, int PartySize, System.DateTime Date, int Hour, int Minute, string Description, int RestaurantId) {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Phonenumber = Phonenumber;
            this.PartySize = PartySize;
            this.Date = Date;
            this.Hour = Hour;
            this.Minute = Minute;
            this.Description = Description;
            this.RestaurantId = RestaurantId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addReservationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="addReservationResponse", Namespace="http://tempuri.org/", Order=0)]
        public RestaurantManagerClient.RestaurantService.addReservationResponseBody Body;
        
        public addReservationResponse() {
        }
        
        public addReservationResponse(RestaurantManagerClient.RestaurantService.addReservationResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class addReservationResponseBody {
        
        public addReservationResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class editReservationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="editReservation", Namespace="http://tempuri.org/", Order=0)]
        public RestaurantManagerClient.RestaurantService.editReservationRequestBody Body;
        
        public editReservationRequest() {
        }
        
        public editReservationRequest(RestaurantManagerClient.RestaurantService.editReservationRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class editReservationRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int ReservationId;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int clientId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Firstname;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Lastname;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Phonenumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int PartySize;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public System.DateTime Date;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public int Hour;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public int Minute;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string Description;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=10)]
        public int RestaurantId;
        
        public editReservationRequestBody() {
        }
        
        public editReservationRequestBody(int ReservationId, int clientId, string Firstname, string Lastname, string Phonenumber, int PartySize, System.DateTime Date, int Hour, int Minute, string Description, int RestaurantId) {
            this.ReservationId = ReservationId;
            this.clientId = clientId;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Phonenumber = Phonenumber;
            this.PartySize = PartySize;
            this.Date = Date;
            this.Hour = Hour;
            this.Minute = Minute;
            this.Description = Description;
            this.RestaurantId = RestaurantId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class editReservationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="editReservationResponse", Namespace="http://tempuri.org/", Order=0)]
        public RestaurantManagerClient.RestaurantService.editReservationResponseBody Body;
        
        public editReservationResponse() {
        }
        
        public editReservationResponse(RestaurantManagerClient.RestaurantService.editReservationResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class editReservationResponseBody {
        
        public editReservationResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : RestaurantManagerClient.RestaurantService.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<RestaurantManagerClient.RestaurantService.WebService1Soap>, RestaurantManagerClient.RestaurantService.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RestaurantManagerClient.RestaurantService.LoginResponse RestaurantManagerClient.RestaurantService.WebService1Soap.Login(RestaurantManagerClient.RestaurantService.LoginRequest request) {
            return base.Channel.Login(request);
        }
        
        public string Login(string username, string password) {
            RestaurantManagerClient.RestaurantService.LoginRequest inValue = new RestaurantManagerClient.RestaurantService.LoginRequest();
            inValue.Body = new RestaurantManagerClient.RestaurantService.LoginRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            RestaurantManagerClient.RestaurantService.LoginResponse retVal = ((RestaurantManagerClient.RestaurantService.WebService1Soap)(this)).Login(inValue);
            return retVal.Body.LoginResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RestaurantManagerClient.RestaurantService.LoginResponse> RestaurantManagerClient.RestaurantService.WebService1Soap.LoginAsync(RestaurantManagerClient.RestaurantService.LoginRequest request) {
            return base.Channel.LoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<RestaurantManagerClient.RestaurantService.LoginResponse> LoginAsync(string username, string password) {
            RestaurantManagerClient.RestaurantService.LoginRequest inValue = new RestaurantManagerClient.RestaurantService.LoginRequest();
            inValue.Body = new RestaurantManagerClient.RestaurantService.LoginRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            return ((RestaurantManagerClient.RestaurantService.WebService1Soap)(this)).LoginAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RestaurantManagerClient.RestaurantService.getReservationsResponse RestaurantManagerClient.RestaurantService.WebService1Soap.getReservations(RestaurantManagerClient.RestaurantService.getReservationsRequest request) {
            return base.Channel.getReservations(request);
        }
        
        public string getReservations(int id) {
            RestaurantManagerClient.RestaurantService.getReservationsRequest inValue = new RestaurantManagerClient.RestaurantService.getReservationsRequest();
            inValue.Body = new RestaurantManagerClient.RestaurantService.getReservationsRequestBody();
            inValue.Body.id = id;
            RestaurantManagerClient.RestaurantService.getReservationsResponse retVal = ((RestaurantManagerClient.RestaurantService.WebService1Soap)(this)).getReservations(inValue);
            return retVal.Body.getReservationsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RestaurantManagerClient.RestaurantService.getReservationsResponse> RestaurantManagerClient.RestaurantService.WebService1Soap.getReservationsAsync(RestaurantManagerClient.RestaurantService.getReservationsRequest request) {
            return base.Channel.getReservationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<RestaurantManagerClient.RestaurantService.getReservationsResponse> getReservationsAsync(int id) {
            RestaurantManagerClient.RestaurantService.getReservationsRequest inValue = new RestaurantManagerClient.RestaurantService.getReservationsRequest();
            inValue.Body = new RestaurantManagerClient.RestaurantService.getReservationsRequestBody();
            inValue.Body.id = id;
            return ((RestaurantManagerClient.RestaurantService.WebService1Soap)(this)).getReservationsAsync(inValue);
        }
        
        public void deleteReservation(int id) {
            base.Channel.deleteReservation(id);
        }
        
        public System.Threading.Tasks.Task deleteReservationAsync(int id) {
            return base.Channel.deleteReservationAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RestaurantManagerClient.RestaurantService.addReservationResponse RestaurantManagerClient.RestaurantService.WebService1Soap.addReservation(RestaurantManagerClient.RestaurantService.addReservationRequest request) {
            return base.Channel.addReservation(request);
        }
        
        public void addReservation(string Firstname, string Lastname, string Phonenumber, int PartySize, System.DateTime Date, int Hour, int Minute, string Description, int RestaurantId) {
            RestaurantManagerClient.RestaurantService.addReservationRequest inValue = new RestaurantManagerClient.RestaurantService.addReservationRequest();
            inValue.Body = new RestaurantManagerClient.RestaurantService.addReservationRequestBody();
            inValue.Body.Firstname = Firstname;
            inValue.Body.Lastname = Lastname;
            inValue.Body.Phonenumber = Phonenumber;
            inValue.Body.PartySize = PartySize;
            inValue.Body.Date = Date;
            inValue.Body.Hour = Hour;
            inValue.Body.Minute = Minute;
            inValue.Body.Description = Description;
            inValue.Body.RestaurantId = RestaurantId;
            RestaurantManagerClient.RestaurantService.addReservationResponse retVal = ((RestaurantManagerClient.RestaurantService.WebService1Soap)(this)).addReservation(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RestaurantManagerClient.RestaurantService.addReservationResponse> RestaurantManagerClient.RestaurantService.WebService1Soap.addReservationAsync(RestaurantManagerClient.RestaurantService.addReservationRequest request) {
            return base.Channel.addReservationAsync(request);
        }
        
        public System.Threading.Tasks.Task<RestaurantManagerClient.RestaurantService.addReservationResponse> addReservationAsync(string Firstname, string Lastname, string Phonenumber, int PartySize, System.DateTime Date, int Hour, int Minute, string Description, int RestaurantId) {
            RestaurantManagerClient.RestaurantService.addReservationRequest inValue = new RestaurantManagerClient.RestaurantService.addReservationRequest();
            inValue.Body = new RestaurantManagerClient.RestaurantService.addReservationRequestBody();
            inValue.Body.Firstname = Firstname;
            inValue.Body.Lastname = Lastname;
            inValue.Body.Phonenumber = Phonenumber;
            inValue.Body.PartySize = PartySize;
            inValue.Body.Date = Date;
            inValue.Body.Hour = Hour;
            inValue.Body.Minute = Minute;
            inValue.Body.Description = Description;
            inValue.Body.RestaurantId = RestaurantId;
            return ((RestaurantManagerClient.RestaurantService.WebService1Soap)(this)).addReservationAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RestaurantManagerClient.RestaurantService.editReservationResponse RestaurantManagerClient.RestaurantService.WebService1Soap.editReservation(RestaurantManagerClient.RestaurantService.editReservationRequest request) {
            return base.Channel.editReservation(request);
        }
        
        public void editReservation(int ReservationId, int clientId, string Firstname, string Lastname, string Phonenumber, int PartySize, System.DateTime Date, int Hour, int Minute, string Description, int RestaurantId) {
            RestaurantManagerClient.RestaurantService.editReservationRequest inValue = new RestaurantManagerClient.RestaurantService.editReservationRequest();
            inValue.Body = new RestaurantManagerClient.RestaurantService.editReservationRequestBody();
            inValue.Body.ReservationId = ReservationId;
            inValue.Body.clientId = clientId;
            inValue.Body.Firstname = Firstname;
            inValue.Body.Lastname = Lastname;
            inValue.Body.Phonenumber = Phonenumber;
            inValue.Body.PartySize = PartySize;
            inValue.Body.Date = Date;
            inValue.Body.Hour = Hour;
            inValue.Body.Minute = Minute;
            inValue.Body.Description = Description;
            inValue.Body.RestaurantId = RestaurantId;
            RestaurantManagerClient.RestaurantService.editReservationResponse retVal = ((RestaurantManagerClient.RestaurantService.WebService1Soap)(this)).editReservation(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RestaurantManagerClient.RestaurantService.editReservationResponse> RestaurantManagerClient.RestaurantService.WebService1Soap.editReservationAsync(RestaurantManagerClient.RestaurantService.editReservationRequest request) {
            return base.Channel.editReservationAsync(request);
        }
        
        public System.Threading.Tasks.Task<RestaurantManagerClient.RestaurantService.editReservationResponse> editReservationAsync(int ReservationId, int clientId, string Firstname, string Lastname, string Phonenumber, int PartySize, System.DateTime Date, int Hour, int Minute, string Description, int RestaurantId) {
            RestaurantManagerClient.RestaurantService.editReservationRequest inValue = new RestaurantManagerClient.RestaurantService.editReservationRequest();
            inValue.Body = new RestaurantManagerClient.RestaurantService.editReservationRequestBody();
            inValue.Body.ReservationId = ReservationId;
            inValue.Body.clientId = clientId;
            inValue.Body.Firstname = Firstname;
            inValue.Body.Lastname = Lastname;
            inValue.Body.Phonenumber = Phonenumber;
            inValue.Body.PartySize = PartySize;
            inValue.Body.Date = Date;
            inValue.Body.Hour = Hour;
            inValue.Body.Minute = Minute;
            inValue.Body.Description = Description;
            inValue.Body.RestaurantId = RestaurantId;
            return ((RestaurantManagerClient.RestaurantService.WebService1Soap)(this)).editReservationAsync(inValue);
        }
    }
}
