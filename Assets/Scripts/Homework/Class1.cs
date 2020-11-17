using System;
using UnityEngine;

namespace RC9Dogs
{


	interface IClass1
    {
		 void Move();

    }

	public class Classxxx : IClass1
	{ 
		public void Move()
        {

        }

    }

	public class Class1 : MonoBehaviour, IClass1
	{
		protected string name;
		public string breed;
		private float height;

		public float prop2 { get; set; }

		public float pros3
        {
			get
            {
				if (height < 0)
					return 0;
				else
					return height;

            }	
			set
            {
				if (value > 2000)
					height = 0;
				else
					height = value;

            }
        }

		public void Move()
        {

        }

		public Class1(string _name, string _breed)
		{
			name = _name;
			breed = _breed;
			SetColour();
		}

		public Class1(string _name, string _breed, float _height)
        {
			name = _name;
			breed = _breed;
			height = _height;
			prop2 = 123;

		}


		public void SetHeight(float _height)
        {
			this.height = _height;

			 int i  = Convert.ToInt32("123");
        }

		public void SetHeight()
		{
			this.height = 100;
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


	public class Class2: Class1
    {
		public float predator;  
		public Class2(string _name, string _breed) : base(_name, _breed)
        {
			this.name = "123123";
			

        }



    }


}
