using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CreateSamplesGUI
{
    public static class NegativeSampleCreator
    {
        private static readonly string[] _validExtenions = { ".jpg", ".png", ".bmp" };

        /// <summary>
        /// Creates bg.txt in desired output path for sample creation.
        /// </summary>
        /// <param name="childPaths"></param>
        public static void CreateBgTxt(List<string> paths, string outputPath)
        {
            using (StreamWriter streamWriter = new StreamWriter(@outputPath + @"\bg.txt"))
            {
                foreach (var path in paths)
                {
                    streamWriter.WriteLine(path);
                }
            }
        }

        /// <summary>
        /// Takes a full path ant turns it into img/picture.jpg or .png
        /// </summary>
        /// <param name="childPaths"></param>
        /// <returns></returns>
        public static List<string> ConvertToNegativeSamplePath(List<string> childPaths)
        {
            var truncatedPaths = new List<string>();

            foreach (var path in childPaths)
            {
                if (FileExtensionIsValid(path))
                {
                    var splitPath = path.Split('\\');
                    truncatedPaths.Add("img/" + splitPath.Last());
                }
            }
            return truncatedPaths;
        }

        /// <summary>
        /// Checks path against a bank of exsisting image file extensions.
        /// </summary>
        /// <param name="path">Path to check</param>
        /// <returns>Whether the file extension is valid or not.</returns>
        private static bool FileExtensionIsValid(string path)
        {
            if (_validExtenions.Contains(Path.GetExtension(path)))
            {
                return true;
            }
            return false;
        }
    }
}
