# Power BI Tenant Settings Comparison
**September 2024 vs November 2025**

Generated: November 20, 2025

---

## Executive Summary

- **September 2024 Model**: 130 tenant settings
- **November 2025 Model**: 159 tenant settings
- **New Settings Added**: 29 settings
- **Settings Changed**: 22 settings modified
- **Settings Removed**: 1 setting

---

## 1. New Settings in November 2025 (29 Total)

### Admin API Settings (1 new)

| Setting Name | Status | Description |
|-------------|--------|-------------|
| `AllowServicePrincipalsUseWriteAdminAPIs` | ❌ Disabled | Service principals can access admin APIs used for updates |

### Advanced Networking (2 new)

| Setting Name | Status | Description |
|-------------|--------|-------------|
| `WorkspaceBlockInboundAccess` | ❌ Disabled | Configure workspace-level inbound network rules |
| `WorkspaceBlockOutboundAccess` | ❌ Disabled | Configure workspace-level outbound network rules |

### Audit and Usage Settings (2 new)

| Setting Name | Status | Description |
|-------------|--------|-------------|
| `AllowCapacityMetricsReportUserMask` | ✅ Enabled | Show user data in the Fabric Capacity Metrics app and reports |
| `PlatformMonitoringTenantSetting` | ✅ Enabled | Workspace admins can turn on monitoring for their workspaces (preview) |

### Azure Maps Services (3 new - NEW CATEGORY)

| Setting Name | Status | Description |
|-------------|--------|-------------|
| `AzureMapsInFabric` | ✅ Enabled | Users can use Azure Maps services |
| `AzureMapsInFabricCrossRegionDataProcessing` | ❌ Disabled | Data sent to Azure Maps can be processed outside your capacity's geographic region, compliance boundary or national cloud instance |
| `AzureMapsWeatherServices` | ✅ Enabled | Users can use Azure Maps Weather Services (Preview) |

### Copilot and Azure OpenAI Service (4 new)

| Setting Name | Status | Description |
|-------------|--------|-------------|
| `ImmersiveTenantAdminSwitch` | ✅ Enabled | Users can access standalone Copilot in Power BI and the Power BI agent (preview) |
| `CopilotCapacitySetupPermissionSwitch` | ❌ Disabled | Capacities can be designated as Fabric Copilot capacities |
| `AllowStoreAOAIDataInOtherRegions` | ❌ Disabled | Data sent to Azure OpenAI can be stored outside your capacity's geographic region, compliance boundary, or national cloud instance |
| `PreppedForCopilotContentDiscovery` | ❌ Disabled | Only show approved items in the standalone Copilot in Power BI experience (preview) |

### Encryption (1 new - NEW CATEGORY)

| Setting Name | Status | Description |
|-------------|--------|-------------|
| `WorkspaceCmk` | ❌ Disabled | Apply customer-managed keys |

### Explore Settings (1 new - NEW CATEGORY)

| Setting Name | Status | Description |
|-------------|--------|-------------|
| `AdminDataExploreViewPermission` | ✅ Enabled | Users with view permission can launch Explore |

### Information Protection (2 new)

| Setting Name | Status | Description |
|-------------|--------|-------------|
| `EimInformationProtectionDefaultLabelDomainSetting` | ❌ Disabled | Domain admins can set default sensitivity labels for their domains (preview) |
| `DataSecurityForAIInteractions` | ✅ Enabled | Allow Microsoft Purview to secure AI interactions |

### Integration Settings (5 new)

| Setting Name | Status | Description |
|-------------|--------|-------------|
| `AzureMapsCrossRegionDataProcessing` | ❌ Disabled | Data sent to Azure Maps can be processed outside your tenant's geographic region, compliance boundary, or national cloud instance |
| `AzureMapsThirdPartyDataProcessing` | ❌ Disabled | Data sent to Azure Maps can be processed by Microsoft Online Services Subprocessors |
| `BingMap` | ❌ Disabled | Map and filled map visuals |
| `EnableEsriLibraries` | ❌ Disabled | ArcGIS GeoAnalytics for Fabric Runtime |
| `AllowNonEntraADAuthInEventStream` | ✅ Enabled | Allow non-Entra ID auth in Eventstream |
| `DirectLakeOnOneLakeSemanticModelCreation` | ✅ Enabled | Users can create "Direct Lake on OneLake semantic models" (preview) |

### Microsoft Fabric (11 new)

