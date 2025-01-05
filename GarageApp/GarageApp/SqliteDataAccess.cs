using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace GarageApp
{
    internal class SqliteDataAccess
    {
        public static List<Vehicule> LoadVehicules()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Vehicule>("select * from Vehicule", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveVehicule(Vehicule vehicule)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Vehicule (Year ,Registration, Color, Brand, Type) values (@Year ,@Registration, @Color, @Brand, @Type)", vehicule);
            }
        }
        public static void DeleteVehicule(Vehicule vehicule)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM Vehicule WHERE Registration = @Registration", vehicule);
            }
        }
        public static void ModifieVehicule(Vehicule vehicule)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE Vehicule SET Year = @Year, Color = @Color, Brand = @Brand, Type = @Type WHERE Registration = @Registration", vehicule);
            }
        }

        private static string LoadConnectionString(string id = "Default") 
        { 
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
