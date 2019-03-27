using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CreateSamplesGUI
{
    public static class PathSelector
    {
        /// <summary>
        /// Gets a list of parent path's children paths.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAllChildPaths(string parentPath)
        {
            List<string> childPaths = Directory.GetFiles(parentPath).ToList(); ;

            if (childPaths.Any())
            {
                return childPaths;
            }

            throw new FileNotFoundException("Unexpected error, file not found?");
        }

        /// <summary>
        /// Gets a file path from browser dialog.
        /// </summary>
        /// <returns></returns>
        public static string GetFilePath()
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK &&
                    !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    return folderBrowserDialog.SelectedPath;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}

