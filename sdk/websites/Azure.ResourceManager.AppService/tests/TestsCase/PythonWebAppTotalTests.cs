﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.AppService.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Tests.TestsCase
{
    public class PythonWebAppTotalTests : AppServiceTestBase
    {
        public PythonWebAppTotalTests(bool isAsync)
           : base(isAsync, Azure.Core.TestFramework.RecordedTestMode.Record)
        {
        }
        private async Task<AppServicePlanContainer> GetAppServicePlanContainerAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            //var AppServicePlanName = Recording.GenerateAssetName("testAppServicePlan_");
            //var PlanInput = ResourceDataHelper.GetBasicAppServicePlanData("AZURE_LOCATION");
            //var lro = await resourceGroup.GetAppServicePlans().CreateOrUpdateAsync(AppServicePlanName, PlanInput);
            //var appServicePlan = lro.Value;
            return resourceGroup.GetAppServicePlans();
        }

        private async Task<SiteContainer> GetSiteContainerAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            return resourceGroup.GetSites();
        }

        private async Task<SiteSlotContainer> GetSiteSlotContainerAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            var SiteName = Recording.GenerateAssetName("testSite");
            var SiteInput = ResourceDataHelper.GetBasicSiteData(DefaultLocation);
            var lro = await resourceGroup.GetSites().CreateOrUpdateAsync(SiteName, SiteInput);
            var Site = lro.Value;
            return Site.GetSiteSlots();
        }

        private async Task<SiteSourcecontrolContainer> GetSiteSourceControlContainerAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            var SiteName = Recording.GenerateAssetName("testSiteSource");
            var SiteInput = ResourceDataHelper.GetBasicSiteData(DefaultLocation);
            var lro = await resourceGroup.GetSites().CreateOrUpdateAsync(SiteName, SiteInput);
            var Site = lro.Value;
            return Site.GetSiteSourcecontrols();
        }

        [TestCase]
        [RecordedTest]
        public async Task AppServicePlanCreateOrUpdate()
        {
            var container = await GetAppServicePlanContainerAsync();
            var name = Recording.GenerateAssetName("testAppServicePlan");
            var input = ResourceDataHelper.GetBasicAppServicePlanData(DefaultLocation);
            var lro = await container.CreateOrUpdateAsync(name, input);
            var appServicePlan = lro.Value;
            Assert.AreEqual(name, appServicePlan.Data.Name);
        }

        [TestCase]
        [RecordedTest]
        public async Task SiteCreateOrUpdate()
        {
            var container = await GetSiteContainerAsync();
            var name = Recording.GenerateAssetName("testSite");
            var input = ResourceDataHelper.GetBasicSiteData(DefaultLocation);
            var lro = await container.CreateOrUpdateAsync(name, input);
            var site = lro.Value;
            Assert.AreEqual(name, site.Data.Name);
        }

        [TestCase]
        [RecordedTest]
        public async Task SiteSlotCreateOrUpdate()
        {
            var container = await GetSiteSlotContainerAsync();
            var name = Recording.GenerateAssetName("testSiteSlot");
            var input = ResourceDataHelper.GetBasicSiteSlotData(DefaultLocation);
            var lro = await container.CreateOrUpdateAsync(name, input);
            var siteSlot = lro.Value;
            Assert.AreEqual(name, siteSlot.Data.Name);
        }

        [TestCase]
        [RecordedTest]
        public async Task SiteSourceControlCreateOrUpdate()
        {
            var container = await GetSiteSourceControlContainerAsync();
            //var name = Recording.GenerateAssetName("testSiteSource");
            var input = ResourceDataHelper.GetBasicSiteSourceControlData();
            var lro = await container.CreateOrUpdateAsync(input);
            var siteSourceControl = lro.Value;
            //Assert.AreEqual(name, siteSourceControl.Data.Name);
        }
    }
}
