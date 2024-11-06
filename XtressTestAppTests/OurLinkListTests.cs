using Microsoft.VisualStudio.TestTools.UnitTesting;
using XtressTestApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtressTestApp.Tests
{
    [TestClass()]
    public class OurLinkListTests
    {

        [TestMethod()]
        public void Count_Empty()
        {
            OurLinkList linkList = new OurLinkList();
            Assert.AreEqual(0, linkList.Count()); 
        }

            [TestMethod()]
        public void Add_FirstTest()
        {
            OurLinkList linkList = new OurLinkList();
            Element element5 = new Element(5, null);
            Element element1 = new Element(1, null);

            linkList.Add_First(element1);

            linkList.Add_First(element5);

            Assert.IsTrue(linkList.FirstElement.Value == 5 && linkList.FirstElement.NextElement != null && linkList.FirstElement.NextElement.NextElement == null);
        }

        [TestMethod()]
        public void Remove_FirstTest()
        {
            OurLinkList linkList = new OurLinkList();
            Element element1 = new Element(1, null);
            Element element2 = new Element(5, null);
            Element element3 = new Element(7, null);


            linkList.Add_First(element1);
            linkList.Add_First(element2);
            linkList.Add_First(element3);
            linkList.Remove_First();

            Assert.IsTrue(linkList.FirstElement.Value == 5);
        }

        [TestMethod()]
        public void CountTest()
        {
            OurLinkList linkList = new OurLinkList();
            Element element = new Element(5, null);

            linkList.Add_First(element);
            linkList.Add_First(element);
            linkList.Add_First(element);
            linkList.Add_First(element);
            linkList.Add_First(element);

            Assert.IsTrue(linkList.Count() == 5);
        }

        [TestMethod()]
        public void To_StringTest()
        {
            OurLinkList linkList = new OurLinkList();

            Element element1 = new Element(1, null);
            Element element = new Element(5, null);

            linkList.Add_First(element1);
            linkList.Add_First(element);
            linkList.Add_First(element);

            Assert.IsTrue(linkList.To_String() == "5,5,1");

        }

        [TestMethod()]
        public void SortTestAsc()
        {
            OurLinkList linkList = new OurLinkList();
            Element element1 = new Element(1, null);
            Element element2 = new Element(2, null);
            Element element3 = new Element(3, null);
            Element element4 = new Element(4, null);

            linkList.Add_First(element1);
            linkList.Add_First(element4);
            linkList.Add_First(element2);
            linkList.Add_First(element2);
            linkList.Add_First(element3);

            linkList.Sort(true);

            Assert.IsTrue(linkList.To_String() == "1,2,2,3,4");
        }
        [TestMethod()]
        public void SortTestDsc()
        {
            OurLinkList linkList = new OurLinkList();
            Element element1 = new Element(1, null);
            Element element2 = new Element(2, null);
            Element element3 = new Element(3, null);
            Element element4 = new Element(4, null);

            linkList.Add_First(element1);
            linkList.Add_First(element4);
            linkList.Add_First(element2);
            linkList.Add_First(element2);
            linkList.Add_First(element3);

            linkList.Sort(false);

            Assert.IsTrue(linkList.To_String() == "4,3,2,2,1");
        }

        [TestMethod()]
        public void ReverseTest()
        {
            OurLinkList linkList = new OurLinkList();
            Element element = new Element(5, null);
            Element element1 = new Element(1, null);

            linkList.Add_First(element1);
            linkList.Add_First(element);
            linkList.Add_First(element);

            linkList.Reverse();

            Assert.IsTrue(linkList.To_String() == "1,5,5");
        }
    }
}