using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService, ITest
{
	List<DTOParkingSpace> IService.ReadAllParkingSpacesInParkingLot(int parkingLotId)
    {
		return ReadAllParkingSpacesInParkingLot(parkingLotId, new DataClassesDataContext());
    }

	private List<DTOParkingSpace> ReadAllParkingSpacesInParkingLot(int parkingLotId, DataClassesDataContext dc)
	{
		List<DTOParkingSpace> list = new List<DTOParkingSpace>();

		var parkingSpaces = dc.ParkingSpaces.Where(x => x.fk_parkingLotId == parkingLotId).ToList();

		foreach (var parkingSpace in parkingSpaces)
		{
			var space = new DTOParkingSpace(parkingSpace.id, parkingSpace.x, parkingSpace.y, parkingSpace.carRegNr);
			if (string.IsNullOrEmpty(parkingSpace.carRegNr))
				space.AddCar(parkingSpace.carRegNr);
			list.Add(space);
		}

		return list;
	}

    DTOParkingSpace IService.ReadParkingSpaceInParkingLotByRegNr(string carRgNr)
    {
        throw new NotImplementedException();
    }

	public List<DTOParkingSpace> TestReadAllParkingSpacesInParkingLot(int parkingLotId, DataClassesDataContext dc)
	{
		return ReadAllParkingSpacesInParkingLot(parkingLotId, dc);
	}

	public DTOParkingSpace TestReadParkingSpaceInParkingLotByRegNr(string carRgNr, DataClassesDataContext dc)
	{
		throw new NotImplementedException();
	}
}
