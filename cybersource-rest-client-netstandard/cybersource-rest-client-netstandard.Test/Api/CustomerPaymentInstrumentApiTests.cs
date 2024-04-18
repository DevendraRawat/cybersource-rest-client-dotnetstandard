/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using CyberSource.Client;
using CyberSource.Api;
using CyberSource.Model;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing CustomerPaymentInstrumentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CustomerPaymentInstrumentApiTests
    {
        private CustomerPaymentInstrumentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CustomerPaymentInstrumentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CustomerPaymentInstrumentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CustomerPaymentInstrumentApi
            //Assert.IsInstanceOfType(typeof(CustomerPaymentInstrumentApi), instance, "instance is a CustomerPaymentInstrumentApi");
        }

        
        /// <summary>
        /// Test DeleteCustomerPaymentInstrument
        /// </summary>
        [Test]
        public void DeleteCustomerPaymentInstrumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customerId = null;
            //string paymentInstrumentId = null;
            //string profileId = null;
            //instance.DeleteCustomerPaymentInstrument(customerId, paymentInstrumentId, profileId);
            
        }
        
        /// <summary>
        /// Test GetCustomerPaymentInstrument
        /// </summary>
        [Test]
        public void GetCustomerPaymentInstrumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customerId = null;
            //string paymentInstrumentId = null;
            //string profileId = null;
            //var response = instance.GetCustomerPaymentInstrument(customerId, paymentInstrumentId, profileId);
            //Assert.IsInstanceOf<PostCustomerPaymentInstrumentRequest> (response, "response is PostCustomerPaymentInstrumentRequest");
        }
        
        /// <summary>
        /// Test GetCustomerPaymentInstrumentsList
        /// </summary>
        [Test]
        public void GetCustomerPaymentInstrumentsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customerId = null;
            //string profileId = null;
            //long? offset = null;
            //long? limit = null;
            //var response = instance.GetCustomerPaymentInstrumentsList(customerId, profileId, offset, limit);
            //Assert.IsInstanceOf<PaymentInstrumentList> (response, "response is PaymentInstrumentList");
        }
        
        /// <summary>
        /// Test PatchCustomersPaymentInstrument
        /// </summary>
        [Test]
        public void PatchCustomersPaymentInstrumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customerId = null;
            //string paymentInstrumentId = null;
            //PatchCustomerPaymentInstrumentRequest patchCustomerPaymentInstrumentRequest = null;
            //string profileId = null;
            //string ifMatch = null;
            //var response = instance.PatchCustomersPaymentInstrument(customerId, paymentInstrumentId, patchCustomerPaymentInstrumentRequest, profileId, ifMatch);
            //Assert.IsInstanceOf<PatchCustomerPaymentInstrumentRequest> (response, "response is PatchCustomerPaymentInstrumentRequest");
        }
        
        /// <summary>
        /// Test PostCustomerPaymentInstrument
        /// </summary>
        [Test]
        public void PostCustomerPaymentInstrumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customerId = null;
            //PostCustomerPaymentInstrumentRequest postCustomerPaymentInstrumentRequest = null;
            //string profileId = null;
            //var response = instance.PostCustomerPaymentInstrument(customerId, postCustomerPaymentInstrumentRequest, profileId);
            //Assert.IsInstanceOf<PostCustomerPaymentInstrumentRequest> (response, "response is PostCustomerPaymentInstrumentRequest");
        }
        
    }

}
