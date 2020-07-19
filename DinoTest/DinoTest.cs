using Microsoft.VisualStudio.TestTools.UnitTesting;
using DinoProject;



namespace DinoTest
{
    [TestClass]
    public class DinozaurTest
    {
        [TestMethod]
        public void dobreZnaki()
        {
            //Arrange
            string wartosc = "2o1";
            string oczekiwana = "50";
            Dinozaur dinozaur = new Dinozaur();

            //Act
            
            Dinozaur.sprawdzZnaki(ref wartosc);
            
            
            //Assert
            Assert.AreEqual(oczekiwana, wartosc);
           

        }
 [TestMethod]
        public void dobreZnaki2()
        {
            //Arrange
            string wartosc = "85";
            string oczekiwana = "85";
            Dinozaur dinozaur = new Dinozaur();

            //Act
            dinozaur.Dlugosc = wartosc;
            Dinozaur.sprawdzZnaki(ref wartosc);


            //Assert
            Assert.AreEqual(oczekiwana, wartosc);


        }
    }
}
