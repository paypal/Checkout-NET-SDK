using Newtonsoft.Json;

namespace PayPal.Sdk.Checkout.Samples
{
    public static class ObjectExtensions
    {
        public static string AsJson<TObject>(this TObject sourceObject)
        {
            return JsonConvert.SerializeObject(sourceObject, typeof(TObject), new JsonSerializerSettings());
        }
    }
}
