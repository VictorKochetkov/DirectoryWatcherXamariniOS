using ObjCRuntime;

[assembly: LinkWith("libDirectoryWatcher.a", LinkTarget.Simulator64 | LinkTarget.Arm64, ForceLoad = false, SmartLink = true, Frameworks = "Foundation CoreFoundation")]
