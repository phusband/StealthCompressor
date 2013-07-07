using System;
using System.IO;
using System.Linq;

using Ionic.Zip;

namespace Stealth_Compressor
{
    class StealthArchive : ZipFile
    {
        // Class initializer
        public StealthArchive()
        {
            setDefaultProperties();
        }
        public StealthArchive(string path)
        {
            Name = path;
            setDefaultProperties();
        }

        #region Properties

        public string TempFileName { get; set; }
        public string CloakingFile { get; set; }
        public string[] FileList { get; set; }
        public bool UseMemory { get; set; }
        public string StealthError { get; private set; }

        private MemoryStream memoryArchive;
        private FileStream fileArchive;

        public enum ArchiveType
        {
            Zip,
            ZipSFX,
            GZip,
            SevenZip,
            Jar,
            Rar,
            RarSFX
        }

        // Default properties
        private void setDefaultProperties()
        {
            UseMemory = true;
            TempFileFolder = Environment.GetEnvironmentVariable("TEMP");
            TempFileName = "TempArchive.zip";
            CompressionLevel = Ionic.Zlib.CompressionLevel.Default;
        }

        #endregion

        /// <summary>
        /// Hides an archive inside another file.
        /// </summary>
        public void Cloak()
        {
            if (CloakingFile != null)
            {
                if (UseMemory)
                {
                    using (memoryArchive = new MemoryStream())
                    {
                        Save(memoryArchive);
                        MergeFiles(memoryArchive, CloakingFile);
                    }
                }
                else
                {
                    string tempFile = string.Format("{0}\\{1}", TempFileFolder, TempFileName);
                    using (fileArchive = new FileStream(tempFile, FileMode.Create, FileAccess.ReadWrite))
                    {
                        Save(fileArchive);
                        MergeFiles(fileArchive, CloakingFile);
                    }
                }
            }

        }
        /// <summary>
        /// Hides an archive inside another file.
        /// </summary>
        /// <param name="cloakingFile"></param>
        /// <param name="fileList"></param>
        public void Cloak(string cloakingFile, string[] fileList)
        {
            cloakingFile = CloakingFile;
            foreach (string file in FileList)
            {
                AddFile(file);
            }
            Cloak();
        }
        /// <summary>
        /// Hides an archive inside another file.
        /// </summary>
        /// <param name="cloakingFile"></param>
        /// <param name="fileList"></param>
        /// <param name="useMemory"></param>
        public void Cloak(string cloakingFile, string[] fileList, bool useMemory)
        {
            cloakingFile = CloakingFile;
            foreach (string file in FileList)
            {
                AddFile(file);
            }
            useMemory = UseMemory;
            Cloak();
        }

        /// <summary>
        /// Returns a list of entries inside a cloaked archive.
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public ZipEntry[] GetCloakedEntries(ArchiveType type)
        {
            byte[] pattern = new byte[] { };

            // Sets the byte pattern based on the supplied archive type
            switch (type)
            {
                case ArchiveType.Zip:
                    pattern = new byte[] { 80, 75, 3, 4 }; // 0x50 0x4B 0x03 0x04
                    break;
                case ArchiveType.ZipSFX:
                    pattern = new byte[] { 77, 90, 144 }; // 0x4D 0x5A 0x90
                    break;
                case ArchiveType.Rar:
                    pattern = new byte[] { 82, 97, 114, 33 }; // 0x52 0x61 0x72 0x21
                    break;
                case ArchiveType.RarSFX:
                    pattern = new byte[] { 77, 90, 80 }; // 0x4D 0x5A 0x50
                    break;
                case ArchiveType.GZip:
                    pattern = new byte[] { 31, 139, 8 }; // 0x1F 0x8B 0x08
                    break;
                case ArchiveType.SevenZip:
                    pattern = new byte[] { 55, 122, 188, 175, 39, 28 }; // 0x37 0x7A 0xBC 0xAF 0x27 0x1C
                    break;
                case ArchiveType.Jar:
                    pattern = new byte[] { 95, 39, 168, 137 }; // 0x5F 0x27 0xA8 0x89
                    break;
                default:
                    return null;
            }

            // Run the GetCloakedFiles method with selected byte pattern
            return GetCloakedEntries(pattern);

        }
        /// <summary>
        /// Returns a list of entries inside a cloaked archive.
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public ZipEntry[] GetCloakedEntries(byte[] pattern)
        {     
            // Return nothing if file doesn't exist
            if (!File.Exists(Name)) return null;
            else
            {
                try
                {
                    // Get the bytes of the image file
                    byte[] data = File.ReadAllBytes(Name);

                    // Gets the starting position of the zip pattern
                    int startPos = IndexOfSequence(ref data, pattern, 0);

                    // Return nothing if the pattern is not found
                    if (startPos == -1) return new ZipEntry[0];

                    // Create an archive from the bytes, from the pattern starting point
                    memoryArchive = new MemoryStream(data, startPos, data.Length - startPos);
                    using (ZipFile archive = ZipFile.Read(memoryArchive))
                    {
                        ZipEntry[] files = new ZipEntry[archive.Entries.Count];

                        // Iterate through each file in the archive
                        for (int i = 0; i < archive.Entries.Count; i++)
                        {
                            files[i] = archive.Entries.ElementAt(i);
                        }

                        // Clear the byte array
                        data = null;

                        // Return the list of files
                        return files;
                    }
                }
                catch(Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.ToString());
                    return null;
                }
            }

        }

