using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousingAPITestApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            cmbMethod.SelectedIndex = 0;
            cmbBaseURL.SelectedIndex = cmbBaseURL.Items.Count - 1;
            cmbEndPoint.SelectedIndex = 0;
            txtTimestamp.Text = GetTimestamp();
        }

        private string GetTimestamp()
        {
            return DateTime.UtcNow.ToString("yyyyMMddTHHmmss");
        }

        private void btnGenerateHeader_Click(object sender, EventArgs e)
        {
            APISignature signature = new APISignature(
                txtKey.Text, 
                txtSecret.Text, 
                cmbMethod.Text, 
                ApiEndpoint(), 
                txtComponent.Text, 
                txtTimestamp.Text, 
                Int32.Parse(txtContentLength.Text));

            string signatureValue = signature.ToSignature();

            OutputBox.ResetText();
            OutputBox.AppendText("Signature: " + signatureValue + "\r\n");
            OutputBox.AppendText(AuthorizationHeader(signatureValue));

            txtBearerToken.Text = AuthorizationHeaderToken(signatureValue);
        }

      
        private string AuthorizationHeader(string signatureValue)
        {
            return String.Format("LSAPI {0}\r\n", AuthorizationHeaderToken(signatureValue));
        }

        private string AuthorizationHeaderToken(string signatureValue)
        {
            return String.Format("key=\"{0}\", timestamp=\"{1}\", signature=\"{2}\"", txtKey.Text, txtTimestamp.Text, signatureValue);
        }

        private string ApiEndpoint()
        {
            Uri baseUrl = new Uri(cmbBaseURL.Text + cmbEndPoint.Text);
            var str = Uri.UnescapeDataString(baseUrl.AbsolutePath);
            return String.Format(str, txtUPRN.Text);
        }

        private void btnRefreshTimeStamp_Click(object sender, EventArgs e)
        {
            txtTimestamp.Text = GetTimestamp();
        }
        
        private void btnCopyToken_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, txtBearerToken.Text);
        }

        
        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            try
            {
                APISignature signature = new APISignature(txtKey.Text, txtSecret.Text, cmbMethod.Text, ApiEndpoint(), txtComponent.Text, txtTimestamp.Text, Int32.Parse(txtContentLength.Text));

                Uri baseUrl = new Uri(cmbBaseURL.Text + cmbEndPoint.Text);
                var request = HttpWebRequest.Create( baseUrl);

                request.ContentLength = 0;
                request.Method = cmbMethod.Text;
                request.Headers.Add(HttpRequestHeader.Authorization, AuthorizationHeader(signature.ToSignature()));

                //var response = request.GetResponse();
                string responseText = "";
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    var encoding = Encoding.GetEncoding(response.CharacterSet);

                    using (var responseStream = response.GetResponseStream())
                    using (var reader = new StreamReader(responseStream, encoding))
                        responseText = reader.ReadToEnd();
                }
                OutputBox.Text = "";
                OutputBox.AppendText("Response:\r\n" + responseText);

            }
            catch (Exception ex)
            {
                
                OutputBox.Invoke((MethodInvoker)delegate
                {
                    OutputBox.AppendText("Error:\r\n");
                    OutputBox.AppendText(ex.Message + "\r\n");
                });
                
            }
        }
    }
}
