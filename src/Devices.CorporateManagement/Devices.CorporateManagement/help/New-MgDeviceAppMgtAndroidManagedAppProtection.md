---
external help file: Microsoft.Graph.Devices.CorporateManagement-help.xml
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtandroidmanagedappprotection
schema: 2.0.0
---

# New-MgDeviceAppMgtAndroidManagedAppProtection

## SYNOPSIS
Create new navigation property to androidManagedAppProtections for deviceAppManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceAppMgtAndroidManagedAppProtection [-AdditionalProperties <Hashtable>]
 [-AllowedAndroidDeviceManufacturers <String>] [-AllowedAndroidDeviceModels <String[]>]
 [-AllowedDataIngestionLocations <String[]>] [-AllowedDataStorageLocations <String[]>]
 [-AllowedInboundDataTransferSources <String>] [-AllowedOutboundClipboardSharingExceptionLength <Int32>]
 [-AllowedOutboundClipboardSharingLevel <String>] [-AllowedOutboundDataTransferDestinations <String>]
 [-AppActionIfAndroidDeviceManufacturerNotAllowed <String>] [-AppActionIfAndroidDeviceModelNotAllowed <String>]
 [-AppActionIfAndroidSafetyNetAppsVerificationFailed <String>]
 [-AppActionIfAndroidSafetyNetDeviceAttestationFailed <String>] [-AppActionIfDeviceComplianceRequired <String>]
 [-AppActionIfDeviceLockNotSet <String>] [-AppActionIfMaximumPinRetriesExceeded <String>]
 [-AppActionIfUnableToAuthenticateUser <String>] [-ApprovedKeyboards <IMicrosoftGraphKeyValuePair[]>]
 [-Apps <IMicrosoftGraphManagedMobileApp[]>]
 [-Assignments <IMicrosoftGraphTargetedManagedAppPolicyAssignment[]>] [-BiometricAuthenticationBlocked]
 [-BlockAfterCompanyPortalUpdateDeferralInDays <Int32>] [-BlockDataIngestionIntoOrganizationDocuments]
 [-ContactSyncBlocked] [-CreatedDateTime <DateTime>] [-CustomBrowserDisplayName <String>]
 [-CustomBrowserPackageId <String>] [-CustomDialerAppDisplayName <String>] [-CustomDialerAppPackageId <String>]
 [-DataBackupBlocked] [-DeployedAppCount <Int32>]
 [-DeploymentSummary <IMicrosoftGraphManagedAppPolicyDeploymentSummary>] [-Description <String>]
 [-DeviceComplianceRequired] [-DeviceLockRequired] [-DialerRestrictionLevel <String>]
 [-DisableAppEncryptionIfDeviceEncryptionIsEnabled] [-DisableAppPinIfDevicePinIsSet] [-DisplayName <String>]
 [-EncryptAppData] [-ExemptedAppPackages <IMicrosoftGraphKeyValuePair[]>] [-FingerprintBlocked] [-Id <String>]
 [-IsAssigned] [-KeyboardsRestricted] [-LastModifiedDateTime <DateTime>] [-ManagedBrowser <String>]
 [-ManagedBrowserToOpenLinksRequired] [-MaximumAllowedDeviceThreatLevel <String>] [-MaximumPinRetries <Int32>]
 [-MinimumPinLength <Int32>] [-MinimumRequiredAppVersion <String>]
 [-MinimumRequiredCompanyPortalVersion <String>] [-MinimumRequiredOSVersion <String>]
 [-MinimumRequiredPatchVersion <String>] [-MinimumWarningAppVersion <String>]
 [-MinimumWarningCompanyPortalVersion <String>] [-MinimumWarningOSVersion <String>]
 [-MinimumWarningPatchVersion <String>] [-MinimumWipeAppVersion <String>]
 [-MinimumWipeCompanyPortalVersion <String>] [-MinimumWipeOSVersion <String>]
 [-MinimumWipePatchVersion <String>] [-MobileThreatDefenseRemediationAction <String>]
 [-NotificationRestriction <String>] [-OrganizationalCredentialsRequired] [-PeriodBeforePinReset <TimeSpan>]
 [-PeriodOfflineBeforeAccessCheck <TimeSpan>] [-PeriodOfflineBeforeWipeIsEnforced <TimeSpan>]
 [-PeriodOnlineBeforeAccessCheck <TimeSpan>] [-PinCharacterSet <String>] [-PinRequired]
 [-PinRequiredInsteadOfBiometricTimeout <TimeSpan>] [-PreviousPinBlockCount <Int32>] [-PrintBlocked]
 [-RequiredAndroidSafetyNetAppsVerificationType <String>]
 [-RequiredAndroidSafetyNetDeviceAttestationType <String>] [-RequiredAndroidSafetyNetEvaluationType <String>]
 [-RoleScopeTagIds <String[]>] [-SaveAsBlocked] [-ScreenCaptureBlocked] [-SimplePinBlocked]
 [-TargetedAppManagementLevels <String>] [-Version <String>]
 [-WarnAfterCompanyPortalUpdateDeferralInDays <Int32>] [-WipeAfterCompanyPortalUpdateDeferralInDays <Int32>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgDeviceAppMgtAndroidManagedAppProtection -BodyParameter <IMicrosoftGraphAndroidManagedAppProtection1>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to androidManagedAppProtections for deviceAppManagement

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

### -AllowedAndroidDeviceManufacturers
Semicolon seperated list of device manufacturers allowed, as a string, for the managed app to work.

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

### -AllowedAndroidDeviceModels
List of device models allowed, as a string, for the managed app to work.

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

### -AllowedDataIngestionLocations
Data storage locations where a user may store managed data.

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

### -AllowedDataStorageLocations
Data storage locations where a user may store managed data.

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

### -AllowedInboundDataTransferSources
managedAppDataTransferLevel

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

### -AllowedOutboundClipboardSharingExceptionLength
Specify the number of characters that may be cut or copied from Org data and accounts to any application.
This setting overrides the AllowedOutboundClipboardSharingLevel restriction.
Default value of '0' means no exception is allowed.

```yaml
Type: Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedOutboundClipboardSharingLevel
managedAppClipboardSharingLevel

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

### -AllowedOutboundDataTransferDestinations
managedAppDataTransferLevel

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

### -AppActionIfAndroidDeviceManufacturerNotAllowed
managedAppRemediationAction

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

### -AppActionIfAndroidDeviceModelNotAllowed
managedAppRemediationAction

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

### -AppActionIfAndroidSafetyNetAppsVerificationFailed
managedAppRemediationAction

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

### -AppActionIfAndroidSafetyNetDeviceAttestationFailed
managedAppRemediationAction

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

### -AppActionIfDeviceComplianceRequired
managedAppRemediationAction

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

### -AppActionIfDeviceLockNotSet
managedAppRemediationAction

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

### -AppActionIfMaximumPinRetriesExceeded
managedAppRemediationAction

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

### -AppActionIfUnableToAuthenticateUser
managedAppRemediationAction

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

### -ApprovedKeyboards
If Keyboard Restriction is enabled, only keyboards in this approved list will be allowed.
A key should be Android package id for a keyboard and value should be a friendly name
To construct, see NOTES section for APPROVEDKEYBOARDS properties and create a hash table.

```yaml
Type: IMicrosoftGraphKeyValuePair[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Apps
List of apps to which the policy is deployed.
To construct, see NOTES section for APPS properties and create a hash table.

```yaml
Type: IMicrosoftGraphManagedMobileApp[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphTargetedManagedAppPolicyAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BiometricAuthenticationBlocked
Indicates whether use of the biometric authentication is allowed in place of a pin if PinRequired is set to True.

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

### -BlockAfterCompanyPortalUpdateDeferralInDays
Maximum number of days Company Portal update can be deferred on the device or app access will be blocked.

```yaml
Type: Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -BlockDataIngestionIntoOrganizationDocuments
Indicates whether a user can bring data into org documents.

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

### -BodyParameter
Policy used to configure detailed management settings targeted to specific security groups and for a specified set of apps on an Android device
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphAndroidManagedAppProtection1
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContactSyncBlocked
Indicates whether contacts can be synced to the user's device.

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

### -CreatedDateTime
The date and time the policy was created.

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

### -CustomBrowserDisplayName
Friendly name of the preferred custom browser to open weblink on Android.
When this property is configured, ManagedBrowserToOpenLinksRequired should be true.

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

### -CustomBrowserPackageId
Unique identifier of the preferred custom browser to open weblink on Android.
When this property is configured, ManagedBrowserToOpenLinksRequired should be true.

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

### -CustomDialerAppDisplayName
Friendly name of a custom dialer app to click-to-open a phone number on Android.

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

### -CustomDialerAppPackageId
PackageId of a custom dialer app to click-to-open a phone number on Android.

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

### -DataBackupBlocked
Indicates whether the backup of a managed app's data is blocked.

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

### -DeployedAppCount
Count of apps to which the current policy is deployed.

```yaml
Type: Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeploymentSummary
The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
To construct, see NOTES section for DEPLOYMENTSUMMARY properties and create a hash table.

```yaml
Type: IMicrosoftGraphManagedAppPolicyDeploymentSummary
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The policy's description.

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

### -DeviceComplianceRequired
Indicates whether device compliance is required.

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

### -DeviceLockRequired
Defines if any kind of lock must be required on android device

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

### -DialerRestrictionLevel
managedAppPhoneNumberRedirectLevel

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

### -DisableAppEncryptionIfDeviceEncryptionIsEnabled
When this setting is enabled, app level encryption is disabled if device level encryption is enabled

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

### -DisableAppPinIfDevicePinIsSet
Indicates whether use of the app pin is required if the device pin is set.

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

### -DisplayName
Policy display name.

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

### -EncryptAppData
Indicates whether application data for managed apps should be encrypted

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

### -ExemptedAppPackages
App packages in this list will be exempt from the policy and will be able to receive data from managed apps.
To construct, see NOTES section for EXEMPTEDAPPPACKAGES properties and create a hash table.

```yaml
Type: IMicrosoftGraphKeyValuePair[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FingerprintBlocked
Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.

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

### -IsAssigned
Indicates if the policy is deployed to any inclusion groups or not.

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

### -KeyboardsRestricted
Indicates if keyboard restriction is enabled.
If enabled list of approved keyboards must be provided as well.

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
Last time the policy was modified.

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

### -ManagedBrowser
managedBrowserType

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

### -ManagedBrowserToOpenLinksRequired
Indicates whether internet links should be opened in the managed browser app, or any custom browser specified by CustomBrowserProtocol (for iOS) or CustomBrowserPackageId/CustomBrowserDisplayName (for Android)

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

### -MaximumAllowedDeviceThreatLevel
managedAppDeviceThreatLevel

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

### -MaximumPinRetries
Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.

```yaml
Type: Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumPinLength
Minimum pin length required for an app-level pin if PinRequired is set to True

```yaml
Type: Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -MinimumRequiredAppVersion
Versions less than the specified version will block the managed app from accessing company data.

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

### -MinimumRequiredCompanyPortalVersion
Minimum version of the Company portal that must be installed on the device or app access will be blocked

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

### -MinimumRequiredOSVersion
Versions less than the specified version will block the managed app from accessing company data.

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

### -MinimumRequiredPatchVersion
Define the oldest required Android security patch level a user can have to gain secure access to the app.

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

### -MinimumWarningAppVersion
Versions less than the specified version will result in warning message on the managed app.

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

### -MinimumWarningCompanyPortalVersion
Minimum version of the Company portal that must be installed on the device or the user will receive a warning

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

### -MinimumWarningOSVersion
Versions less than the specified version will result in warning message on the managed app from accessing company data.

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

### -MinimumWarningPatchVersion
Define the oldest recommended Android security patch level a user can have for secure access to the app.

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

### -MinimumWipeAppVersion
Versions less than or equal to the specified version will wipe the managed app and the associated company data.

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

### -MinimumWipeCompanyPortalVersion
Minimum version of the Company portal that must be installed on the device or the company data on the app will be wiped

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

### -MinimumWipeOSVersion
Versions less than or equal to the specified version will wipe the managed app and the associated company data.

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

### -MinimumWipePatchVersion
Android security patch level less than or equal to the specified value will wipe the managed app and the associated company data.

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

### -MobileThreatDefenseRemediationAction
managedAppRemediationAction

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

### -NotificationRestriction
managedAppNotificationRestriction

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

### -OrganizationalCredentialsRequired
Indicates whether organizational credentials are required for app use.

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

### -PeriodBeforePinReset
TimePeriod before the all-level pin must be reset if PinRequired is set to True.

```yaml
Type: TimeSpan
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PeriodOfflineBeforeAccessCheck
The period after which access is checked when the device is not connected to the internet.

```yaml
Type: TimeSpan
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PeriodOfflineBeforeWipeIsEnforced
The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.

```yaml
Type: TimeSpan
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PeriodOnlineBeforeAccessCheck
The period after which access is checked when the device is connected to the internet.

```yaml
Type: TimeSpan
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PinCharacterSet
managedAppPinCharacterSet

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

### -PinRequired
Indicates whether an app-level pin is required.

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

### -PinRequiredInsteadOfBiometricTimeout
Timeout in minutes for an app pin instead of non biometrics passcode

```yaml
Type: TimeSpan
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PreviousPinBlockCount
Requires a pin to be unique from the number specified in this property.

```yaml
Type: Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrintBlocked
Indicates whether printing is allowed from managed apps.

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

### -RequiredAndroidSafetyNetAppsVerificationType
androidManagedAppSafetyNetAppsVerificationType

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

### -RequiredAndroidSafetyNetDeviceAttestationType
androidManagedAppSafetyNetDeviceAttestationType

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

### -RequiredAndroidSafetyNetEvaluationType
androidManagedAppSafetyNetEvaluationType

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

### -RoleScopeTagIds
List of Scope Tags for this Entity instance.

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

### -SaveAsBlocked
Indicates whether users may use the 'Save As' menu item to save a copy of protected files.

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

### -ScreenCaptureBlocked
Indicates whether a managed user can take screen captures of managed apps

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

### -SimplePinBlocked
Indicates whether simplePin is blocked.

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

### -TargetedAppManagementLevels
appManagementLevel

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

### -Version
Version of the entity.

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

### -WarnAfterCompanyPortalUpdateDeferralInDays
Maximum number of days Company Portal update can be deferred on the device or the user will receive the warning

```yaml
Type: Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -WipeAfterCompanyPortalUpdateDeferralInDays
Maximum number of days Company Portal update can be deferred on the device or the company data on the app will be wiped

```yaml
Type: Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: 0
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAndroidManagedAppProtection1
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAndroidManagedAppProtection1
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

APPS \<IMicrosoftGraphManagedMobileApp\[\]\>: List of apps to which the policy is deployed.
  \[Id \<String\>\]: Read-only.
  \[MobileAppIdentifier \<IMicrosoftGraphMobileAppIdentifier\>\]: The identifier for a mobile app.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Version \<String\>\]: Version of the entity.

ASSIGNMENTS \<IMicrosoftGraphTargetedManagedAppPolicyAssignment1\[\]\>: Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
  \[Id \<String\>\]: Read-only.
  \[Target \<IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1\>\]: Base type for assignment targets.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.

BODYPARAMETER \<IMicrosoftGraphAndroidManagedAppProtection\>: Policy used to configure detailed management settings targeted to specific security groups and for a specified set of apps on an Android device
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Assignments \<IMicrosoftGraphTargetedManagedAppPolicyAssignment1\[\]\>\]: Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
    \[Id \<String\>\]: Read-only.
    \[Target \<IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1\>\]: Base type for assignment targets.
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[IsAssigned \<Boolean?\>\]: Indicates if the policy is deployed to any inclusion groups or not.
  \[AllowedDataStorageLocations \<String\[\]\>\]: Data storage locations where a user may store managed data.
  \[AllowedInboundDataTransferSources \<String\>\]: managedAppDataTransferLevel
  \[AllowedOutboundClipboardSharingLevel \<String\>\]: managedAppClipboardSharingLevel
  \[AllowedOutboundDataTransferDestinations \<String\>\]: managedAppDataTransferLevel
  \[ContactSyncBlocked \<Boolean?\>\]: Indicates whether contacts can be synced to the user's device.
  \[DataBackupBlocked \<Boolean?\>\]: Indicates whether the backup of a managed app's data is blocked.
  \[DeviceComplianceRequired \<Boolean?\>\]: Indicates whether device compliance is required.
  \[DisableAppPinIfDevicePinIsSet \<Boolean?\>\]: Indicates whether use of the app pin is required if the device pin is set.
  \[FingerprintBlocked \<Boolean?\>\]: Indicates whether use of the fingerprint reader is allowed in place of a pin if PinRequired is set to True.
  \[ManagedBrowser \<String\>\]: managedBrowserType
  \[ManagedBrowserToOpenLinksRequired \<Boolean?\>\]: Indicates whether internet links should be opened in the managed browser app, or any custom browser specified by CustomBrowserProtocol (for iOS) or CustomBrowserPackageId/CustomBrowserDisplayName (for Android)
  \[MaximumPinRetries \<Int32?\>\]: Maximum number of incorrect pin retry attempts before the managed app is either blocked or wiped.
  \[MinimumPinLength \<Int32?\>\]: Minimum pin length required for an app-level pin if PinRequired is set to True
  \[MinimumRequiredAppVersion \<String\>\]: Versions less than the specified version will block the managed app from accessing company data.
  \[MinimumRequiredOSVersion \<String\>\]: Versions less than the specified version will block the managed app from accessing company data.
  \[MinimumWarningAppVersion \<String\>\]: Versions less than the specified version will result in warning message on the managed app.
  \[MinimumWarningOSVersion \<String\>\]: Versions less than the specified version will result in warning message on the managed app from accessing company data.
  \[OrganizationalCredentialsRequired \<Boolean?\>\]: Indicates whether organizational credentials are required for app use.
  \[PeriodBeforePinReset \<TimeSpan?\>\]: TimePeriod before the all-level pin must be reset if PinRequired is set to True.
  \[PeriodOfflineBeforeAccessCheck \<TimeSpan?\>\]: The period after which access is checked when the device is not connected to the internet.
  \[PeriodOfflineBeforeWipeIsEnforced \<TimeSpan?\>\]: The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped.
  \[PeriodOnlineBeforeAccessCheck \<TimeSpan?\>\]: The period after which access is checked when the device is connected to the internet.
  \[PinCharacterSet \<String\>\]: managedAppPinCharacterSet
  \[PinRequired \<Boolean?\>\]: Indicates whether an app-level pin is required.
  \[PrintBlocked \<Boolean?\>\]: Indicates whether printing is allowed from managed apps.
  \[SaveAsBlocked \<Boolean?\>\]: Indicates whether users may use the 'Save As' menu item to save a copy of protected files.
  \[SimplePinBlocked \<Boolean?\>\]: Indicates whether simplePin is blocked.
  \[CreatedDateTime \<DateTime?\>\]: The date and time the policy was created.
  \[Description \<String\>\]: The policy's description.
  \[DisplayName \<String\>\]: Policy display name.
  \[LastModifiedDateTime \<DateTime?\>\]: Last time the policy was modified.
  \[Version \<String\>\]: Version of the entity.
  \[Id \<String\>\]: Read-only.
  \[Apps \<IMicrosoftGraphManagedMobileApp\[\]\>\]: List of apps to which the policy is deployed.
    \[Id \<String\>\]: Read-only.
    \[MobileAppIdentifier \<IMicrosoftGraphMobileAppIdentifier\>\]: The identifier for a mobile app.
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Version \<String\>\]: Version of the entity.
  \[CustomBrowserDisplayName \<String\>\]: Friendly name of the preferred custom browser to open weblink on Android.
When this property is configured, ManagedBrowserToOpenLinksRequired should be true.
  \[CustomBrowserPackageId \<String\>\]: Unique identifier of the preferred custom browser to open weblink on Android.
When this property is configured, ManagedBrowserToOpenLinksRequired should be true.
  \[DeployedAppCount \<Int32?\>\]: Count of apps to which the current policy is deployed.
  \[DeploymentSummary \<IMicrosoftGraphManagedAppPolicyDeploymentSummary\>\]: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[ConfigurationDeployedUserCount \<Int32?\>\]: Not yet documented
    \[ConfigurationDeploymentSummaryPerApp \<IMicrosoftGraphManagedAppPolicyDeploymentSummaryPerApp\[\]\>\]: Not yet documented
      \[ConfigurationAppliedUserCount \<Int32?\>\]: Number of users the policy is applied.
      \[MobileAppIdentifier \<IMicrosoftGraphMobileAppIdentifier\>\]: The identifier for a mobile app.
    \[DisplayName \<String\>\]: Not yet documented
    \[LastRefreshTime \<DateTime?\>\]: Not yet documented
    \[Version \<String\>\]: Version of the entity.
  \[DisableAppEncryptionIfDeviceEncryptionIsEnabled \<Boolean?\>\]: When this setting is enabled, app level encryption is disabled if device level encryption is enabled
  \[EncryptAppData \<Boolean?\>\]: Indicates whether application data for managed apps should be encrypted
  \[MinimumRequiredPatchVersion \<String\>\]: Define the oldest required Android security patch level a user can have to gain secure access to the app.
  \[MinimumWarningPatchVersion \<String\>\]: Define the oldest recommended Android security patch level a user can have for secure access to the app.
  \[ScreenCaptureBlocked \<Boolean?\>\]: Indicates whether a managed user can take screen captures of managed apps

DEPLOYMENTSUMMARY \<IMicrosoftGraphManagedAppPolicyDeploymentSummary\>: The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[ConfigurationDeployedUserCount \<Int32?\>\]: Not yet documented
  \[ConfigurationDeploymentSummaryPerApp \<IMicrosoftGraphManagedAppPolicyDeploymentSummaryPerApp\[\]\>\]: Not yet documented
    \[ConfigurationAppliedUserCount \<Int32?\>\]: Number of users the policy is applied.
    \[MobileAppIdentifier \<IMicrosoftGraphMobileAppIdentifier\>\]: The identifier for a mobile app.
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DisplayName \<String\>\]: Not yet documented
  \[LastRefreshTime \<DateTime?\>\]: Not yet documented
  \[Version \<String\>\]: Version of the entity.

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtandroidmanagedappprotection](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtandroidmanagedappprotection)
