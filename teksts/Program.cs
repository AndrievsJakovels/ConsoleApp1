using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teksts
{
    class Program
    {
        static void Main(string[] args)
        {

            [HttpPost]
            public ActionResult Edit(User user)
            {
                if (ModelState.IsValid)

                {
                    using (var db = new DBNull())
                    {
                        User oldUser = db.Users.Find(user.Id);

                        oldUser.Firstname = user.FirstName;
                        oldUser.LastName = user.Last.Name;

                        db.SaveChanges();
                    }



                }
                return View(user);

            }

        // sadaļa View/User add view -> Edit

        @model FirstWebAplication.Models.User
            @{
            View.Title = "Edit";

        }
        <h2>Edit</h2>

            @using (Html.BeginForm("Edit", "User", FormMEthod.Post))
        {
            <div> 
            @Html.LabelFor(m = > m.FirstName)
            @Html.EditorFor( m => m.FirstNAme)
            
            
            </div> 

              <div> 
            @Html.LabelFor(m = > mbox.LastName)
            @Html.EditorFor(m => mbox.LastNAme)
            
            
            </div> 

            <div> 
            @Html.HiddenForm(mbox => mbox.Id)
            <input type = "submit" vale = "Saglabat"/>
               </div> 





        }


    // build 



















        }
    }
}
