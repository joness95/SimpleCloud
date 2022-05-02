namespace Server.FileSystem
{
    /// <summary>
    /// A description update of a file to be handled in a repository <see cref="IRepository"/>.
    /// </summary>
    public class FileDescriptionUpdate
    {
        /// <summary>
        /// Path of the File that recieved the update
        /// </summary>
        public string Path;

        /// <summary>
        /// The type of the update recogniced by the OS/FileSystem Watcher
        /// </summary>
        public FileChangeType ChangeType= FileChangeType.NONE;

        /// <summary>
        /// The Time when the update occured
        /// </summary>
        public ulong TimeStamp = 0;
    }
}
