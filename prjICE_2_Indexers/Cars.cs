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
                if (attrName == "carPrice")
                    return this.carPrice;
                else if (attrName == "carPower")
                    return this.carPower;
                else if (attrName == "carSpeed")
                    return this.carSpeed;
                else if (attrName == "carName")
                    return this.carName;
                else if (attrName == "carColour")
                    return this.carColour;
                else
                    return null;
            }

            set
            {
                if (attrName.ToLower().Equals("carPrice"))
                    this.carPrice = (int)value;
                else if (attrName.ToLower().Equals("carPower"))
                    this.carPower = (int)value;
                else if (attrName.ToLower().Equals("carSpeed"))
                    this.carSpeed = (int)value;
                else if (attrName.ToLower().Equals("carName"))
                    this.carName = (string)value;
                else if (attrName.ToLower().Equals("carColour"))
                    this.carColour = (string)value;
            }
        }
    }
}
