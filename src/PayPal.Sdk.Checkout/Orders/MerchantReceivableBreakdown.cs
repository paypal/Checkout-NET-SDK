// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// MerchantReceivableBreakdown.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/+xZ328bNwx+319B+GkDnLhNmw7I09pmxbKhbdBlA4aucGiJ5xOik66UZPc29H8fqLuzfbaLZVtaYK2fgiP1g/zE7xOt/Dm6amoanY2eE6sSXYRXpMgscGYJnjDhjfZLNxqPfkU2YnyBlQwfjUc/UbP+OKeg2NTReDc6G12VBJoiGksaZv0q4AuIJYHCOiYmDTU2Fbl4PBqPHjNj04Zybzx6RahfOtuMzgq0gcTwNhkmvTJcsq+Jo6EwOnu9SoLeSQ5zmjJG2g16273OYNuzm04/AmQExBKjZEhcGUchp4WVTy5C9KC8WxBHKNhX4B2BSszkVCNOdD6WxCvb3WUfIhs33007+MSKpv2Gg8R3fbupv44lEx2pEhlVJIaLn18ePTy5/+06L+U1vfl6or0KE+MizRllgYk2TCpOmEKc9IOPZHCYfNOCaDS5aArTgXhXqLhk7fvx30ITkecU90Oz6/uioFmgTUOS9JZdGFqo1jm3VDiG798ms0BLLS2ECcmZ2OtAW3vrvOCZ5wpjJA0YIGNFDJ5BkzIVWsgBwNLEMq8VPdw/BW3mJgb5kDXZzMvVBv282pv/rjIZtjcbwD33jppd3ObsQ5i2CAzg23LsoriGz+leTQrPgFAYh04ZtBAZXUAls8YQkioFKoQZWnSKBKxOVEEn+vjS0oc8lcIdZLvt+R9yJ3L6+NTJnjEsS6NKqHL1zujs93Tv3gOVbP5L7Zc17ddjt+KGVEeXmmRqzQ3B9Y+Xv123ICATOB8hNrVRaG0DBbe1g/a4XXTSr7q1x4o7/Yz9e129ON/YK6SZNgujSUuEQkifAjody7B/u0mf4TPPLX078MGlaibkL9YktqgodIQYVMgYAhG8ftrbnkoh/NOyuYvKuIU6OIr7tGFgPijDQRkOyvClKUONTY12WtCwPgbmgzIclOGgDJ+tMtQWY+G56ti+LRAb3jDUiC3PsGIeO0AJUoDpR7ak5+ikIIjCGJSvKhOC8S6MxTtjf0OMc8r+7rxC8Mqg/EDLP8Ju8Zjz6N/rxwd0ck/3dOicDvp40McvQB+xIZrOMNDe9mntG7RPH+ic2vfpNnmBqeofwJelB86P4F2hF8npkAWkSLYw1rZmz5r4GK4255oAaIOHG+eXTmREBuYYPoFuWEMuTo0easaGdReEOs2sUXBxvoIhB3skotcndaSYsuZjXR/DhYvsdVKkIXoIqa49R0hBboIgF0kvoE8YjbtiItgol/beuMTmEq0QlLjbEa6pQmOnqDVTCNcSwHUfwdToa4FWeIcLNFay/kTPoDms4f8KNgPdi6okzA5bUTB/kIY8B7o5HW9n1qubt8lH2qRviOzdvLW88LGXrcmmHX6pBfxHD2El9CGLBVrrl6RhRoWXT6fh5PT0Q6OwkBtCDr3dQ1jbbvBdt+naAsHM3TH84Je0IB7nWXNyxFkCUSmqpUQqfGeqVIElN49lKyxumL0c5MnpZugth2qMghosiPs7RiTQQXIZJH3bKIHemRBX6rgN86cpm43SHRTP0L5bOi01MicYLs77S0x0BSoMN6QFIGnT+kfubgYqlZubTuSlBJ1cGnIEws6uYTOsc+NnqIN9e14AprzDzDZATnGTDza3T1Czr9lQRG5gIQm7/Nb+BAM9OJG5KbS6QE4Opbt+QrJ39fp+i9/RvPr/5b6Htn3eQ9d46BoPXeNn1jW+ef/VXwAAAP//
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The detailed breakdown of the captured payment.
    /// </summary>
    [DataContract]
    public class MerchantReceivableBreakdown
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public MerchantReceivableBreakdown()
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
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "paypal_fee", EmitDefaultValue = false)]
        public Money PaypalFee { get; set; } = null!;

        /// <summary>
        /// The currency and amount for a financial transaction, such as a balance or payment due.
        /// </summary>
        [DataMember(Name = "receivable_amount", EmitDefaultValue = false)]
        public Money ReceivableAmount { get; set; } = null!;
    }
}
