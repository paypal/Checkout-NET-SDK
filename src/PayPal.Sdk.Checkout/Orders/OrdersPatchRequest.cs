// This class was generated on Tue, 04 Sep 2018 12:18:45 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// OrdersPatchRequest.cs
// @version 0.1.0-dev+904328-dirty
// @type request
// @data H4sIAAAAAAAC/9RXTW/jNhC991cQcxasYFv0YKAHw0mRfuzaTdwFisSwJ+I44q6kYclhtkaQ/15QlJLINnY3bYI2N/txyHlPMxo93sI7rAnGwE6T8yOLUpSQwTH5whkrhhsYw+9Wo5BX2Kg2TkmJokr0SkpS6+nZyWRxcrxW7NR6Mp+fzd7Hf15Qgh+pPzioApuGRYX2oIdzPhkp1Xo6ezv/9WRxYI9q+cQsnhSKOHMVEhGt+OoDFeLHl+Ho6NtC8Kqi9id1QEmoB4AbLiuszHXzwyVUtJFLSIuTPkfUkjKk+FzKr9g+s+QwPjR/cFc+5JDvc7xivf0M6UFwwbpTbBqhpif6APdZhin0QeZnZCssDm/Zof11nGxwRYmeVqEx4p+DW6ZQ65cieLEcFcEL1yujn41sphzVfEMvSFo/vKivibbFLdGIajTVa2gNXxprTXP9mh6x542s+vZg95qoY83h/z3PLpYj09ywKei/mhf53rcif/QNhAx+C+S2c3RYk5DzML5YZnBKqMntoj+yq3exOUo5wG5hsbXRKnhxprmGDN6jMzHlYwuxMhoy+IW2HbjnJRYlqZ+OFW9a79DZCe6cwQgymDiH25TqKIMzQj1rqi2MN1h5isCfwTjSMBYXKIO5Y0tODHkYN6Gq7pYphrykQ+55zztvs0O7tRgrl7YMuO+uDIVMGoWRapTy8/nsXedVOlsSNaG11VZZdGKw6hS2C448B1eQ39H7/Wf1dsBjwV8uysZxPRDVAftFSRo4eom2IrE8gu6aRGkuQk2NqIqL1t6oeIr6VJpozljFnm3jb7AKNFI9Z7VhlyxijFgr7u3Rk+p8QHdb6OzLHWkH0tu/+8LvWUUpBde2oid24j9naFHK3Z4r/315UB6K0ytK79sLVSB1/b6+tiEGAntkX2G7cv/ejFTE1mkgPmodpZm8ipcJl/gp7NruORQt72KUt9x4SudEOIMptxa7UxsJmvSo8w+eG8jgVMS+JSlZx0kzWUxPIc1QGEN+8yYvSio+cpA8XbTy235a3kEG5x+Nved08pelQkift1ehKWuC8Zuj7+6++RsAAP//
// DO NOT EDIT

using PayPal.Sdk.Checkout.Core.MessageSerializers;
using System;
using System.IO;
using System.Net.Http;
using System.Collections.Generic;


namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// Updates an order that has the `CREATED` or `APPROVED` status. You cannot update an order with `COMPLETED` status.
    /// You can patch these attributes and objects:
    /// <table><thead><tr><th align="left">Attribute or object</th><th align="left">Operations</th></tr></thead>
    /// <tbody><tr><td><code>intent</code></td><td align="left">Replace</td></tr>
    /// <tr><td><code>purchase_units</code></td><td align="left">Replace, add</td></tr>
    /// <tr><td><code>purchase_units[].custom_id</code></td><td align="left">Replace, add, remove</td></tr>
    /// <tr><td><code>purchase_units[].description</code></td><td align="left">Replace, add, remove</td></tr>
    /// <tr><td><code>purchase_units[].payee.email</code></td><td align="left">Replace, add</td></tr>
    /// <tr><td><code>purchase_units[].shipping</code></td><td align="left">Replace, add, remove</td></tr>
    /// <tr><td><code>purchase_units[].soft_descriptor</code></td><td align="left">Replace, add, remove</td></tr>
    /// <tr><td><code>purchase_units[].amount</code></td><td align="left">Replace</td></tr><tr><td><code>purchase_units[].invoice_id</code></td><td align="left">Replace, add, remove</td></tr></tbody></table>
    /// </summary>
    public class OrdersPatchRequest<T> : BaseVoidHttpRequest<ICollection<Patch<T>>>
    {
        public OrdersPatchRequest(string orderId) : base("/v2/checkout/orders/{order_id}?", HttpMethod.Patch)
        {
            try
            {
                Path = Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(orderId)));
            }
            catch (IOException)
            {
            }

            ContentType = JsonSerializer.ApplicationJson;
        }
    }
}
