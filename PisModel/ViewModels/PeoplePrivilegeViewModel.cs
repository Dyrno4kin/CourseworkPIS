
namespace Model.ViewModels
{
    public class PeoplePrivilegeViewModel
    {
        public int Id { get; set; }
        public int PeopleId { get; set; }
        public int PrivilegeId { get; set; }
        public string NamePrivilege { get; set; }
        public double Multiplier { set; get; }
    }
}
