// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// Refund.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/+xc7W/cNtL//vwVg+0DNAb2JU1it/Wnx2ncp76rE8NxDjj4gt1ZcbTimSJVkvJad+j/fiAp7eptE7fZ7F1z+hAEO0NK88YfZ6gx/zm6KTIanY40xblko/HoL6g5LgW9xrRB/zMVJWk0Hr0iE2meWa7k6HR0kxCEccBlrHSKjjEdjUdnWmMR3vB0PLomZG+kKEanMQpDjvBLzjWxDeFKq4y05WRGp7cb2S6VpKIrGqYql7Yh2obUFTDKtSYZFYCSQRgHsdKAEHOJMuIowGqUBiM3awwmjxJAAwhLFCgjAqUhwyIlaYHltD/9jNVcrroKViLPI8WooWeb01X31iaaaBIlqDGypOHi7ZvJi2fffLs1hJv7/smMqcjMuLS00t5vM8Y1RXamydhZNXjiBpvZEdgELXBG0vKYkwFbM+1vsojVecsgMhfi1/FHrXKPIm9ao6J0reA5Y1gnPEog5avEwpJO/5Y/ffo8yoX/n8IvwcOvMwneFqR9dJSqOU0FvyNY/Onqr4tgBNQEUlmwRcYjFKKAWIfYQTEND51VT229AxhFPEWxmdH/rpvXr2rvMvmS8XvOyK0yq8AmKjcomU1M/+tmlYY/Ku39pEvjg8zTJWlQ8UaQTGBEplwQjQgZgyGC2x8q2g8uEH5r2OwjMt4/IjYiTWhpbnnaWi8NejdOGFrywOBGjIFLuL2QlrQk2+RBgLf3TxJrM3M6m1mlhJlysvFU6dUssamY6Th6/vz5918Z8s6dHE9PjqbwliIlmfG+3HhinXBBtcABUxulskY0LYWK7n7JlaW6l43VSq4C5bWyVXTP6nQICL3KBWqgh0yTMS7qMq1cQBlY5Zx5iFvmFpgi4yNb098psoBCAJf3KDjzxtiEW1ugTwTER65/3tyN/M+uR6+wuEIxWZEkjZYYXLzy0W03e9X0QOLKe8UjmrfFrpO74p9dXYADFdKT0kkM6MFFJHpnuLnVMg5qcQNKM9JTOMsyQm1cFC+VTbzKGRakvzb1HQ4SbqzSYUN0YyhFLkwAnM0c0BQRvyezZ3P9zOUd1PXuGE5weWcaNqsoTXOdSUAnl4MzTcI7+/ans5vzN2dvwU+p0AozPtMUk4Mmcr8mmkympCEz+ypBSwrNxM9oA9bJ/jd3ktHcuiF1DUlGN4HWDYmUGEe325DzbNjSrHLbQsrtBt/JeMTCA0V3oiluaFASevIvlWaCLIFFvSIL765/nsKNghTvqJQ++M6F/dgNX3IZOCnZRDFYcx/M3MDtu+sLuKE0czMmAZItsY+i8snxt0+PfExMwW2KmSa3vCIHh3LlcD8SOQsvXfzvYgyLJ4uxXx+LowVscikz9YC6cLougIck6I4KqKLO6aqkyxP9YvIh5fbV0gRBx6APOgca5zhpPflAjvPR1A1AT35ECI5dZswo5pIYLAu4vf7xB3j29MXJ1gfr9XrrAR1H7p8bMbUP9mharv1lmUI6E5WRcTADuKBqKV+Supr/dHNzVcXhZvO2O6L3QBpoEg3xw++eUsAb1wvoYN+576Mr5fj7777b5C8vjqoU2pC+J+OrIlntqFg6z0V6LjFd8lWuciMKYA0XG0pRWh4ZB9SVz11aRHDrd4PrUkLTiiGU6GVDY/hKuvLLzNzcSaVS++f0walx9Dl2rLdRQil2fWEq+tYdG1JfsbwFaldV7jH6txuPWrrsradsZoyHvHLOLaXNLXbLvCh57c22gO0Y8A/Ys51RiLmKvWw9wntmU2Qh3sQfzApMvpwEb5TI7e2e5saCz2p9gr9CLk1IduvjPzEPaOsmiw/o5plN3WSxR92U9GcYqQrV5GfScVfc+d3CB04z5Jr0pqb7jazdkmUkWSi9W6I1GJ9Ttl0gH2tcOcibazJK5GWqvBWx4l/X2V3EqYbB9jHTwxi3izF8B7J4NNmzVA5Z91Na+BF7XiqXLp/akZt107KPVQUuT42UtPRgJyQjxbhcgV/jBzirXHKJuphX721IH3jnW1ZfdSAtya7cIT24zIXlWa4zZQg2BzOXyAWcP1iSxoEHPLm8uDw/givUFt5IOnUpforWOW87h4zBFcFLxTiZj6ZBz56+OD46UDrXycXtx9Pw322fm7U6BR9+4MR6lCVO9mOJ948ADama5/rh92fdGyTt3pkDsyGRkrTnnXk7fs8osyvgMrTJ3FjUTVs78tuS2oo9BZhloghFeJAV/Ek0gVMDZUTma3h3fWHG4B/sWe53rXj3Z/IH2nwytG4xzLPt1Jaqjn1V53aXWzkKtg85lPQ7pN4t7r7X5wdrnlCwvO1WPi3GUP8M9c9Q/wz1z1D/DPXPUP8M9c9Q/wz1z1D/DPXPH6D+2YlV3IoWWJWUrvlCcePY00OJJ5WluVVz38HRBpIGp682Q1M2pNV6Zf4YTSVBWLembW7mjKx7966e1u6w2re7NqunZSzwqo+ZZf9rmPj5043gpdbn35K006frpKjLmmD4MLu4On/96uL1/y9ccbT48ezi5/NXiz1p0gnZS9JRgtLCFRZOH3ipCe+YWvd0ABkSgrSLVUecL2sja67aPahriA236bbP3qq80sqYeU/DcosxtC0PbctD2/IX27a8Ax0k2T5saJAHZBiQYUCGLxYZtmt9m8HsKMb7hu7AjQ9kQ/VKfZsV+fAym+Rfki2RZQrXZHMt/Z8skGysklYKzA0wHvsuawuxVmnv4NCfDxhFHrjWCWnaFAgEiRLMr0WuwT3V7K8hewcIR0rek7bE+qC4hzkA8gDIAyB/sYBMD65MXdFco6Wev95osWt/wtHidEOmGgFuRLA+I0s65bIM9xI8rIISeAKOKlkDGasApbIJ6d+3On4XXhiV64jm1QubhXiH9wfEjE/4fOHbF/pN0+X9V5nmt+Bp+ddB2720TD/Of8n5PQoKy8KthFxyW2UTIfa2epWfviwxt79WcKv0Bo28AOFQ3j3LKvjmGBhfcWuqE33twbx8wQbFFJd2/4di/SlJdabVk5B0WEM6MqQjQzryhaUjj8OIDMU8Jmrjw5Y8YMOADQM2fLGlSibQxkqn5WpvA0SN2/qO3uLsPiCqRoZFr610AUFk/J9pp9xfJmHGjrvU6o40rsjzP3zjwslwI9AAggMIDiC4FxDEgmi+REO9OdKW18iRdqRHVW9HBV9p1bSwTtSmd8Vz/Nm0B5A4FzEXIpDLm1hu6nO5ARRGwZ1Uawll74WX4QC4IThJ276Dpk7tafvKl4JH9XtzvLAT30JfKjUJFysxwCybwoW0WrE8ClcjmDzLlLaQG4IIjdstKgB9qZHLG00EtXAJ1Xj4LjAuPwiEjwEL30Q0R8Y0GRPaVCoJ5pz5KzjcusN75MJpfaBzDS9W8/CvLmivVbnvTsUACvwfxEKHFJRzPv2qp3eZM/7Ji9p1JR4sUAi1JgZLipUOzdLPjo93jcLY7RDO6eEdbtWGF/xf+dItBQxfySn8pNZ0T3rsZ4V7lxwEYhRR5kIkxQee5ikIkiubBGCRTe2dI58dv+jctFJ1IN6TrvYYB4EScumNxB4rJdADN/bffIFVLXRbTe51+q4rrcoOuotX1SbmcAVSNHfEnIH8xV79H9lKkHchKN2m4VzgVmfVm6qZz+44lWZvzzOgyb9hKQogGenCO9anT747VHOyqAu4dwpLf3j2Eg09f+bm5ibggm9xry5NMbnY13HaI4plqyyKeUhG+z/07RoxZI9D9jhkj1/w8drOL16+DbanObg3PgKrgt8IM5vrQ2UjecZ6775s0oe7L/9z7758/+v//AsAAP//
// DO NOT EDIT

