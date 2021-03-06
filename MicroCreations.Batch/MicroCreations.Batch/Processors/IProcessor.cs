﻿using System.Collections.Generic;
using System.Threading.Tasks;
using MicroCreations.Batch.Common.Operations;

namespace MicroCreations.Batch.Processors
{
    public interface IProcessor
    {
        Task<IEnumerable<OperationResult>> ProcessAsync(ProcessRequest processRequest);

        ProcessorType ProcessorType { get; }
    }
}
