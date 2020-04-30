namespace RedisWithCSharp.Global.DTO
{
    public class Contact
    {
        public string Type { get; set; }

        public string Value { get; set; }

        public Contact(string type, string value)
        {
            Type = type;
            Value = value;
        }
    }
}
