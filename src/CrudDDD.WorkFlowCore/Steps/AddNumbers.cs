﻿using System.Threading.Tasks;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace CrudDDD.WorkFlowCore.Steps
{
    public class AddNumbers : StepBodyAsync
    {
        public int Input1 { get; set; }

        public int Input2 { get; set; }

        public int Output { get; set; }


        public override async Task<ExecutionResult> RunAsync(IStepExecutionContext context)
        {
            Output = (Input1 + Input2);
            return ExecutionResult.Next();
        }
    }
}
