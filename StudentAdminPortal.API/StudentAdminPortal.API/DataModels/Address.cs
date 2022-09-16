namespace StudentAdminPortal.API.DataModels
{
    public class Address
    {
        public Guid ID { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }

        //Navigation Property
        public Guid StudentID { get; set; }
    }
}
