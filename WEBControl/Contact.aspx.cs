using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBControl
{
    public partial class Contact : Page
    {


        WebUserControl1 webUser = new WebUserControl1();

        

        //public List<Event> events = new List<Event>();

        protected void Page_Load(object sender, EventArgs e)
        {
            var students = webUser.studentList;

            GridView1.DataSource = students;
            GridView1.DataBind();
     
        }


        //public class Event
        //{
        //    public int ID { get; set; }
        //    public string Name { get; set; }
        //    public int ParentId { get; set; }
        //}
    }

}