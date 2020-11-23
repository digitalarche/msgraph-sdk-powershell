---
external help file: Microsoft.Graph.Identity.DirectoryManagement-help.xml
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgorganizationsettingprofilecardproperty
schema: 2.0.0
---

# New-MgOrganizationSettingProfileCardProperty

## SYNOPSIS
Create new navigation property to profileCardProperties for organization

## SYNTAX

### CreateExpanded (Default)
```
New-MgOrganizationSettingProfileCardProperty -OrganizationId <String> [-AdditionalProperties <Hashtable>]
 [-Annotations <IMicrosoftGraphProfileCardAnnotation[]>] [-DirectoryPropertyName <String>] [-Id <String>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgOrganizationSettingProfileCardProperty -OrganizationId <String>
 -BodyParameter <IMicrosoftGraphProfileCardProperty> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgOrganizationSettingProfileCardProperty -InputObject <IIdentityDirectoryManagementIdentity>
 [-AdditionalProperties <Hashtable>] [-Annotations <IMicrosoftGraphProfileCardAnnotation[]>]
 [-DirectoryPropertyName <String>] [-Id <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgOrganizationSettingProfileCardProperty -InputObject <IIdentityDirectoryManagementIdentity>
 -BodyParameter <IMicrosoftGraphProfileCardProperty> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to profileCardProperties for organization

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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Annotations
.
To construct, see NOTES section for ANNOTATIONS properties and create a hash table.

```yaml
Type: IMicrosoftGraphProfileCardAnnotation[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
profileCardProperty
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphProfileCardProperty
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DirectoryPropertyName
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: IIdentityDirectoryManagementIdentity
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OrganizationId
key: id of organization

```yaml
Type: String
Parameter Sets: CreateExpanded, Create
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

### Microsoft.Graph.PowerShell.Models.IIdentityDirectoryManagementIdentity
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProfileCardProperty
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProfileCardProperty
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ANNOTATIONS \<IMicrosoftGraphProfileCardAnnotation\[\]\>: .
  \[DisplayName \<String\>\]: 
  \[Localizations \<IMicrosoftGraphDisplayNameLocalization\[\]\>\]: 
    \[DisplayName \<String\>\]: 
    \[LanguageTag \<String\>\]: 

BODYPARAMETER \<IMicrosoftGraphProfileCardProperty\>: profileCardProperty
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Annotations \<IMicrosoftGraphProfileCardAnnotation\[\]\>\]: 
    \[DisplayName \<String\>\]: 
    \[Localizations \<IMicrosoftGraphDisplayNameLocalization\[\]\>\]: 
      \[DisplayName \<String\>\]: 
      \[LanguageTag \<String\>\]: 
  \[DirectoryPropertyName \<String\>\]: 

INPUTOBJECT \<IIdentityDirectoryManagementIdentity\>: Identity Parameter
  \[AdministrativeUnitId \<String\>\]: key: id of administrativeUnit
  \[CommandId \<String\>\]: key: id of command
  \[ContractId \<String\>\]: key: id of contract
  \[DeviceId \<String\>\]: key: id of device
  \[DirectoryObjectId \<String\>\]: key: id of directoryObject
  \[DirectoryRoleId \<String\>\]: key: id of directoryRole
  \[DirectoryRoleTemplateId \<String\>\]: key: id of directoryRoleTemplate
  \[DirectorySettingId \<String\>\]: key: id of directorySetting
  \[DirectorySettingTemplateId \<String\>\]: key: id of directorySettingTemplate
  \[DomainDnsRecordId \<String\>\]: key: id of domainDnsRecord
  \[DomainId \<String\>\]: key: id of domain
  \[ExtensionId \<String\>\]: key: id of extension
  \[FeatureRolloutPolicyId \<String\>\]: key: id of featureRolloutPolicy
  \[OrgContactId \<String\>\]: key: id of orgContact
  \[OrganizationId \<String\>\]: key: id of organization
  \[ProfileCardPropertyId \<String\>\]: key: id of profileCardProperty
  \[ScopedRoleMembershipId \<String\>\]: key: id of scopedRoleMembership
  \[SharedEmailDomainId \<String\>\]: key: id of sharedEmailDomain
  \[SharedEmailDomainInvitationId \<String\>\]: key: id of sharedEmailDomainInvitation
  \[SubscribedSkuId \<String\>\]: key: id of subscribedSku
  \[UserId \<String\>\]: key: id of user

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgorganizationsettingprofilecardproperty](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgorganizationsettingprofilecardproperty)
