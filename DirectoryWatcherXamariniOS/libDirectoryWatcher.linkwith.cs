using System;
using ObjCRuntime;

[assembly: LinkWith("libDirectoryWatcher.a", LinkTarget.Arm64 | LinkTarget.Simulator64, ForceLoad = true, SmartLink = true)]
