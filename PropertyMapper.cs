using System;
using System.Reflection;

public static class PropertyMapper
{
    public static void MapProperties(object source, object destination)
    {
        Type sourceType = source.GetType();
        Type destinationType = destination.GetType();

        PropertyInfo[] sourceProperties = sourceType.GetProperties();
        PropertyInfo[] destinationProperties = destinationType.GetProperties();

        foreach (var sourceProperty in sourceProperties)
        {
            var destinationProperty = Array.Find(destinationProperties,
                prop => prop.Name == sourceProperty.Name && prop.PropertyType == sourceProperty.PropertyType);

            if (destinationProperty != null)
            {
                destinationProperty.SetValue(destination, sourceProperty.GetValue(source));
            }
        }
    }
}