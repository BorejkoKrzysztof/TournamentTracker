using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

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
            throw new NotImplementedException();
        }
    }
}
