using ItUniver.Calc.DB.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItUniver.Calc.DB.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
         where T : IEntity
    {
        // TODO: вынести в конфиг
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\1\Desktop\calculator\calculator\ConsoleCalc\ItUniver.Calc.DB\App_Data\Database.mdf;Integrated Security=True";

        protected string tableName { get; set; }

        public BaseRepository()
        {
            this.tableName = typeof(T).Name;
        }

        public BaseRepository(string tableName)
        {
            this.tableName = tableName;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public T Find(long id)
        {
            var result = ReadData().Where(i => i.Id == id);

            return result.First();
        }

        public void Save(T item)
        {
            // get props of T
            var props = typeof(T).GetProperties()
                .Where(p => p.Name != "Id")
                .OrderBy(p => p.Name);

            // create columns from props and empty values list
            var columns = props.Select(p => p.Name);

            var values = new List<string>();

            // fill values
            foreach (var prop in props)
            {
                var value = prop.GetValue(item);
                var str = $"{value}";

                if (value == null)
                {
                    str = "NULL";
                }
                else if (value is string)
                {
                    str = $"N'{value}'";
                }
                else if (value is DateTime)
                {
                    var date = (DateTime)value;
                    str = $"N'{date.ToString(CultureInfo.InvariantCulture)}'";
                }
                else if (value is double)
                {
                    var doubleValue = (double)value;
                    str = $"{doubleValue.ToString(CultureInfo.InvariantCulture)}";
                }
                // todo boolean

                values.Add(str);
            }

            // bake strings
            var strColumns = "[" + string.Join("], [", columns) + "]";
            var strValues = string.Join(", ", values);

            // sql
            var insertQuery =
                $"INSERT INTO [{tableName}] ({strColumns}) VALUES ({strValues})";


            string queryString = item.Id > 0
                ? "UPDATE * FROM [dbo].[History]"
                : insertQuery;

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();

                var count = command.ExecuteNonQuery();
            }
        }

        public IEnumerable<T> GetAll(string condition)
        {
            return ReadData(condition);
        }

        public IEnumerable<T> GetAll()
        {
            return ReadData();
        }

        #region Работа с БД

        protected IEnumerable<T> ReadData()
        {
            return ReadData(null);
        }

        protected IEnumerable<T> ReadData(string where)
        {
            // TODO: SQL injections

            var items = new List<T>();

            var queryString = $"SELECT * FROM [dbo].[{tableName}]" + (where == null ? "" : $" WHERE {where}") ;

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    items.Add(ReadSingleRow(reader));
                }

                reader.Close();
            }

            return items;
        }

        private T ReadSingleRow(IDataRecord record)
        {
            var obj = Activator.CreateInstance<T>();

            //record.

            var tclass = typeof(T);
            var props = tclass.GetProperties();

            // TODO: при запросе не с * - ошибка :(
            foreach (var prop in props)
            {
                var ind = record.GetOrdinal(prop.Name);
                var isnull = record.IsDBNull(ind);
                if (!isnull)
                {
                    var value = record[prop.Name];
                    prop.SetValue(obj, value);
                }
            }

            return obj;
        }

        #endregion
    }
}
