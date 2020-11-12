using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        public MilitaryType militaryType;

        public MilitaryPlane(string model, int maximumSpeed, int maxFlightDistance, int maxLoadCapacity, MilitaryType type)
            : base(model, maximumSpeed, maxFlightDistance, maxLoadCapacity)
        {
            militaryType = type;
        }

        public override bool Equals(object obj)
        {
            var plane = obj as MilitaryPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   militaryType == plane.militaryType;
        }



        public MilitaryType GetPlaneType()
        {
            return militaryType;
        }
        public override int GetHashCode()
        {
           return  base.GetHashCode()+militaryType.GetHashCode();
           
        }


        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", type=" + militaryType +
                    '}');
        }        
    }
}
