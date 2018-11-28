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
        {
            parkingSpaceIds.Add(item.id);
        }
        var cars = dc.Cars.Where(x => parkingSpaceIds.Contains(x.fk_parkingSpaceId)).ToList();

        foreach (var parkingSpace in parkingSpaces)
        {
            list.Add(new DTOParkingSpace(parkingSpace.x, parkingSpace.y));
        }



        //var parkingSpaces =
        //    (from a in dc.GetTable<ParkingSpace>()
        //        where a.fk_parkingLotId == parkingLotId
        //        select a).ToList();

        //var cars =
        //    from a in dc.GetTable<Car>()
        //    where parkingSpaces.Exists(x => x.id == a.fk_parkingSpaceId)
        //    select a;

        //foreach (var car in cars)
        //{
        //    var space = parkingSpaces.Find(x => x.id == car.fk_parkingSpaceId);
        //    var dtoCar = list.Find(x => x.Coordinates[0] == space.x && x.Coordinates[1] == space.y);
        //    dtoCar.AddCar(car.regNr);
        //}
        return list;
    }

    DTOParkingSpace IService.ReadParkingSpaceInParkingLotByRegNr(string carRgNr)
    {
        throw new NotImplementedException();
    }
}
