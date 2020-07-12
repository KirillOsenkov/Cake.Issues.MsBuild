﻿namespace Cake.Issues.MsBuild.Tests
{
    using System;
    using System.Collections.Generic;
    using Cake.Core.Diagnostics;

    internal class FakeMsBuildLogFileFormat : BaseMsBuildLogFileFormat
    {
        public FakeMsBuildLogFileFormat(ICakeLog log)
           : base(log)
        {
        }

        public new (bool Valid, string FilePath) ValidateFilePath(string filePath, IRepositorySettings repositorySettings)
        {
            return base.ValidateFilePath(filePath, repositorySettings);
        }

        public new bool CheckIfFileIsInRepository(string filePath, IRepositorySettings repositorySettings)
        {
            return base.CheckIfFileIsInRepository(filePath, repositorySettings);
        }

        public new string MakeFilePathRelativeToRepositoryRoot(string filePath, IRepositorySettings repositorySettings)
        {
            return base.MakeFilePathRelativeToRepositoryRoot(filePath, repositorySettings);
        }

        public new string RemoveLeadingDirectorySeparator(string filePath)
        {
            return base.RemoveLeadingDirectorySeparator(filePath);
        }

        public override IEnumerable<IIssue> ReadIssues(
            MsBuildIssuesProvider issueProvider,
            IRepositorySettings repositorySettings,
            MsBuildIssuesSettings issueProviderSettings)
        {
            throw new NotImplementedException();
        }
    }
}
