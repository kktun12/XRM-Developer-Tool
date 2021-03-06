﻿using JosephM.Application.Modules;
using JosephM.Core.Attributes;
using JosephM.Prism.Infrastructure.Module;
using JosephM.Prism.XrmModule.SavedXrmConnections;

namespace JosephM.InstanceComparer
{
    [MyDescription("Compare The State Of Customisations And Data Between 2 CRM Instances. Note This Is Not A Complete Comparison")]
    [DependantModule(typeof(SavedXrmConnectionsModule))]
    public class InstanceComparerModule :
        ServiceRequestModule
            <InstanceComparerDialog, InstanceComparerService, InstanceComparerRequest, InstanceComparerResponse, InstanceComparerResponseItem>
    {
        public override void InitialiseModule()
        {
            base.InitialiseModule();
            AddHelpUrl("Instance Comparison", "CrmInstanceComparison");
        }
        public override string MainOperationName
        {
            get { return "Instance Compare"; }
        }
    }
}