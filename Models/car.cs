using System;
using System.Collections.Generic;

namespace Dealership.Models
{
   class Car 
	 {
    private string _makeModel;
    private int _price;
    private int _miles;
    private string _message;

		 public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    
    public Car(string makeModel, int price, int miles, string message)
    {
        _makeModel = makeModel;
        _price = price;
        _miles = miles;
        _message = message;
    }

    public string GetMakeModel()
    {
			return _makeModel;
    }
		public int GetPrice()
    {
			return _price;
    }
		public int GetMiles()
    {
			return _miles;
    }
		public string GetMessage()
    {
			return _message;
    }
    public bool WorthBuying(int maxPrice, int maxMile)
    {
    
        return (_price < maxPrice && _miles < maxMile);
    }
  }
}

