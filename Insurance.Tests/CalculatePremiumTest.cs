﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Insurance.Tests
{
    [TestFixture]
    public class CalculatePremiumTest
    {
        CalculatePremium sut = new CalculatePremium();

        [TestCase(25, "female", ExpectedResult = 5)]
        [TestCase(55, "female", ExpectedResult = 1.25)]
        [TestCase(17, "female", ExpectedResult = 0)]
        [TestCase(25, "N", ExpectedResult = 0)]
        [TestCase(30, "male", ExpectedResult = 6)]
        [TestCase(40, "male", ExpectedResult = 5)]
        [TestCase(17, "male", ExpectedResult = 0)]
        [TestCase(55, "male", ExpectedResult = 2.5)]
        public float pTest(int age, string gender)
        {
            float actualResult = sut.CalcPremium(age, gender);
            return actualResult;
        }

        //[Test]
        //public void CalcPremium()
        //{
        //    //CalculatePremium sut = new CalculatePremium();

        //    float female25 = sut.CalcPremium(25, "female");
        //    Assert.That(female25, Is.EqualTo(5));

        //    //float female55 = sut.CalcPremium(55, "female");
        //    //Assert.That(female55, Is.EqualTo(1.25));

        //    float female17 = sut.CalcPremium(17, "female");
        //    Assert.That(female17, Is.EqualTo(0));

        //    float noGender = sut.CalcPremium(25, "N");
        //    Assert.That(noGender, Is.EqualTo(0));

        //    float male30 = sut.CalcPremium(30, "male");
        //    Assert.That(male30, Is.EqualTo(6));

        //    float male40 = sut.CalcPremium(40, "male");
        //    Assert.That(male40, Is.EqualTo(5));

        //    float male17 = sut.CalcPremium(17, "male");
        //    Assert.That(male17, Is.EqualTo(0));

        //    //float male55 = sut.CalcPremium(55, "male");
        //    //Assert.That(male55, Is.EqualTo(2.5));
        //}        
    }
}
