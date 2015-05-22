﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JosephM.Core.FieldType;
using JosephM.Record.Application.SettingTypes;

namespace JosephM.Xrm.ImportExporter.Service
{
    public class ImportExportRecordType
    {
        public RecordType RecordType { get; set; }
        public bool IncludeInactive { get; set; }
    }
}
