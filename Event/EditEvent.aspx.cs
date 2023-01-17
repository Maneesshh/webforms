using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Event
{
    public partial class EditEvent : System.Web.UI.Page
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Get the ID of the event to edit from the session variable
                int eid = (int)Session["eventId"];

                // Fetch the event data from the database
                string str = "Server=localhost;Port=5432;Database=EventWebForm;UserId=postgres;Password=root";
                conn = new NpgsqlConnection(str);
                conn.Open();
                string sql = "SELECT * FROM Event WHERE eid = @eid";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@eid", eid);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Populate the form controls with the event data
                    EventName.Text = reader["eventname"].ToString();
                    EventDate.Text = reader["eventdate"].ToString();
                }
            }
        }
        protected void Save_Click(object sender, EventArgs e)
        {
            // Get the ID of the event to edit from the session variable
            int eid = (int)Session["eventId"];

            // Update the event in the database
            string str = "Server=localhost;Port=5432;Database=EventWebForm;UserId=postgres;Password=root";
            conn = new NpgsqlConnection(str);
            conn.Open();
            string sql = "UPDATE Event SET eventname = @eventname, eventdate = @eventdate WHERE eid = @eid";
            cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@eventname", EventName.Text);
            cmd.Parameters.AddWithValue("@eventdate", EventDate.Text);
            cmd.Parameters.AddWithValue("@eid", eid);
            cmd.ExecuteNonQuery();
            ConfirmationLabel.Text = "Event updated successfully!";
        }

        // Show a confirmation message
    }
}