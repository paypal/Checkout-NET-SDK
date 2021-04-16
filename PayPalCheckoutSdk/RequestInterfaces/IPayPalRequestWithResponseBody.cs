namespace PayPalCheckoutSdk.RequestInterfaces
{
    public interface IPayPalRequestWithResponseBody
    {
    }

    public interface IPayPalRequestWithResponseBody<TResponseType> : IPayPalRequestWithResponseBody
        where TResponseType : notnull
    {
    }
}
