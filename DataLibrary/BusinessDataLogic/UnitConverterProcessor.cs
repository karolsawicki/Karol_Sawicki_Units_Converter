using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAccess;
using DataLibrary.Models;

namespace DataLibrary.BusinessDataLogic
{
    public static class UnitConverterProcessor
    {
        public static int UnitConvert(DateTime ConvertTime, string whatUnit, double convertFrom, double convertTo, double result)
        {
            UnitConverterModel data = new UnitConverterModel
            {
                whatUnit = whatUnit,
                convertFrom = convertFrom,
                convertTo = convertTo,
                result = result,
                ConvertTime = DateTime.Now
        };
            string sql = @"insert into dbo.Converts (ConvertTime, whatUnit, convertFrom, convertTo, result) values (@ConvertTime, @whatUnit, @convertFrom, @convertTo, @result);";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<UnitConverterModel> LoadUnitConverterData()
        {
            string sql = @"select Id, ConvertTime, whatUnit, convertFrom, convertTo, result from dbo.Converts;";

            return SqlDataAccess.LoadData<UnitConverterModel>(sql);
        }
    }
}
