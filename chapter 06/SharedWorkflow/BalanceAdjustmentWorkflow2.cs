//--------------------------------------------------------------------------------
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
using System.Workflow.Activities;

namespace SharedWorkflows
{
    public sealed partial class BalanceAdjustmentWorkflow2
        : SequentialWorkflowActivity
    {
        public Int32 Id { get; set; }
        public Double Adjustment { get; set; }
        public Account Account { get; set; }

        public BalanceAdjustmentWorkflow2()
        {
            InitializeComponent();
        }
    }
}
