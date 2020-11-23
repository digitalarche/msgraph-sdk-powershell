---
external help file: Microsoft.Graph.Security-help.xml
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/new-mgsecurityhostsecurityprofile
schema: 2.0.0
---

# New-MgSecurityHostSecurityProfile

## SYNOPSIS
Create new navigation property to hostSecurityProfiles for security

## SYNTAX

### CreateExpanded (Default)
```
New-MgSecurityHostSecurityProfile [-AdditionalProperties <Hashtable>] [-AzureSubscriptionId <String>]
 [-AzureTenantId <String>] [-FirstSeenDateTime <DateTime>] [-Fqdn <String>] [-Id <String>] [-IsAzureAdJoined]
 [-IsAzureAdRegistered] [-IsHybridAzureDomainJoined] [-LastSeenDateTime <DateTime>]
 [-LogonUsers <IMicrosoftGraphLogonUser[]>] [-NetBiosName <String>]
 [-NetworkInterfaces <IMicrosoftGraphNetworkInterface[]>] [-OS <String>] [-OSVersion <String>]
 [-ParentHost <String>] [-RelatedHostIds <String[]>] [-RiskScore <String>] [-Tags <String[]>]
 [-VendorInformation <IMicrosoftGraphSecurityVendorInformation>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgSecurityHostSecurityProfile -BodyParameter <IMicrosoftGraphHostSecurityProfile> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to hostSecurityProfiles for security

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
hostSecurityProfile
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphHostSecurityProfile
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -FirstSeenDateTime
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

### -Fqdn
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

### -IsAzureAdJoined
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

### -IsAzureAdRegistered
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

### -IsHybridAzureDomainJoined
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

### -LastSeenDateTime
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

### -LogonUsers
.
To construct, see NOTES section for LOGONUSERS properties and create a hash table.

```yaml
Type: IMicrosoftGraphLogonUser[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetBiosName
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

### -NetworkInterfaces
.
To construct, see NOTES section for NETWORKINTERFACES properties and create a hash table.

```yaml
Type: IMicrosoftGraphNetworkInterface[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OS
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

### -OSVersion
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

### -ParentHost
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

### -RelatedHostIds
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphHostSecurityProfile
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphHostSecurityProfile
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphHostSecurityProfile\>: hostSecurityProfile
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AzureSubscriptionId \<String\>\]: 
  \[AzureTenantId \<String\>\]: 
  \[FirstSeenDateTime \<DateTime?\>\]: 
  \[Fqdn \<String\>\]: 
  \[IsAzureAdJoined \<Boolean?\>\]: 
  \[IsAzureAdRegistered \<Boolean?\>\]: 
  \[IsHybridAzureDomainJoined \<Boolean?\>\]: 
  \[LastSeenDateTime \<DateTime?\>\]: 
  \[LogonUsers \<IMicrosoftGraphLogonUser\[\]\>\]: 
    \[AccountDomain \<String\>\]: 
    \[AccountName \<String\>\]: 
    \[AccountType \<String\>\]: userAccountSecurityType
    \[FirstSeenDateTime \<DateTime?\>\]: 
    \[LastSeenDateTime \<DateTime?\>\]: 
    \[LogonId \<String\>\]: 
    \[LogonTypes \<String\[\]\>\]: 
  \[NetBiosName \<String\>\]: 
  \[NetworkInterfaces \<IMicrosoftGraphNetworkInterface\[\]\>\]: 
    \[Description \<String\>\]: 
    \[IPV4Address \<String\>\]: 
    \[IPV6Address \<String\>\]: 
    \[LocalIPV6Address \<String\>\]: 
    \[MacAddress \<String\>\]: 
  \[OS \<String\>\]: 
  \[OSVersion \<String\>\]: 
  \[ParentHost \<String\>\]: 
  \[RelatedHostIds \<String\[\]\>\]: 
  \[RiskScore \<String\>\]: 
  \[Tags \<String\[\]\>\]: 
  \[VendorInformation \<IMicrosoftGraphSecurityVendorInformation\>\]: securityVendorInformation
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Provider \<String\>\]: Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.
    \[ProviderVersion \<String\>\]: Version of the provider or subprovider, if it exists, that generated the alert.
Required
    \[SubProvider \<String\>\]: Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.
    \[Vendor \<String\>\]: Name of the alert vendor (for example, Microsoft, Dell, FireEye).
Required

LOGONUSERS \<IMicrosoftGraphLogonUser\[\]\>: .
  \[AccountDomain \<String\>\]: 
  \[AccountName \<String\>\]: 
  \[AccountType \<String\>\]: userAccountSecurityType
  \[FirstSeenDateTime \<DateTime?\>\]: 
  \[LastSeenDateTime \<DateTime?\>\]: 
  \[LogonId \<String\>\]: 
  \[LogonTypes \<String\[\]\>\]: 

NETWORKINTERFACES \<IMicrosoftGraphNetworkInterface\[\]\>: .
  \[Description \<String\>\]: 
  \[IPV4Address \<String\>\]: 
  \[IPV6Address \<String\>\]: 
  \[LocalIPV6Address \<String\>\]: 
  \[MacAddress \<String\>\]: 

VENDORINFORMATION \<IMicrosoftGraphSecurityVendorInformation\>: securityVendorInformation
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Provider \<String\>\]: Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.
  \[ProviderVersion \<String\>\]: Version of the provider or subprovider, if it exists, that generated the alert.
Required
  \[SubProvider \<String\>\]: Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.
  \[Vendor \<String\>\]: Name of the alert vendor (for example, Microsoft, Dell, FireEye).
Required

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/new-mgsecurityhostsecurityprofile](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/new-mgsecurityhostsecurityprofile)
