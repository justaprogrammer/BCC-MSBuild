﻿namespace BCC.MSBuildLog.Model
{
    public class Parameters
    {
        public string CloneRoot { get; set; }
        public string Owner { get; set; }
        public string Repo { get; set; }
        public string Hash { get; set; }
        public string Token { get; set; }
        public string ConfigurationFile { get; set; }
        public int AnnotationCount { get; set; } = 100;
        public int? PullRequestNumber { get; set; }
    }
}