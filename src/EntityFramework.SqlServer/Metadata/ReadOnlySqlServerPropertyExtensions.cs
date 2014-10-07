// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Relational.Metadata;

namespace Microsoft.Data.Entity.SqlServer.Metadata
{
    public class ReadOnlySqlServerPropertyExtensions : ReadOnlyRelationalPropertyExtensions, ISqlServerPropertyExtensions
    {
        protected const string SqlServerNameAnnotation = SqlServerAnnotationNames.Prefix + RelationalAnnotationNames.ColumnName;
        protected const string SqlServerColumnTypeAnnotation = SqlServerAnnotationNames.Prefix + RelationalAnnotationNames.ColumnType;
        protected const string SqlServerDefaultExpressionAnnotation = SqlServerAnnotationNames.Prefix + RelationalAnnotationNames.ColumnDefaultExpression;

        public ReadOnlySqlServerPropertyExtensions([NotNull] IProperty property)
            : base(property)
        {
        }

        public override string Column
        {
            get { return Property[SqlServerNameAnnotation] ?? base.Column; }
        }

        public override string ColumnType
        {
            get { return Property[SqlServerNameAnnotation] ?? base.ColumnType; }
        }

        public override string DefaultExpression
        {
            get { return Property[SqlServerDefaultExpressionAnnotation] ?? base.DefaultExpression; }
        }
    }
}