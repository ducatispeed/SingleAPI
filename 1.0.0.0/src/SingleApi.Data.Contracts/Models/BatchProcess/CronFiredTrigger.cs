﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleApi.Data.Contracts.Models.BatchProcess
{
    public class CronFiredTrigger
    {
        public string SchedName { get; set; }
        public string EntryId { get; set; }
        public string TriggerName { get; set; }
        public string TriggerGroup { get; set; }
        public string InstanceName { get; set; }
        public long FiredTime { get; set; }
        public long SchedTime { get; set; }
        public int Priority { get; set; }
        public string State { get; set; }
        public string JobName { get; set; }
        public string JobGroup { get; set; }
        public bool? IsNonConcurrent { get; set; }
        public bool? RequestsRecovery { get; set; }
    }
}
