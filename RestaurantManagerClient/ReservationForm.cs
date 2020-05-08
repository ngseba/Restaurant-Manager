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

namespace RestaurantManagerClient
{
    public partial class ReservationForm : MetroFramework.Forms.MetroForm
    {
        User user;
        WebService1SoapClient service;
        Reservation reservation;
        RestaurantForm restaurantForm;
        public ReservationForm(User user, RestaurantForm restaurantForm)
        {
            this.user = user;
            this.service = restaurantForm.service;
            this.restaurantForm = restaurantForm;
            InitializeComponent();
        }
        public ReservationForm(Reservation reservation,User user,RestaurantForm restaurantForm)
        {
            this.user = user;
            this.service = restaurantForm.service;
            this.reservation = reservation;
            this.restaurantForm = restaurantForm;
            InitializeComponent();
            this.Text = "Edit Reservation";
            this.firstNameTextbox.Text = reservation.FirstName;
            this.lastNameTextbox.Text = reservation.LastName;
            this.PhoneTextbox.Text = reservation.PhoneNumber;
            this.PartySizeTextbox.Text = reservation.PartySize.ToString();
            this.reservationDatepicker.Value = reservation.ReservationDate;
            this.reservationHourTextbox.Text = reservation.ReservationTime.Hours.ToString();
            this.reservationMinuteTextbox.Text = reservation.ReservationTime.Minutes.ToString();
            this.descriptionTextbox.Text = reservation.ReservationDetails;
            this.submitButton.Text = "Edit";
            this.deleteButton.Visible = true;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string Firstname = this.firstNameTextbox.Text;
            string Lastname = this.lastNameTextbox.Text;
            string Phonenumber = this.PhoneTextbox.Text;
            int PartySize = Convert.ToInt32(this.PartySizeTextbox.Text);
            int Hour = Convert.ToInt32(this.reservationHourTextbox.Text);
            int Minute = Convert.ToInt32(this.reservationMinuteTextbox.Text);
            DateTime Date = this.reservationDatepicker.Value;
            string Description = this.descriptionTextbox.Text;
            if(submitButton.Text == "Edit")
            {
                this.service.editReservation(this.reservation.ReservationId,this.reservation.ClientId,Firstname, Lastname, Phonenumber, PartySize, Date, Hour, Minute, Description, this.user.Id);
                this.restaurantForm.refreshReservationsDB();
                this.Close();
            }
            else
            {
                this.service.addReservation(Firstname, Lastname, Phonenumber, PartySize, Date, Hour,Minute, Description,this.user.Id);
                this.restaurantForm.refreshReservationsDB();
                this.Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the reservation?", "Delete reservation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.service.deleteReservation(this.reservation.ReservationId);
                this.restaurantForm.refreshReservationsDB();
            }
            this.Close();
        }
    }
}
