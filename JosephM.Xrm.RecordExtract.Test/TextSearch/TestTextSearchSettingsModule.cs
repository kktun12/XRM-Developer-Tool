﻿using JosephM.Application.Modules;
using JosephM.Prism.Infrastructure.Module;
using JosephM.Prism.Infrastructure.Prism;
using JosephM.Prism.Infrastructure.Test;
using JosephM.Record.Application.Fakes;
using JosephM.Xrm.RecordExtract.Test.RecordExtract;
using JosephM.Xrm.RecordExtract.TextSearch;

namespace JosephM.Xrm.RecordExtract.Test.TextSearch
{
    [DependantModule(typeof (TestingModule))]
    public class TestTextSearchSettingsModule :
        SettingsModule<TestTextSearchSettingsDialog, ITextSearchSettings, TextSearchSettings>
    {
    }
}