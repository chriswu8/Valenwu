using System;
using System.Linq;
using NMemory;
using NMemory.Indexes;
using NMemory.Tables;

namespace Valenwu
{
    /*public class Member
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? GroupId { get; set; }
    }*/

    // Table definition
    public class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }

    public class MyDatabase : Database
    {
        public MyDatabase()
        {
            // Create table
            /*var members = this.Tables.Create<Member, int>(x => x.Id);*/
            var groups = base.Tables.Create<Group, int>(g => g.Id);

            /*this.Members = members;*/
            this.Groups = groups;

            /*RelationOptions options = new RelationOptions(
                cascadedDeletion: true);

            var peopleGroupIdIndex = members.CreateIndex(
                new RedBlackTreeIndexFactory(),
                p => p.GroupId);

            this.Tables.CreateRelation(
                groups.PrimaryKeyIndex,
                peopleGroupIdIndex,
                x => x ?? -1,
                x => x,
                options);*/
        }

        //public ITable<Member> Members { get; private set; }

        public ITable<Group> Groups { get; private set; }
    }

    public partial class Valenwu : Form
    {

        public Valenwu()
        {
            InitializeComponent();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MyDatabase myDatabase = new MyDatabase();

            // insert data into table
            myDatabase.Groups.Insert(new Group() { Id = 1, Name = "Edmond" });
            myDatabase.Groups.Insert(new Group() { Id = 2, Name = "Chris" });

            /*myDatabase.Members.Insert(new Member() { Id = 1, GroupId = 1, Name = "It's Member_1" });

            myDatabase.Members.Insert(new Member() { Id = 2, Name = "It's Member_2" });*/

            // delete thing with id == 1
            //myDatabase.Groups.Delete(new Group { Id = 1 });

            // select all from database
            var list = myDatabase.Groups;

            // select specific thing from database - LINQ
            var list1 = from s in list where s.Name == "Edmond" select s;

            /*var list2 = myDatabase.Groups.Where(x => Functions.Like(x.Name, "Edmond")).ToList();*/

            // update - figure out a better way of updating entities
            Group g = new Group();
            g.Id = 1;
            g.Name = "Edmond Updated";

            myDatabase.Groups.Update(g);


            var list2 = myDatabase.Groups.ToList();

            //FiddleHelper.WriteTable("Members", list);


            /*myDatabase.Members.Insert(new Member() { Id = 3, GroupId = 2, Name = "It's Member_3" });*/

            //FiddleHelper.WriteTable("All Members", myDatabase.Members.ToList());


        }
    }
}