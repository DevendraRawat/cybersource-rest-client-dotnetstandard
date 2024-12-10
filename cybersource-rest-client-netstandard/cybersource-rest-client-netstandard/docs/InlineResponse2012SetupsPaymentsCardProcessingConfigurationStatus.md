# CyberSource.Model.InlineResponse2012SetupsPaymentsCardProcessingConfigurationStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigurationId** | **Guid?** | This is NOT for MVP | [optional] 
**Version** | **string** |  | [optional] 
**SubmitTimeUtc** | **string** | Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC.  | [optional] 
**Status** | **string** | Possible values: - SUCCESS - PARTIAL - PENDING - NOT_SETUP | [optional] 
**Reason** | **string** | Possible values: - PENDING_PROVISIONING_PROCESS - MISSING_DATA - INVALID_DATA - DUPLICATE_FIELD - NOT_APPLICABLE | [optional] 
**Details** | **List&lt;Dictionary&lt;string, string&gt;&gt;** |  | [optional] 
**Message** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
