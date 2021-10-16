using Moq;
using NUnit.Framework;
using VendorAPI.CTSModel;
using VendorAPI.Service;

namespace VendorAPITestPrj
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

        public Mock<IVendorServ<Vendortbl>> cmock;
        public Vendortbl ad;
        public Vendortbl adadd;
        public Vendortbl adinadd;
        public Vendortbl adput;
        public Vendortbl adinput;
        public Vendortbl adlogin;
        public Vendortbl adtest;
        [SetUp]
        public void Setup()
        {
            ad = new Vendortbl();
            adadd = new Vendortbl
            {
                CompanyName = "Test",
                Email = "Test@gmail.com",

                Phoneno = "9879879150",
                UserName = "Test",
                Password = "Test@123"

            };
            adinadd = new Vendortbl
            {
                VendorId = 101,
                CompanyName = "Test",
                Email = "Test@gmail.com",

                Phoneno = "9879879150",
                UserName = "Test",
                Password = "Test@123"

            };
            adtest = new Vendortbl
            {
                VendorId = 101,
                CompanyName = "Test",
                Email = "Test@gmail.com",

                Phoneno = "9879879150",
                UserName = "Test",
                Password = "Test@123"
            };
            adput = new Vendortbl
            {
                VendorId = 101,
                CompanyName = "Test",
                Email = "Test@gmail.com",

                Phoneno = "9879879150",
                UserName = "Test",
                Password = "Test@123"
            };
            adinput = new Vendortbl
            {

                CompanyName = "Test",
                Email = "Test@gmail.com",

                Phoneno = "9879879150",
                UserName = "Test",
                Password = "Test@123"
            };
            adlogin = new Vendortbl
            {

                VendorId = 101,
                CompanyName = "Test",
                Email = "Test@gmail.com",

                Phoneno = "9879879150",
                UserName = "Test",
                Password = "Test@123"
            };
            cmock = new Mock<IVendorServ<Vendortbl>>();
        }

        [Test]
        public void ValidGetAllVendor()
        {
            cmock.Setup(G => G.GetAllVendor()).Returns(ad.GetAllVendor());
            var res = ad.GetVendorById(1).Result;
            Assert.AreEqual(res.UserName, adtest.UserName);
        }
        [Test]
        public void InValidGetAllVendor()
        {
            cmock.Setup(G => G.GetAllVendor()).Returns(ad.GetAllVendor());
            var res = ad.GetVendorById(4).Result;
            Assert.AreEqual(res.UserName, adtest.UserName);
        }


        [Test]
        public void ValidAddVendor()
        {
            cmock.Setup(G => G.GetAllVendor()).Returns(ad.GetAllVendor());
            var res = ad.AddVendor(adadd);
            Assert.AreEqual(1, res);
        }
        [Test]
        public void InVaidAddVendor()
        {
            cmock.Setup(G => G.GetAllVendor()).Returns(ad.GetAllVendor());
            var res = ad.AddVendor(adinadd);
            Assert.AreEqual(1, res);
        }


        [Test]
        public void ValidDeleteVendor()
        {
            cmock.Setup(G => G.GetAllVendor()).Returns(ad.GetAllVendor());
            var res = ad.DeleteVendor(ad);
            Assert.AreEqual(res, 1);
        }
        [Test]
        public void InValidDeleteVendor()
        {
            cmock.Setup(G => G.GetAllVendor()).Returns(ad.GetAllVendor());
            var res = ad.DeleteVendor(ad);
            Assert.AreEqual(res, 1);
        }
    }
}