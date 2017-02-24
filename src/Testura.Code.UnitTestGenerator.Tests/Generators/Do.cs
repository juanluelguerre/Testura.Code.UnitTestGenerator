﻿using NUnit.Framework;
using Testura.Code.UnitTestGenerator.Util;

namespace Testura.Code.UnitTestGenerator.Tests.Generators
{
    [TestFixture]
    public class Do
    {
        [Test]
        public void Hej()
        {
            var o = new UnitTestGenerator();
            //o.GenerateUnitTests(@"C:\Users\Mille\Documents\Visual Studio 2017\Projects\TestFramework\TestFramework\bin\Debug\TestFramework.exe", TestFrameworks.NUnit, MockFrameworks.Moq, @"C:\Users\Mille\Documents\KodGenerated\Mo");
            o.GenerateUnitTests(@"C:\Users\Mille\Documents\Testura\Testura.Android.PageObjectCreator\src\Testura.Android.PageObjectCreator\bin\Debug\Testura.Android.PageObjectCreator.exe", TestFrameworks.NUnit, MockFrameworks.Moq, @"C:\Users\Mille\Documents\KodGenerated\Mo2");
        }
    }
}