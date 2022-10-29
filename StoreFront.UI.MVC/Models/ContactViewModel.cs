using Microsoft.EntityFrameworkCore; //Added to address error with primary key for CVM
using System.ComponentModel.DataAnnotations;

namespace StoreFront.UI.MVC.Models
{
    [Keyless]
    public class ContactViewModel
    {
        [Required(ErrorMessage = "*")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*")]
        //[DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "*Must be a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "*")]
        public string Message { get; set; }
    }
}