| Setting Name | Status | Description |
|-------------|--------|-------------|
| `HLSWorkloadTenantSwitch` | ❌ Disabled | Users can create Healthcare Cohort items (preview) |
| `DigitalOperationsPreview` | ❌ Disabled | Digital Twin Builder (preview) |
| `OntologyPreview` | ❌ Disabled | Enable Ontology item (preview) |
| `ArtifactOrgAppPreview` | ✅ Enabled | Users can discover and create org apps (preview) |
| `EnableMetricSet` | ❌ Disabled | Users can discover and use metrics (preview) |
| `ArtifactGraphPreview` | ❌ Disabled | User can create Graph (preview) |
| `FabricPromotionTenantSwitch` | ❌ Disabled | Users can be informed of upcoming conferences featuring Microsoft Fabric when they are logged in to Fabric |
| `MLModelEndpointsTenantSwitch` | ❌ Disabled | ML models can serve real-time predictions from API endpoints (preview) |
| `RTHAnomalyDetectionTenantSwitch` | ❌ Disabled | Detect anomalies in Real-Time Intelligence (Preview) |
| `ArtifactMapTenantSwitch` | ❌ Disabled | Users can create Maps (preview) |
| `RTHOperationalAgentsTenantSwitch` | ❌ Disabled | Enable Operations Agents (Preview) |
| `ShowActivatorEntryPointsTenantSwitch` | ✅ Enabled | All Power BI users can see "Set alert" button to create Fabric Activator alerts |
| `ArtifactSnowflakeDatabasePreview` | ❌ Disabled | Enable Snowflake database item (preview) |

### OneLake Settings (4 new)

| Setting Name | Status | Description |
|-------------|--------|-------------|
| `AllowGetOneLakeUDK` | ✅ Enabled | Use short-lived user-delegated SAS tokens |
| `AllowOneLakeUDK` | ❌ Disabled | Authenticate with OneLake user-delegated SAS tokens |
| `DeltaToIcebergTableVirtualization` | ❌ Disabled | Enable Delta Lake to Apache Iceberg table format virtualization (preview) |
| `OneLakeDiagnosticLogsEUII` | ✅ Enabled | Include end-user identifiers in OneLake diagnostic logs |

### Additional Workloads (2 new)

| Setting Name | Status | Description |
|-------------|--------|-------------|
| `FabricAddWorkloadToWorkspace` | ✅ Enabled | Workspace admins can add and remove additional workloads (preview) |
| `ThirdPartyPrivateWorkloads` | ❌ Disabled | Users can see and work with additional workloads not validated by Microsoft |

### Workspace Settings (1 new)

| Setting Name | Status | Description |
|-------------|--------|-------------|
| `AutomaticallyUsePBIR` | ✅ Enabled | Automatically convert and store reports using Power BI enhanced metadata format (PBIR) (preview) |

---

## 2. Settings Changed Between Versions

### Settings with Status Changes

| Setting Name | Sept 2024 | Nov 2025 | Impact | Description |
|-------------|-----------|----------|--------|-------------|
| `AdminApisIncludeDetailedMetadata` | ✅ Enabled | ❌ Disabled | 🔴 More Restrictive | Enhance admin APIs responses with detailed metadata |
| `AdminApisIncludeExpressions` | ✅ Enabled | ❌ Disabled | 🔴 More Restrictive | Enhance admin APIs responses with DAX and mashup expressions |
| `TemplatePublish` | ✅ Enabled for groups | ❌ Disabled | 🔴 More Restrictive | Create template organizational apps |
| `CertifyDatasets` | ✅ Enabled for groups | ❌ Disabled | 🔴 More Restrictive | Certification |
| `AllowSendAOAIDataToOtherRegions` | ✅ Enabled | ❌ Disabled | 🔴 More Restrictive | Data sent to Azure OpenAI can be processed outside region |
| `ExternalSharingV2` | ✅ Enabled | ❌ Disabled | 🔴 More Restrictive | Users can invite guest users to collaborate through item sharing and permissions |
| `ElevatedGuestsTenant` | ❌ Disabled | ✅ Enabled | 🟢 More Permissive | Guest users can browse and access Fabric content |
| `GitHubTenantSettings` | ❌ Disabled | ✅ Enabled | 🟢 More Permissive | Users can sync workspace items with GitHub repositories |
| `FabricFeedbackTenantSwitch` | ✅ Enabled | ❌ Disabled | 🔴 More Restrictive | Product Feedback |
| `AISkillArtifactTenantSwitch` | ❌ Disabled | ✅ Enabled | 🟢 More Permissive | Users can create and share Data agent item types (preview) |
| `FabricAddPartnerWorkload` | ❌ Disabled | ✅ Enabled | 🟢 More Permissive | Capacity admins and contributors can add and remove additional workloads |
| `CreateAppWorkspaces` | ✅ Enabled for groups | ✅ Enabled for entire org | 🟢 More Permissive | Create workspaces |
| `GoogleBigQuerySSO` | ❌ Disabled | ✅ Enabled | 🟢 More Permissive | Google BigQuery SSO |
| `BingMap` | ✅ Enabled | ❌ Disabled | 🔴 More Restrictive | Map and filled map visuals (moved from Integration to new setting) |

