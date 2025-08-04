using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjICE_2_Indexers
{
    public class Cars
    {
        int carPrice, carPower, carSpeed;
        string carName, carColour;
        
        public Cars(int carPrice, int carPower, int carSpeed, string carName, string carColour)
        {
            this.carPrice = carPrice;
            this.carPower = carPower;
            this.carSpeed = carSpeed;
            this.carName = carName;
            this.carColour = carColour;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.carPrice;
                else if (index == 1)
                    return this.carPower;
                else if (index == 2)
                    return this.carSpeed;
                else if (index == 3)
                    return this.carName;
                else if (index == 4)
                    return this.carColour;
                else
                    return null;
            }
            set
            {
                if (index == 0)
                    this.carPrice = (int)value;
                else if (index == 1)
                    this.carPower = (int)value;
                else if (index == 2)
                    this.carSpeed = (int)value;
                else if (index == 3)
                    this.carName = (string)value;
                else if (index == 4)
                    this.carColour = (string)value;
            }
        }

        public object this[string attrName]
        {
            get 
            {     
                if (attrName == "price")
                    return this.carPrice;
                else if (attrName == "power")
                    return this.carPower;
                else if (attrName == "speed")
                    return this.carSpeed;
                else if (attrName == "name")
                    return this.carName;
                else if (attrName == "colour")
                    return this.carColour;
                return null;
            }

            set
            {
                if (attrName.ToLower().Equals("price"))
                    this.carPrice = (int)value;
                else if (attrName.ToLower().Equals("power"))
                    this.carPower = (int)value;
                else if (attrName.ToLower().Equals("speed"))
                    this.carSpeed = (int)value;
                else if (attrName.ToLower().Equals("name"))
                    this.carName = (string)value;
                else if (attrName.ToLower().Equals("colour"))
                    this.carColour = (string)value;
            }
        }
    }
}
