using System;
using UnityEngine;

namespace RC9Dogs
{
	public class Class1 : MonoBehaviour
	{
		string name;
		string breed;
		float height;


		public Class1(string _name, string _breed)
		{
			name = _name;
			breed = _breed;
			SetColour();
		}

		public string GetName()
		{
			return name;
		}


		public string GetBreed()
		{
			return breed;
		}

		private void SetColour()
		{

		}

		public void Walking ()
        {
			// actions 
        }
	}


}
