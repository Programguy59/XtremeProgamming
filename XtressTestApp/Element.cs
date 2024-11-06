namespace XtressTestApp
{
    public class Element
    {
        public int Value;
        public Element NextElement;
        public Element(int value, Element nextElement)
        {
            Value = value;
            NextElement = nextElement;
        }
        public Element(int value)
        {
            Value = value;
            NextElement = null;
        }
    }
}
