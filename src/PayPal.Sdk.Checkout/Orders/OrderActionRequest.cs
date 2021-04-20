// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// OrderActionRequest.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/8xabY/bNvJ///8UA/fFPwFkO7tuc719t3WubdomXeTpEOSC9UgaW4OlSIWk1nEO990PQ0qWZdl53DOKAJvVzJCcZ/5I7r9HLzYVjS5Gf9qcLFxmno2GZ/SuJudHyegVWsZU0VMsRWqUjH6nTffxiFxmuZJBo4vR3JSVIk8OUAPGqZbGypeR6SejZHRpLW7img+S0TPC/E+tNqOLJSpHQnhXs6V8S7iypiLrmdzo4s1W2wo3JWl/7UxtMxrqOeB3Wg9YfRteFASNCEQRyGnJmoV/dwZkaPOh2g21U7YhHFdRBMAbqB3Jf8ta54AtdwJz1JASIGSWcvZgLOSUchx3d9Zgnlty7roy1os5Q8sOSHRWpqwU69V1I3TY4GYgsPZkNQoLFVTGeVTQjJzAE6ycOOLNZaS8QsV5EH5CHnP0+PZe4X3lLqbTFfuiTieZKacrY1aK+OxHPVWcNrOxrmo/XfMNT4/Odh9Q5/Driyd/wA+TM3hzWXuzjOZI6peQGe2tUe4CfEGAtTdZUyWA3ltOa0+dSuv1erKeTYxdTV88mxa+VD+cTR1lY5nLTYTwHXZLBPK4XWLsCxrvrjDernD/7mLduAIekUdW7nio861AF+khbxhpbfR4G23Mc25C3YyFZiz4Aj2gJXCmJM8lOdBEOeWh5wQfMOqMErDsbhLJfeMLsuAy0mjZOFgXZAmWrGm8ssh6uwZr8WyINJS8KrxUUZx9Ak+N79Jxzb6QxUqjwRdsc6jQ+k1IC1ORbprIBJ5RXusctW+HhJVJ5W7yr/rBg1mW2mn4hX42Fug9SgwTWOxXzqQlKNZ0fbYAdlC7GpXaSJ2bMuVYHWCW3ejGaRPnLZG/1nWZkl0ksGgJWNIiCVq3JL+paHF3eeO8Zb0apktas8ql+kWFflvY4/RT5RKEnIMyWTC3SQhLlSVH2rtQcJWlkh1N4OXWRe20YbxkRXQGhKRRirLWea2gixHDNsz9cRPoxSvGMjM5xWDOLd6Shl9N7SIlm3bMb/WurpX6T/JJF+ek+Jbs5tqRveW9/fAAc1iTrRA0QhO4Ms6DWS45I0jN+wRSXDUeCaVW7fDFYScydSede1b26UMDIz9qCr/VzsPika3tZgGsm1/hD9TfXhBfaEdw6EFLWs5xW2J6nlRf6RmHtG3oR3UV/l4hSdnUlEBqakW3aPMErME8JBe9lyJ3a9ycyrw6vW7bQd++PmNo4JKt8+MAf4G0Z7+BlJRZAzb9a9uOjN32soOtzNXp+EA7c6xXirpppFfJTvYFzWwHJy4V+gScN3aTwFIZY8XtpgxuR9naArC8C6+//Qy/9/e6g1BiyzriexAB8UDAXy1O7KVatwHEdNxjL87+NoPdFgCtcQFpCAyU0Nq46XfAI3wK9oCsoOxG0Kk0FoFrgjVEn2WtOvB6mlTu+e38uEvPD9crZUbnn+FTV7OnXtKctiH1bJkdN3N20MyI5A5YmQAvt0Cw36/aXhbRd7BY0uMnix9YJZCzbarR03upsTorAB0sNL33cmT5J6oSrV/EUgOFOi/R3sgGhBoe65xRnzxXStbXaAkHxddjDB1Y8KogKT66JRVaV8637MT8pjnVUjEJrAvOij6Gray55QDcnUdPwR+Pn/85np09fDg+l8nauUIISoyObo6CLVTZL+L55SIUpDYeFnNUvDRWMy4m8ApV2Gg2nVbsLiJYq1VEavFLcfx6+fsELqP0pkHv05a3J/lcJIMdHxeco8YcRbg1/+Pyv2GFOorTkjJf208MeL5m/4GspJUMu0HtjT48ZNpaffIsOz+WZecH8H/GfpOAN2sdUuSWlcIVTeB5iUqRlU1UywloO0lIxuuzxemrZ3bMrtkBu6RaBAmoYJ+r09qmCWjiVZEaWxgTQVDOsnDmP2nweZvjn0rr2Kom8LxZMkW21oTFdlf/eJ6FRhXm2Bqxp20HtXvnbHahNlGtceMAb5FVOGGntZfmemQ+yFroEs8n4goQ4/9qqf39sRT4/vAtSC/c64B/vyTos4WILwSftm773DSI122hmTpjvYBKObKGJvtLTVY7ilCnRL2Bny3prABP1rI3lsl1e1vD+6Vm1PjxtIl4rb2IoRyCRWIter6luJE42TzmBeu/RnSb7eJavNO/tu0zhtF949dmnBVoMfMUdjcIu9tZ8PTbe9PcZG7K2tPKhuqYRvgwteT8tJl+LLJuej+eFjiX48WSKZ4WGhlJAksr3rb6VJns5l1tPO06znlr9CpSnhpPTX5Md+nwYmfaLiEsoYefLAdMy25wAfLLT4Nrj+0+vC/78vcDsgINKIcGMXtTjSOoyE0pS0ofcUGV4IZGQTkhURiwmJ8vhmqHJIK1sSpfc0MT4IY29JxaN5eqinKoLGcE9+Yvr+5DSb6QgkxR34RL9Hhnllnj3DiNxzxvUbv4/NHe7U333f4lCept/XX5GYt4mJ59+qG79lD8wt8BaOLMD1xFHwq0elfzLarwzvBiU3EW4JvdPRpFt0tKNofOnZkhPgztzvKcCN7siHT34qQna77himRvMXYVb+WvOjvun+xIKkEf3nPsUocODa80mvza2BuxO7URhVWVCvVqmveZJL7OJLDipY+ZtfvQcyrYT+8rtpuefVvS0LgNoY3bgdG+SKRQBa3/+PDBGSxev379evzkyUJOyaHKSmwD/Tg85JCPLJnAc9nKdKH3xig3YfLLEPjCl2pql9lsNvv7dy6eqMY/TB5+WQJ8dUlx/32OD7/OXeHmCtV4RZosesrh8aOmQ9GdvLx9prIKnb/OecW+/wrTpw/VFz5Efnv83U3DE2k/uMM9enkbyqswKif7/y4CS3TAHrCqCK0Do0/t+gMXtx+5sa0sl2g3gFnomO2F1L2ry6f3t4nz1SH46mR3lNWW/QGAs885dINiicbS7JamtuOQTdAOazaAZRcVuFTOwI02ay2xE/r81asE5q/m8uOp/PhHQMDzx4/uvNd7c0N6aH9L7uxuKQfsFQ5/oHz/rweGr/L/8ye1b29SwZrTJNlgKz26izYubl5lAxCLmK8zQXT/wvw4ovjb8O///gsAAP//
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// Completes an action for an order.
    /// </summary>
    [DataContract]
    public class OrderActionRequest
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public OrderActionRequest()
        {
        }

        /// <summary>
        /// The payment source definition.
        /// </summary>
        [DataMember(Name = "payment_source", EmitDefaultValue = false)]
        public PaymentSource PaymentSource { get; set; } = null!;
    }
}
