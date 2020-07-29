using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Xml;
using System.Management.Automation;
using System.Management.Automation.Remoting;
using System.Management.Automation.Runspaces;
using System.CodeDom.Compiler;
using System.Security;
using System.Net.Mail;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;

namespace ExactDataMatchConfiguration
{
    public partial class frmEDM : Form
    {

        List<Fields> lstFields = new List<Fields>();

        public frmEDM()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            dlgFile.Filter = "CSV files (*.csv)|*.csv";
            dlgFile.ShowDialog();
            txtFileSelected.Text = dlgFile.FileName;

            // path to the csv file
            string path = txtFileSelected.Text;
            //int iLineCounter = 0;

            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                foreach (string column in columns)
                {
                    var index = dgRules.Rows.Add();
                    dgRules.Rows[index].Cells[0].Value = column.ToString();

                }
                break;
            }
        }
        
        private void frmEDM_Load(object sender, EventArgs e)
        {
            cboLanguage.SelectedIndex = 0;
            ToolTip ttUserName = new ToolTip();
            ttUserName.SetToolTip(txtUserName, "<User>@<Domain>.onmicrosoft.com");

            toolStripStatusProcessingStep.Text = "Process Status:  Idle";
            statusStrip.Refresh();

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            // path to the csv file
            string path = txtFileSelected.Text;
            //int iLineCounter = 0;

            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                foreach (string column in columns)
                {
                    var index = dgRules.Rows.Add();
                    dgRules.Rows[index].Cells[0].Value = column.ToString();
                    
                }
                break;
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(RequiredFields())
            { 
               
                GetFields();
                
                CreateSchema();
                
                CreateSchemaRulePack();

                UploadSchema();
                
                UploadData();
                toolStripStatusProcessingStep.Text = "Process Status:  Idle...";
                statusStrip.Refresh();


            }
            else
            {
                MessageBox.Show("Please complete all required fields");
            }

        }

        private void CreateSchemaRulePack()
        {
            try
            {
                toolStripStatusProcessingStep.Text = "Process Status:  Creating Rule Pack";
                statusStrip.Refresh();
                Guid gRulePack = Guid.NewGuid();
                Guid gPublisher = Guid.NewGuid();
                Guid gExactMatch = Guid.NewGuid();


                string sSchemaRuleRule = ConfigurationSettings.AppSettings["EdmSchemaRulePack"].ToString();
                XmlWriter xmlWriter = XmlWriter.Create(sSchemaRuleRule);
                xmlWriter.WriteStartDocument(true);

                //<RulePackage>
                xmlWriter.WriteStartElement("RulePackage");

                //<RulePack>
                xmlWriter.WriteStartElement("RulePack");
                xmlWriter.WriteAttributeString("id", gRulePack.ToString());

                //<Version>
                xmlWriter.WriteStartElement("Version");
                xmlWriter.WriteAttributeString("build", "0");
                xmlWriter.WriteAttributeString("major", "2");
                xmlWriter.WriteAttributeString("minor", "0");
                xmlWriter.WriteAttributeString("revision", "0");
                //</Version>
                xmlWriter.WriteEndElement();

                //<Publisher>
                xmlWriter.WriteStartElement("Publisher");
                xmlWriter.WriteAttributeString("id", gPublisher.ToString());
                //</Publisher>
                xmlWriter.WriteEndElement();

                //<Details>
                xmlWriter.WriteStartElement("Details");
                xmlWriter.WriteAttributeString("defaultLangCode", "en-us");

                //<LocalizedDetails>
                xmlWriter.WriteStartElement("LocalizedDetails");
                xmlWriter.WriteAttributeString("langcode", "en-us");

                //<PublisherName>
                xmlWriter.WriteStartElement("PublisherName");
                xmlWriter.WriteString(txtPublisherName.Text);

                //</PublisherName>
                xmlWriter.WriteEndElement();

                //<Name>
                xmlWriter.WriteStartElement("Name");
                xmlWriter.WriteString(txtDataStoreName.Text + " Rulepack");
                //</Name>
                xmlWriter.WriteEndElement();

                //<Description>
                xmlWriter.WriteStartElement("Description");
                xmlWriter.WriteString(txtDescription.Text);

                //</Description>
                xmlWriter.WriteEndElement();

                //</LocalizedDetails>
                xmlWriter.WriteEndElement();

                //</Details>
                xmlWriter.WriteEndElement();


                //</RulePack>
                xmlWriter.WriteEndElement();

                //<Rules>
                xmlWriter.WriteStartElement("Rules");

                //<ExactMatch>
                xmlWriter.WriteStartElement("ExactMatch");
                xmlWriter.WriteAttributeString("id", gExactMatch.ToString());
                xmlWriter.WriteAttributeString("patternsProximity", txtProximity.Text);
                xmlWriter.WriteAttributeString("dataStore", txtDataStoreName.Text);
                xmlWriter.WriteAttributeString("recommendedConfidence", txtConfidence.Text);

                //<Pattern>
                xmlWriter.WriteStartElement("Pattern");
                xmlWriter.WriteAttributeString("confidenceLevel", txtConfidence.Text);

                //<idMatch>
                //Get all the fields selected as "Searchable"
                foreach (var field in lstFields)
                {
                    if (field.Search)
                    {

                        xmlWriter.WriteStartElement("idMatch");
                        xmlWriter.WriteAttributeString("matches", field.FieldName.ToString());
                        xmlWriter.WriteAttributeString("classification", txtCustomInformationType.Text);

                        xmlWriter.WriteEndElement();
                    }
                }
                //</idMatch>

                //</Pattern>
                xmlWriter.WriteEndElement();

                //<Pattern>
                xmlWriter.WriteStartElement("Pattern");
                xmlWriter.WriteAttributeString("confidenceLevel", txtConfidence.Text);

                //<idMatch>
                //Get all the fields selected as "Searchable"
                foreach (var field in lstFields)
                {
                    if (field.Search)
                    {

                        xmlWriter.WriteStartElement("idMatch");
                        xmlWriter.WriteAttributeString("matches", field.FieldName.ToString());
                        xmlWriter.WriteAttributeString("classification", txtCustomInformationType.Text);
                        xmlWriter.WriteEndElement();
                    }
                }
                //</idMatch>

                //<Any>
                xmlWriter.WriteStartElement("Any");
                xmlWriter.WriteAttributeString("minMatches", txtMinMatches.Text);
                xmlWriter.WriteAttributeString("maxMatches", txtMaxMatches.Text);

                //<match>
                //Get all the fields selected as "Match"
                foreach (var field in lstFields)
                {
                    if (field.Match)
                    {
                        xmlWriter.WriteStartElement("match");
                        xmlWriter.WriteAttributeString("matches", field.FieldName.ToString());
                        xmlWriter.WriteEndElement();
                    }
                }
                //</match>

                //</Any>
                xmlWriter.WriteEndElement();

                //</Pattern>
                xmlWriter.WriteEndElement();

                //</ExactMatch>
                xmlWriter.WriteEndElement();

                //<LocalizedStrings>
                xmlWriter.WriteStartElement("LocalizedStrings");

                //<Resource>
                xmlWriter.WriteStartElement("Resource");
                xmlWriter.WriteAttributeString("idRef", gExactMatch.ToString());

                //<Name>
                xmlWriter.WriteStartElement("Name");
                xmlWriter.WriteAttributeString("default", "true");
                xmlWriter.WriteAttributeString("langcode", "en-us");
                xmlWriter.WriteString(txtCustomInformationType.Text);

                //</Name>
                xmlWriter.WriteEndElement();

                //<Description>
                xmlWriter.WriteStartElement("Description");
                xmlWriter.WriteAttributeString("default", "true");
                xmlWriter.WriteAttributeString("langcode", "en-us");
                xmlWriter.WriteString(txtDescription.Text);

                //</Description>
                xmlWriter.WriteEndElement();

                //</Resource>
                xmlWriter.WriteEndElement();

                //</LocalizedStrings>
                xmlWriter.WriteEndElement();

                //</Rules>
                xmlWriter.WriteEndElement();

                //</RulePackage>
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Close();

                RemoveXMLDeclaration(ConfigurationSettings.AppSettings["EdmSchemaRulePack"].ToString());

                toolStripStatusProcessingStep.Text = "Process Status:  Finished Creating Rule Pack";
                statusStrip.Refresh();
            }
            catch (Exception exp)
            {
                toolStripStatusProcessingStep.Text = "Process Status:  Error Creating Rule Pack";
                statusStrip.Refresh();
                throw new Exception(exp.Message);
            }
        }

        private void CreateSchema()
        {
            try
            {
                toolStripStatusProcessingStep.Text = "Process Status:  Creating EDM Schema";
                statusStrip.Refresh();
                string sSchemaFile = ConfigurationSettings.AppSettings["EdmSchema"].ToString();
                XmlWriter xmlWriter = XmlWriter.Create(sSchemaFile);
                xmlWriter.WriteStartDocument(true);
                xmlWriter.WriteStartElement("EdmSchema");
                //xmlWriter.WriteAttributeString("xmlns", @"http://schemas.microsoft.com/office/2018/edm");

                //DataStore Element
                xmlWriter.WriteStartElement("DataStore");
                xmlWriter.WriteAttributeString("name", txtDataStoreName.Text.ToString());
                xmlWriter.WriteAttributeString("description", txtDescription.Text.ToString());
                xmlWriter.WriteAttributeString("version", "1");


                //Field elements from the grid
                foreach (var field in lstFields)
                {
                    xmlWriter.WriteStartElement("Field");
                    xmlWriter.WriteAttributeString("name", field.FieldName.ToString());

                    if (field.Search)
                    {
                        xmlWriter.WriteAttributeString("searchable", "true");
                    }

                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Close();

                RemoveXMLDeclaration(ConfigurationSettings.AppSettings["EdmSchema"].ToString());


                //***************** Upload the EDM Schema to SCC
                //*****************  https://foxlearn.com/windows-forms/how-to-execute-powershell-script-in-csharp-444.html

                toolStripStatusProcessingStep.Text = "Process Status:  Finished Creating EDM Schema";
                statusStrip.Refresh();


                ///TODO:  Add functionality to create the base sensitive information type in SCC.
            }
            catch (Exception exp)
            {
                toolStripStatusProcessingStep.Text = "Process Status:  Error Creating EDM Schema";
                statusStrip.Refresh();
                throw new Exception(exp.Message);
            }
        }

        private void UploadSchema()
        {
            toolStripStatusProcessingStep.Text = "Process Status:  Uploading schema and rule pack";
            statusStrip.Refresh();
            // Set credentials to make a remote connection to Outlook Live
            string userName = txtUserName.Text;      
            string password = txtPassword.Text;     

            try
            {
                using (PowerShell powershell = PowerShell.Create())
                {
                    StringBuilder sbPSInput = new StringBuilder();
                    sbPSInput.Append("$loginName = '" + userName + "'; ");
                    sbPSInput.Append("$loginPassword = '" + password + "'; ");
                    sbPSInput.Append("$credentials = New-Object -TypeName System.Management.Automation.PSCredential -argumentlist $loginName, $(convertto-securestring $loginPassword -asplaintext -force)" + "; ");
                    sbPSInput.Append("Get-PSSession | Remove-PSSession" + "; ");
                    sbPSInput.Append("$Session = New-PSSession -ConfigurationName Microsoft.Exchange -ConnectionUri 'https://ps.compliance.protection.outlook.com/powershell-liveid/' -Credential $credentials -Authentication Basic -AllowRedirection" + "; ");
                    sbPSInput.Append("Import-PSSession $Session -DisableNameChecking" + "; ");
                    sbPSInput.Append("$edmSchemaXml = Get-Content '" + ConfigurationSettings.AppSettings["EdmSchema"].ToString() + "' -Encoding Byte -ReadCount 0" + " ;");
                    sbPSInput.Append("New-DlpEdmSchema -FileData $edmSchemaXml -Confirm:$false" + " ;");
                    sbPSInput.Append("$rulepack = Get-Content '" + ConfigurationSettings.AppSettings["EdmSchemaRulePack"].ToString() + "' -Encoding Byte -ReadCount 0" + " ;");
                    sbPSInput.Append("New-DlpSensitiveInformationTypeRulePackage -FileData $rulepack");


                    powershell.AddScript(sbPSInput.ToString(), true);
                    powershell.AddCommand("Out-String");
                    Collection<PSObject> PSOutput = powershell.Invoke();
                    StringBuilder stringBuilder = new StringBuilder();
                    foreach (PSObject pSObject in PSOutput)
                        stringBuilder.AppendLine(pSObject.ToString());
                }
                toolStripStatusProcessingStep.Text = "Process Status:  Finished Uploading schema and rule pack";
                statusStrip.Refresh();
                ///return true;
            }
            catch(Exception exp)
            {
                toolStripStatusProcessingStep.Text = "Process Status:  Error Uploading schema and rule pack";
                statusStrip.Refresh();
                throw new Exception(exp.Message);
                //return false;
            }
        }

        private void UploadData()
        {
            try
            {
                toolStripStatusProcessingStep.Text = "Process Status:  Uploading data";
                statusStrip.Refresh();
                //Authorize the user
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.WorkingDirectory = @"C:\Program Files\Microsoft\EdmUploadAgent\";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.FileName = @"C:\Program Files\Microsoft\EdmUploadAgent\EdmUploadAgent.exe";
                process.StartInfo.Arguments = "/Authorize";
                process.StartInfo.CreateNoWindow = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string sExitCode = process.ExitCode.ToString();

                if (sExitCode != "0")
                {
                    throw new Exception("Error Authorizing EDM Upload Agent:  " + output.ToString());
                }

                //Upload the file
                process.StartInfo.FileName = @"C:\Program Files\Microsoft\EdmUploadAgent\EdmUploadAgent.exe";

                string sParms = " /UploadData /DataStoreName " + (char)34 + txtDataStoreName.Text + (char)34 + " /DataFile " + (char)34 + txtFileSelected.Text + (char)34 + " /HashLocation C:\\temp\\";

                process.StartInfo.Arguments = sParms;
                process.StartInfo.CreateNoWindow = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.Start();
                output = process.StandardOutput.ReadToEnd();
                sExitCode = process.ExitCode.ToString();
                if (sExitCode != "0")
                {
                    throw new Exception("Error uploading data to DataStore:  " + output.ToString());
                }

                process.Close();

                toolStripStatusProcessingStep.Text = "Process Status:  Finished Uploading data";
                statusStrip.Refresh();
            }
            catch (Exception exp)
            {
                toolStripStatusProcessingStep.Text = "Process Status:  Error Uploading data";
                statusStrip.Refresh();
                throw new Exception(exp.Message);
            }
        }

        private static void RemoveXMLDeclaration(string XmlFileName)
        {
            //Remove the <xml> declaration on the top of the file.
            XmlDocument xmlSchema = new XmlDocument();
            xmlSchema.Load(XmlFileName);
            if (xmlSchema.FirstChild.NodeType == XmlNodeType.XmlDeclaration)
            {
                xmlSchema.RemoveChild(xmlSchema.FirstChild);

                xmlSchema.DocumentElement.RemoveAttribute("xmlns:msdata");
                xmlSchema.DocumentElement.RemoveAttribute("xmlns");

                XmlAttributeCollection xmlAttributeCollection = xmlSchema.DocumentElement.Attributes;
                XmlNode xmlNode = xmlSchema.CreateNode(XmlNodeType.Attribute, "xmlns", "http://www.w3.org/2000/xmlns/");
                xmlNode.Value = "http://schemas.microsoft.com/office/2018/edm";
                xmlAttributeCollection.Append((XmlAttribute)xmlNode);

                //XmlAttribute nsAttribute = xmlSchema.CreateAttribute("xmlns", "xx", @"http://schemas.microsoft.com/office/2018/edm");
                //XmlElement root = xmlSchema.GetElementById("EdmSchema");
                //root.Attributes.Append(nsAttribute);
                xmlSchema.Save(XmlFileName);
            }
        }

        private Boolean RequiredFields()
        {
            if (txtFileSelected.Text == "" || txtDataStoreName.Text == "" || txtDescription.Text == "" || txtPublisherName.Text == "" || txtCustomInformationType.Text == "" || txtUserName.Text == "" || txtPassword.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void GetFields()
        {
            toolStripStatusProcessingStep.Text = "Process Status:  Initializing...";
            statusStrip.Refresh();
            //var lstFields = new List<string>();
            lstFields.Clear();
            Boolean bSearch = false;
            Boolean bMatch = false;
            foreach (DataGridViewRow dr in dgRules.Rows)
            {
                if (Convert.ToBoolean(dr.Cells[Searchable.Name].Value) == true)
                {
                    bSearch = true;
                }

                if (Convert.ToBoolean(dr.Cells[Match.Name].Value) == true)
                {
                    bMatch = true;
                }

                lstFields.Add(new Fields()
                {
                    FieldName = dr.Cells[0].Value.ToString(),
                    Search = bSearch,
                    Match = bMatch    
                });

                bSearch = false;
                bMatch = false;
            }
            toolStripStatusProcessingStep.Text = "Process Status:  Finished Initializing...";
            statusStrip.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createEDMSchemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetFields();
            CreateSchema();
        }

        private void createEDMRulePackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetFields();
            CreateSchemaRulePack();
        }

        private void uploadSchemaAndRulePackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetFields();
            UploadSchema();
        }

        private void uploadDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetFields();
            UploadData();
        }
    }

    public class Fields
    {
        public string FieldName { get; set; }
        public Boolean Search { get; set; }

        public Boolean Match { get; set; }
    }
}
