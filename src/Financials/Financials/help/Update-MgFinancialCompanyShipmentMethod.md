---
external help file: Microsoft.Graph.Financials-help.xml
Module Name: Microsoft.Graph.Financials
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.financials/update-mgfinancialcompanyshipmentmethod
schema: 2.0.0
---

# Update-MgFinancialCompanyShipmentMethod

## SYNOPSIS
Update the navigation property shipmentMethods in financials

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgFinancialCompanyShipmentMethod -CompanyId <String> -ShipmentMethodId <String>
 [-AdditionalProperties <Hashtable>] [-Code <String>] [-DisplayName <String>] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgFinancialCompanyShipmentMethod -CompanyId <String> -ShipmentMethodId <String>
 -BodyParameter <IMicrosoftGraphShipmentMethod> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgFinancialCompanyShipmentMethod -InputObject <IFinancialsIdentity> [-AdditionalProperties <Hashtable>]
 [-Code <String>] [-DisplayName <String>] [-Id <String>] [-LastModifiedDateTime <DateTime>] [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgFinancialCompanyShipmentMethod -InputObject <IFinancialsIdentity>
 -BodyParameter <IMicrosoftGraphShipmentMethod> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property shipmentMethods in financials

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
shipmentMethod
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphShipmentMethod
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Code
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CompanyId
key: id of company

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IFinancialsIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShipmentMethodId
key: id of shipmentMethod

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IFinancialsIdentity
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphShipmentMethod
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphShipmentMethod\>: shipmentMethod
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Code \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[LastModifiedDateTime \<DateTime?\>\]: 

INPUTOBJECT \<IFinancialsIdentity\>: Identity Parameter
  \[AccountId \<String\>\]: key: id of account
  \[AgedAccountsPayableId \<String\>\]: key: id of agedAccountsPayable
  \[AgedAccountsReceivableId \<String\>\]: key: id of agedAccountsReceivable
  \[CompanyId \<String\>\]: key: id of company
  \[CompanyInformationId \<String\>\]: key: id of companyInformation
  \[CountryRegionId \<String\>\]: key: id of countryRegion
  \[CurrencyId \<String\>\]: key: id of currency
  \[CustomerId \<String\>\]: key: id of customer
  \[CustomerPaymentId \<String\>\]: key: id of customerPayment
  \[CustomerPaymentJournalId \<String\>\]: key: id of customerPaymentJournal
  \[DimensionId \<String\>\]: key: id of dimension
  \[DimensionValueId \<String\>\]: key: id of dimensionValue
  \[EmployeeId \<String\>\]: key: id of employee
  \[GeneralLedgerEntryId \<String\>\]: key: id of generalLedgerEntry
  \[ItemCategoryId \<String\>\]: key: id of itemCategory
  \[ItemId \<String\>\]: key: id of item
  \[JournalId \<String\>\]: key: id of journal
  \[JournalLineId \<String\>\]: key: id of journalLine
  \[PaymentMethodId \<String\>\]: key: id of paymentMethod
  \[PaymentTermId \<String\>\]: key: id of paymentTerm
  \[PictureId \<String\>\]: key: id of picture
  \[PurchaseInvoiceId \<String\>\]: key: id of purchaseInvoice
  \[PurchaseInvoiceLineId \<String\>\]: key: id of purchaseInvoiceLine
  \[SalesCreditMemoId \<String\>\]: key: id of salesCreditMemo
  \[SalesCreditMemoLineId \<String\>\]: key: id of salesCreditMemoLine
  \[SalesInvoiceId \<String\>\]: key: id of salesInvoice
  \[SalesInvoiceLineId \<String\>\]: key: id of salesInvoiceLine
  \[SalesOrderId \<String\>\]: key: id of salesOrder
  \[SalesOrderLineId \<String\>\]: key: id of salesOrderLine
  \[SalesQuoteId \<String\>\]: key: id of salesQuote
  \[SalesQuoteLineId \<String\>\]: key: id of salesQuoteLine
  \[ShipmentMethodId \<String\>\]: key: id of shipmentMethod
  \[TaxAreaId \<String\>\]: key: id of taxArea
  \[TaxGroupId \<String\>\]: key: id of taxGroup
  \[UnitOfMeasureId \<String\>\]: key: id of unitOfMeasure
  \[VendorId \<String\>\]: key: id of vendor

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.financials/update-mgfinancialcompanyshipmentmethod](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.financials/update-mgfinancialcompanyshipmentmethod)
