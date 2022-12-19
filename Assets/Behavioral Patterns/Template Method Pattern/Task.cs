using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vectorform.DesignPatternCookbook.TemplateMethodPattern
{
    public abstract class Task
    {

        public string TaskName 
        {
            get
            {
                return _taskName;
            }
            private set
            {
                _taskName = value;
            }
        }

        private AuditTrail _auditTrail;

        protected string _taskName;

        public Task(string name, AuditTrail auditTrail)
        {
            _taskName = name;
            _auditTrail = auditTrail;
        }

        public void Execute()
        {
            _auditTrail.RecordTask(this);

            DoExecute();
        }

        protected abstract void DoExecute();
    }
}
