namespace VisitorPattern
{
    public class Woman : Person
    {
        public override void Accept(Action visitor)
        {
            visitor.GetWomanMessage(this);
        }
    }
}