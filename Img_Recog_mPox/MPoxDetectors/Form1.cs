using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;
namespace MPoxDetectors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;

                    pbImage.ImageLocation = selectedImagePath;
                }
            }
        }

        private void bExecutePython_Click(object sender, EventArgs e)
        {
            // Ensure that an image is attached
            if (pbImage.Image == null)
            {
                MessageBox.Show("Please attach an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the path to the Python script
            string pythonScriptPath = "";

            // Load the XML configuration file
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("mpox_config.xml"); 

            XmlNode pythonScriptNode = xmlDoc.SelectSingleNode("/Configuration/PythonScriptPath");
            if (pythonScriptNode != null)
            {
                pythonScriptPath = pythonScriptNode.InnerText;
            }
            else
            {
                MessageBox.Show("Python script path not found in the configuration file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Get the path to the attached image
            string attachedImagePath = pbImage.ImageLocation;

            // Execute the Python script with the attached image as an argument
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = $"\"{pythonScriptPath}\" \"{attachedImagePath}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            // Show processing message
            ShowProcessingMessage("Processing...");
            using (Process process = new Process { StartInfo = startInfo })
            {
                process.Start();
                ShowProcessingMessage("Processing...");
                // Read the output and error streams
                string result = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                // Check if certain text is found in the output
                if (result.Contains("Other"))
                {
                    label2.Text = "Client Is Safe";
                    panelResult.BackColor = System.Drawing.Color.Green;
                    MessageBox.Show("Not Infected", "Inspection Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    HideProcessingMessage();
                }
                else if (result.Contains("MonkeyPox"))
                {
                    HideProcessingMessage();
                    label2.Text = "Client Is Infected";
                    // Change UI color to red
                    panelResult.BackColor = System.Drawing.Color.Red;
                    
                    MessageBox.Show("Infected", "Inspection Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
           }

        }
        private void ShowProcessingMessage(string message)
        {
            label1.Text = message;
            this.Refresh();
        }

        private void HideProcessingMessage()
        {
            label1.Text = "";
            this.Refresh();
        }

        private void bAbout_Click(object sender, EventArgs e)
        {
            ShowAboutDialog();
        }
        private void ShowAboutDialog()
        {
            string version = "1.0.0"; // Replace with your actual version number
            string aboutText = $"MPoxDetector: STOP MONKEYPOX SPREAD{version}\n\nCopyright © 2024";

            MessageBox.Show(aboutText, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}