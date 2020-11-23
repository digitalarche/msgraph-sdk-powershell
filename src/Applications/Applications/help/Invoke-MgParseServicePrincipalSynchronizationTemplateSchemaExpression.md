---
external help file: Microsoft.Graph.Applications-help.xml
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/invoke-mgparseserviceprincipalsynchronizationtemplateschemaexpression
schema: 2.0.0
---

# Invoke-MgParseServicePrincipalSynchronizationTemplateSchemaExpression

## SYNOPSIS
Invoke action parseExpression

## SYNTAX

### ParseExpanded (Default)
```
Invoke-MgParseServicePrincipalSynchronizationTemplateSchemaExpression -ServicePrincipalId <String>
 -SynchronizationTemplateId <String> [-AdditionalProperties <Hashtable>] [-Expression <String>]
 [-TargetAttributeDefinition <IMicrosoftGraphAttributeDefinition>]
 [-TestInputObject <IMicrosoftGraphExpressionInputObject>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Parse
```
Invoke-MgParseServicePrincipalSynchronizationTemplateSchemaExpression -ServicePrincipalId <String>
 -SynchronizationTemplateId <String>
 -BodyParameter <IPaths1Ia9XfcServiceprincipalsServiceprincipalIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ParseViaIdentityExpanded
```
Invoke-MgParseServicePrincipalSynchronizationTemplateSchemaExpression -InputObject <IApplicationsIdentity>
 [-AdditionalProperties <Hashtable>] [-Expression <String>]
 [-TargetAttributeDefinition <IMicrosoftGraphAttributeDefinition>]
 [-TestInputObject <IMicrosoftGraphExpressionInputObject>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ParseViaIdentity
```
Invoke-MgParseServicePrincipalSynchronizationTemplateSchemaExpression -InputObject <IApplicationsIdentity>
 -BodyParameter <IPaths1Ia9XfcServiceprincipalsServiceprincipalIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action parseExpression

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
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IPaths1Ia9XfcServiceprincipalsServiceprincipalIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Parse, ParseViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Expression
.

```yaml
Type: String
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
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
Type: IApplicationsIdentity
Parameter Sets: ParseViaIdentityExpanded, ParseViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ServicePrincipalId
key: id of servicePrincipal

```yaml
Type: String
Parameter Sets: ParseExpanded, Parse
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SynchronizationTemplateId
key: id of synchronizationTemplate

```yaml
Type: String
Parameter Sets: ParseExpanded, Parse
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetAttributeDefinition
attributeDefinition
To construct, see NOTES section for TARGETATTRIBUTEDEFINITION properties and create a hash table.

```yaml
Type: IMicrosoftGraphAttributeDefinition
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TestInputObject
expressionInputObject
To construct, see NOTES section for TESTINPUTOBJECT properties and create a hash table.

