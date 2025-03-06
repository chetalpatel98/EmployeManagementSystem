namespace EmployeManagementSystem.Models
{
    public class RegisterVM
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Salary { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string JoinDate { get; set; }
        public int PreviousExperince { get; set; }
        public string Deparment { get; set; }
        public IFormFile profilePhoto { get; set; }
        public string profilePhotoUrl { get; set; }
    }
}
