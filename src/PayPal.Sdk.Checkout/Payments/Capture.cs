// This class was generated on Tue, 04 Sep 2018 13:47:44 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// Capture.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/+w8628jt/Hff3/FQPkBOQOydLk7O4k/1Xd2Grfx2bB9BQrXkKjlSMuaS25IrmS1yP9eDLm72pdiJyc7bbIfDEMzfMyL8+Bj/z24Wac4OBp8YKnLDA6Gg78xI9hM4keWEGIwHPwV15sfJ2gjI1IntBocDY4hCh05pGydoHKjwXBwbAxbh4FfDwdXyPiFkuvB0ZxJiwT4MRMGeQm4NDpF4wTawdFtSdK5VrhuE8QSnSlXI6sE1Ym7iRGizBhU0RqY4hDawVwbYDAXiqlIMAnOMGVZRL2GYLMoBmaBwYxJpiIEbQregGe4O/6sM0It2gwWJE8izbHGZxPTZvfWxQZxP4qZYZFDA2fXF/vv3nz19UYQ1Pfu1ZjryI6FcrgwjAYYc2EwcmOD1o2LxvvU2I73wMXMgeConJgLtOAqov1FEnEmawhEZVL+NHxUKksms7o0CkhbCh4zhFUsohgSsYgdzPDoH9nr12+jTPr/GH5JEX4dK/CyQOOtI2eNOJXiHmH6l8u/T4MQmEFQ2oFbpyJiUq5hboLtMDkKg46LURtzAMdIJEyWPbrnuvl4UpnLZjMuloIjJwo1uFhnlinuYts93bjg8DttvJ5MLnxQWTJDA3peEpJKFqHNF0TNQoZgEeH2QwH7QIbwS81mF5Zx9wTbiAwyhxMnksZ6qcHbdsKZQ+8YqMUQhILbM+XQKHR1HEkoYe7uVexcao/GY6e1tCOBbj7SZjGOXSLHZh69ffv22y8seuXuH4wO90ZwjZFW3HpdlppYxUJixXDAVlrptGZNM6mj+x8z7bCqZeuMVosA+ahdYd3jKhxuvPYXmWQG8CE1aC1ZXWo0GZSFRSa4d3GzzAHXaL1lG/wnRg6YlCDUkknBvTBKc2sS9JkO8Ynrnws7y4xF8sOTpOkZu7Btfc8zknG5tGKUHLSCGcZMzmld0HJJ0EQx+/xA1uBrprVEptqMURySk6iMvxummpg6Q2eKi4j0AqsYXYwG1jqDiClI2D0C41zkxpWPYIEtmFDWeTZZ5mJtxL8qkRuu0YHTMKWlOAUx9yNy7a2C1jytBl0MV50hH6F7Bu8nNoN7UZWjf+6wL2N8gtcU43+2zeuSrS+Z3F+gQsMccjg78a7VB8sdp0lPJVwttYhw0mSgCm4zcnx5BhTb0OznvoIDPpBjZN4nUN8imgQGhQVtOJoRHKcpMmPJmc60iz3zKVuj+dJWEy2IhXXahLyM2mDChMwXZ9kHDEYolmh3LK4fhLqHKt8twUmh7m1NZgWkkQArYEQXeQ+D0qv99vvjm9OL42vwXYqgyVIx1ks0S4Gr8Rcxc6iZ3fdNmoHycPdJJarIt6hytIG1TSBBLhglOUiaDJmU05SNJMKVaQVaHyjZC1lzbHBe4yAHdKT9OkklOgTHzAIdfLr6YQQ3OrjGQH3QFZn5kJrPhMLc/7tYc1gJb7zCwu2nqzO4wSSlHvshE3DIH00GDg++fr3nbWAElIulBmk5RRSF1YLSjUhmPEw6/f/pEKavpkO/HqZ7UyhTeDvycXxKvE5BhNz7HtdQWBnxqhWVJ37xeIuidC4XQeAx8MNIgZYUp5wHv5DivDW17K8K/TkLHFI9xnEuFHKYreH26rsP8Ob1u8ONClar1UYBZh7RH7UYuQe3N8qX+iwvXEhCuWG8GP9kUw3mc1Cb8+9vbi4LMyxTRrfFeF+IA4OyRn743VGAeuF6AsnLk/oeXSgH337zTZk1v9srCjeLZklJiwWmilDKcuWRoWeKJTOxyHRm5Rp4TcUWE6aciGyR1YVleE01jXf+VzmFtmFDTDFPG7NWLJTPPsbUd79gqflz9EBs7D1HgLqOYkxYWxe2gG/UUYLaGqn6adBml9a/CTt6RjVDx2ZNmcydOUzqAbWNqxO/W4keSwkXc6CpOsiU8qIeWQrI9mhvs9l+EHvuob2Ak8w68EWTrx/zvJUccLX9Z4b7Jmtq/TOsqXWTtRyyG9a08jtkiQ57Fc/E4jb78lHBW1Hdturw57Sr7ZSlqHjY2GmQVkM8J23bnPncsAW5tiu0WmZ5AlypO7vQv4UMRctniE5PcayAEM/gg3dTGPgWO14R55Qebcm02lnWYzk+ZZ2RVg4f3D6qSHOhFuCX8gtseM+EYmZ9mk9bI76F6kr1lUPVJjsE+/NMOpFmJtUWodzcO2dCwumDQ2XJRcCr87Pz0z24ZMbBhcIjytcT5kh3mz5oLVsgvNdcoH00qXnz+t3B3gslZ66ZWbvHk+pfLZ+blT4Cb31AZD1JEoe7kcTdE3yG0vWzofD7Ob3XhcLt4VcrbITfArK78Ltpv2Mfs83eUubia8dMXdJVaMPyNLA0letQTwdSwZ9lIBAXTEVov4RPV2d2CJaG8Cj6XanD/anO6GUiT0olvlGVng1OW9jfIj6mW8h7XrrunlqnhCLjul2tNBB9zdLXLH3N0tcsfc3S1yx9zdLXLH3N0tcsfc3S1yzPVLNs9UjCyYZLyiFtnxQKEkLv3Elco5Ro4NJoF47EOg6AfJNJWm1SOQvqwHZwgEuUtHI37UDP52iQN49bw70WaBHmT+TO8+tSjYO0lK1TJkeRTsaZHa9wxtLUjpM0HVuMMiPcehzo3N/Mv/f8YZsLm2YOJxFzuNCmled2obc7vUirUA5WLpVFeullWFz8qdx5eSFPZx1zWZ2vEvTYFbIGxSAsoBQLMZP+DiQEnVVsZufmX9gTXPmrP8QXvDfI7rlebV8Kpmw8mVUatxbFlnYdV0PRMSFpARTNipPk57vwfvpAnC8QrpjruImPOXpiArpykaeBabNTtABqEYyVo0OTCJWfmOd3450mq16icTA3OvGxurwY7DQwpb2h/KrL379qyVqdmQgnxYR1rbZw/4NX4j8jh/Y7Yt2iaeP+UKL5Jc8F8jtim6cifimM4PTHTCyZxLAsaCVkSrjCDwTb2/CV118uxM/iNYE25WV7T0DIDWksp+GrA+BiIZwtEkvj3yrkE5SX9LXY0X3Rmp/tfl2zMNraSccbmwaif2nTv7TpX9r8bl/abPEOCl2Xb6iBe8/Qe4beM/zRPEOo9ydzxMauUwXce4beM/Se4XfrGS4lc3NtEvgOO3Yv0hxLvqCx9dvAbN9vK1qGRW+cIoNAtP4BTyL861Y7JOzM6Hs0bIEen+vLWh0J/3Ai36B/dDPnsP96Qe8fe//Y+8edZE7FzvZ7ZrEzg2onT1vyprA7bctDhuLNOqxiXb6Z9Zjw5J3cxzyTcyFlAOePdW+qfYUFJq2Ge6VXipxI8Qz3JbyGFKhc85lyFdoWQprNpIg26zoYP0tTCN998IdXVemMAzNwppzRPIvCqzqbpak2DjJL4cCihVc0Do4WI3hvmFA3BhEqRhOiRzgU24NVjCYXU3jDPGGcG7TW3zDLZ54ITuKllceWTEji/IU2Qms01U8NGpi2hIW/W8GCe/CfCvB9IO/z+R+o+JSSBg7fVV67erfBpNQrUiDOtQk3fd4cHGxrxeYuP7oKc9D6DRP8KZ90AwErFmoE3+sVLtEMfa/wYJ+cIYsiTMlyEvYgkiwBiWrh4mBYqs49KfTNwbvWQ938oB2WaIpoQ85QQaa8kPhTqQR8ENb9xp/dqFhw44ZWFb7tWwj5K/6zkyKckY+BhNl75CQgG06dvRbyHiyKfJqTu/vwfYj8PJWWaHG3wnCfAgrMxd7sZ8Ggn2Em14AqMmuvWJ9IQWp0agQ6ZtawJIaV33Unx/z2DfXNbHAO/oJW8ejWZnJX+/BPqKgrR5UdSWMXts8f+/yxzx9/Z/nj3U5vfJB9BNRzXWdoGPR1mOwkJKzbSJ/wEt9koYLangdv4SVn9fmdlkFmG7ewSlDX6xZCwSpe/xzVFIaml6cfT84+/nlKbnh6cvrx7PRkOnqpC3FZyjs/q1aH959V++/9rNrdT//3HwAAAP//
// DO NOT EDIT

