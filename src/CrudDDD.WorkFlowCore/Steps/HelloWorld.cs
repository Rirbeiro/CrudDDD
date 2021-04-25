﻿using System;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace CrudDDD.WorkFlowCore.Steps
{
    public class HelloWorld : StepBody
    {
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Console.WriteLine("Hello world");
            return ExecutionResult.Next();
        }
    }
}
