using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

	//@PlaceNumber int,
	//@PlaceName nvarchar(50),
	//@PrizeAmount money,
 //   @PrizePercentage float,
 //   @Id int = 0 output


namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// Saves the prize to a database.
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize informations, including the unique identifier.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@Id");

                return model;
            }
        }
    }
}
