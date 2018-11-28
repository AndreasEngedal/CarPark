using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ParkingSpace
/// </summary>
public class DTOParkingSpace
{
    public string CarRegNr { get; set; }
    public int[] Coordinates { get; set; }

    public bool IsOccupied
    {
        get { return !string.IsNullOrEmpty(CarRegNr); }
    }

    public DTOParkingSpace(int x, int y)
    {
        Coordinates = new int[2];
        Coordinates[0] = x;
        Coordinates[1] = y;
    }

    public void AddCar(string carRegNr)
    {
        this.CarRegNr = carRegNr;
    }
}