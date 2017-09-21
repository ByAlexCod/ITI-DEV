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
        /// 
        /// </summary>
        /// <param name="capacity"></param>
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
            get { return _currentVolume; }
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
