using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1
{
    [Activity(Label = "Surveying  BAU  App", Theme = "@style/AppTheme")]
    public class softwares_page : AppCompatActivity
    {
        ListView my_software;
        List<TableItem> tableitem;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here



            SetContentView(Resource.Layout.soft1);
            var rock = FindViewById<TextView>(Resource.Id.rokns);
            rock.Text = " فريق ركــن الـمــسـاحه ";



            my_software = FindViewById<ListView>(Resource.Id.software_list);

            tableitem = new List<TableItem>();
            tableitem.Add(new TableItem(" MathCAD ", "1"));
            tableitem.Add(new TableItem(" ArcGIS ", "2"));
            tableitem.Add(new TableItem(" PCI-Geomatica ", "3"));

            my_software.Adapter = new HomeScreenAdapter(this, tableitem);

            my_software.ItemClick += onlistitemclick;

        }


        //  selected item 


        void onlistitemclick(object sender, AdapterView.ItemClickEventArgs e)
        {

            var listview = sender as ListView;
            var r = tableitem[e.Position];

            if (r.no == "1")
            {
                //  mathcad
                var url = Android.Net.Uri.Parse("https://www.facebook.com/102050431974230/posts/102061428639797/");
                var intent = new Intent(Intent.ActionView, url);
                StartActivity(intent);
            }
            else if (r.no == "2")
            {
                //  gis
                var url = Android.Net.Uri.Parse("https://www.facebook.com/102050431974230/posts/102060055306601/");
                var intent = new Intent(Intent.ActionView, url);
                StartActivity(intent);
            }
            else if (r.no == "3")
            {
                //  pci
                var url = Android.Net.Uri.Parse("https://www.facebook.com/102050431974230/posts/102062421973031/");
                var intent = new Intent(Intent.ActionView, url);
                StartActivity(intent);
            }

        }


        //   table

        public class TableItem
        {
            public string software;
            public string no;
            public TableItem(string software, string no)
            {
                this.software = software;
                this.no = no;
            }
        }

        //  Adapter

        public class HomeScreenAdapter : BaseAdapter<TableItem>
        {
            List<TableItem> items;
            Activity context;
            public HomeScreenAdapter(Activity context, List<TableItem> items)
                : base()
            {
                this.context = context;
                this.items = items;
            }
            public override long GetItemId(int position)
            {
                return position;
            }
            public override TableItem this[int position]
            {
                get { return items[position]; }
            }
            public override int Count
            {
                get { return items.Count; }
            }
            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                var item = items[position];
                View view = convertView;
                if (view == null) // no view to re-use, create new
                    view = context.LayoutInflater.Inflate(Resource.Layout.listviewsource, null);
                view.FindViewById<TextView>(Resource.Id.name_of_material).Text = item.software;
                return view;
            }
        }

    }
}