---
external help file: Microsoft.Graph.Security-help.xml
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/new-mgsecurityfilesecurityprofile
schema: 2.0.0
---

# New-MgSecurityFileSecurityProfile

## SYNOPSIS
Create new navigation property to fileSecurityProfiles for security

## SYNTAX

### CreateExpanded (Default)
```
New-MgSecurityFileSecurityProfile [-ActivityGroupNames <String[]>] [-AdditionalProperties <Hashtable>]
 [-AzureSubscriptionId <String>] [-AzureTenantId <String>] [-CertificateThumbprint <String>]
 [-Extensions <String[]>] [-FileType <String>] [-FirstSeenDateTime <DateTime>]
 [-Hashes <IMicrosoftGraphFileHash[]>] [-Id <String>] [-LastSeenDateTime <DateTime>]
 [-MalwareStates <IMicrosoftGraphMalwareState[]>] [-Names <String[]>] [-RiskScore <String>] [-Size <Int64>]
 [-Tags <String[]>] [-VendorInformation <IMicrosoftGraphSecurityVendorInformation>]
 [-VulnerabilityStates <IMicrosoftGraphVulnerabilityState[]>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgSecurityFileSecurityProfile -BodyParameter <IMicrosoftGraphFileSecurityProfile> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to fileSecurityProfiles for security

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

### -ActivityGroupNames
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
fileSecurityProfile
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphFileSecurityProfile
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CertificateThumbprint
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

### -Extensions
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

### -FileType
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

### -Hashes
.
To construct, see NOTES section for HASHES properties and create a hash table.

```yaml
Type: IMicrosoftGraphFileHash[]
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

### -MalwareStates
.
To construct, see NOTES section for MALWARESTATES properties and create a hash table.

```yaml
Type: IMicrosoftGraphMalwareState[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Names
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

### -Size
.

```yaml
Type: Int64
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: 0
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

### -VulnerabilityStates
.
To construct, see NOTES section for VULNERABILITYSTATES properties and create a hash table.

```yaml
Type: IMicrosoftGraphVulnerabilityState[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFileSecurityProfile
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFileSecurityProfile
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphFileSecurityProfile\>: fileSecurityProfile
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[ActivityGroupNames \<String\[\]\>\]: 
  \[AzureSubscriptionId \<String\>\]: 
  \[AzureTenantId \<String\>\]: 
  \[CertificateThumbprint \<String\>\]: 
  \[Extensions \<String\[\]\>\]: 
  \[FileType \<String\>\]: 
  \[FirstSeenDateTime \<DateTime?\>\]: 
  \[Hashes \<IMicrosoftGraphFileHash\[\]\>\]: 
    \[HashType \<String\>\]: fileHashType
    \[HashValue \<String\>\]: Value of the file hash.
  \[LastSeenDateTime \<DateTime?\>\]: 
  \[MalwareStates \<IMicrosoftGraphMalwareState\[\]\>\]: 
    \[Category \<String\>\]: Provider-generated malware category (for example, trojan, ransomware, etc.).
    \[Family \<String\>\]: Provider-generated malware family (for example, 'wannacry', 'notpetya', etc.).
    \[Name \<String\>\]: Provider-generated malware variant name (for example, Trojan:Win32/Powessere.H).
    \[Severity \<String\>\]: Provider-determined severity of this malware.
    \[WasRunning \<Boolean?\>\]: Indicates whether the detected file (malware/vulnerability) was running at the time of detection or was detected at rest on the disk.
  \[Names \<String\[\]\>\]: 
  \[RiskScore \<String\>\]: 
  \[Size \<Int64?\>\]: 
  \[Tags \<String\[\]\>\]: 
  \[VendorInformation \<IMicrosoftGraphSecurityVendorInformation\>\]: securityVendorInformation
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Provider \<String\>\]: Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.
    \[ProviderVersion \<String\>\]: Version of the provider or subprovider, if it exists, that generated the alert.
Required
    \[SubProvider \<String\>\]: Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.
    \[Vendor \<String\>\]: Name of the alert vendor (for example, Microsoft, Dell, FireEye).
Required
  \[VulnerabilityStates \<IMicrosoftGraphVulnerabilityState\[\]\>\]: 
    \[Cve \<String\>\]: Common Vulnerabilities and Exposures (CVE) for the vulnerability.
    \[Severity \<String\>\]: Base Common Vulnerability Scoring System (CVSS) severity score for this vulnerability.
    \[WasRunning \<Boolean?\>\]: Indicates whether the detected vulnerability (file) was running at the time of detection or was the file detected at rest on the disk.

HASHES \<IMicrosoftGraphFileHash\[\]\>: .
  \[HashType \<String\>\]: fileHashType
  \[HashValue \<String\>\]: Value of the file hash.

MALWARESTATES \<IMicrosoftGraphMalwareState\[\]\>: .
  \[Category \<String\>\]: Provider-generated malware category (for example, trojan, ransomware, etc.).
  \[Family \<String\>\]: Provider-generated malware family (for example, 'wannacry', 'notpetya', etc.).
  \[Name \<String\>\]: Provider-generated malware variant name (for example, Trojan:Win32/Powessere.H).
  \[Severity \<String\>\]: Provider-determined severity of this malware.
  \[WasRunning \<Boolean?\>\]: Indicates whether the detected file (malware/vulnerability) was running at the time of detection or was detected at rest on the disk.

VENDORINFORMATION \<IMicrosoftGraphSecurityVendorInformation\>: securityVendorInformation
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Provider \<String\>\]: Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.
  \[ProviderVersion \<String\>\]: Version of the provider or subprovider, if it exists, that generated the alert.
Required
  \[SubProvider \<String\>\]: Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.
  \[Vendor \<String\>\]: Name of the alert vendor (for example, Microsoft, Dell, FireEye).
Required

VULNERABILITYSTATES \<IMicrosoftGraphVulnerabilityState\[\]\>: .
  \[Cve \<String\>\]: Common Vulnerabilities and Exposures (CVE) for the vulnerability.
  \[Severity \<String\>\]: Base Common Vulnerability Scoring System (CVSS) severity score for this vulnerability.
  \[WasRunning \<Boolean?\>\]: Indicates whether the detected vulnerability (file) was running at the time of detection or was the file detected at rest on the disk.

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/new-mgsecurityfilesecurityprofile](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/new-mgsecurityfilesecurityprofile)
