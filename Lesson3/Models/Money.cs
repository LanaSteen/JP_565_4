using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3.Models
{
	internal class Money
	{

		public string Currency { get; set; }
		public decimal Amount { get; set; }

		public override string? ToString()
		{
				return $"{Currency} {Amount}";
		}

		public static Money operator + (Money m1, Money m2)
			{
			   if(m1.Currency != m2.Currency) 
			    {
				     throw new ArgumentException("currencies must be the same");
			    }


				return new Money 
				{ 
				  Currency = m1.Currency,
				  Amount = m1.Amount + m2.Amount
				
				};
		}

		public static Money operator -(Money m1, Money m2)
		{
			if (m1.Currency != m2.Currency)
			{
				throw new ArgumentException("currencies must be the same");
			}


			return new Money
			{
				Currency = m1.Currency,
				Amount = m1.Amount - m2.Amount

			};
		}



		public static bool operator ==(Money m1, Money m2)
		{

			return m1.Currency == m2.Currency && m1.Amount == m2.Amount;
		}

		public static bool operator !=(Money m1, Money m2)
		{

			return m1.Currency != m2.Currency || m1.Amount != m2.Amount;
		}



		public static Money operator %(Money m1, Money m2)
		{
			return new Money
			{
				Currency = m1.Currency,
				Amount = m1.Amount % m2.Amount
			};
		}

		public static Money operator ++(Money m1)
		{
			return new Money
			{
				Currency = m1.Currency,
				Amount = m1.Amount + 1
			};
		}

		public static Money operator --(Money m1)
		{
			return new Money
			{
				Currency = m1.Currency,
				Amount = m1.Amount - 1
			};
		}


		public static bool operator >(Money m1, Money m2)
		{
			if (m1.Currency != m2.Currency)
			{
				throw new ArgumentException("currencies must be the same");
			}
			return m1.Amount > m2.Amount;
		}
		public static bool operator <(Money m1, Money m2)
		{
			if (m1.Currency != m2.Currency)
			{
				throw new ArgumentException("currencies must be the same");
			}
			return m1.Amount < m2.Amount;
		}
	}
}






//enum Currency
//{
//	USD,
//	EUR,
//	GBP,
//	RUB
//}