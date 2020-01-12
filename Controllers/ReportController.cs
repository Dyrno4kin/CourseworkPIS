using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ReportController
    {
        private PisDbContext context;
        public ReportController(PisDbContext context)
        {
            this.context = context;
        }

        public async Task SaveToJsonAsync(string fileName)
        {
            DataContractJsonSerializer formatterPeople= new DataContractJsonSerializer(typeof(List<People>));
            MemoryStream msPeople = new MemoryStream();
            formatterPeople.WriteObject(msPeople, await context.Peoples.ToListAsync());
            msPeople.Position = 0;
            StreamReader srPeople = new StreamReader(msPeople);
            string peopleJSON = srPeople.ReadToEnd();
            srPeople.Close();
            msPeople.Close();

            DataContractJsonSerializer formatterPeoplePrivileges = new DataContractJsonSerializer(typeof(List<PeoplePrivilege>));
            MemoryStream msPeoplePrivileges = new MemoryStream();
            formatterPeoplePrivileges.WriteObject(msPeoplePrivileges, await context.PeoplePrivileges.ToListAsync());
            msPeoplePrivileges.Position = 0;
            StreamReader srPeoplePrivileges = new StreamReader(msPeoplePrivileges);
            string peoplePrivilegesJSON = srPeoplePrivileges.ReadToEnd();
            srPeoplePrivileges.Close();
            msPeoplePrivileges.Close();

            File.WriteAllText(fileName, "{\n" +
                "    \"People\": " + peopleJSON + ",\n" +
                "    \"PeoplePrivileges\": " + peoplePrivilegesJSON + ",\n" +
                "}");
        }
    }
}
