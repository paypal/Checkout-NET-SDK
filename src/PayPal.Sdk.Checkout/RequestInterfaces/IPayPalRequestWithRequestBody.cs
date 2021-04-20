namespace PayPal.Sdk.Checkout.RequestInterfaces
{
    public interface IPayPalRequestWithRequestBody
    {
        string ContentType { get; }

        string PayPalRequestId { get; }
    }

    public interface IPayPalRequestWithRequestBody<out TRequestBody> : IPayPalRequestWithRequestBody
        where TRequestBody : notnull
    {
        TRequestBody Body { get; }
    }
}
