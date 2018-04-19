namespace VisitorPattern
{
    public class Man : Person
    {
        public override void Accept(Action visitor)
        {
            visitor.GetManMessage(this);
        }
    }
}