using System;
using System.Collections.Generic;
using System.Linq;
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

        var parkingSpaces =
            (from a in dc.GetTable<ParkingSpace>()
            where a.fk_parkingLotId == parkingLotId
            select a).ToList();

        foreach (var parkingSpace in parkingSpaces)
        {
            list.Add(new DTOParkingSpace(parkingSpace.x, parkingSpace.y));
        }

        //var cars =
        //    from a in dc.GetTable<Car>()
        //    where parkingSpaces.Find(x => x.fk_parkingLotId == parkingLotId)
        //    select a;

        return null;
    }

    DTOParkingSpace IService.ReadParkingSpaceInParkingLotByRegNr(string carRgNr)
    {
        throw new NotImplementedException();
    }
}
