// This class was generated on Tue, 21 May 2019 11:25:19 PDT by version 0.1.0-dev+8fcb5f of Braintree SDK Generator
// Name.cs
// @version 0.1.0-dev+8fcb5f
// @type object
// @data H4sIAAAAAAAC/8RUTY/TMBC98ytGvuzFqjj3Vm17QoLVqsABoZXbTJrROuPgmbBEaP87SpwmzaZ8qKBya549z+89v/q72TYVmqV560o01nxwkdzOY/e5NMaaN9iMH2uUfaRKKbBZmm2BwK5ECDlogVC5qM3CWLOK0TWJ+LU19+iyd+wbs8ydF2yBLzVFzAbgLoYKoxKKWX4aJIlG4sNclPOKkZ3iQ157/8BJ+ajz/PpU+npzd7+5XW036wVsj9JvBIbZztgCbh3DDsHBrhZiFOlwC0z7x/QrRHDcQNACY0pDC6ewd8xB21mpPCkQa4CcoqgF70R7/mMU8FQgjyECycmZfxsp194/29/mej7Nn2f48YzkCqMEtiN8I9AyJLvX8XGgr8hzIxP4MicdRXfl/U1e0VVJWeZxbmuKX+YrcfSVfC8IzksADSAaIkJZe6XK4+k+AeK9rzPiQ0+lMXBT0j7l49r/w43YCfd1kqoi5vRtEtIAzR+wtNSJVlKPtvV9Gs4VlUudv1Q+QHPlaQnyVvn/0htnfRyxy7rYz6cSleSbvpartpKPHJ4YnHQTf/qMplN+Wez+0JelLqelLsOx1P3+fxLz5+dXPwAAAP//
// DO NOT EDIT

using System.Runtime.Serialization;


namespace PayPal.Sdk.Checkout.Orders
{
    /// <summary>
    /// The name of the party.
    /// </summary>
    [DataContract]
    public class Name
    {
        /// <summary>
        /// Required default constructor
        /// </summary>
        public Name()
        {
        }

        /// <summary>
        /// DEPRECATED. The party's alternate name. Can be a business name, nickname, or any other name that cannot be split into first, last name. Required when the party is a business.
        /// </summary>
        [DataMember(Name = "alternate_full_name", EmitDefaultValue = false)]
        public string AlternateFullName { get; set; } = null!;

        /// <summary>
        /// When the party is a person, the party's full name.
        /// </summary>
        [DataMember(Name = "full_name", EmitDefaultValue = false)]
        public string FullName { get; set; } = null!;

        /// <summary>
        /// When the party is a person, the party's given, or first, name.
        /// </summary>
        [DataMember(Name = "given_name", EmitDefaultValue = false)]
        public string GivenName { get; set; } = null!;

        /// <summary>
        /// When the party is a person, the party's middle name. Use also to store multiple middle names including the patronymic, or father's, middle name.
        /// </summary>
        [DataMember(Name = "middle_name", EmitDefaultValue = false)]
        public string MiddleName { get; set; } = null!;

        /// <summary>
        /// The prefix, or title, to the party's name.
        /// </summary>
        [DataMember(Name = "prefix", EmitDefaultValue = false)]
        public string Prefix { get; set; } = null!;

        /// <summary>
        /// The suffix for the party's name.
        /// </summary>
        [DataMember(Name = "suffix", EmitDefaultValue = false)]
        public string Suffix { get; set; } = null!;

        /// <summary>
        /// When the party is a person, the party's surname or family name. Also known as the last name. Required when the party is a person. Use also to store multiple surnames including the matronymic, or mother's, surname.
        /// </summary>
        [DataMember(Name = "surname", EmitDefaultValue = false)]
        public string Surname { get; set; } = null!;
    }
}
