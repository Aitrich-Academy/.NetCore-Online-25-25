namespace Alishachapter3.models
{
    abstract class LibraryMember
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public LibraryMember(int memberId, string name)
        {
            MemberId = memberId;
            Name = name;
        }
        public abstract double CalculateFine(int overdueDays);
    }
}
