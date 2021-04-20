using Newtonsoft.Json;

namespace PayPalCheckoutSdk.Samples
{
    public static class ObjectExtensions
    {
        public static string AsJson<TObject>(this TObject sourceObject)
        {
            return JsonConvert.SerializeObject(sourceObject, typeof(TObject), new JsonSerializerSettings());
        }
    }
}
