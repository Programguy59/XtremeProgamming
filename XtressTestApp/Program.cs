namespace XtressTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OurLinkList linkList = new OurLinkList();
            Element element1 = new Element(1, null);
            Element element5 = new Element(5, null);
            Element element2 = new Element(2, null);

            linkList.Add_First(element1);
            linkList.Add_First(element5);
            linkList.Add_First(element2);

            linkList.Reverse();

            Console.ReadLine();
        }
    }
}
