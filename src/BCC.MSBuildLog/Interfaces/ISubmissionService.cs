﻿using System.Threading.Tasks;

namespace BCC.MSBuildLog.Interfaces
{
    public interface ISubmissionService
    {
        Task<bool> SubmitAsync(string inputFile, string token, string headSha);
        Task<bool> SubmitAsync(byte[] bytes, string token, string headSha);
    }
}