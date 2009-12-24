﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestfulieClientTests.helpers;
using RestfulieClient.resources;
using RestfuliClientTests.helpers;

namespace RestfuliClientTests
{
    /// <summary>
    /// Summary description for ResourceServiceTest
    /// </summary>
    [TestClass]
    public class ResourceServiceTest
    {
        public ResourceServiceTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ShoudBePossibleToLoadAResourceFromXml()
        {        
         
            ResourceService resource = new ResourceService() { RemoteResourceService = RemoteResourceFactory.GetRemoteResource() };
            dynamic order = resource.FromXml("http:\\localhost:3000\\order\\1.xml");

            // verificando os atributos do recurso
            Assert.IsNotNull(order.date);
            Assert.IsNotNull(order.total);
        }

        [Ignore]
        public void ShouldBePossibleToExecuteATransitionOfStateOfAResource()
        {                  
            ResourceService resource = new ResourceService() { RemoteResourceService = RemoteResourceFactory.GetRemoteResource() };
            dynamic order = resource.FromXml("http:\\localhost:3000\\order\\1.xml");
            Assert.IsNotNull(order.Pay());

        }


    }
}
