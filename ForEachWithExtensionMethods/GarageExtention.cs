using System;
using System.Collections;
namespace ForEachExtensionMethods
{
    static class GarageExtention
    {
        public static IEnumerator GetEnumerator(this Garage g)
        {
            return g.CarsinGarage.GetEnumerator();
        }
    }
}