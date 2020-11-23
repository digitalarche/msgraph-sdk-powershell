---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgagreement
schema: 2.0.0
---

# Update-MgAgreement

## SYNOPSIS
Update entity in agreements

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgAgreement -AgreementId <String> [-Acceptances <IMicrosoftGraphAgreementAcceptance[]>]
 [-AdditionalProperties <Hashtable>] [-DisplayName <String>] [-File <IMicrosoftGraphAgreementFile>]
 [-Files <IMicrosoftGraphAgreementFileLocalization[]>] [-Id <String>] [-IsPerDeviceAcceptanceRequired]
 [-IsViewingBeforeAcceptanceRequired] [-TermsExpiration <IMicrosoftGraphTermsExpiration>]
 [-UserReacceptRequiredFrequency <TimeSpan>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgAgreement -AgreementId <String> -BodyParameter <IMicrosoftGraphAgreement> [-PassThru] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgAgreement -InputObject <IIdentityGovernanceIdentity>
 [-Acceptances <IMicrosoftGraphAgreementAcceptance[]>] [-AdditionalProperties <Hashtable>]
 [-DisplayName <String>] [-File <IMicrosoftGraphAgreementFile>]
 [-Files <IMicrosoftGraphAgreementFileLocalization[]>] [-Id <String>] [-IsPerDeviceAcceptanceRequired]
 [-IsViewingBeforeAcceptanceRequired] [-TermsExpiration <IMicrosoftGraphTermsExpiration>]
 [-UserReacceptRequiredFrequency <TimeSpan>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgAgreement -InputObject <IIdentityGovernanceIdentity> -BodyParameter <IMicrosoftGraphAgreement>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update entity in agreements

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

### -Acceptances
.
To construct, see NOTES section for ACCEPTANCES properties and create a hash table.

```yaml
Type: IMicrosoftGraphAgreementAcceptance[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### -AgreementId
key: id of agreement

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

### -BodyParameter
agreement
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphAgreement
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -File
agreementFile
To construct, see NOTES section for FILE properties and create a hash table.

```yaml
Type: IMicrosoftGraphAgreementFile
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Files
.
To construct, see NOTES section for FILES properties and create a hash table.

```yaml
Type: IMicrosoftGraphAgreementFileLocalization[]
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
Type: IIdentityGovernanceIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsPerDeviceAcceptanceRequired
.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsViewingBeforeAcceptanceRequired
.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
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

### -TermsExpiration
termsExpiration
To construct, see NOTES section for TERMSEXPIRATION properties and create a hash table.

```yaml
Type: IMicrosoftGraphTermsExpiration
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserReacceptRequiredFrequency
.

```yaml
Type: TimeSpan
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IIdentityGovernanceIdentity
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAgreement
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ACCEPTANCES \<IMicrosoftGraphAgreementAcceptance\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[AgreementFileId \<String\>\]: 
  \[AgreementId \<String\>\]: 
  \[DeviceDisplayName \<String\>\]: 
  \[DeviceId \<String\>\]: 
  \[DeviceOSType \<String\>\]: 
  \[DeviceOSVersion \<String\>\]: 
  \[ExpirationDateTime \<DateTime?\>\]: 
  \[RecordedDateTime \<DateTime?\>\]: 
  \[State \<String\>\]: agreementAcceptanceState
  \[UserDisplayName \<String\>\]: 
  \[UserEmail \<String\>\]: 
  \[UserId \<String\>\]: 
  \[UserPrincipalName \<String\>\]: 

BODYPARAMETER \<IMicrosoftGraphAgreement\>: agreement
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Acceptances \<IMicrosoftGraphAgreementAcceptance\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AgreementFileId \<String\>\]: 
    \[AgreementId \<String\>\]: 
    \[DeviceDisplayName \<String\>\]: 
    \[DeviceId \<String\>\]: 
    \[DeviceOSType \<String\>\]: 
    \[DeviceOSVersion \<String\>\]: 
    \[ExpirationDateTime \<DateTime?\>\]: 
    \[RecordedDateTime \<DateTime?\>\]: 
    \[State \<String\>\]: agreementAcceptanceState
    \[UserDisplayName \<String\>\]: 
    \[UserEmail \<String\>\]: 
    \[UserId \<String\>\]: 
    \[UserPrincipalName \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[File \<IMicrosoftGraphAgreementFile\>\]: agreementFile
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[CreatedDateTime \<DateTime?\>\]: 
    \[FileData \<IMicrosoftGraphAgreementFileData\>\]: agreementFileData
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Data \<Byte\[\]\>\]: 
    \[FileName \<String\>\]: 
    \[IsDefault \<Boolean?\>\]: 
    \[IsMajorVersion \<Boolean?\>\]: 
    \[Language \<String\>\]: 
    \[Id \<String\>\]: Read-only.
    \[Localizations \<IMicrosoftGraphAgreementFileLocalization\[\]\>\]: 
      \[CreatedDateTime \<DateTime?\>\]: 
      \[FileData \<IMicrosoftGraphAgreementFileData\>\]: agreementFileData
      \[FileName \<String\>\]: 
      \[IsDefault \<Boolean?\>\]: 
      \[IsMajorVersion \<Boolean?\>\]: 
      \[Language \<String\>\]: 
      \[Id \<String\>\]: Read-only.
      \[Versions \<IMicrosoftGraphAgreementFileVersion\[\]\>\]: 
        \[CreatedDateTime \<DateTime?\>\]: 
        \[FileData \<IMicrosoftGraphAgreementFileData\>\]: agreementFileData
        \[FileName \<String\>\]: 
        \[IsDefault \<Boolean?\>\]: 
        \[IsMajorVersion \<Boolean?\>\]: 
        \[Language \<String\>\]: 
        \[Id \<String\>\]: Read-only.
  \[Files \<IMicrosoftGraphAgreementFileLocalization\[\]\>\]: 
  \[IsPerDeviceAcceptanceRequired \<Boolean?\>\]: 
  \[IsViewingBeforeAcceptanceRequired \<Boolean?\>\]: 
  \[TermsExpiration \<IMicrosoftGraphTermsExpiration\>\]: termsExpiration
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Frequency \<TimeSpan?\>\]: 
    \[StartDateTime \<DateTime?\>\]: 
  \[UserReacceptRequiredFrequency \<TimeSpan?\>\]: 

FILE \<IMicrosoftGraphAgreementFile\>: agreementFile
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[CreatedDateTime \<DateTime?\>\]: 
  \[FileData \<IMicrosoftGraphAgreementFileData\>\]: agreementFileData
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Data \<Byte\[\]\>\]: 
  \[FileName \<String\>\]: 
  \[IsDefault \<Boolean?\>\]: 
  \[IsMajorVersion \<Boolean?\>\]: 
  \[Language \<String\>\]: 
  \[Id \<String\>\]: Read-only.
  \[Localizations \<IMicrosoftGraphAgreementFileLocalization\[\]\>\]: 
    \[CreatedDateTime \<DateTime?\>\]: 
    \[FileData \<IMicrosoftGraphAgreementFileData\>\]: agreementFileData
    \[FileName \<String\>\]: 
    \[IsDefault \<Boolean?\>\]: 
    \[IsMajorVersion \<Boolean?\>\]: 
    \[Language \<String\>\]: 
    \[Id \<String\>\]: Read-only.
    \[Versions \<IMicrosoftGraphAgreementFileVersion\[\]\>\]: 
      \[CreatedDateTime \<DateTime?\>\]: 
      \[FileData \<IMicrosoftGraphAgreementFileData\>\]: agreementFileData
      \[FileName \<String\>\]: 
      \[IsDefault \<Boolean?\>\]: 
      \[IsMajorVersion \<Boolean?\>\]: 
      \[Language \<String\>\]: 
      \[Id \<String\>\]: Read-only.

FILES \<IMicrosoftGraphAgreementFileLocalization\[\]\>: .
  \[CreatedDateTime \<DateTime?\>\]: 
  \[FileData \<IMicrosoftGraphAgreementFileData\>\]: agreementFileData
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Data \<Byte\[\]\>\]: 
  \[FileName \<String\>\]: 
  \[IsDefault \<Boolean?\>\]: 
  \[IsMajorVersion \<Boolean?\>\]: 
  \[Language \<String\>\]: 
  \[Id \<String\>\]: Read-only.
  \[Versions \<IMicrosoftGraphAgreementFileVersion\[\]\>\]: 
    \[CreatedDateTime \<DateTime?\>\]: 
    \[FileData \<IMicrosoftGraphAgreementFileData\>\]: agreementFileData
    \[FileName \<String\>\]: 
    \[IsDefault \<Boolean?\>\]: 
    \[IsMajorVersion \<Boolean?\>\]: 
    \[Language \<String\>\]: 
    \[Id \<String\>\]: Read-only.

INPUTOBJECT \<IIdentityGovernanceIdentity\>: Identity Parameter
  \[AccessPackageAssignmentId \<String\>\]: key: id of accessPackageAssignment
  \[AccessPackageAssignmentPolicyId \<String\>\]: key: id of accessPackageAssignmentPolicy
  \[AccessPackageAssignmentRequestId \<String\>\]: key: id of accessPackageAssignmentRequest
  \[AccessPackageAssignmentResourceRoleId \<String\>\]: key: id of accessPackageAssignmentResourceRole
  \[AccessPackageCatalogId \<String\>\]: key: id of accessPackageCatalog
  \[AccessPackageId \<String\>\]: key: id of accessPackage
  \[AccessPackageResourceId \<String\>\]: key: id of accessPackageResource
  \[AccessPackageResourceRequestId \<String\>\]: key: id of accessPackageResourceRequest
  \[AccessPackageResourceRoleId \<String\>\]: key: id of accessPackageResourceRole
  \[AccessPackageResourceRoleScopeId \<String\>\]: key: id of accessPackageResourceRoleScope
  \[AccessPackageResourceScopeId \<String\>\]: key: id of accessPackageResourceScope
  \[AccessReviewDecisionId \<String\>\]: key: id of accessReviewDecision
  \[AccessReviewId \<String\>\]: key: id of accessReview
  \[AccessReviewId1 \<String\>\]: key: id of accessReview
  \[AccessReviewInstanceId \<String\>\]: key: id of accessReviewInstance
  \[AccessReviewReviewerId \<String\>\]: key: id of accessReviewReviewer
  \[AccessReviewScheduleDefinitionId \<String\>\]: key: id of accessReviewScheduleDefinition
  \[AgreementAcceptanceId \<String\>\]: key: id of agreementAcceptance
  \[AgreementFileLocalizationId \<String\>\]: key: id of agreementFileLocalization
  \[AgreementFileVersionId \<String\>\]: key: id of agreementFileVersion
  \[AgreementId \<String\>\]: key: id of agreement
  \[BusinessFlowTemplateId \<String\>\]: key: id of businessFlowTemplate
  \[ConnectedOrganizationId \<String\>\]: key: id of connectedOrganization
  \[DirectoryObjectId \<String\>\]: key: id of directoryObject
  \[GovernanceResourceId \<String\>\]: key: id of governanceResource
  \[GovernanceRoleAssignmentId \<String\>\]: key: id of governanceRoleAssignment
  \[GovernanceRoleAssignmentRequestId \<String\>\]: key: id of governanceRoleAssignmentRequest
  \[GovernanceRoleDefinitionId \<String\>\]: key: id of governanceRoleDefinition
  \[GovernanceRoleSettingId \<String\>\]: key: id of governanceRoleSetting
  \[PrivilegedAccessId \<String\>\]: key: id of privilegedAccess
  \[PrivilegedApprovalId \<String\>\]: key: id of privilegedApproval
  \[PrivilegedOperationEventId \<String\>\]: key: id of privilegedOperationEvent
  \[PrivilegedRoleAssignmentId \<String\>\]: key: id of privilegedRoleAssignment
  \[PrivilegedRoleAssignmentRequestId \<String\>\]: key: id of privilegedRoleAssignmentRequest
  \[PrivilegedRoleId \<String\>\]: key: id of privilegedRole
  \[ProgramControlId \<String\>\]: key: id of programControl
  \[ProgramControlTypeId \<String\>\]: key: id of programControlType
  \[ProgramId \<String\>\]: key: id of program
  \[UserId \<String\>\]: key: id of user

TERMSEXPIRATION \<IMicrosoftGraphTermsExpiration\>: termsExpiration
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Frequency \<TimeSpan?\>\]: 
  \[StartDateTime \<DateTime?\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgagreement](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgagreement)
