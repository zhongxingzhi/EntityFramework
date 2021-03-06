﻿// Copyright(c) Microsoft Open Technologies, Inc.All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.Infrastructure;

namespace Microsoft.Data.Entity.SqlServer.Extensions
{
    public class SqlServerDbContextOptions : RelationalDbContextOptions
    {
        public SqlServerDbContextOptions([NotNull] DbContextOptions options)
            : base(options)
        { }

        public virtual SqlServerDbContextOptions MaxBatchSize(int maxBatchSize)
        {
            ((IDbContextOptions)Options)
                .AddOrUpdateExtension<SqlServerOptionsExtension>(x => x.MaxBatchSize = maxBatchSize);

            return this;
        }
    }
}