using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPalCheckoutSdk.Orders
{
    /// <summary>
    /// The refund information.
    /// </summary>
    [DataContract]
    public class Refund
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public Refund()
        {
        }

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Money Amount { get; set; } = null!;

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; } = null!;

        /// <summary>
        /// The PayPal-generated ID for the refund.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; } = null!;

        /// <summary>
        /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [DataMember(Name = "invoice_id", EmitDefaultValue = false)]
        public string InvoiceId { get; set; } = null!;

        /// <summary>
        /// An array of related [HATEOAS links](/docs/api/reference/api-responses/#hateoas-links).
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<LinkDescription> Links { get; set; } = null!;

        /// <summary>
        /// The reason for the refund. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [DataMember(Name = "note_to_payer", EmitDefaultValue = false)]
        public string NoteToPayer { get; set; } = null!;

        /// <summary>
        /// The details of the refund status.
        /// </summary>
        [DataMember(Name = "status_details", EmitDefaultValue = false)]
        public RefundStatusDetails RefundStatusDetails { get; set; } = null!;

        /// <summary>
        /// The breakdown of the refund.
        /// </summary>
        [DataMember(Name = "seller_payable_breakdown", EmitDefaultValue = false)]
        public MerchantPayableBreakdown SellerPayableBreakdown { get; set; } = null!;

        /// <summary>
        /// The status of the capture.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; } = null!;

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [DataMember(Name = "update_time", EmitDefaultValue = false)]
        public string UpdateTime { get; set; } = null!;
    }
}