### Settings Renamed or Reorganized

| Sept 2024 Setting | Nov 2025 Setting | Change Type |
|-------------------|------------------|-------------|
| `AllowAccessOverPrivateLinks` | `AllowAccessOverPrivateLinks` | Title changed: "Azure Private Link" → "Tenant-level Private Link" |
| `ServicePrincipalAccess` | Split into 2 settings | Split into `ServicePrincipalAccessGlobalAPIs` (Disabled) and `ServicePrincipalAccessPermissionAPIs` (Enabled) |
| `AzureMap` | `AzureMaps` + 3 new settings | Expanded into dedicated "Azure Maps services" category with granular controls |
| `EmailSubscriptionsToB2BUsers` | `EmailSubscriptionsToB2BUsers` | Title clarified: "Guest users..." → "B2B guest users..." |
| `AutoInstallPowerBIAppInTeamsTenant` | `AutoInstallPowerBIAppInTeamsTenant` | Title expanded to include "Power BI agent for Microsoft 365 Copilot" |
| `AllowEndorsementMasterDataSwitch` | `AllowEndorsementMasterDataSwitch` | Removed "(preview)" designation |
| `ASWritethruContinuousExportTenantSwitch` | `ASWritethruContinuousExportTenantSwitch` | Title changed: "...export data to OneLake (preview)" → "...export data to OneLake" |
| `WebModelingTenantSwitch` | `WebModelingTenantSwitch` | Category: "Data model settings" → "Semantic model settings"; Removed "(preview)" |
| `EnableAOAI` | `EnableAOAI` | Category title: "Copilot and Azure OpenAI Service​" → "Copilot and Azure OpenAI Service" |
| `GitIntegrationTenantSwitch` | `GitIntegrationTenantSwitch` | Removed "(preview)" designation |
| `GitIntegrationCrossGeoTenantSwitch` | `GitIntegrationCrossGeoTenantSwitch` | Removed "(preview)" designation |
| `GitIntegrationSensitivityLabelsTenantSwitch` | `GitIntegrationSensitivityLabelsTenantSwitch` | Removed "(preview)" designation |
| `PowerPlatformSolutionsIntegrationTenant` | ❌ Removed | No longer present in Nov 2025 |
| `ASWritethruTenantSwitch` | ❌ Removed | Users can store semantic model tables in OneLake (preview) |
| `TridentPrivatePreview` | ❌ Removed | Data Activator (preview) - likely merged/renamed |
| `SustainabilitySolutionsTenantSwitch` | ❌ Removed | Sustainability solutions (preview) |
| `RetailSolutionsTenantSwitch` | ❌ Removed | Retail data solutions (preview) |
| `HealthcareSolutionsTenantSwitch` | ❌ Removed | Healthcare data solutions (preview) - replaced by `HLSWorkloadTenantSwitch` |
| `EnableFabricAirflow` | ❌ Removed | Users can create and use data workflows (preview) |
| `GraphQLTenant` | ❌ Removed | API for GraphQL (preview) |
| `KustoDashboardTenantSwitch` | ❌ Removed | Users can create Real-Time Dashboards (preview) |
| `Mirroring` | ❌ Removed | Database Mirroring (preview) |

---

## 3. Category-Level Analysis

### Categories with Most New Settings

1. **Microsoft Fabric**: 11 new settings (most additions)
2. **Integration Settings**: 5 new settings
3. **OneLake Settings**: 4 new settings
4. **Copilot and Azure OpenAI**: 4 new settings
5. **Azure Maps Services**: 3 new settings (entirely new category)

### New Categories in November 2025

1. **Azure Maps Services** (3 settings)
2. **Encryption** (1 setting)
3. **Explore Settings** (1 setting)

### Categories Renamed

- "Data model settings" → "Semantic model settings"
- "Additional workloads (preview)" → "Additional workloads"

---

