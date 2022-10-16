namespace Semina.model
{
    public class S_EMP
    {
        public int Id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string userID { get; set; }
        public DateTime startDate { get; set; }
        public string comments { get; set; }  
        public int managerId { get; set; }
        public string title { get; set; }
        public int deptId { get; set; }
        public float salary { get; set; }
        public float commisstionPCT { get; set; }

    }
}
