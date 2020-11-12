using System.Collections.Generic;

namespace Aircompany.Planes
{
    public abstract class Plane
    {
        public string model;
        public int maximumSpeed;
        public int maximumFlightDistance;
        public int maximumLoadCapacity;

        public Plane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity)
        {
            this.model = model;
            maximumSpeed = maxSpeed;
            maximumFlightDistance = maxFlightDistance;
            maximumLoadCapacity = maxLoadCapacity;
        }

        public string GetModel()
        {
            return model;
        }

        public int GetMaximumSpeed()
        {
            return maximumSpeed;
        }

        public int MaximumFlightDistance()
        {
            return maximumFlightDistance;
        }

        public int MaximumLoadCapacity()
        {
            return maximumLoadCapacity;
        }

        public override string ToString()
        {
            return "Plane{" +
                "model='" + model + '\'' +
                ", maxSpeed=" + maximumSpeed +
                ", maxFlightDistance=" + maximumFlightDistance +
                ", maxLoadCapacity=" + maximumLoadCapacity +
                '}';
        }

        public override bool Equals(object obj)
        {
            var plane = obj as Plane;
            return plane != null &&
                   model == plane.model &&
                   maximumSpeed == plane.maximumSpeed &&
                   maximumFlightDistance == plane.maximumFlightDistance &&
                   maximumLoadCapacity == plane.maximumLoadCapacity;
        }

        public override int GetHashCode()
        {
            var hashCode = -1043886837;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(model);
            hashCode = hashCode * -1521134295 + maximumSpeed.GetHashCode();
            hashCode = hashCode * -1521134295 + maximumFlightDistance.GetHashCode();
            hashCode = hashCode * -1521134295 + maximumLoadCapacity.GetHashCode();
            return hashCode;
        }        

    }
}
