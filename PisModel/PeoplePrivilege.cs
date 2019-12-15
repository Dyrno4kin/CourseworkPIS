namespace Model
{
    public class PeoplePrivilege
    {
        public int Id { get; set; }
        public int PeopleId { get; set; }
        public int PrivilegeId { get; set; }
        public virtual People People { get; set; }
        public virtual Privilege Privilege { get; set; }
    }
}
