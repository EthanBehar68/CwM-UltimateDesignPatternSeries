using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.TemplateMethodPattern
{
    public class TransferMoneyTask : Task
    {

        public TransferMoneyTask(string taskName, AuditTrail auditTrail) : base(taskName, auditTrail)
        {
        }

        protected override void DoExecute()
        {
            Debug.Log($"Executing {_taskName}");
        }
    }
}
