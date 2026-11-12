using System;
using System.Collections.Generic;
using System.Text;

namespace University.Application.Services.Interfaces
{
	public interface IEmailService
	{
		 void SendEmail(string to, string subject, string body);
		 void SendVerificationCode(string email, string verificationCode);

	}
}
