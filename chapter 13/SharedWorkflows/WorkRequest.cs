﻿//--------------------------------------------------------------------------------
// This file is part of the downloadable code for the Apress book:
// Pro WF: Windows Workflow in .NET 3.5
// Copyright (c) Bruce Bukovics.  All rights reserved.
//
// This code is provided as is without warranty of any kind, either expressed
// or implied, including but not limited to fitness for any particular purpose. 
// You may use the code for any commercial or noncommercial purpose, and combine 
// it with your own code, but cannot reproduce it in whole or in part for 
// publication purposes without prior approval. 
//--------------------------------------------------------------------------------

using System;

namespace SharedWorkflows
{
    /// <summary>
    /// Represents a request to a long running service
    /// </summary>
    [Serializable]
    public class WorkRequest
    {
        public Guid InstanceId { get; set; }
        public String RequestedWork { get; set; }
        public String ResponseQueueName { get; set; }

        public WorkRequest(
            Guid instanceId, String queueName, String theWork)
        {
            InstanceId = instanceId;
            ResponseQueueName = queueName;
            RequestedWork = theWork;
        }
    }
}