```yaml
Type: IMicrosoftGraphExpressionInputObject
Parameter Sets: ParseExpanded, ParseViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IApplicationsIdentity
### Microsoft.Graph.PowerShell.Models.IPaths1Ia9XfcServiceprincipalsServiceprincipalIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphParseExpressionResponse
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IPaths1Ia9XfcServiceprincipalsServiceprincipalIdSynchronizationTemplatesSynchronizationtemplateIdSchemaMicrosoftGraphParseexpressionPostRequestbodyContentApplicationJsonSchema\>: .
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Expression \<String\>\]: 
  \[TargetAttributeDefinition \<IMicrosoftGraphAttributeDefinition\>\]: attributeDefinition
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Anchor \<Boolean?\>\]: 
    \[ApiExpressions \<IMicrosoftGraphStringKeyStringValuePair\[\]\>\]: 
      \[Key \<String\>\]: 
      \[Value \<String\>\]: 
    \[CaseExact \<Boolean?\>\]: 
    \[DefaultValue \<String\>\]: 
    \[FlowNullValues \<Boolean?\>\]: 
    \[Metadata \<IMicrosoftGraphMetadataEntry\[\]\>\]: 
      \[Key \<String\>\]: 
      \[Value \<String\>\]: 
    \[Multivalued \<Boolean?\>\]: 
    \[Mutability \<String\>\]: mutability
    \[Name \<String\>\]: 
    \[ReferencedObjects \<IMicrosoftGraphReferencedObject\[\]\>\]: 
      \[ReferencedObjectName \<String\>\]: 
      \[ReferencedProperty \<String\>\]: 
    \[Required \<Boolean?\>\]: 
    \[Type \<String\>\]: attributeType
  \[TestInputObject \<IMicrosoftGraphExpressionInputObject\>\]: expressionInputObject
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Definition \<IMicrosoftGraphObjectDefinition\>\]: objectDefinition
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Attributes \<IMicrosoftGraphAttributeDefinition\[\]\>\]: 
      \[Metadata \<IMicrosoftGraphMetadataEntry\[\]\>\]: 
      \[Name \<String\>\]: 
      \[SupportedApis \<String\[\]\>\]: 
    \[Properties \<IMicrosoftGraphStringKeyObjectValuePair\[\]\>\]: 
      \[Key \<String\>\]: 

INPUTOBJECT \<IApplicationsIdentity\>: Identity Parameter
  \[AppRoleAssignmentId \<String\>\]: key: id of appRoleAssignment
  \[ApplicationId \<String\>\]: key: id of application
  \[ApplicationTemplateId \<String\>\]: key: id of applicationTemplate
  \[ConnectorGroupId \<String\>\]: key: id of connectorGroup
  \[ConnectorId \<String\>\]: key: id of connector
  \[DelegatedPermissionClassificationId \<String\>\]: key: id of delegatedPermissionClassification
  \[DirectoryDefinitionId \<String\>\]: key: id of directoryDefinition
  \[EndpointId \<String\>\]: key: id of endpoint
  \[ExtensionPropertyId \<String\>\]: key: id of extensionProperty
  \[GroupId \<String\>\]: key: id of group
  \[LicenseDetailsId \<String\>\]: key: id of licenseDetails
  \[OnPremisesAgentGroupId \<String\>\]: key: id of onPremisesAgentGroup
  \[OnPremisesAgentGroupId1 \<String\>\]: key: id of onPremisesAgentGroup
  \[OnPremisesAgentId \<String\>\]: key: id of onPremisesAgent
  \[OnPremisesAgentId1 \<String\>\]: key: id of onPremisesAgent
  \[OnPremisesPublishingProfileId \<String\>\]: key: id of onPremisesPublishingProfile
  \[PublishedResourceId \<String\>\]: key: id of publishedResource
  \[PublishedResourceId1 \<String\>\]: key: id of publishedResource
  \[ServicePrincipalId \<String\>\]: key: id of servicePrincipal
  \[SynchronizationJobId \<String\>\]: key: id of synchronizationJob
  \[SynchronizationTemplateId \<String\>\]: key: id of synchronizationTemplate
  \[UserId \<String\>\]: key: id of user

TARGETATTRIBUTEDEFINITION \<IMicrosoftGraphAttributeDefinition\>: attributeDefinition
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Anchor \<Boolean?\>\]: 
  \[ApiExpressions \<IMicrosoftGraphStringKeyStringValuePair\[\]\>\]: 
    \[Key \<String\>\]: 
    \[Value \<String\>\]: 
  \[CaseExact \<Boolean?\>\]: 
  \[DefaultValue \<String\>\]: 
  \[FlowNullValues \<Boolean?\>\]: 
  \[Metadata \<IMicrosoftGraphMetadataEntry\[\]\>\]: 
    \[Key \<String\>\]: 
    \[Value \<String\>\]: 
  \[Multivalued \<Boolean?\>\]: 
  \[Mutability \<String\>\]: mutability
  \[Name \<String\>\]: 
  \[ReferencedObjects \<IMicrosoftGraphReferencedObject\[\]\>\]: 
    \[ReferencedObjectName \<String\>\]: 
    \[ReferencedProperty \<String\>\]: 
  \[Required \<Boolean?\>\]: 
  \[Type \<String\>\]: attributeType

TESTINPUTOBJECT \<IMicrosoftGraphExpressionInputObject\>: expressionInputObject
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Definition \<IMicrosoftGraphObjectDefinition\>\]: objectDefinition
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Attributes \<IMicrosoftGraphAttributeDefinition\[\]\>\]: 
      \[Anchor \<Boolean?\>\]: 
      \[ApiExpressions \<IMicrosoftGraphStringKeyStringValuePair\[\]\>\]: 
        \[Key \<String\>\]: 
        \[Value \<String\>\]: 
      \[CaseExact \<Boolean?\>\]: 
      \[DefaultValue \<String\>\]: 
      \[FlowNullValues \<Boolean?\>\]: 
      \[Metadata \<IMicrosoftGraphMetadataEntry\[\]\>\]: 
        \[Key \<String\>\]: 
        \[Value \<String\>\]: 
      \[Multivalued \<Boolean?\>\]: 
      \[Mutability \<String\>\]: mutability
      \[Name \<String\>\]: 
      \[ReferencedObjects \<IMicrosoftGraphReferencedObject\[\]\>\]: 
        \[ReferencedObjectName \<String\>\]: 
        \[ReferencedProperty \<String\>\]: 
      \[Required \<Boolean?\>\]: 
      \[Type \<String\>\]: attributeType
    \[Metadata \<IMicrosoftGraphMetadataEntry\[\]\>\]: 
    \[Name \<String\>\]: 
    \[SupportedApis \<String\[\]\>\]: 
  \[Properties \<IMicrosoftGraphStringKeyObjectValuePair\[\]\>\]: 
    \[Key \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/invoke-mgparseserviceprincipalsynchronizationtemplateschemaexpression](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/invoke-mgparseserviceprincipalsynchronizationtemplateschemaexpression)
