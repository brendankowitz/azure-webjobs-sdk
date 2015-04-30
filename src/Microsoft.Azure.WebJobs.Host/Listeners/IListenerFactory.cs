﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs.Host.Executors;

namespace Microsoft.Azure.WebJobs.Host.Listeners
{
    public interface IListenerFactory
    {
        Task<IListener> CreateAsync(IFunctionExecutor executor, CancellationToken cancellationToken);
    }
}
