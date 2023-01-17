using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Event
{
    public partial class About : Page
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string str = "Server=localhost;Port=5432;Database=EventWebForm;UserId=postgres;Password=root";
                conn = new NpgsqlConnection(str);
                conn.Open();
                string sql = "SELECT * FROM Event";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                EventsGridView.DataSource = dataTable;
                EventsGridView.DataBind();
            }
        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            // Get the ID of the event to edit
            Button button = (Button)sender;
            int id = int.Parse(button.CommandArgument);

            // Store the ID in a session variable
            Session["eventId"] = id;

            // Redirect to the EditEvent page
            Response.Redirect("EditEvent.aspx");
        }

        private void BindGridView()
        {
            string str = "Server=localhost;Port=5432;Database=EventWebForm;UserId=postgres;Password=root";
            conn = new NpgsqlConnection(str);
            conn.Open();
            string sql = "SELECT * FROM Event";
            cmd = new NpgsqlCommand(sql, conn);

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            EventsGridView.DataSource = dataTable;
            EventsGridView.DataBind();

        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            // Get the ID of the event to delete
            Button button = (Button)sender;
            int eid = int.Parse(button.CommandArgument);
            string str = "Server=localhost;Port=5432;Database=EventWebForm;UserId=postgres;Password=root";
            conn = new NpgsqlConnection(str);
            conn.Open();
            // Delete the event from the database       
            string sql = "DELETE FROM Event WHERE eid = @eid";
            cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@eid", eid);
            cmd.ExecuteNonQuery();
            BindGridView();
        }
    }

    // Refresh the GridView

}



