using System.Runtime.Serialization;

namespace SOAP.Model
{
    [DataContract]
    public class Calculator
    {
        [DataMember]
        public int Num1 { get; set; }
        [DataMember]
        public int Num2 { get; set; }
    }
}
