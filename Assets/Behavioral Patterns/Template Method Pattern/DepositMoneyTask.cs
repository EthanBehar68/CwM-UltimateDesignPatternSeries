using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.TemplateMethodPattern
{
    public class DepositMoneyTask : Task
    {

        public DepositMoneyTask(string taskName, AuditTrail auditTrail) : base(taskName, auditTrail)
        {
        }

        protected override void DoExecute()
        {
            Debug.Log($"Executing {_taskName}");
        }
    }
}
