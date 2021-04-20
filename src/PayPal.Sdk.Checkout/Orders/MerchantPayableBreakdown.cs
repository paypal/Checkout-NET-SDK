// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// MerchantPayableBreakdown.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/+yaYW/bNhPH3z+f4uBXzwM4cZs2fYC8WtusWDasDbpswNAVzpk8WUQoUj2e7GrDvvtASrItW9nSIiiwVK8C80jx+Nfdjycyf0yu6pImZ5MfiVWOTuASa1xYghdMeKP92k2mk1+QTWx8jUXsO5lOfqB6++OcgmJTivFucja5ygkW3WDwGUhOwJRVTh9PppPnzFg3kz6aTt4S6jfO1pOzDG2g2PChMkx603DJviQWQ2Fy9m7rrndUH3q2ZB/CHAtfOel5uWc49FhVzORUDeg0NP0g8wwImXHolEELwugCqjhqCqFSOWAAhAVadIrAM5RYF+QEdEX3t9YgbNzycLGdy3PlNfVWu285XO47yZnoSOXIqIQYLn56c/T05PH/t0LEse//O9NehZlxQkvG+ICZNkxKZkxBZl3no9g5zP4HkqOA0eTEZIZCevddp09SRLjaE8RV1v45/UdVVmirvhpdy6EKyTKFdW5UDoVZ5gILOvutevToiaps+kvNL2uaX88dJC2IU3S0S4srteaG4Pr7y1+vGxGQCZwXkLo0Cq2tIeMmdtAeNw+ddU/dmwM0KVOg3YwYnuvq9fnOXKFaaLMymnT00IPkvgrotORheLpZt8JXntscbcQHVxUL4pi6nSOlRUWhTYhehEwhEMG7l13byxgInxo29xEZ73di4xY6OJIhNvSaRzKMZBjJ8GDJsM31+aZGmRuh4u9ose16Czd6HfrB9NwBRv+jZtuqKIVXo1rU15G0ZDmGtyQVO9Kwzsn1sqRfS4EJoE2WEUesZOyLwc6XWF+iBVQqgWudE1MylFgTQe6tTrloGOJTw57gz+69RFPerYiF9BCKB4wjkEcgj0B+sECmj/Gzc0lzRqHDENk3b0Nl33IYMl0PiD0a9TUJcWFcG+4tPMRDC56Go97tQEY8oPOSE39ednwWL4KvWNG8m7C38EPbv5AZA6rcERqCvCQZlubQ9lVJ8yk8baTa2Uvb8uPbD5VZoaUmLWImVM5IV000sbddF7zyXKAI6bi/drj1vKFRcgDWRvL0LPHw+BS0WRoJkMhHwAnm7QQbinnj5F5ku8N3YdkceQ0VJAemsRwZy5GxHHlg5cjdGFGinWdE+3zYNo9sGNkwsuHBfqqUFiXzXLTZvg+IHWvoM2LPcvsBUdezSXoWFwOCKExB+aIwIRjvwjRaF+xviHFJyb45SBq8Zrv/M5yBQmkskEYIjhD8CiCINdF8gYEGa6StrVcj3VIeaRI0douvovsnhHXugUmRWbWBns6mE0CyymbG2qbZsyY+hqvdsSYA2uDhxvm1ixjZnHZ/AW5YQ07mRveZsdN6KEJZLaxRcHG+kSE5exSh1y3qSDFh+souy2O4cMJeV4p0/IYOVVl6FqgCgcIQd4sOoC8YjbtiItgJl+ZrvLkXmLYXAs1lwDUVaOwctWYK4To6cN15MDf6Okob8w5XaGxc9Rc610hu9Q//dh0dVDUumB02UDC/k4Y0Btoxbd4urFc3HyovtJu+Qdi7ZdPy2kuHrdluO/xcRvGfPYUN6EOCBVrr16RhQZmPP52Gk9PT23phFneI+NKbOWLWNhN80066bYFglu4YvvNrWhFP06glOeKEQFSKyhgiBX40RVWAJbeUvAGL668+vsiT013XmxwqUaJqsCLu9piIQAeVSyLpu3oJ9NEE2dBxX+YvEzY7odsLnn77Yei0V2YxJxguzrtNLHIFCgw3pKNAsRa75ZKthXwMQRc3jfgKYnamxJPcsE7VnaFW9v1xAZjSDAtbAznFdXqxqXyCkn3JhgS5hlVcsEuHZy8w0JOTOLYKDRfIxZfSbj+hsvd1nHaHj2XxgnbeFKPDF3239Rirx7F6HKvHB3e89p+/AAAA//8=
// DO NOT EDIT

using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The breakdown of the refund.
    /// </summary>
    [DataContract]
    public class MerchantPayableBreakdown
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public MerchantPayableBreakdown()
        {
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "gross_amount", EmitDefaultValue = false)]
        public Money GrossAmount { get; set; } = null!;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "net_amount", EmitDefaultValue = false)]
        public Money NetAmount { get; set; } = null!;

        /// <summary>
        /// An array of breakdown values for the net amount. Returned when the currency of the refund is different from the currency of the PayPal account where the payee holds their funds.
        /// </summary>
        [DataMember(Name = "net_amount_breakdown", EmitDefaultValue = false)]
        public List<NetAmountBreakdownItem> NetAmountBreakdown { get; set; } = null!;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "paypal_fee", EmitDefaultValue = false)]
        public Money PaypalFee { get; set; } = null!;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "total_refunded_amount", EmitDefaultValue = false)]
        public Money TotalRefundedAmount { get; set; } = null!;
    }
}
