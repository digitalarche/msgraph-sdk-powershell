---
external help file: Microsoft.Graph.Security-help.xml
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/new-mgsecuritycloudappsecurityprofile
schema: 2.0.0
---

# New-MgSecurityCloudAppSecurityProfile

## SYNOPSIS
Create new navigation property to cloudAppSecurityProfiles for security

## SYNTAX

### CreateExpanded (Default)
```
New-MgSecurityCloudAppSecurityProfile [-AdditionalProperties <Hashtable>] [-AzureSubscriptionId <String>]
 [-AzureTenantId <String>] [-CreatedDateTime <DateTime>] [-DeploymentPackageUrl <String>]
 [-DestinationServiceName <String>] [-Id <String>] [-IsSigned] [-LastModifiedDateTime <DateTime>]
 [-Manifest <String>] [-Name <String>] [-PermissionsRequired <String>] [-Platform <String>]
 [-PolicyName <String>] [-Publisher <String>] [-RiskScore <String>] [-Tags <String[]>] [-Type <String>]
 [-VendorInformation <IMicrosoftGraphSecurityVendorInformation>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgSecurityCloudAppSecurityProfile -BodyParameter <IMicrosoftGraphCloudAppSecurityProfile> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to cloudAppSecurityProfiles for security

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureSubscriptionId
.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureTenantId
.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
cloudAppSecurityProfile
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphCloudAppSecurityProfile
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeploymentPackageUrl
.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DestinationServiceName
.

```yaml
Type: String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsSigned
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Manifest
.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PermissionsRequired
applicationPermissionsRequired

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Platform
.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PolicyName
.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Publisher
.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RiskScore
.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tags
.

```yaml
Type: String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Type
.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VendorInformation
securityVendorInformation
To construct, see NOTES section for VENDORINFORMATION properties and create a hash table.

```yaml
Type: IMicrosoftGraphSecurityVendorInformation
Parameter Sets: CreateExpanded
Aliases:

Required: False
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudAppSecurityProfile
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudAppSecurityProfile
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphCloudAppSecurityProfile\>: cloudAppSecurityProfile
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AzureSubscriptionId \<String\>\]: 
  \[AzureTenantId \<String\>\]: 
  \[CreatedDateTime \<DateTime?\>\]: 
  \[DeploymentPackageUrl \<String\>\]: 
  \[DestinationServiceName \<String\>\]: 
  \[IsSigned \<Boolean?\>\]: 
  \[LastModifiedDateTime \<DateTime?\>\]: 
  \[Manifest \<String\>\]: 
  \[Name \<String\>\]: 
  \[PermissionsRequired \<String\>\]: applicationPermissionsRequired
  \[Platform \<String\>\]: 
  \[PolicyName \<String\>\]: 
  \[Publisher \<String\>\]: 
  \[RiskScore \<String\>\]: 
  \[Tags \<String\[\]\>\]: 
  \[Type \<String\>\]: 
  \[VendorInformation \<IMicrosoftGraphSecurityVendorInformation\>\]: securityVendorInformation
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Provider \<String\>\]: Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.
    \[ProviderVersion \<String\>\]: Version of the provider or subprovider, if it exists, that generated the alert.
Required
    \[SubProvider \<String\>\]: Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.
    \[Vendor \<String\>\]: Name of the alert vendor (for example, Microsoft, Dell, FireEye).
Required

VENDORINFORMATION \<IMicrosoftGraphSecurityVendorInformation\>: securityVendorInformation
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Provider \<String\>\]: Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.
  \[ProviderVersion \<String\>\]: Version of the provider or subprovider, if it exists, that generated the alert.
Required
  \[SubProvider \<String\>\]: Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.
  \[Vendor \<String\>\]: Name of the alert vendor (for example, Microsoft, Dell, FireEye).
Required

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/new-mgsecuritycloudappsecurityprofile](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/new-mgsecuritycloudappsecurityprofile)
