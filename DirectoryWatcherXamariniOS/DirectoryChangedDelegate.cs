using System;
namespace DirectoryWatcherXamariniOS
{
    public interface IDirectoryWatcher
    {
        void OnChanged(DirectoryWatcherXamariniOS.DirectoryWatcher folderWatcher);
    }

    public class DirectoryChangedDelegate : DirectoryWatcherDelegate
    {
        private readonly IDirectoryWatcher m_watcher;

        public DirectoryChangedDelegate(IDirectoryWatcher watcher)
        {
            m_watcher = watcher;
        }

        public override void DirectoryDidChange(DirectoryWatcherXamariniOS.DirectoryWatcher folderWatcher)
        {
            if (m_watcher != null)
                m_watcher.OnChanged(folderWatcher);
        }
    }
}

