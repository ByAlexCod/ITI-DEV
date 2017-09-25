using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.bottle
{
    public class Bottle
    {
        readonly int _capacity;
        int _currentVolume;
        int _calcul;
        string _name;
       /// <summary>
       /// Set for bottle, capacity and name.
       /// </summary>
       /// <param name="capacity">Set Capacity in Milliliters</param>
       /// <param name="name">Set name as string</param>
        public Bottle (int capacity, string name)
        {
            _capacity = capacity;
            _name = name;
        }
        /// <summary>
        /// Gets the capicity in mililliter.
        /// </summary>
        public int Capacity
        {
            get { return _capacity;  }
        }
        
        public int Volume
        {
            get {
                    if (_currentVolume > _capacity)
                    {
                        _currentVolume = _capacity;
                        return _currentVolume;
                    } else if (_currentVolume < 0)
                    {
                        _currentVolume = 0;
                    return _currentVolume;
                    } else
                    {
                        return _currentVolume;
                    }
                }
            set { _currentVolume = value; }
        }

        public int calcul
        {
            
            get {
                _calcul = _capacity - _currentVolume;
                return _calcul;
            }
            
        }
        public string name
        {
            get {
                return _name;
            }
            set
            {
                _name = value;

            }
        }

    }
}
