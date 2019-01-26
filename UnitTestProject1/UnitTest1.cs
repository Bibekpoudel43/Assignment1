using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        /// <summary>
        /// This method tests the output returned by the GetAverage method.
        /// </summary>
        public void TestGetAverageTest()
        {
            //Assemble
            List<string[]> inputData = new List<string[]>();
            double expectedResult = 49.5;
            //Act
            for (int i = 0; i < 100; i++)
            {
                inputData.Add(new string[] { Convert.ToString(i), Convert.ToString(i), Convert.ToString(i), Convert.ToString(i), Convert.ToString(i) });
            }

            double actualResult = Summary.GetAverage(inputData, 1);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        /// <summary>
        /// This test method returns the average
        /// accepts double value as a parameter 
        /// </summary>
        public void TestAverage()
        {
            //Assemble
            List<double> hrt = new List<double>()
            {
             122.33, 91.55, 94.11
            };
        double expectedResult = 102.66;

        //Act
        double actualResult = Summary.Average(hrt);

        //Assert
        Assert.AreEqual(expectedResult, Math.Round(actualResult, 2, MidpointRounding.AwayFromZero));
        
       }

      [TestMethod]
       /// <summary>
       /// calculates the round off value for double data type
       /// </summary>
        public void TestRoundOff()
        {
            //Assemble
            double va = 22.54585465154415;
            double expectedResult = 22.55;

            //Act
            double actualResult = Summary.roundOff(va);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        /// <summary>
        /// calculates the power balance of string data type power
        /// </summary>
        public void TeestCalculatePowerBalance()
        {
            //Assemble
            List<string> power = new List<string>()
            {
             "122.33", "91.55", "94.11"
            };
            double expectedResult = 102.66;
            //Act
            double actualResult = Summary.CalculatePowerBalance(power);

            //Assert
            Assert.AreEqual(expectedResult, Summary.roundOff(actualResult));       
        }

        [TestMethod]
        /// <summary>
        /// calculates the sum, accepts value of string data type 
        /// </summary>
        public void TestSum()
        {
            //Assemble
            List<string> power = new List<string>()
            {
             "12.33", "9.55", "94.11"
            };
            double expectedResult = 115.99;

            //Act
            double actualResult = Summary.Sum(power);

            //Assert
            Assert.AreEqual(expectedResult, Summary.roundOff(actualResult));
        }

        [TestMethod]
        /// <summary>
        /// this test methods test the max value from provided list array
        /// </summary>
        public void TestMax()
        {
            //Assemble
            List<string> speedKMHR = new List<string>()
            {
             "50.33", "80.55", "40.11"
            };
            double expectedResult = 80.55;

            //Act
            double actualResult = Summary.Max(speedKMHR);

            //Assert
            Assert.AreEqual(expectedResult, Summary.roundOff(actualResult));
        }

        [TestMethod]
        /// <summary>
        /// this test methods test the min value from provided list array
        /// </summary>
        public void TestMin()
        {
            //Assemble
            List<string> speedKMHR = new List<string>()
            {
             "50", "80", "40"
            };
            int expectedResult = 40;

            //Act
            int actualResult = Summary.Min(speedKMHR);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        /// <summary>
        /// this test methods test the total distance travelled in KM/HR value from provided list array
        /// </summary>
        public void TestTotalDistance()
        {
            //Assemble
            double average = 99.2;
            int count = 3000;
            int interval = 1;
            double expectedResult = 82.67;

            //Act
            double actualResult = Summary.TotalDistance(average, count, interval);

            //Assert
            Assert.AreEqual(expectedResult, Summary.roundOff(actualResult));
        }

        [TestMethod]
        /// <summary>
        /// this test methods test the interval session from provided list speed array
        /// </summary>
        public void TestDetectClearInterval()
        {
            //Assemble
            List<string> speedKMHR = new List<string>()
            {
             "50.33", "0", "0", "80.55", "40.11", "0", "0", "44.2", "55.1"
            };
            int expectedResult = 2;

            //Act
            int actualResult = Summary.DetectClearInterval(speedKMHR);

            //Assert
            Assert.AreEqual(expectedResult, Summary.roundOff(actualResult));
        }

        [TestMethod]
        /// <summary>
        /// this test methods test the Training Stress Score from provided np, ftp and if
        /// </summary>
        public void TestCalculateTrainingStressScore()
        {
            //Assemble
            List<string> hrt = new List<string>()
            {
             "122.33", "91.55", "94.11"
            };
            double NP = 400.11;
            double IF = 198.22;
            double FTP = 191.2;
            string expectedResult = "34.57";

            //Act
            string[] heart1 = hrt.ToArray();
            int sec = heart1.Length;

            double TSS1 = (sec * NP * IF) / (FTP * 3600) * 100;
            double TSS = Math.Round(TSS1, 2);

            //Assert
            Assert.AreEqual(expectedResult, TSS.ToString());
        }

    }
}
