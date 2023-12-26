﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Executor
{
    public interface IBaseExecutor
    {
        public Task<string> ExecutePlaybookMockAsync(string playbookExecutorName);
    }
}