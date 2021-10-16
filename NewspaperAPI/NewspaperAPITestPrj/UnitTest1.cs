using NUnit.Framework;
using NewspaperAPI.CTSModel;
using NewspaperAPI.Service;
using Moq;

namespace NewspaperAPITestPrj
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        //[Test]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}

        public Mock<INewspaperServ<Newspapertbl>> cmock;
        public Newspapertbl ad;
        public Newspapertbl adadd;
        public Newspapertbl adinadd;
        public Newspapertbl adput;
        public Newspapertbl adinput;
        public Newspapertbl adlogin;
        public Newspapertbl adtest;
        [SetUp]
        public void Setup()
        {
            ad = new Newspapertbl();
            adadd = new Newspapertbl
            {
                Title = "Test",
                Language = "TestAadhar",

                Price = "150"
            };
            adinadd = new Newspapertbl
            {
                Id = 101,
                Title = "Test",
                Language = "TestAadhar",

                Price = "150"

            };
            adtest = new Newspapertbl
            {
                Id = 101,
                Title = "Test12",
                Language = "TestAadhar",

                Price = "150"
            };
            adput = new Newspapertbl
            {
                Id = 101,
                Title = "Test",
                Language = "TestAadhar",

                Price = "150"
            };
            adinput = new Newspapertbl
            {
               
                Title = "Test",
                Language = "TestAadhar",

                Price = "150"
            };
            //adlogin = new Newspapertbl
            //{

            //    Id = 101,
            //    Title = "Test",
            //    Language = "TestAadhar",

            //    Price = "150"
            //};
            cmock = new Mock<INewspaperServ<Newspapertbl>>();
        }

        [Test]
        public void ValidGetAllNewspapers()
        {
            cmock.Setup(G => G.GetAllNewspapers()).Returns(ad.GetAllNewspapers());
            var res = ad.GetNewspaperById(1).Result;
            Assert.AreEqual(res.Title, adtest.Title);
        }
        [Test]
        public void InValidGetAllNewspapers()
        {
            cmock.Setup(G => G.GetAllNewspapers()).Returns(ad.GetAllNewspapers());
            var res = ad.GetNewspaperById(1).Result;
            Assert.AreEqual(res.Title, adtest.Title);
        }


        [Test]
        public void ValidAddNewspaper()
        {
            cmock.Setup(G => G.GetAllNewspapers()).Returns(ad.GetAllNewspapers());
            var res = ad.AddNewspaper(adadd);
            Assert.AreEqual(1, res);
        }
        [Test]
        public void InVaidAddNewspaper()
        {
            cmock.Setup(G => G.GetAllNewspapers()).Returns(ad.GetAllNewspapers());
            var res = ad.AddNewspaper(adinadd);
            Assert.AreEqual(1, res);
        }


        [Test]
        public void ValidDeleteNewspaper()
        {
            cmock.Setup(G => G.GetAllNewspapers()).Returns(ad.GetAllNewspapers());
            var res = ad.DeleteNewspaper(ad);
            Assert.AreEqual(res, 1);
        }
        [Test]
        public void InValidDeleteNewspaper()
        {
            cmock.Setup(G => G.GetAllNewspapers()).Returns(ad.GetAllNewspapers());
            var res = ad.DeleteNewspaper(ad);
            Assert.AreEqual(res, 1);
        }

    }
}