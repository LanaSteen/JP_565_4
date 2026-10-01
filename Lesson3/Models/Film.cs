using Lesson3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3.Models
{
	internal class Film
	{

		public Dierctor Dierctor { get; set; }
		public Producer  Producer { get; set; }


		public Actor[] Actors { get; set; }


		//public string[] Locations { get; set; }  // ["","",""]

	}
}


