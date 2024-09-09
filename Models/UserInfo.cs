using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
	public class UserInfo
	{
		public int Id { get; set; }

		[Required (ErrorMessage ="İsim alanı zorunlu")]
        public string? Name { get; set; }

		[Required(ErrorMessage = "Telefon numarası alanı zorunlu")]
		public string? Phone { get; set; }

		[Required(ErrorMessage = "Email alanı zorunlu")]
		[EmailAddress(ErrorMessage = "Geçersiz email")]
		public string? Email { get; set; }

		[Required(ErrorMessage = "Katılım durumunuzu belirtiniz")]
        public bool? WillAttend { get; set; }
    }
}