        /// <summary>
        /// Extracts files from a cloaked archive
        /// </summary>
        /// <param name="files"></param>
        /// <param name="extractPath"></param>
        /// <param name="overwrite"></param>
        public void ExtractCloakedFiles(string[] files, string extractPath, bool overwrite)
        {
            ExtractCloakedFiles(files, extractPath, overwrite, string.Empty);
        }
        /// <summary>
        /// Extracts files from a cloaked archive
        /// </summary>
        /// <param name="files"></param>
        /// <param name="extractPath"></param>
        /// <param name="overwrite"></param>
        /// <param name="password"></param>
        public void ExtractCloakedFiles(string[] files, string extractPath, bool overwrite, string password)
        {
            // Reset the stream position
            memoryArchive.Position = 0;

            // Set the saving overwrite option
            ExtractExistingFileAction setting;
            if (overwrite) setting = ExtractExistingFileAction.OverwriteSilently;
            else setting = ExtractExistingFileAction.DoNotOverwrite;

            // Create a new archive from the memory stream
            using (ZipFile archive = ZipFile.Read(memoryArchive))
            {
                // Apply a password to the archive if applicable
                if (password != string.Empty) archive.Password = password;

                // Iterate through each file in the archive
                foreach (ZipEntry item in archive)
                {
                    // Iterate through each file in the file list
                    for (int i = 0; i < files.Length; i++)
                    {
                        // If the current archive file matches current file from the file list
                        if (files[i] == item.FileName)
                        {
                            try
                            {
                                // Extract the file
                                item.Extract(extractPath, setting);
                            }
                            catch 
                            {

                            }
                        }
                    }
                }
            }

            // Clean up 
            //memoryArchive.Dispose();
        }

        private void MergeFiles(Stream archive, string destFileName)
        {
            // Create the output stream
            using (FileStream cloakedArchive = new FileStream(destFileName, FileMode.Append, FileAccess.Write))
            {
                int count;
                byte[] buffer = new byte[BufferSize];
                archive.Position = 0;

                try
                {
                    // Read through the archive
                    while ((count = archive.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        // Append to the destination file
                        cloakedArchive.Write(buffer, 0, count);
                    }
                }
                catch (Exception e)
                {
                    StealthError = e.ToString();
                }

            }

        }

        // Got this here:  http://stackoverflow.com/questions/283456/byte-array-pattern-search
        // Returns the start position of a byte pattern within a byte array
        private int IndexOfSequence(ref byte[] buffer, byte[] pattern, int startIndex)
        {
            int i = Array.IndexOf<byte>(buffer, pattern[0], startIndex);
            while (i >= 0 && i <= buffer.Length - pattern.Length)
            {
                byte[] segment = new byte[pattern.Length];
                Buffer.BlockCopy(buffer, i, segment, 0, pattern.Length);
                if (segment.SequenceEqual<byte>(pattern))
                    return i;
                i = Array.IndexOf<byte>(buffer, pattern[0], i + pattern.Length);
            }

            return -1;
        }
    }
}