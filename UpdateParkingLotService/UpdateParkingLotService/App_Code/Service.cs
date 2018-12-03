using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IPublic, ITest
{
    public void AddCarToParkingLot(string carRegNr, int parkingSpaceId)
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings[1].ToString();
		AddCarToParkingLot(carRegNr, parkingSpaceId, connectionString);
    }

	private void AddCarToParkingLot(string carRegNr, int parkingSpaceId, string connString)
	{
		using (var conn = new SqlConnection(connString))
		using (var command = new SqlCommand("AddCarToParkingSpace", conn)
		{
			CommandType = CommandType.StoredProcedure
		})
		{
			conn.Open();
			command.Parameters.Add(new SqlParameter("@RegNr", carRegNr));
			command.Parameters.Add(new SqlParameter("@ParkingSpaceId", parkingSpaceId));
			command.ExecuteNonQuery();
		}
	}

	public void RemoveCarFromParkingLot(int parkingSpaceId)
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings[1].ToString();
		RemoveCarFromParkingLot(parkingSpaceId, connectionString);
    }

	private void RemoveCarFromParkingLot(int parkingSpaceId, string connString)
	{
		using (var conn = new SqlConnection(connString))
		using (var command = new SqlCommand("RemoveCarFromParkingSpace", conn)
		{
			CommandType = CommandType.StoredProcedure
		})
		{
			conn.Open();
			command.Parameters.Add(new SqlParameter("@ParkingSpaceId", parkingSpaceId));
			command.ExecuteNonQuery();
		}
	}

	public void TestAddCarToParkingLot(string carRegNr, int parkingSpaceId, string connString)
	{
		AddCarToParkingLot(carRegNr, parkingSpaceId, connString);
	}

	public void TestRemoveCarFromParkingLot(int parkingSpaceId, string connString)
	{
		RemoveCarFromParkingLot(parkingSpaceId, connString);
	}
}
