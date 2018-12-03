using Xunit;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System;
using Xunit.Abstractions;


namespace TestAccesToWCF
{
	public class UpdateParkingLotServiceTest
	{
		private readonly ITestOutputHelper output;

		public UpdateParkingLotServiceTest(ITestOutputHelper output)
		{
			this.output = output;
		}

		[Fact]
		public void TestAddToDatabase()
		{
			var updateService = new TestUpdateParkingLotService.TestClient();

			string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;
			updateService.TestAddCarToParkingLot("Zk995", 3, connectionString);


			output.WriteLine("conc string : " + connectionString);
		}
	}
}
