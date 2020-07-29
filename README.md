# ExactDataMatchConfiguration

<h1>Synopsis:</h1>
Within Security and Compliance center there is functionality to configure a Sensitive Information Type from your own data.  This feature, Exact Data Match, provides organizations the ability to further secure their sensitive information from leaking out.  To configure this functionality there are a series of XML files and command line methods to properly deploy it.  This solutions has a user interface to assist in creating the required XML files, deploying them to Security and Compliance Center and lastly to upload the data used with the sensitive information type.

<h1>Pre-Requisites</h1>

<ol>
  <li>Dowload and install the <a href="https://www.nuget.org/packages/System.Management.Automation/7.0.3">System.Management.Automation package</a>.  This is used for the PowerShell automation.</li>
  <li>Download and install the <a href="https://www.powershellgallery.com/packages/ExchangeOnlineManagement/1.0.1">ExchangeOnlineManagement</a> package so PowerShell can connect to Security and Compliance Center.</li>
  <li>Create a new <a href="https://docs.microsoft.com/en-us/microsoft-365/admin/email/create-edit-or-delete-a-security-group?view=o365-worldwide">security group</a> in Azure Active Directory called "EDM_DataUploaders" and add the account performing the data upload to it.</li>
  <li><a href="https://techcommunity.microsoft.com/t5/microsoft-security-and/implementing-microsoft-exact-data-match-edm-part-2/ba-p/1350483">Create a new Sensitive Information Type</a> in Security and Compliance center that will define the searchable value in your data file. Think of this as the primary key to identify unique rows.</li>
  <li>Download and install the <a href="https://go.microsoft.com/fwlink/?linkid=2088639">EDM Upload Agent</a>.  This is needed to securely upload data from your line of business database to Security and Compliance Center.</li>
  <li>Download and run the .exe, input the required values and create the EDM Schema in Security and Compliance Center.</li>
</ol>
