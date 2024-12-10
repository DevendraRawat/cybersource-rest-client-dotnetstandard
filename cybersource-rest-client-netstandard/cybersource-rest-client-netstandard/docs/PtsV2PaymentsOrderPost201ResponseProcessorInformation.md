# CyberSource.Model.PtsV2PaymentsOrderPost201ResponseProcessorInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SellerProtection** | [**PtsV2PaymentsOrderPost201ResponseProcessorInformationSellerProtection**](PtsV2PaymentsOrderPost201ResponseProcessorInformationSellerProtection.md) |  | [optional] 
**Avs** | [**PtsV2PaymentsPost201Response1ProcessorInformationAvs**](PtsV2PaymentsPost201Response1ProcessorInformationAvs.md) |  | [optional] 
**TransactionId** | **string** | Network transaction identifier (TID). You can use this value to identify a specific transaction when you are discussing the transaction with your processor. Not all processors provide this value.  Returned by the authorization service.  #### PIN debit Transaction identifier generated by the processor.  Returned by PIN debit credit.  #### GPX Processor transaction ID.  #### Cielo For Cielo, this value is the non-sequential unit (NSU) and is supported for all transactions. The value is generated by Cielo or the issuing bank.  #### Comercio Latino For Comercio Latino, this value is the proof of sale or non-sequential unit (NSU) number generated by the acquirers Cielo and Rede, or the issuing bank.  #### CyberSource through VisaNet and GPN For details about this value for CyberSource through VisaNet and GPN, see \&quot;processorInformation.networkTransactionId\&quot; in [REST API Fields](https://developer.cybersource.com/content/dam/docs/cybs/en-us/apifields/reference/all/rest/api-fields.pdf)  #### Moneris This value identifies the transaction on a host system. It contains the following information: - Terminal used to process the transaction - Shift during which the transaction took place - Batch number - Transaction number within the batch You must store this value. If you give the customer a receipt, display this value on the receipt.  **Example** For the value 66012345001069003: - Terminal ID &#x3D; 66012345 - Shift number &#x3D; 001 - Batch number &#x3D; 069 - Transaction number &#x3D; 003  | [optional] 
**ResponseDetails** | **string** | This field might contain information about a decline. This field is supported only for **CyberSource through VisaNet**.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
