/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using CyberSource.Api;
using CyberSource.Model;
using CyberSource.Client;
using System.Reflection;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing CardProcessingConfigCommon
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CardProcessingConfigCommonTests
    {
        // TODO uncomment below to declare an instance variable for CardProcessingConfigCommon
        //private CardProcessingConfigCommon instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CardProcessingConfigCommon
            //instance = new CardProcessingConfigCommon();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CardProcessingConfigCommon
        /// </summary>
        [Test]
        public void CardProcessingConfigCommonInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CardProcessingConfigCommon
            //Assert.IsInstanceOfType<CardProcessingConfigCommon> (instance, "variable 'instance' is a CardProcessingConfigCommon");
        }

        /// <summary>
        /// Test the property 'Processors'
        /// </summary>
        [Test]
        public void ProcessorsTest()
        {
            // TODO unit test for the property 'Processors'
        }
        /// <summary>
        /// Test the property 'AmexVendorCode'
        /// </summary>
        [Test]
        public void AmexVendorCodeTest()
        {
            // TODO unit test for the property 'AmexVendorCode'
        }
        /// <summary>
        /// Test the property 'DefaultAuthTypeCode'
        /// </summary>
        [Test]
        public void DefaultAuthTypeCodeTest()
        {
            // TODO unit test for the property 'DefaultAuthTypeCode'
        }
        /// <summary>
        /// Test the property 'MasterCardAssignedId'
        /// </summary>
        [Test]
        public void MasterCardAssignedIdTest()
        {
            // TODO unit test for the property 'MasterCardAssignedId'
        }
        /// <summary>
        /// Test the property 'EnablePartialAuth'
        /// </summary>
        [Test]
        public void EnablePartialAuthTest()
        {
            // TODO unit test for the property 'EnablePartialAuth'
        }
        /// <summary>
        /// Test the property 'MerchantCategoryCode'
        /// </summary>
        [Test]
        public void MerchantCategoryCodeTest()
        {
            // TODO unit test for the property 'MerchantCategoryCode'
        }
        /// <summary>
        /// Test the property 'SicCode'
        /// </summary>
        [Test]
        public void SicCodeTest()
        {
            // TODO unit test for the property 'SicCode'
        }
        /// <summary>
        /// Test the property 'FoodAndConsumerServiceId'
        /// </summary>
        [Test]
        public void FoodAndConsumerServiceIdTest()
        {
            // TODO unit test for the property 'FoodAndConsumerServiceId'
        }
        /// <summary>
        /// Test the property 'EnableSplitShipment'
        /// </summary>
        [Test]
        public void EnableSplitShipmentTest()
        {
            // TODO unit test for the property 'EnableSplitShipment'
        }
        /// <summary>
        /// Test the property 'EnableInterchangeOptimization'
        /// </summary>
        [Test]
        public void EnableInterchangeOptimizationTest()
        {
            // TODO unit test for the property 'EnableInterchangeOptimization'
        }
        /// <summary>
        /// Test the property 'VisaDelegatedAuthenticationId'
        /// </summary>
        [Test]
        public void VisaDelegatedAuthenticationIdTest()
        {
            // TODO unit test for the property 'VisaDelegatedAuthenticationId'
        }
        /// <summary>
        /// Test the property 'CreditCardRefundLimitPercent'
        /// </summary>
        [Test]
        public void CreditCardRefundLimitPercentTest()
        {
            // TODO unit test for the property 'CreditCardRefundLimitPercent'
        }
        /// <summary>
        /// Test the property 'BusinessCenterCreditCardRefundLimitPercent'
        /// </summary>
        [Test]
        public void BusinessCenterCreditCardRefundLimitPercentTest()
        {
            // TODO unit test for the property 'BusinessCenterCreditCardRefundLimitPercent'
        }
        /// <summary>
        /// Test the property 'AllowCapturesGreaterThanAuthorizations'
        /// </summary>
        [Test]
        public void AllowCapturesGreaterThanAuthorizationsTest()
        {
            // TODO unit test for the property 'AllowCapturesGreaterThanAuthorizations'
        }
        /// <summary>
        /// Test the property 'EnableDuplicateMerchantReferenceNumberBlocking'
        /// </summary>
        [Test]
        public void EnableDuplicateMerchantReferenceNumberBlockingTest()
        {
            // TODO unit test for the property 'EnableDuplicateMerchantReferenceNumberBlocking'
        }
        /// <summary>
        /// Test the property 'DomesticMerchantId'
        /// </summary>
        [Test]
        public void DomesticMerchantIdTest()
        {
            // TODO unit test for the property 'DomesticMerchantId'
        }
        /// <summary>
        /// Test the property 'ProcessLevel3Data'
        /// </summary>
        [Test]
        public void ProcessLevel3DataTest()
        {
            // TODO unit test for the property 'ProcessLevel3Data'
        }
        /// <summary>
        /// Test the property 'SubMerchantId'
        /// </summary>
        [Test]
        public void SubMerchantIdTest()
        {
            // TODO unit test for the property 'SubMerchantId'
        }
        /// <summary>
        /// Test the property 'SubMerchantBusinessName'
        /// </summary>
        [Test]
        public void SubMerchantBusinessNameTest()
        {
            // TODO unit test for the property 'SubMerchantBusinessName'
        }
        /// <summary>
        /// Test the property 'PreferCobadgedSecondaryBrand'
        /// </summary>
        [Test]
        public void PreferCobadgedSecondaryBrandTest()
        {
            // TODO unit test for the property 'PreferCobadgedSecondaryBrand'
        }
        /// <summary>
        /// Test the property 'MerchantDescriptorInformation'
        /// </summary>
        [Test]
        public void MerchantDescriptorInformationTest()
        {
            // TODO unit test for the property 'MerchantDescriptorInformation'
        }
        /// <summary>
        /// Test the property 'GovernmentControlled'
        /// </summary>
        [Test]
        public void GovernmentControlledTest()
        {
            // TODO unit test for the property 'GovernmentControlled'
        }
        /// <summary>
        /// Test the property 'DropBillingInfo'
        /// </summary>
        [Test]
        public void DropBillingInfoTest()
        {
            // TODO unit test for the property 'DropBillingInfo'
        }

    }

}
