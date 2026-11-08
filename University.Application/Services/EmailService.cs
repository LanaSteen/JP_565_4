using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace University.Application.Services
{
	public class EmailService
	{
		public static void SendEmail(string to, string subject, string body) /// todo appsettings.json
		{
			SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = new NetworkCredential("stepacc210@gmail.com", "chpy ntyf pzdo pjyw");
			smtpClient.EnableSsl = true;


			MailMessage message = new MailMessage();
			message.From = new MailAddress("stepacc210@gmail.com");
			message.To.Add(to);
			message.Subject = subject;
			message.Body = body;
			message.IsBodyHtml = true;


			smtpClient.Send(message);
		}


		public void SendVerificationCode(string email, string verificationCode)
		{
			SendEmail(email, "ვერიფიკაციის კოდი", $"public void SendVerificationCode(string email, string verificationCode)\r\n{{\r\n    string htmlBody = $@\"\r\n    <!DOCTYPE html>\r\n    <html lang='ka'>\r\n    <head>\r\n        <meta charset='UTF-8'>\r\n        <meta name='viewport' content='width=device-width, initial-scale=1.0'>\r\n        <title>ვერიფიკაციის კოდი</title>\r\n    </head>\r\n    <body style='margin:0; padding:0; background-color:#f4f6f8; font-family:Arial, sans-serif;'>\r\n\r\n        <table width='100%' cellpadding='0' cellspacing='0' \r\n               style='background-color:#f4f6f8; padding:40px 15px;'>\r\n            <tr>\r\n                <td align='center'>\r\n\r\n                    <table width='100%' cellpadding='0' cellspacing='0'\r\n                           style='max-width:500px; background-color:#ffffff;\r\n                                  border-radius:12px; overflow:hidden;'>\r\n\r\n                        <tr>\r\n                            <td style='background-color:#61756b; padding:30px;\r\n                                       text-align:center;'>\r\n                                <h1 style='color:#ffffff; margin:0; font-size:24px;'>\r\n                                    Email Verification\r\n                                </h1>\r\n                            </td>\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <td style='padding:35px 30px; text-align:center;'>\r\n\r\n                                <h2 style='color:#333333; margin-top:0;'>\r\n                                    მოგესალმებით!\r\n                                </h2>\r\n\r\n                                <p style='color:#666666; font-size:15px;\r\n                                          line-height:1.6;'>\r\n                                    თქვენი ელფოსტის მისამართის დასადასტურებლად\r\n                                    გამოიყენეთ ქვემოთ მოცემული ვერიფიკაციის კოდი.\r\n                                </p>\r\n\r\n                                <div style='background-color:#f0f4f1;\r\n                                            border:1px dashed #61756b;\r\n                                            border-radius:8px;\r\n                                            padding:20px;\r\n                                            margin:25px 0;'>\r\n\r\n                                    <span style='font-size:32px;\r\n                                                 font-weight:bold;\r\n                                                 letter-spacing:8px;\r\n                                                 color:#61756b;'>\r\n                                        {verificationCode}\r\n                                    </span>\r\n\r\n                                </div>\r\n\r\n                                <p style='color:#888888; font-size:13px;'>\r\n                                    კოდი მოქმედებს 5 წუთის განმავლობაში.\r\n                                </p>\r\n\r\n                                <p style='color:#999999; font-size:12px;\r\n                                          line-height:1.5; margin-top:30px;'>\r\n                                    თუ თქვენ არ მოგითხოვიათ ვერიფიკაციის კოდი,\r\n                                    შეგიძლიათ უგულებელყოთ ეს შეტყობინება.\r\n                                </p>\r\n\r\n                            </td>\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <td style='background-color:#f8f9fa; padding:20px;\r\n                                       text-align:center;'>\r\n                                <p style='color:#999999; font-size:12px; margin:0;'>\r\n                                    © 2026 Your Application. All rights reserved.\r\n                                </p>\r\n                            </td>\r\n                        </tr>\r\n\r\n                    </table>\r\n\r\n                </td>\r\n            </tr>\r\n        </table>\r\n\r\n    </body>\r\n    </html>\";\r\n\r\n    ");
		}
	}
}



//smtp
//https 
//ftp
//ip