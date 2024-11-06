namespace XtressTestApp
{
    public class OurLinkList
    {
        public Element FirstElement;
        public OurLinkList()
        {
        }
        public void Add_First(Element data)
        {
            data.NextElement = FirstElement;
            Element Temp = new Element(data.Value, data.NextElement);
            FirstElement = Temp;
        }
        public void Add_First(int data)
        {
            FirstElement = new Element(data, FirstElement);
        }
        public void Remove_First()
        {
            if (FirstElement != null)
            {
                FirstElement = FirstElement.NextElement;
            }
        }
        public int Count()
        {
            if (FirstElement == null)
            {
                return 0;
            }

            Element currentElement = FirstElement;
            int count = 1;

            while (currentElement.NextElement != null)
            {
                currentElement = currentElement.NextElement;
                count++;
            }

            return count;
        }

        public string To_String()
        {
            if (FirstElement == null)
            {
                return "";
            }

            Element currentElement = FirstElement;
            string result = "";
            bool run = true;

            while (run)
            {
                if (currentElement.NextElement == null)
                {
                    result = result + currentElement.Value;
                    run = false;
                }
                else
                {
                    result = result + currentElement.Value + ",";
                    currentElement = currentElement.NextElement;
                }
            }
            return result;
        }

        public void Sort(bool IsAcsending)
        {

            if (FirstElement == null)
            {
                return;
            }

            Element currentElement = FirstElement;
            bool run = currentElement.NextElement != null;

            while (run)
            {
                if (currentElement.NextElement == null)
                {
                    break;
                }

                if (currentElement.Value > currentElement.NextElement.Value)
                {
                    int temp;
                    temp = currentElement.NextElement.Value;
                    currentElement.NextElement.Value = currentElement.Value;
                    currentElement.Value = temp;
                    currentElement = FirstElement;
                }
                else
                {

                    currentElement = currentElement.NextElement;

                }
            }
            if (!IsAcsending)
            {
                Reverse();
            }
        }

        public void Reverse()
        {
            int count = Count();
            OurLinkList temp = new OurLinkList();

            for (int i = 0; i < count; i++)
            {
                temp.Add_First(new Element(FirstElement.Value));
                Remove_First();
            }

            FirstElement = temp.FirstElement;
        }
    }
}
