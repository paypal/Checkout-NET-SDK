namespace PayPalCheckoutSdk.RequestInterfaces
{
    public interface IPayPalRequestWithRequestBody
    {
        string ContentType { get; }
    }

    public interface IPayPalRequestWithRequestBody<out TRequestBody> : IPayPalRequestWithRequestBody
    {
        TRequestBody Body { get; }
    }
}
