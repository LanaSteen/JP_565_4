using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4
{
	internal class Temperature
	{
		public int Amount { get; set; }
		public string Measurement { get; set; }

		public override string? ToString()
		{
			return $"{Amount} {Measurement}";
		}

		public static Temperature operator +(Temperature temp1, Temperature temp2)
		{
		
			if(temp1.Measurement == temp2.Measurement)
			{
				Temperature tempSum = new Temperature();
				tempSum.Measurement = temp1.Measurement;
				tempSum.Amount = temp1.Amount + temp2.Amount;
				return tempSum;
			}


			return null;  // throw error
		}

		public static Temperature operator -(Temperature temp1, Temperature temp2)
		{

			if (temp1.Measurement == temp2.Measurement)
			{
				Temperature tempSum = new Temperature();
				tempSum.Measurement = temp1.Measurement;
				tempSum.Amount = temp1.Amount - temp2.Amount;
				return tempSum;
			}
			return null;  // throw error
		}

		public static Temperature operator *(Temperature temp1, Temperature temp2)
		{

			if (temp1.Measurement == temp2.Measurement)
			{
				Temperature tempSum = new Temperature();
				tempSum.Measurement = temp1.Measurement;
				tempSum.Amount = temp1.Amount * temp2.Amount;
				return tempSum;
			}
			return null;  // throw error
		}


		public static Temperature operator /(Temperature temp1, Temperature temp2)
		{

			if (temp1.Measurement == temp2.Measurement && temp2.Amount != 0)
			{
				Temperature tempSum = new Temperature();
				tempSum.Measurement = temp1.Measurement;
				tempSum.Amount = temp1.Amount / temp2.Amount;
				return tempSum;
			}
			return null;  // throw error
		}

		
		public static bool operator >(Temperature temp1, Temperature temp2)
		{

			if (temp1.Measurement == temp2.Measurement)
			{
				return temp1.Amount > temp2.Amount;
			}
			return false;
		}
		public static bool operator <(Temperature temp1, Temperature temp2)
		{

			if (temp1.Measurement == temp2.Measurement)
			{
				return temp1.Amount < temp2.Amount;
			}
			return false;
		}
	
	
	    public static bool operator ==(Temperature temp1, Temperature temp2)
		  {
			if (temp1.Measurement == temp2.Measurement)
			{
				return temp1.Amount == temp2.Amount;
			}
			return false;

		}
		public static bool operator !=(Temperature temp1, Temperature temp2)
		{
			if (temp1.Measurement == temp2.Measurement)
			{
				return temp1.Amount != temp2.Amount;
			}
			return false;

		}


		public static bool operator >=(Temperature temp1, Temperature temp2)
		{
			if (temp1.Measurement == temp2.Measurement)
			{
				return temp1.Amount >= temp2.Amount;
			}
			return false;

		}

		public static bool operator <=(Temperature temp1, Temperature temp2)
		{
			if (temp1.Measurement == temp2.Measurement)
			{
				return temp1.Amount <= temp2.Amount;
			}
			return false;

		}

		public static Temperature operator %(Temperature temp1, Temperature temp2)
		{

			if (temp1.Measurement == temp2.Measurement)
			{
				Temperature tempSum = new Temperature();
				tempSum.Measurement = temp1.Measurement;
				tempSum.Amount = temp1.Amount % temp2.Amount;
				return tempSum;
			}


			return null;  // throw error
		}


		public static Temperature operator ++(Temperature temp1)
		{
				Temperature tempSum = new Temperature();
				tempSum.Measurement = temp1.Measurement;
				tempSum.Amount = temp1.Amount +1;
				return tempSum;
		}

		public static Temperature operator --(Temperature temp1)
		{
			Temperature tempSum = new Temperature();
			tempSum.Measurement = temp1.Measurement;
			tempSum.Amount = temp1.Amount - 1;
			return tempSum;
		}


		
	}
}

