namespace MyLittleLispy.Runtime
{
    public class String : Value<string>
    {
        public String(string value) : base(value) { }
    }
}