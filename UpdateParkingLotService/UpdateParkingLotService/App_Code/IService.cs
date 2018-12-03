using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IPublic
{
	[OperationContract]
	void AddCarToParkingLot(string carRegNr, int parkingSpaceId);

    [OperationContract]
    void RemoveCarFromParkingLot(int parkingSpaceId);
}

[ServiceContract]
public interface ITest
{
	[OperationContract]
	void TestAddCarToParkingLot(string carRegNr, int parkingSpaceId, string connString);

	[OperationContract]
	void TestRemoveCarFromParkingLot(int parkingSpaceId, string connString);
}

