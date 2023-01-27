using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using System.Data;
using System.Diagnostics;
using System.Globalization;

namespace ImgOrg
{
    public partial class Form1 : Form
    {
        private string[] imgFileTypes = { ".jpg", ".jpeg", ".nef", ".raw", ".gif", ".tif", ".tiff", ".png" };

        public Form1()
        {
            InitializeComponent();
        }

        private string GetSelectedFolderPath()
        {
            var fbd = new FolderBrowserDialog();
            var result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                return fbd.SelectedPath;
            }
            return "";
        }

        private void imgPathBtn_Click(object sender, EventArgs e)
        {
            imgPath.Text = GetSelectedFolderPath();
        }

        private void imgOrgBtn_Click(object sender, EventArgs e)
        {
            ValidateRequiredData();

            var result = MessageBox.Show("Are you sure you are ready to proceed?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ProcessImages(false);
            }
        }

        private void ValidateRequiredData()
        {
            // Image Location Validation
            if (string.IsNullOrWhiteSpace(imgPath.Text)) MessageBox.Show("You must select a folder before organizing images", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!System.IO.Directory.Exists(imgPath.Text)) MessageBox.Show("Selected imgage folder doesn't exit. Please try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Output Validation
            if (string.IsNullOrWhiteSpace(outputPath.Text)) MessageBox.Show("You must an output folder before organizing images", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!System.IO.Directory.Exists(outputPath.Text)) MessageBox.Show("Selected output folder doesn't exit. Please try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ProcessImages(bool isDryRun)
        {
            var imgFiles = GetImageFiles();

            foreach (var file in imgFiles)
            {
                var datetaken = GetDateTaken(file);

                if (datetaken == DateTime.MinValue)
                {
                    // Log File Result
                    resultList.Rows.Add(file, "Could not determine date taken.");
                }
                else
                {
                    var newFilePath = MoveFileToDatedFolder(file, datetaken, isDryRun);

                    // Log File Result
                    resultList.Rows.Add(file, newFilePath);
                }
            }
        }


        public string MoveFileToDatedFolder(string file, DateTime datetaken, bool isDryRun)
        {
            // Build new file name
            var filename = Path.GetFileName(file);
            var root = outputPath.Text;
            var newFilePath = Path.Combine(root, datetaken.ToString("yyyy-MM-dd"), filename);

            // Only move file if this is not a dry run.
            if (isDryRun == false)
            {
                // Get new parent directory and check to make sure it exists.  If not, create directory.
                var parent = System.IO.Directory.GetParent(newFilePath);
                var dir = (parent != null) ? parent.FullName : "";
                if (!System.IO.Directory.Exists(dir))
                {
                    System.IO.Directory.CreateDirectory(dir);
                }

                // Move file
                File.Move(file, newFilePath);
            }

            return newFilePath;
        }

        public DateTime GetDateTaken(string file)
        {
            // https://github.com/drewnoakes/metadata-extractor-dotnet

            // Get File Metadata
            IEnumerable<MetadataExtractor.Directory> directories = ImageMetadataReader.ReadMetadata(file);

            // Find the EXIF Sub directory info
            var subIfdDirectory = directories.OfType<ExifSubIfdDirectory>().FirstOrDefault();

            // Get the Original Date Time Taken data
            var dateTime = subIfdDirectory?.GetDescription(ExifDirectoryBase.TagDateTimeOriginal);

            // Covert EXIF datetime to a C# DateTime object
            DateTime.TryParseExact(dateTime, "yyyy:MM:dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out var date);

            return date;
        }

        private string[] GetImageFiles()
        {
            return System.IO.Directory.GetFiles(imgPath.Text, "*.*")
                .Where(f => imgFileTypes.Contains(new FileInfo(f).Extension.ToLower())).ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputPath.Text = GetSelectedFolderPath();
        }

        private void dryRunBtn_Click(object sender, EventArgs e)
        {
            ValidateRequiredData();
            ProcessImages(true);
        }

        private void resultList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get selected cell
            var selectedCell = resultList.SelectedCells[0].Value.ToString();
            if (selectedCell == null) return;

            // Get the parent folder of selected cell file path
            var parent = System.IO.Directory.GetParent(selectedCell);
            if (parent == null) return;

            // If Directory exists, open folder.
            if (System.IO.Directory.Exists(parent.FullName))
            {
                Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", parent.FullName);
            }
            
        }
    }
}