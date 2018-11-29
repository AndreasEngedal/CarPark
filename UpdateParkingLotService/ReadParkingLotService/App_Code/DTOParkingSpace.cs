using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for ParkingSpace
/// </summary>
[DataContract(IsReference = true)]
public class DTOParkingSpace
{
    [DataMember]
    public string CarRegNr { get; set; }
    [DataMember]
    public int[] Coordinates { get; set; }
    [DataMember]
    public int Id { get; set; }

    public bool IsOccupied
    {
        get { return !string.IsNullOrEmpty(CarRegNr); }
    }

    public DTOParkingSpace(int id, int x, int y, string carRegNr)
    {
        this.Id = id;
        Coordinates = new int[2];
        Coordinates[0] = x;
        Coordinates[1] = y;
		this.CarRegNr = carRegNr;
    }

    public void AddCar(string carRegNr)
    {
        this.CarRegNr = carRegNr;
    }
}