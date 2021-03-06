﻿using System.Collections.Generic;
using JosephM.Application.ViewModel.SettingTypes;
using JosephM.Record.Application;

namespace JosephM.Xrm.RecordExtract.TextSearch
{
    public interface ITextSearchSettings
    {
        IEnumerable<RecordTypeSetting> ExtendedRecordTypesToExclude { get; set; }
        IEnumerable<RecordFieldSetting> ExtendedFieldsToExclude { get; set; }
        IEnumerable<string> GetFieldsToExclude();
        int TextSearchSetSize { get; set; }
        IEnumerable<RecordFieldSetting> ExtendedTextSearchSetFields { get; set; }
        IEnumerable<string> GetRecordTypesToExclude();
        IEnumerable<RecordFieldSetting> GetTextSearchSetFields();
    }
}