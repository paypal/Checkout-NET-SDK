using PayPal.Sdk.Checkout.Core;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace PayPal.Sdk.Checkout.Samples
{
    public class PayPalClient
    {
        public static PayPalHttpClient CreateHttpClient()
        {
        }

        /**
            This method can be used to Serialize Object to JSON string.
        */
        public static string ObjectToJSONString<T>(T serializableObject)
        {
            using var memoryStream = new MemoryStream();
            using var writer = JsonReaderWriterFactory.CreateJsonWriter(
                memoryStream, Encoding.UTF8, true, true, "  "
            );
            var ser = new DataContractJsonSerializer(typeof(T), new DataContractJsonSerializerSettings {UseSimpleDictionaryFormat = true});
            ser.WriteObject(writer, serializableObject);

            memoryStream.Seek(0, SeekOrigin.Begin);

            using var sr = new StreamReader(memoryStream);
            return sr.ReadToEnd();
        }
    }
}
