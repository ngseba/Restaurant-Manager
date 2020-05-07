using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using RestaurantManagerClient.RestaurantService;
using Newtonsoft.Json;
using System.Threading;
namespace RestaurantManagerClient
{
    public partial class RestaurantForm : MetroFramework.Forms.MetroForm
    {
        public WebService1SoapClient service;
        User user;
        List<Reservation> reservations;

       

        public RestaurantForm(User user, WebService1SoapClient service)
        {
            InitializeComponent();
            this.user = user;
            this.service = service;
            refreshReservationsDB();
        }

        public void refreshReservationsDB()
        {
            
            var reservationResponse = this.service.getReservations(this.user.Id);
            reservations = JsonConvert.DeserializeObject<List<Reservation>>(reservationResponse);
            refreshReservations();
          
        }

        public void refreshReservations()
        {
            this.reservationListbox.Items.Clear();
            reservationListbox.ValueMember = "ReservationId";
            reservationListbox.DisplayMember = "Text";
            reservations.ForEach(r => {
                if (r.ReservationDate.ToString().Split(' ')[0].Equals(datePicker.Value.ToString().Split(' ')[0]))
                    reservationListbox.Items.Add(new { r.ReservationId, Text = "[" + r.PartySize.ToString() + "] " + r.FirstName.ToString() + " " + r.LastName.ToString() });
            });
        }


        private void reservationButton_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm(user,this);
            reservationForm.ShowDialog();
        }

       

        void reservationListbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.reservationListbox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                int reservationId = Convert.ToInt32(reservationListbox.Items[index].ToString().Split(',')[0].Split('=')[1]);
                Reservation reservation = reservations.FirstOrDefault(r => r.ReservationId == reservationId);
                new ReservationForm(reservation, user,this).Show();

            }
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            refreshReservations();
        }

        public void tableDoubleClick(object sender, EventArgs e)
        {
            Table table = (Table)sender;
            if (reservationListbox.SelectedItem != null && table.isOpen)
            {
                var selectedItem = reservationListbox.SelectedItem.ToString();
                var name = selectedItem.Split(' ')[7] +" "+ selectedItem.Split(' ')[8];
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to assign "+name+" to Table "+table.tableName.Text+" ?","Sit customer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int reservationId = Convert.ToInt32(reservationListbox.SelectedItem.ToString().Split(',')[0].Split('=')[1]);
                    service.deleteReservation(reservationId);
                    this.refreshReservationsDB();
                    table.sitGuest(this,new EventArgs());
                }
            }
        }

    }
}
