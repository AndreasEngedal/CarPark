using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    List<DTOParkingSpace> IService.ReadAllParkingSpacesInParkingLot(int parkingLotId)
    {
        List<DTOParkingSpace> list = new List<DTOParkingSpace>();
        DataClassesDataContext dc = new DataClassesDataContext();

        var parkingSpaces = dc.ParkingSpaces.Where(x => x.fk_parkingLotId == parkingLotId).ToList();

        var parkingSpaceIds = new List<int>();
        foreach (var item in parkingSpaces)
            parkingSpaceIds.Add(item.id);

        var cars = dc.Cars.Where(x => parkingSpaceIds.Contains(x.fk_parkingSpaceId)).ToList();

        foreach (var parkingSpace in parkingSpaces)
        {
            var space = new DTOParkingSpace(parkingSpace.x, parkingSpace.y);
            var car = cars.Find(x => x.fk_parkingSpaceId == parkingSpace.id);
            if (car != null)
                space.AddCar(car.regNr);
            list.Add(space);
        }

        return list;
    }

    DTOParkingSpace IService.ReadParkingSpaceInParkingLotByRegNr(string carRgNr)
    {
        throw new NotImplementedException();
    }
}
