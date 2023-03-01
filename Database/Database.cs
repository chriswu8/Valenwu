using NMemory;
using NMemory.Tables;
using System;
using Valenwu.Tables;

public class MyDatabase : Database
{
    public MyDatabase()
    {
        /*var peopleTable = base.Tables.Create<Person, int>(p => p.Id);
        var groupTable = base.Tables.Create<Group, int>(g => g.Id);

        var peopleGroupIdIndex = peopleTable.CreateIndex(
            new RedBlackTreeIndexFactory<Person>(),
            p => p.GroupId);

        this.Tables.CreateRelation(
            groupTable.PrimaryKeyIndex,
            peopleGroupIdIndex,
            x => x,
            x => x);

        this.People = peopleTable;
        this.Groups = groupTable;*/

        var patientTable = base.Tables.Create<Patient, Guid>(p => p.Id);
        this.Patients = patientTable;
    }

    public ITable<Patient> Patients { get; set; }
}
