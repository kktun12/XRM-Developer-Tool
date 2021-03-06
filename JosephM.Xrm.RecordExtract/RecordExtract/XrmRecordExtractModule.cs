﻿using JosephM.Application.Modules;
using JosephM.Core.Attributes;
using JosephM.Prism.Infrastructure.Module;

namespace JosephM.Xrm.RecordExtract.RecordExtract
{
    [MyDescription("Generate A Document Detailing The Field Values And Related Records For A Specific Record In The CRM Instance")]
    public class XrmRecordExtractModule :
        ServiceRequestModule
            <XrmRecordExtractDialog, XrmRecordExtractService, RecordExtractRequest, RecordExtractResponse, RecordExtractResponseItem>
    {
        public override string MainOperationName
        {
            get { return "Record Report"; }
        }

        public override string MenuGroup => "Reports";

        public override void InitialiseModule()
        {
            base.InitialiseModule();
            //AddHelp("Record Report", "Record Extract Help.docx");
        }
    }
}