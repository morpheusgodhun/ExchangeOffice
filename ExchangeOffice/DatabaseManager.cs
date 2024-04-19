using System.Data.SqlClient;

namespace ExchangeOffice {
    public class DatabaseManager {
        private string connectionString;

        public DatabaseManager(string connectionString) {
            this.connectionString = connectionString;
        }

        public void SaveCurrencyRates(decimal dollarBuy, decimal dollarSell, decimal euroBuy, decimal euroSell) {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                string query = @"INSERT INTO CurrencyRates (DollarBuying, DollarSelling, EuroBuying, EuroSelling, RateDate)
                                 VALUES (@dollarBuy, @dollarSell, @euroBuy, @euroSell, GETDATE())";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@dollarBuy", dollarBuy);
                cmd.Parameters.AddWithValue("@dollarSell", dollarSell);
                cmd.Parameters.AddWithValue("@euroBuy", euroBuy);
                cmd.Parameters.AddWithValue("@euroSell", euroSell);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}