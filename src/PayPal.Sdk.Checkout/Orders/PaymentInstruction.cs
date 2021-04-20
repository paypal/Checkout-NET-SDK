// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// PaymentInstruction.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/7xXb2/ctg9+//sUhF/9BlzuuvTPgLxa2mxYNqwNtmzA0BUXWqLPQmTJpaRLvWHffaBs5+y7y7BuWdEXrSnxSD58+FD9vbjuWirOiha7hlxcGxciJxWNd8Wi+BnZYGnpNTYPX/qOuuG8WBQXFBSbNh+dFeeuA9TayCdaGPxh4h+g8gxX2F2hHf7J0RGDSiH6hjgs4SsnOQSoCGNi6l3a/l4AdBoa5FuKrUVFYQEhqRowgCaLHWnQJpSJA+XYcl15aymHB18BQmsxVp4bqIiWcN621lAAndi4DXjWkg4TZgeJrbCVRPRYUADP4/XhLP9wirVn89vk4rJYFOfM2PWwP1kUPxDqN852xVmFNpAY3ifDpO8NV+xb4mgoFGdv7xsWooQ77NG02HXjNc06dOx03rLrmqBKTgeINUZAJqjJavAOSqrRVlJZrAkaYlWji/+2JJes/WOxI+LQi3VFdISBk9Mwq2z/ZJ+IgJKjJL9FNj4JnYQsyjeNCUGouIBo2rDIzfQut3u/YS/+ecO+9466w4qw8cnFWSn3psPOqMRMTnWZxv29zEiEyjh0yqCFyOgCZnrvZgGhRItOEeTZ6edQJ/rvCTmmvFb7ZNw/OSz3bayZ6ETVyKgiMVz++Obk2ennX+yAEN93/19pr8LKuEgbzo1bacOk4oopxNV4+UQuh9VnPbWNJhdNJaMeJ9B+FCKR01/T+SFUtmjTHI3RcohCPlnAXW1UDY3Z1BFKOvs1PXnyVCWb/6b+y5r+69xBxoK416u+NKnUmluCm2+vfrnZzbfzEWLXGoXWdlBxzx20y/5HV+Ov7sUATco0ItuDx/FY168vJrFCKrXZGk1aMvQQa58COh3rcDzcaqzwa8+5TzyADy41JbFM9JhIvwCGgZgxZAGBCN6+Gm2vhAgfS5vHYMa7qdRhR7QuMdDRVbs7m6icmI+SRFNEY/vip/IMd7UHJkVmOxC9V3cRkCrZyljbm/OeW8L11NcEQBs83Dp/50RG5GLO4RPohjX5raHnmjGxHoLQptIaBZcX9zDkZE9E9MaiTvIqJw3Ytku4dJG9Too0RA8hta3nCCkQKAzTx8RLRuOumQgmdIE7E+vh9SIDSjxEhBtq0Ng1as0Uwo0kcDNmsDb6RqCVucMtGitVP/IafQjVnNYM0VmiR1GVgrnfh2jzcyb7wOAzzG1pvbp9n3yk6fiGyN5testrH0fZWk3t8FMr4L94BvdCH7JYoLX+jjSUVHn5dBpOnz9/6BZWsiGk6X0Mmdo+wJdD0J0Fgtm4JXzj72hLvMheG3LEWQJRKWqFIg1+ME1qwJLbxLoXFjevXhp5+nyaej9DLUZBDbbE444RCXSQXAZJ/90sgT6YEO/VcR/mT0ObCXVn5JnbD6kzPOxlJhguL8YlJroCDYZb0gJQGF7iceeBSuXHzSDyQkEnS0NaINOZBy/WhnX+n4ChAfZ9vwBMOUJpOyCnuMuNzc8naNm3bCgid/lVKJLnK3iJgZ6eim8KvS6Qk6YM6yck+ziP3nf5z//+BAAA//8=
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// Any additional payment instructions for PayPal for Partner customers. Enables features for partners and marketplaces, such as delayed disbursement and collection of a platform fee. Applies during order creation for captured payments or during capture of authorized payments.
    /// </summary>
    [DataContract]
    public class PaymentInstruction
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public PaymentInstruction()
        {
        }

        /// <summary>
        /// The funds that are held on behalf of the merchant.
        /// </summary>
        [DataMember(Name = "disbursement_mode", EmitDefaultValue = false)]
        public string DisbursementMode { get; set; } = null!;
    }
}
