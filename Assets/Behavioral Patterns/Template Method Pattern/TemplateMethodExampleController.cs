using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.TemplateMethodPattern
{
    public class TemplateMethodExampleController : MonoBehaviour
    {

        private AuditTrail _auditTrail = new();

        public void ExecuteDeposit()
        {
            DepositMoneyTask dmt = new("Deposit", _auditTrail);
            
            // Consumer of template method pattern 
            // must use the template method to excute the primitive operations.
            dmt.Execute();
        }

        public void ExecuteTransfer()
        {
            TransferMoneyTask tmt = new("Transfer", _auditTrail);
            
            // Consumer of template method pattern 
            // must use the template method to excute the primitive operations.
            tmt.Execute();
        }

        public void ExecuteReport()
        {
            GenerateReportTask grt = new("Report", _auditTrail);
            
            // Consumer of template method pattern 
            // must use the template method to excute the primitive operations.
            grt.Execute();
        }

        public void PrintAuditTrail()
        {
            _auditTrail.PrintAuditTrail();
        }
    }
}
