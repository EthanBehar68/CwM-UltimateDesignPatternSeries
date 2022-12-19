using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.TemplateMethodPattern
{
    public class AuditTrail
    {
        List<string> _trail = new();

        public void RecordTask(Task taskToRecord)
        {
            _trail.Add($"Executed task: {taskToRecord.TaskName}");
        }

        public void PrintAuditTrail()
        {
            Debug.Log("Printing audit trail.\nUser executed the following tasks:");
            foreach (string s in _trail)
                Debug.Log(s);
        }
    }
}