## 4. Security & Compliance Impact Analysis

### 🔴 More Restrictive Changes (Security Hardening)

1. **Admin API Access**: Metadata and expressions disabled
2. **Certification**: Disabled for entire organization
3. **Azure OpenAI**: Cross-region data processing disabled
4. **Guest User Invitations**: External sharing through item permissions disabled
5. **Product Feedback**: Disabled
6. **Bing Maps**: Disabled (replaced with Azure Maps)
7. **Template Apps**: Template organizational apps disabled

### 🟢 More Permissive Changes (Expanded Capabilities)

1. **GitHub Integration**: Now enabled for repository sync
2. **Guest Browsing**: Guests can now browse and access Fabric content
3. **Workspace Creation**: Expanded from groups to entire organization
4. **Google BigQuery SSO**: Now enabled
5. **Partner Workloads**: Capacity admins can add workloads
6. **AI Agents**: Data agent items now enabled

### 🔵 New Security Controls Added

1. **Workspace-level Network Rules**: Inbound/outbound controls
2. **Customer-Managed Keys**: Encryption control
3. **OneLake Authentication**: User-delegated SAS tokens
4. **Copilot Capacity Designation**: Control over Copilot capacities
5. **AI Interaction Security**: Microsoft Purview integration

---

## 5. Notable Patterns & Trends

### Preview Features Moving to GA

Several settings removed "(preview)" designation, indicating general availability:
- Git Integration (main switch and sub-features)
- Master data endorsement
- OneLake export for semantic models
- Web modeling for semantic models

### Preview Features Removed/Consolidated

The following preview features were removed, likely consolidated or renamed:
- Data Activator (TridentPrivatePreview)
- Sustainability, Retail, and Healthcare Solutions (replaced by focused workload switches)
- Fabric Airflow, GraphQL, Kusto Dashboards, Mirroring

### Azure Maps Expansion

Azure Maps evolved from a single setting (`AzureMap`) to:
- New dedicated category "Azure Maps services"
- 5 granular settings controlling different aspects
- Cross-region processing controls
- Weather services
- Third-party data processing controls

### Service Principal Access Split

The single `ServicePrincipalAccess` setting split into:
- `ServicePrincipalAccessGlobalAPIs` - Create workspaces, connections, pipelines (Disabled)
- `ServicePrincipalAccessPermissionAPIs` - Call Fabric public APIs (Enabled)

This provides more granular control over service principal permissions.

### Copilot Feature Expansion

Significant expansion of Copilot-related controls:
- Standalone Copilot access
- Capacity designation
- Data storage location controls
- Content discovery restrictions
- Integration with Microsoft 365 Copilot

---

## 6. Recommendations

### Immediate Actions Required

1. **Review Admin API Access**: Consider if disabling metadata/expressions in admin APIs impacts automation
2. **Certification Process**: Verify alternative certification workflows since org-wide certification is disabled
3. **Guest User Strategy**: Review the conflicting changes:
   - ✅ Guests can browse content (ElevatedGuestsTenant: Enabled)
   - ❌ Users cannot invite guests (ExternalSharingV2: Disabled)
4. **Template Apps**: Verify if template organizational apps are still needed
5. **Bing Maps to Azure Maps**: Update any reports using Bing Map visuals

### Security Considerations

1. **Azure OpenAI Data Residency**: Verify this aligns with data residency requirements (cross-region disabled)
2. **Network Controls**: Consider enabling workspace-level network rules if needed
3. **Customer-Managed Keys**: Evaluate if encryption with CMK is required
4. **OneLake Authentication**: Review SAS token usage patterns

### Feature Enablement Review

1. **GitHub Integration**: Now enabled - establish GitHub governance policies
2. **Google BigQuery SSO**: Now enabled - verify authentication requirements
3. **Copilot Features**: Review which users should access standalone Copilot
4. **Partner Workloads**: Establish approval process for additional workloads

---

## 7. Settings Summary by Status

### Enabled for Entire Organization: 85 settings (Nov 2025)
### Disabled for Entire Organization: 68 settings (Nov 2025)
### Enabled for Specific Groups: 6 settings (Nov 2025)

---

## Appendix A: Complete Settings List by Category (Nov 2025)

### Admin API Settings (4 settings)
- ❌ AllowServicePrincipalsUseReadAdminAPIs
- ❌ AllowServicePrincipalsUseWriteAdminAPIs
- ❌ AdminApisIncludeDetailedMetadata
- ❌ AdminApisIncludeExpressions

