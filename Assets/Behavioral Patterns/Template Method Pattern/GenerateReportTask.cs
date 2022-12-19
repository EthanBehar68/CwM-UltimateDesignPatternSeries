using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.TemplateMethodPattern
{
    public class GenerateReportTask : Task
    {

        public GenerateReportTask(string taskName, AuditTrail auditTrail) : base(taskName, auditTrail)
        {
        }

        protected override void DoExecute()
        {
            Debug.Log($"Executing {_taskName}");
        }
    }
}
