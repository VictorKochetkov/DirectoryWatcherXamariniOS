using Foundation;
using ObjCRuntime;

namespace DirectoryWatcherXamariniOS
{
    [Model, BaseType(typeof(NSObject))]
    public partial interface DirectoryWatcherDelegate
    {

        [Export("directoryDidChange:")]
        void DirectoryDidChange(DirectoryWatcher folderWatcher);
    }

    [BaseType(typeof(NSObject))]
    public partial interface DirectoryWatcher
    {

        [Export("delegate", ArgumentSemantic.Assign)]
        DirectoryWatcherDelegate Delegate { get; set; }

        [Static, Export("watchFolderWithPath:delegate:")]
        DirectoryWatcher WatchFolderWithPath(string watchPath, DirectoryWatcherDelegate watchDelegate);

        [Export("invalidate")]
        void Invalidate();
    }
}
