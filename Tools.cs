using System;
using System.Reflection;
using System.Xml.Serialization;

namespace SATeC
{
    public class Tools
    {
        public static T GetCode<T>(string value)
        {
            foreach (object o in System.Enum.GetValues(typeof(T)))
            {
                T enumValue = (T)o;

                if (GetXmlAttrNameFromEnumValue(enumValue).Equals(value, StringComparison.OrdinalIgnoreCase))
                {
                    return (T)o;
                }
            }

            throw new Exception("No XmlEnumAttribute code exists for type " + typeof(T).ToString() + " corresponding to value of " + value);
        }
        public static string GetXmlAttrNameFromEnumValue<T>(T pEnumVal)
        {
            try
            {
                Type type = pEnumVal.GetType();
                FieldInfo info = type.GetField(Enum.GetName(typeof(T), pEnumVal));
                XmlEnumAttribute att = (XmlEnumAttribute)info.GetCustomAttributes(typeof(XmlEnumAttribute), false)[0];
                return att.Name;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}