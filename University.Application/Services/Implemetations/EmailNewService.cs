using System;
using System.Collections.Generic;
using System.Text;
using University.Application.Services.Interfaces;

namespace University.Application.Services.Implemetations
{
	public class EmailNewService : IEmailService
	{
		public void SendEmail(string to, string subject, string body)
		{
			throw new NotImplementedException();
		}

		public void SendVerificationCode(string email, string verificationCode)
		{
			throw new NotImplementedException();
		}
	}
}
