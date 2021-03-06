﻿
using JosephM.Core.Attributes;
using JosephM.Core.FieldType;
using JosephM.Prism.XrmModule.SavedXrmConnections;
using JosephM.Record.Attributes;
using JosephM.Record.Query;
using JosephM.Xrm.Schema;
using System.Collections.Generic;

namespace JosephM.Xrm.Vsix.Module.PackageSettings
{
    [Group(Sections.ObjectPrefixes, true, 20)]
    [Group(Sections.Solution, true, 10)]
    [Group(Sections.ConnectionInstances, true, 30)]
    public class XrmPackageSettings : ISavedXrmConnections
    {
        [Group(Sections.Solution)]
        public bool AddToSolution { get; set; }

        [Group(Sections.Solution)]
        [RequiredProperty]
        [ReferencedType(Entities.solution)]
        [UsePicklist(Fields.solution_.uniquename)]
        [LookupCondition(Fields.solution_.ismanaged, false)]
        [LookupCondition(Fields.solution_.isvisible, true)]
        [LookupCondition(Fields.solution_.uniquename, ConditionType.NotEqual, "default")]
        [PropertyInContextByPropertyValue(nameof(AddToSolution), true)]
        public Lookup Solution { get; set; }

        [Group(Sections.ObjectPrefixes)]
        [RequiredProperty]
        public string SolutionObjectPrefix { get; set; }
        [Group(Sections.ObjectPrefixes)]
        [RequiredProperty]
        public string SolutionDynamicsCrmPrefix { get; set; }



        [Hidden]
        public string SolutionObjectInstancePrefix
        {
            get
            {
                if (string.IsNullOrEmpty(SolutionObjectPrefix))
                    return SolutionObjectPrefix;
                if (char.IsLower(SolutionObjectPrefix[0]))
                    return "" + char.ToUpper(SolutionObjectPrefix[0]) + (SolutionObjectPrefix.Length == 1 ? "" : SolutionObjectPrefix.Substring(1));
                if (char.IsUpper(SolutionObjectPrefix[0]))
                    return "" + char.ToLower(SolutionObjectPrefix[0]) + (SolutionObjectPrefix.Length == 1 ? "" : SolutionObjectPrefix.Substring(1));
                return SolutionObjectPrefix;
            }
        }

        [FormEntry]
        [Group(Sections.ConnectionInstances)]
        public IEnumerable<SavedXrmRecordConfiguration> Connections { get; set; }

        private static class Sections
        {
            public const string ObjectPrefixes = "Object Prefixes";
            public const string Solution = "Active Dev Solution";
            public const string ConnectionInstances = "Instance Connections";
        }
    }
}