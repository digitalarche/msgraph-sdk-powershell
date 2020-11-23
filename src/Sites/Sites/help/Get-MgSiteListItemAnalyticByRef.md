---
external help file: Microsoft.Graph.Sites-help.xml
Module Name: Microsoft.Graph.Sites
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.sites/get-mgsitelistitemanalyticbyref
schema: 2.0.0
---

# Get-MgSiteListItemAnalyticByRef

## SYNOPSIS
Get ref of analytics from sites

## SYNTAX

### Get1 (Default)
```
Get-MgSiteListItemAnalyticByRef -ListId <String> -ListItemId <String> -SiteId <String> [<CommonParameters>]
```

### GetViaIdentity1
```
Get-MgSiteListItemAnalyticByRef -InputObject <ISitesIdentity> [<CommonParameters>]
```

## DESCRIPTION
Get ref of analytics from sites

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: ISitesIdentity
Parameter Sets: GetViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ListId
key: id of list

```yaml
Type: String
Parameter Sets: Get1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ListItemId
key: id of listItem

```yaml
Type: String
Parameter Sets: Get1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteId
key: id of site

```yaml
Type: String
Parameter Sets: Get1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.ISitesIdentity
## OUTPUTS

### System.String
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT \<ISitesIdentity\>: Identity Parameter
  \[ColumnDefinitionId \<String\>\]: key: id of columnDefinition
  \[ColumnLinkId \<String\>\]: key: id of columnLink
  \[ContentTypeId \<String\>\]: key: id of contentType
  \[DriveId \<String\>\]: key: id of drive
  \[EndDateTime \<String\>\]: 
  \[GroupId \<String\>\]: key: id of group
  \[IncludePersonalNotebooks \<Boolean?\>\]: 
  \[Interval \<String\>\]: 
  \[ListId \<String\>\]: key: id of list
  \[ListItemId \<String\>\]: key: id of listItem
  \[ListItemVersionId \<String\>\]: key: id of listItemVersion
  \[NotebookId \<String\>\]: key: id of notebook
  \[OnenotePageId \<String\>\]: key: id of onenotePage
  \[OnenoteSectionId \<String\>\]: key: id of onenoteSection
  \[Path \<String\>\]: 
  \[SiteId \<String\>\]: key: id of site
  \[SiteId1 \<String\>\]: key: id of site
  \[SitePageId \<String\>\]: key: id of sitePage
  \[StartDateTime \<String\>\]: 
  \[SubscriptionId \<String\>\]: key: id of subscription
  \[UserId \<String\>\]: key: id of user

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.sites/get-mgsitelistitemanalyticbyref](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.sites/get-mgsitelistitemanalyticbyref)
