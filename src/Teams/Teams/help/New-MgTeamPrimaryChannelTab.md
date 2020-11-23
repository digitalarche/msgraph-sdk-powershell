---
external help file: Microsoft.Graph.Teams-help.xml
Module Name: Microsoft.Graph.Teams
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/new-mgteamprimarychanneltab
schema: 2.0.0
---

# New-MgTeamPrimaryChannelTab

## SYNOPSIS
Create new navigation property to tabs for teams

## SYNTAX

### CreateExpanded (Default)
```
New-MgTeamPrimaryChannelTab -TeamId <String> [-AdditionalProperties <Hashtable>]
 [-Configuration <IMicrosoftGraphTeamsTabConfiguration>] [-DisplayName <String>] [-Id <String>]
 [-MessageId <String>] [-SortOrderIndex <String>] [-TeamsApp <IMicrosoftGraphTeamsApp>] [-TeamsAppId <String>]
 [-WebUrl <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgTeamPrimaryChannelTab -TeamId <String> -BodyParameter <IMicrosoftGraphTeamsTab> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgTeamPrimaryChannelTab -InputObject <ITeamsIdentity> [-AdditionalProperties <Hashtable>]
 [-Configuration <IMicrosoftGraphTeamsTabConfiguration>] [-DisplayName <String>] [-Id <String>]
 [-MessageId <String>] [-SortOrderIndex <String>] [-TeamsApp <IMicrosoftGraphTeamsApp>] [-TeamsAppId <String>]
 [-WebUrl <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgTeamPrimaryChannelTab -InputObject <ITeamsIdentity> -BodyParameter <IMicrosoftGraphTeamsTab> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to tabs for teams

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

### -BodyParameter
teamsTab
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphTeamsTab
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Configuration
teamsTabConfiguration
To construct, see NOTES section for CONFIGURATION properties and create a hash table.

```yaml
Type: IMicrosoftGraphTeamsTabConfiguration
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Name of the tab.

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
Type: ITeamsIdentity
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MessageId
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

### -SortOrderIndex
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

### -TeamId
key: id of team

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

### -TeamsApp
teamsApp
To construct, see NOTES section for TEAMSAPP properties and create a hash table.

```yaml
Type: IMicrosoftGraphTeamsApp
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamsAppId
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

### -WebUrl
Deep link URL of the tab instance.
Read only.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsTab
### Microsoft.Graph.PowerShell.Models.ITeamsIdentity
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsTab
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphTeamsTab1\>: teamsTab
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Configuration \<IMicrosoftGraphTeamsTabConfiguration\>\]: teamsTabConfiguration
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[ContentUrl \<String\>\]: Url used for rendering tab contents in Teams.
Required.
    \[EntityId \<String\>\]: Identifier for the entity hosted by the tab provider.
    \[RemoveUrl \<String\>\]: Url called by Teams client when a Tab is removed using the Teams Client.
    \[WebsiteUrl \<String\>\]: Url for showing tab contents outside of Teams.
  \[DisplayName \<String\>\]: Name of the tab.
  \[TeamsApp \<IMicrosoftGraphTeamsApp1\>\]: teamsApp
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[AppDefinitions \<IMicrosoftGraphTeamsAppDefinition1\[\]\>\]: The details for each version of the app.
      \[Id \<String\>\]: Read-only.
      \[DisplayName \<String\>\]: The name of the app provided by the app developer.
      \[TeamsAppId \<String\>\]: The ID from the Teams app manifest.
      \[Version \<String\>\]: The version number of the application.
    \[DisplayName \<String\>\]: The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
    \[DistributionMethod \<String\>\]: teamsAppDistributionMethod
    \[ExternalId \<String\>\]: The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.
  \[WebUrl \<String\>\]: Deep link URL of the tab instance.
Read only.

CONFIGURATION \<IMicrosoftGraphTeamsTabConfiguration\>: teamsTabConfiguration
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[ContentUrl \<String\>\]: Url used for rendering tab contents in Teams.
Required.
  \[EntityId \<String\>\]: Identifier for the entity hosted by the tab provider.
  \[RemoveUrl \<String\>\]: Url called by Teams client when a Tab is removed using the Teams Client.
  \[WebsiteUrl \<String\>\]: Url for showing tab contents outside of Teams.

INPUTOBJECT \<ITeamsIdentity\>: Identity Parameter
  \[ChannelId \<String\>\]: key: id of channel
  \[ChatId \<String\>\]: key: id of chat
  \[ChatMessageHostedContentId \<String\>\]: key: id of chatMessageHostedContent
  \[ChatMessageId \<String\>\]: key: id of chatMessage
  \[ChatMessageId1 \<String\>\]: key: id of chatMessage
  \[ConversationMemberId \<String\>\]: key: id of conversationMember
  \[GroupId \<String\>\]: key: id of group
  \[OfferShiftRequestId \<String\>\]: key: id of offerShiftRequest
  \[OpenShiftChangeRequestId \<String\>\]: key: id of openShiftChangeRequest
  \[OpenShiftId \<String\>\]: key: id of openShift
  \[SchedulingGroupId \<String\>\]: key: id of schedulingGroup
  \[ShiftId \<String\>\]: key: id of shift
  \[SwapShiftsChangeRequestId \<String\>\]: key: id of swapShiftsChangeRequest
  \[TeamId \<String\>\]: key: id of team
  \[TeamsAppDefinitionId \<String\>\]: key: id of teamsAppDefinition
  \[TeamsAppId \<String\>\]: key: id of teamsApp
  \[TeamsAppInstallationId \<String\>\]: key: id of teamsAppInstallation
  \[TeamsAsyncOperationId \<String\>\]: key: id of teamsAsyncOperation
  \[TeamsTabId \<String\>\]: key: id of teamsTab
  \[TimeCardId \<String\>\]: key: id of timeCard
  \[TimeOffId \<String\>\]: key: id of timeOff
  \[TimeOffReasonId \<String\>\]: key: id of timeOffReason
  \[TimeOffRequestId \<String\>\]: key: id of timeOffRequest
  \[UserId \<String\>\]: key: id of user
  \[UserScopeTeamsAppInstallationId \<String\>\]: key: id of userScopeTeamsAppInstallation
  \[WorkforceIntegrationId \<String\>\]: key: id of workforceIntegration

TEAMSAPP \<IMicrosoftGraphTeamsApp1\>: teamsApp
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AppDefinitions \<IMicrosoftGraphTeamsAppDefinition1\[\]\>\]: The details for each version of the app.
    \[Id \<String\>\]: Read-only.
    \[DisplayName \<String\>\]: The name of the app provided by the app developer.
    \[TeamsAppId \<String\>\]: The ID from the Teams app manifest.
    \[Version \<String\>\]: The version number of the application.
  \[DisplayName \<String\>\]: The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
  \[DistributionMethod \<String\>\]: teamsAppDistributionMethod
  \[ExternalId \<String\>\]: The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/new-mgteamprimarychanneltab](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/new-mgteamprimarychanneltab)
