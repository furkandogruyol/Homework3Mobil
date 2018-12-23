using System;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace Odev3
{

    class Dialog1 : DialogFragment
    {
        private ListView listView;
        private string[] menu = { "Mentoring", "Course Information", "Project Information", "Objection", "General" }; 
        private ArrayAdapter adapter;
        string send;
       
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fraglayout,container,false);
            //title
            this.Dialog.SetTitle("Select a Subject");

            listView = view.FindViewById<ListView>(Resource.Id.listView);
            //adapter
            adapter = new ArrayAdapter(this.Activity, Android.Resource.Layout.SimpleListItem1, menu);
            listView.Adapter = adapter; 
            Toast.MakeText(Application.Context, this.Tag,ToastLength.Long).Show();
            send = this.Tag;
            //Item Clicks
            listView.ItemClick += lv_ItemClick;
                return view;
        }

       
        void lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            
            var intent = new Intent(Application.Context, typeof(SendMail));
            Obje obje = new Obje();
            obje.email = send;
            obje.subject = menu[e.Position];
            intent.PutExtra("email", obje.ToJson());
            intent.PutExtra("subject", obje.ToJson());
            StartActivity(intent);

        }
    }
   

}