﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JosephM.ObjectMapping;
using JosephM.Prism.XrmModule.SavedXrmConnections;
using JosephM.Record.Application.Controller;
using JosephM.Record.Xrm.Test;
using JosephM.Record.Xrm.XrmRecord;
using Microsoft.Xrm.Sdk.Client;

namespace JosephM.Prism.XrmModule.Test
{
    public class XrmModuleTest : XrmRecordTest
    {
        public IApplicationController CreateFakeApplicationController()
        {
            var xrmConfig = GetSavedTestEncryptedXrmConfiguration();
            var enumMapper = new EnumMapper<XrmRecordAuthenticationProviderType, AuthenticationProviderType>();
            var savedConfig = new SavedXrmRecordConfiguration()
            {
                Active = true,
                AuthenticationProviderType = enumMapper.Map(xrmConfig.AuthenticationProviderType),
                DiscoveryServiceAddress = xrmConfig.DiscoveryServiceAddress,
                Domain = xrmConfig.Domain,
                OrganizationUniqueName = xrmConfig.OrganizationUniqueName,
                Password = xrmConfig.Password,
                Username = xrmConfig.Username
            };
            var savedConfigs = new SavedXrmConnections.SavedXrmConnections()
            {
                Connections = new[] {savedConfig}
            };
            return new FakeXrmApplicationController(savedConfigs);
        }
    }
}
