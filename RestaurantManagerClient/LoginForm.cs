using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManagerClient.RestaurantService;
using Newtonsoft.Json;

namespace RestaurantManagerClient
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        WebService1SoapClient service = new WebService1SoapClient();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginSpinner.Visible = true;
            string username = this.usernameTextbox.Text;
            string password = this.passwordTextbox.Text;
            string serviceResponse = service.Login(username, password);
            if (serviceResponse != null)
            {
                loginSpinner.Visible = false;
                User user = JsonConvert.DeserializeObject<User>(serviceResponse);
                RestaurantForm restaurantForm = new RestaurantForm(user,service);
                restaurantForm.Show();
                this.Hide();
            }
            else
            {
                statusLabel.Text = "Wrong Username or Password";
                statusLabel.ForeColor = Color.Red;
                statusLabel.Visible = true;
                loginSpinner.Visible = false;
            }
        }
    }
}
