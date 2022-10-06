using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class DebugDisplay
    {
        private PropertyInfo[] propertyInfos1;
        private PropertyInfo[] propertyInfos2;
        private PropertyInfo[] propertyInfos3;
        private PropertyInfo[] propertyInfos4;

        public void OutoutInfoToDebug(Type t1, Type t2, Type t3, Type t4)
        {
            propertyInfos1 = t1.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            Debug.WriteLine($"The number properties: {propertyInfos1.Length}.\n");
            Display(propertyInfos1);
            propertyInfos2 = t2.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            Debug.WriteLine($"The number properties: {propertyInfos2.Length}.\n");
            Display(propertyInfos2);
            propertyInfos3 = t3.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            Debug.WriteLine($"The number properties: {propertyInfos3.Length}.\n");
            Display(propertyInfos3);
            propertyInfos4 = t4.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            Debug.WriteLine($"The number properties: {propertyInfos4.Length}.\n");
            Display(propertyInfos4);
        }
        public void Display(PropertyInfo[] propertyInfos)
        {
            foreach (var propInfo in propertyInfos)
            {
                Debug.WriteLine($"Property name: {propInfo.Name}");
                Debug.WriteLine($"Property type: {propInfo.PropertyType}");
                Debug.WriteLine("");
            }
        }
    }
}
