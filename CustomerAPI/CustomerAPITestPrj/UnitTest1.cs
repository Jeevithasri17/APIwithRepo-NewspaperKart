using CustomerAPI.CTSModel;
using CustomerAPI.Service;
using Moq;
using NUnit.Framework;

namespace CustomerAPITestPrj
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

        public Mock<ICustomerServ<Customertbl>> cmock;
        public Customertbl ad;
        public Customertbl adadd;
        public Customertbl adinadd;
        public Customertbl adput;
        public Customertbl adinput;
        public Customertbl adlogin;
        public Customertbl adtest;
        [SetUp]
        public void Setup()
        {
            ad = new Customertbl();
            adadd = new Customertbl
            {
                Name = "Test",
                Address = "Test",

                Phoneno = "9879879150",
                UserName = "Test",
                Password = "Test@123"

            };
            adinadd = new Customertbl
            {
                CustomerId = 101,
                Name = "Test",
                Address = "Test",

                Phoneno = "9879879150",
                UserName = "Test",
                Password = "Test@123"


            };
            adtest = new Customertbl
            {
                CustomerId = 101,
                Name = "Test",
                Address = "Test",

                Phoneno = "9879879150",
                UserName = "Test",
                Password = "Test@123"
            };
            adput = new Customertbl
            {
                CustomerId = 101,
                Name = "Test",
                Address = "Test",

                Phoneno = "9879879150",
                UserName = "Test",
                Password = "Test@123"
            };
            adinput = new Customertbl
            {

                Name = "Test",
                Address = "Test",

                Phoneno = "9879879150",
                UserName = "Test",
                Password = "Test@123"
            };
            adlogin = new Customertbl
            {

                CustomerId = 101,
                Name = "Test",
                Address = "Test",

                Phoneno = "9879879150",
                UserName = "Test",
                Password = "Test@123"
            };
            cmock = new Mock<ICustomerServ<Customertbl>>();
        }

        [Test]
        public void ValidGetAllCustomer()
        {
            cmock.Setup(G => G.GetAllCustomer()).Returns(ad.GetAllCustomer());
            var res = ad.GetAccById(1).Result;
            Assert.AreEqual(res.UserName, adtest.UserName);
        }
        [Test]
        public void InValidGetAllCustomer()
        {
            cmock.Setup(G => G.GetAllCustomer()).Returns(ad.GetAllCustomer());
            var res = ad.GetAccById(4).Result;
            Assert.AreEqual(res.UserName, adtest.UserName);
        }


        [Test]
        public void ValidAddCustomer()
        {
            cmock.Setup(G => G.GetAllCustomer()).Returns(ad.GetAllCustomer());
            var res = ad.AddCustomer(adadd);
            Assert.AreEqual(1, res);
        }
        [Test]
        public void InVaidAddCustomer()
        {
            cmock.Setup(G => G.GetAllCustomer()).Returns(ad.GetAllCustomer());
            var res = ad.AddCustomer(adinadd);
            Assert.AreEqual(1, res);
        }


        [Test]
        public void ValidDeleteAccount()
        {
            cmock.Setup(G => G.GetAllCustomer()).Returns(ad.GetAllCustomer());
            var res = ad.DeleteAccount(ad);
            Assert.AreEqual(res, 1);
        }
        [Test]
        public void InValidDeleteAccount()
        {
            cmock.Setup(G => G.GetAllCustomer()).Returns(ad.GetAllCustomer());
            var res = ad.DeleteAccount(ad);
            Assert.AreEqual(res, 1);
        }
    }
}