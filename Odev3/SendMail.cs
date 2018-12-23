using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Odev3
{
    [Activity(Label = "SendMail")]
    class SendMail : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Create
            SetContentView(Resource.Layout.MailSend);


            var nameSend1 = FindViewById<EditText>(Resource.Id.editText1);
            var emailSend1 = FindViewById<EditText>(Resource.Id.txtName);
            Button buttonSend = FindViewById<Button>(Resource.Id.buttonSend);

            var mail = Intent.GetStringExtra("email");
            Obje obje = Helper.FromJson<Obje>(mail);
            nameSend1.Text = obje.email;
            emailSend1.Text = "Subject : " + obje.subject;
            buttonSend.Click += ButtonSend;


       
        }

        void ButtonSend(object sender, EventArgs e)
        {
            Toast.MakeText(this.ApplicationContext, "Mail Send", ToastLength.Long).Show();
        }
    }
}