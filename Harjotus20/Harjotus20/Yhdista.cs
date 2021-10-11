using MySql.Data.MySqlClient;
using System.Data;

namespace Harjotus20
{
    class Yhdista
    {
        public string yhteyslause()
        {
            return "datasource = localhost; port=3306; username =root; password=; database = opiskelijat";

        }

        private MySqlConnection yhteys = new MySqlConnection("datasource = localhost; port = 3306; username = root; password=; database = opiskelijat; SSL Mode = None");

        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }

        public void avaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

        public void suljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
