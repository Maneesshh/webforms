using Npgsql;
using System;
using System.Web.UI.WebControls;
namespace Event
{
    public partial class AddEvent : System.Web.UI.Page
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    // Clear any previous data in the form controls
            //    EventName.Text = "";
            //    EventDate.Text = DateTime.Today;
            //}
            string str = "Server=localhost;Port=5432;Database=EventWebForm;UserId=postgres;Password=root";
            conn = new NpgsqlConnection(str);
            conn.Open();
            string sql = "CREATE TABLE IF NOT EXISTS Event(eid SERIAL PRIMARY KEY ,eventname varchar(50),eventdate varchar(50))";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        protected void AddEvent_Click(object sender, EventArgs e)
        {
            string eventName = EventName.Text;
            string eventDate = EventDate.Text;

            // Insert the new event into the database
            string sql = "INSERT INTO Event (eventname, eventdate) VALUES (@EventName, @EventDate)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EventName", eventName);
            cmd.Parameters.AddWithValue("@EventDate", eventDate);
            cmd.ExecuteNonQuery();
            // Show a confirmation message
            ConfirmationLabel.Text = "Event added successfully!";
        }
    }
}