using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.Sdk.Checkout.Payments
{
    /// <summary>
    /// A captured payment.
    /// </summary>
    [DataContract]
    public class Capture
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public Capture()
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
        /// The funds that are held on behalf of the merchant.
        /// </summary>
        [DataMember(Name = "disbursement_mode", EmitDefaultValue = false)]
        public string DisbursementMode { get; set; } = null!;

        /// <summary>
        /// Indicates whether you can make additional captures against the authorized payment. Set to `true` if you do not intend to capture additional payments against the authorization. Set to `false` if you intend to capture additional payments against the authorization.
        /// </summary>
        [DataMember(Name = "final_capture", EmitDefaultValue = false)]
        public bool? FinalCapture { get; set; } = null!;

        /// <summary>
        /// The PayPal-generated ID for the captured payment.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; } = null!;

        /// <summary>
        /// The API caller-provided external invoice number for this order. Appears in both the payer's transaction history and the emails that the payer receives.
        /// </summary>
        [DataMember(Name = "invoice_id", EmitDefaultValue = false)]
        public string InvoiceId { get; set; } = null!;

        /// <summary>
        /// An array of related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<LinkDescription> Links { get; set; } = null!;

        /// <summary>
        /// The level of protection offered as defined by [PayPal Seller Protection for Merchants](https://www.paypal.com/us/webapps/mpp/security/seller-protection).
        /// </summary>
        [DataMember(Name = "seller_protection", EmitDefaultValue = false)]
        public SellerProtection SellerProtection { get; set; } = null!;

        /// <summary>
        /// The detailed breakdown of the captured payment.
        /// </summary>
        [DataMember(Name = "seller_receivable_breakdown", EmitDefaultValue = false)]
        public MerchantReceivableBreakdown SellerReceivableBreakdown { get; set; } = null!;

        /// <summary>
        /// The status of the captured payment.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; } = null!;

        /// <summary>
        /// The details of the captured payment status.
        /// </summary>
        [DataMember(Name = "status_details", EmitDefaultValue = false)]
        public StatusDetails StatusDetails { get; set; } = null!;

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [DataMember(Name = "update_time", EmitDefaultValue = false)]
        public string UpdateTime { get; set; } = null!;
    }
}
