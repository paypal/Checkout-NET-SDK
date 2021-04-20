namespace PayPal.Sdk.Checkout.RequestInterfaces
{
    public interface IPayPalRequestWithResponseBody
    {
    }

    public interface IPayPalRequestWithResponseBody<TResponseType> : IPayPalRequestWithResponseBody
        where TResponseType : notnull
    {
    }
}
