using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;

namespace Odev3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        private FragmentManager fragmentManager;
        private Dialog1 dialog;
        TextView emailMain1;
        TextView emailMain2;
        TextView emailMain3;
        TextView emailMain4;
        TextView emailMain5;
        TextView emailMain6;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button button = FindViewById<Button>(Resource.Id.SendButton1);
            Button button2 = FindViewById<Button>(Resource.Id.SendButton2);
            Button button3 = FindViewById<Button>(Resource.Id.SendButton3);
            Button button4 = FindViewById<Button>(Resource.Id.SendButton4);
            Button button5 = FindViewById<Button>(Resource.Id.SendButton5);
            Button button6 = FindViewById<Button>(Resource.Id.SendButton6);
            emailMain1 =FindViewById<TextView>(Resource.Id.email1);
            emailMain2 = FindViewById<TextView>(Resource.Id.email2);
            emailMain3 = FindViewById<TextView>(Resource.Id.email3);
            emailMain4 = FindViewById<TextView>(Resource.Id.email4);
            emailMain5 = FindViewById<TextView>(Resource.Id.email5);
            emailMain6 = FindViewById<TextView>(Resource.Id.email6);
            button.Click += button_Click;
            button2.Click += button_Click2;
            button3.Click += button_Click3;
            button4.Click += button_Click4;
            button5.Click += button_Click5;
            button6.Click += button_Click6;
            fragmentManager = this.FragmentManager;
            dialog = new Dialog1();


        }

        void button_Click(object sender, EventArgs e)
        {
           
            dialog.Show(fragmentManager, emailMain1.Text);
        }

        void button_Click2(object sender, EventArgs e)
        {

            dialog.Show(fragmentManager, emailMain2.Text);
        }
        void button_Click3(object sender, EventArgs e)
        {

            dialog.Show(fragmentManager, emailMain3.Text);
        }
        void button_Click4(object sender, EventArgs e)
        {

            dialog.Show(fragmentManager, emailMain4.Text);
        }
        void button_Click5(object sender, EventArgs e)
        {

            dialog.Show(fragmentManager, emailMain5.Text);
        }
        void button_Click6(object sender, EventArgs e)
        {

            dialog.Show(fragmentManager, emailMain6.Text);
        }
    }
}