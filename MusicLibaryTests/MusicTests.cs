using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicLibary;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MusicLibary.Tests
{
    [TestClass()]
    public class MusicTests
    {
        private Music music;
        

        [TestInitialize]
        public void Init()
        {
            music = new Music();
        }

        [TestMethod()]
        public void MuArtTest()
        {
            /// Arrange
            music.Artis = "The one";

            /// Act
            

            /// Assert
            Assert.AreEqual("The one", music.Artis);

        }

        [TestMethod()]
        public void MuIdTest()
        {
            music.Id = 1;
        }

        [TestMethod()]
        public void MuDurTest()
        {
            music.Id = 1;
        }

        [TestMethod()]
        public void MuTest()
        {
            music.Id = 1;
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }
    }
}