### Advanced Networking (4 settings)
- ❌ AllowAccessOverPrivateLinks (Tenant-level Private Link)
- ❌ BlockAccessFromPublicNetworks
- ❌ WorkspaceBlockInboundAccess
- ❌ WorkspaceBlockOutboundAccess

### Audit and Usage Settings (5 settings)
- ✅ UsageMetrics
- ✅ UsageMetricsTrackUserLevelInfo
- ✅ AllowCapacityMetricsReportUserMask
- ❌ LogAnalyticsAttachForWorkspaceAdmins
- ✅ PlatformMonitoringTenantSetting
- ✅ ASCollectQueryTextTelemetryTenantSwitch

### Insights Settings (2 settings)
- ✅ AutomatedInsightsTenant
- ✅ AutomatedInsightsEntryPoints

### Azure Maps Services (3 settings)
- ✅ AzureMapsInFabric
- ❌ AzureMapsInFabricCrossRegionDataProcessing
- ✅ AzureMapsWeatherServices

### Copilot and Azure OpenAI Service (6 settings)
- ✅ EnableAOAI
- ✅ ImmersiveTenantAdminSwitch
- ❌ AllowSendAOAIDataToOtherRegions
- ❌ CopilotCapacitySetupPermissionSwitch
- ❌ AllowStoreAOAIDataInOtherRegions
- ❌ PreppedForCopilotContentDiscovery

### Gen1 Dataflow Settings (1 setting)
- ✅ CDSAManagement

### App Settings (3 settings)
- ❌ TemplatePublish
- ✅ AppPush
- ✅ PublishContentPack

### Power BI Visuals (5 settings)
- ✅ CustomVisualsTenant
- ❌ CertifiedCustomVisualsTenant
- ❌ AllowCVToExportDataToFileTenant
- ❌ AllowCVAuthenticationTenant
- ✅ AllowCVLocalStorageV2Tenant

### Dashboard Settings (1 setting)
- ❌ WebContentTilesTenant

### Domain Management Settings (1 setting)
- ✅ EnableReassignDataDomainSwitch

### Explore Settings (1 setting)
- ✅ AdminDataExploreViewPermission

### Datamart Settings (1 setting)
- ✅ DatamartTenant

### Semantic Model Settings (1 setting)
- ✅ WebModelingTenantSwitch

### Semantic Model Security (1 setting)
- ❌ BlockAutoDiscoverAndPackageRefresh

### Developer Settings (5 settings)
- ✅ Embedding
- ❌ ServicePrincipalAccessGlobalAPIs
- ✅ ServicePrincipalAccessPermissionAPIs
- ❌ AllowServicePrincipalsCreateAndUseProfiles
- ❌ BlockResourceKeyAuthentication

### Discovery Settings (3 settings)
- ✅ DiscoverDatasetsSettingsPromoted
- ✅ DiscoverDatasetsSettingsCertified
- ✅ DiscoverDatasetsConsumption

### Encryption (1 setting)
- ❌ WorkspaceCmk

### Export and Sharing Settings (29 settings)
- ❌ AllowExternalDataSharingSwitch
- ❌ AllowExternalDataSharingReceiverSwitch
- ✅ AllowGuestUserToAccessSharedContent
- ❌ ExternalSharingV2
- ✅ ElevatedGuestsTenant
- ✅ AllowGuestLookup
- ✅ PublishToWeb
- ✅ ExportVisualImageTenant
- ✅ ExportToExcelSetting
- ✅ ExportToCsv
- ✅ ExportReport
- ✅ LiveConnection
- ✅ ExportToPowerPoint
- ✅ ExportToMHTML
- ✅ ExportToWord
- ✅ ExportToXML
- ❌ ExportToImage
- ✅ Printing
- ❌ CertifyDatasets
- ❌ AllowEndorsementMasterDataSwitch
- ✅ EmailSubscriptionTenant
- ✅ EmailSubscriptionsToB2BUsers
- ✅ EmailSubscriptionsToExternalUsers
- ✅ PromoteContent
- ✅ EnableExcelYellowIntegration
- ✅ ShareLinkToEntireOrg
- ✅ ShareToTeamsTenant
- ✅ AutoInstallPowerBIAppInTeamsTenant
- ✅ StorytellingTenant
- ✅ AllowPowerBIASDQOnTenant
- ❌ ExternalDatasetSharingTenant
- ✅ EnableDatasetInPlaceSharing

