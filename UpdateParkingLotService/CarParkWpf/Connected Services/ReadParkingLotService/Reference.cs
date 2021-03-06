﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarParkWpf.ReadParkingLotService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DTOParkingSpace", Namespace="http://schemas.datacontract.org/2004/07/", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class DTOParkingSpace : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CarRegNrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] CoordinatesField;
        
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
        public string CarRegNr {
            get {
                return this.CarRegNrField;
            }
            set {
                if ((object.ReferenceEquals(this.CarRegNrField, value) != true)) {
                    this.CarRegNrField = value;
                    this.RaisePropertyChanged("CarRegNr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] Coordinates {
            get {
                return this.CoordinatesField;
            }
            set {
                if ((object.ReferenceEquals(this.CoordinatesField, value) != true)) {
                    this.CoordinatesField = value;
                    this.RaisePropertyChanged("Coordinates");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReadParkingLotService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReadAllParkingSpacesInParkingLot", ReplyAction="http://tempuri.org/IService/ReadAllParkingSpacesInParkingLotResponse")]
        CarParkWpf.ReadParkingLotService.DTOParkingSpace[] ReadAllParkingSpacesInParkingLot(int parkingLotId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReadAllParkingSpacesInParkingLot", ReplyAction="http://tempuri.org/IService/ReadAllParkingSpacesInParkingLotResponse")]
        System.Threading.Tasks.Task<CarParkWpf.ReadParkingLotService.DTOParkingSpace[]> ReadAllParkingSpacesInParkingLotAsync(int parkingLotId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReadParkingSpaceInParkingLotByRegNr", ReplyAction="http://tempuri.org/IService/ReadParkingSpaceInParkingLotByRegNrResponse")]
        CarParkWpf.ReadParkingLotService.DTOParkingSpace ReadParkingSpaceInParkingLotByRegNr(string carRgNr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReadParkingSpaceInParkingLotByRegNr", ReplyAction="http://tempuri.org/IService/ReadParkingSpaceInParkingLotByRegNrResponse")]
        System.Threading.Tasks.Task<CarParkWpf.ReadParkingLotService.DTOParkingSpace> ReadParkingSpaceInParkingLotByRegNrAsync(string carRgNr);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : CarParkWpf.ReadParkingLotService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<CarParkWpf.ReadParkingLotService.IService>, CarParkWpf.ReadParkingLotService.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CarParkWpf.ReadParkingLotService.DTOParkingSpace[] ReadAllParkingSpacesInParkingLot(int parkingLotId) {
            return base.Channel.ReadAllParkingSpacesInParkingLot(parkingLotId);
        }
        
        public System.Threading.Tasks.Task<CarParkWpf.ReadParkingLotService.DTOParkingSpace[]> ReadAllParkingSpacesInParkingLotAsync(int parkingLotId) {
            return base.Channel.ReadAllParkingSpacesInParkingLotAsync(parkingLotId);
        }
        
        public CarParkWpf.ReadParkingLotService.DTOParkingSpace ReadParkingSpaceInParkingLotByRegNr(string carRgNr) {
            return base.Channel.ReadParkingSpaceInParkingLotByRegNr(carRgNr);
        }
        
        public System.Threading.Tasks.Task<CarParkWpf.ReadParkingLotService.DTOParkingSpace> ReadParkingSpaceInParkingLotByRegNrAsync(string carRgNr) {
            return base.Channel.ReadParkingSpaceInParkingLotByRegNrAsync(carRgNr);
        }
    }
}
