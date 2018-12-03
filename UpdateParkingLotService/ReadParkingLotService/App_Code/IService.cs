using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
    [OperationContract]
    List<DTOParkingSpace> ReadAllParkingSpacesInParkingLot(int parkingLotId);

    [OperationContract]
    DTOParkingSpace ReadParkingSpaceInParkingLotByRegNr(string carRgNr);
}

[ServiceContract]
public interface ITest
{ 
	[OperationContract]
List<DTOParkingSpace> TestReadAllParkingSpacesInParkingLot(int parkingLotId, DataClassesDataContext dc);

[OperationContract]
DTOParkingSpace TestReadParkingSpaceInParkingLotByRegNr(string carRgNr, DataClassesDataContext dc);
}

