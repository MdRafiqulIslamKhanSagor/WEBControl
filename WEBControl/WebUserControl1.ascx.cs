using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBControl
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
      

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Student> students = studentList.ToList();
        }

 



        public List<Student> studentList = new List<Student>() {

            new Student(){ StudentId=1, StudentName="Bill",Age=18},
            new Student(){ StudentId=2, StudentName="Steve",Age=20},
            new Student(){ StudentId=3, StudentName="Ram",Age=18},
            new Student(){ StudentId=4, StudentName="Moin",Age=15},
            new Student(){ StudentId=5, StudentName="Moin",Age=22},
            new Student(){ StudentId=6, StudentName="Moin",Age=18}
            

            
        };
    }
}