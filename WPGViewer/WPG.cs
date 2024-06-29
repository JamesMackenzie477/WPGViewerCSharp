using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPGViewer
{
    class File
    {
        // the name of the file accociated with the section
        string FileName;
        // the offset of the data block from the base of the file
        private uint FileOffset;
        // the size of the data block
        private uint FileSize;
        // contains information on whether the data is encrypted or compressed
        uint FileInfo;

        public File(string FileName, uint FileOffset, uint FileSize, uint FileInfo)
        {
            this.FileName = FileName;
            this.FileOffset = FileOffset;
            this.FileSize = FileSize;
            this.FileInfo = FileInfo;
        }
    }

    class Package
    {
        // defines the unique fourcc code used to identify the file format
        // private const uint FourCC = 0x474B5052;
        // defines the max length of a package name
        // private const uint MaxPackName = 0x80;

        // an array of package files
        public File[] Files;

        // the number of files within the package
        public uint Count;

        // opens the given wpg package
        public Package(string PackagePath)
        {

        }

        // returns the requested file as a buffer
        public bool GetFile(string FilePath)
        {
            return true;
        }

        // validates the given wpg package
        private bool Validate()
        {
            return true;
        }

        // decrypts the given wpg package
        private bool Decrypt()
        {
            return true;
        }

        // decompresses the given wpg package
        private bool Decompress()
        {
            return true;
        }
    }
}
