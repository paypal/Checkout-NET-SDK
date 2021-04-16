using System;
using PayPalCheckoutSdk.Core;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Runtime.Serialization.Json;

namespace PayPalCheckoutSdk.Samples
{
    public class PayPalClient
    {
        /**
            Setting up PayPal environment with credentials with sandbox cerdentails. 
            For Live, this should be LiveEnvironment Instance. 
         */
        public static PayPalEnvironment environment()
        {
            return new SandboxEnvironment(
                Environment.GetEnvironmentVariable("PAYPAL_CLIENT_ID") ?? "<<PAYPAL-CLIENT-ID>>",
                Environment.GetEnvironmentVariable("PAYPAL_CLIENT_SECRET") ?? "<<PAYPAL-CLIENT-SECRET>>"
            );
        }

        /**
            Returns PayPalHttpClient instance which can be used to invoke PayPal API's.
         */
        public static HttpClient client()
        {
            return new PayPalHttpClient(environment());
        }

        public static HttpClient client(string refreshToken)
        {
            return new PayPalHttpClient(environment(), refreshToken);
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