### Git Integration (4 settings)
- ✅ GitIntegrationTenantSwitch
- ❌ GitIntegrationCrossGeoTenantSwitch
- ✅ GitIntegrationSensitivityLabelsTenantSwitch
- ✅ GitHubTenantSettings

### Metrics Settings (1 setting)
- ✅ PowerBIGoalsTenant

### Help and Support Settings (4 settings)
- ❌ TenantSettingPublishGetHelpInfo
- ❌ EmailSecurityGroupsOnOutage
- ✅ AllowFreeTrial
- ❌ AdminCustomDisclaimer

### Information Protection (7 settings)
- ❌ EimInformationProtectionEdit
- ❌ EimInformationProtectionDataSourceInheritanceSetting
- ❌ EimInformationProtectionDownstreamInheritanceSetting
- ❌ EimInformationProtectionWorkspaceAdminsOverrideAutomaticLabelsSetting
- ❌ BlockProtectedLabelSharingToEntireOrg
- ❌ EimInformationProtectionDefaultLabelDomainSetting
- ✅ DataSecurityForAIInteractions

### Integration Settings (17 settings)
- ✅ OnPremAnalyzeInExcel
- ✅ DatasetExecuteQueries
- ✅ EsriVisual
- ✅ ArtifactSearchTenant
- ✅ AzureMaps
- ❌ AzureMapsCrossRegionDataProcessing
- ❌ AzureMapsThirdPartyDataProcessing
- ❌ BingMap
- ✅ VisualizeListInPowerBI
- ❌ DremioSSO
- ❌ SnowflakeSSO
- ❌ RedshiftSSO
- ✅ GoogleBigQuerySSO
- ❌ AADSSOForGateway
- ✅ OneDriveSharePointViewerIntegrationTenantSettingV2
- ✅ OneDriveSharePointAllowSharingTenantSetting
- ❌ ASShareableCloudConnectionBindingSecurityModeTenant
- ✅ ASWritethruContinuousExportTenantSwitch
- ✅ ODSPRefreshEnforcementTenantAllowAutomaticUpdate
- ❌ EnableEsriLibraries
- ✅ AllowNonEntraADAuthInEventStream
- ✅ DirectLakeOnOneLakeSemanticModelCreation

### Share Data with Your Microsoft 365 Services (1 setting)
- ✅ M365DataSharing

### Microsoft Fabric (16 settings)
- ✅ FabricGAWorkloads
- ❌ HLSWorkloadTenantSwitch
- ❌ DigitalOperationsPreview
- ❌ OntologyPreview
- ✅ ArtifactOrgAppPreview
- ❌ FabricFeedbackTenantSwitch
- ✅ AISkillArtifactTenantSwitch
- ❌ EnableMetricSet
- ❌ ArtifactGraphPreview
- ❌ FabricPromotionTenantSwitch
- ❌ MLModelEndpointsTenantSwitch
- ❌ RTHAnomalyDetectionTenantSwitch
- ❌ ArtifactMapTenantSwitch
- ❌ RTHOperationalAgentsTenantSwitch
- ✅ ShowActivatorEntryPointsTenantSwitch
- ❌ ArtifactSnowflakeDatabasePreview

### OneLake Settings (6 settings)
- ✅ OneLakeForThirdParty
- ✅ AllowGetOneLakeUDK
- ❌ AllowOneLakeUDK
- ✅ OneLakeFileExplorer
- ❌ DeltaToIcebergTableVirtualization
- ✅ OneLakeDiagnosticLogsEUII

### Q&A Settings (2 settings)
- ✅ QnaFeedbackLoop
- ✅ QnaLsdlSharing

### R and Python Visuals Settings (1 setting)
- ✅ RScriptVisual

### Scale-out Settings (1 setting)
- ✅ QueryScaleOutTenant

### Template App Settings (3 settings)
- ✅ DevelopServiceApps
- ✅ InstallServiceApps
- ❌ InstallNonvalidatedTemplateApps

### User Experience Experiments (1 setting)
- ✅ ExpFlightingTenant

### Additional Workloads (4 settings)
- ✅ FabricAddWorkloadToWorkspace
- ✅ FabricAddPartnerWorkload
- ❌ FabricThirdPartyWorkloads
- ❌ ThirdPartyPrivateWorkloads

### Workspace Settings (5 settings)
- ✅ CreateAppWorkspaces
- ✅ UseDatasetsAcrossWorkspaces
- ❌ RestrictMyFolderCapacity
- ✅ ConfigureFolderRetentionPeriod
- ✅ AutomaticallyUsePBIR

---

**End of Report**
