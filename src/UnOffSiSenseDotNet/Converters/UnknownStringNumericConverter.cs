using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UnOffSiSenseDotNet.Converters
{
    public class UnknownStringNumericConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.Value is null)
            { return null; }

            if (reader.ValueType.Name == "String")
            {
                string value = (string)reader.Value;
                string numberOnly = Regex.Replace(value, "[^0-9.]", "");
                double.TryParse(numberOnly, out double number);
                return number;
            }
            double.TryParse(reader.Value.ToString(), out double origNumber);
            return origNumber;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanRead
        {
            get
            {
                return true;
            }
        }
    }
}
