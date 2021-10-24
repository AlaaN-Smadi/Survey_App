using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System.Collections.Generic;

namespace App1
{
    [Activity(Label = "Surveying  BAU  App", Theme = "@style/AppTheme", MainLauncher = true, Icon = "@drawable/main_icon")]
    public class MainActivity : AppCompatActivity
    {
        ListView survey_material;
        List<TableItem> tableitem;

        TextView mawad;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.main_page);
            
            mawad = FindViewById<TextView>(Resource.Id.mawad);

            mawad.Text = "قــائـمة  الــمــواد";

            survey_material = FindViewById<ListView>(Resource.Id.listView1);

            //  data in listview

            var rock = FindViewById<TextView>(Resource.Id.rokn);
            rock.Text = " فريق ركــن الـمــسـاحه ";

            tableitem = new List<TableItem>();
            tableitem.Add(new TableItem("مساحة 1", "1")); //
            tableitem.Add(new TableItem("مساحة 2", "2"));
            tableitem.Add(new TableItem("احتمالات ومتغيرات عشوائية", "3"));
            tableitem.Add(new TableItem("جيولوجيا", "4"));
            tableitem.Add(new TableItem("مساحة الطرق والمساحة الانشائية", "5"));
            tableitem.Add(new TableItem("علم الخرائط والاسقاطات الجغرافية", "6"));
            tableitem.Add(new TableItem("استعشار عن بعد 1", "7")); 
            tableitem.Add(new TableItem("استشعار عن بعد 2", "8"));
            tableitem.Add(new TableItem("البرمجة لتطبيقات الجيوماتكس", "9")); 
            tableitem.Add(new TableItem("تحاليل هندسية", "10"));
            tableitem.Add(new TableItem("المساحة العقارية", "11"));
            tableitem.Add(new TableItem("GPS", "12"));
            tableitem.Add(new TableItem("GIS", "13"));
            tableitem.Add(new TableItem("المساحة التصويرية", "14"));
            tableitem.Add(new TableItem("المساحة التصويرية التحليلية الرقمية", "15"));
            tableitem.Add(new TableItem("معالجة الصور الجوية", "16"));
            tableitem.Add(new TableItem("حساب الكميات", "17"));
            tableitem.Add(new TableItem("Dynamic", "18"));
            tableitem.Add(new TableItem("الخرائط الرقمية ", "19"));
            tableitem.Add(new TableItem("تصميم وتنفيذ نظم المعلومات الجغرافية", "20")); 
            tableitem.Add(new TableItem("الاقتصاد الهندسي", "21"));
            tableitem.Add(new TableItem("مبادئ الجيوديزياء", "22"));
            tableitem.Add(new TableItem("تعديل القياسات", "23"));
            tableitem.Add(new TableItem("شبكات الجيوماتكس", "24"));
            tableitem.Add(new TableItem("تفسير الصور الجوية", "25"));
            tableitem.Add(new TableItem("القياس بواسطة الاقمار الصناعية وتطبيقاتهــا", "26"));
            tableitem.Add(new TableItem("حقل الجاذبية", "27"));

            tableitem.Add(new TableItem("استاتيكا", "29"));


            survey_material.Adapter = new HomeScreenAdapter(this, tableitem);


            survey_material.ItemClick += onlistitemclick;




            // email test



        }


        //  selected item 


        void onlistitemclick(object sender, AdapterView.ItemClickEventArgs e)
        {

            var listview = sender as ListView;
            var r = tableitem[e.Position];

            var intent = new Intent(this, typeof(maddah));
            intent.PutExtra("no", r.no);
            intent.PutExtra("lectures", r.lectures);
            StartActivity(intent);


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
                view.FindViewById<TextView>(Resource.Id.name_of_material).Text = item.lectures;
                return view;
            }
        }





        //   table

        public class TableItem
        {
            public string lectures;
            public string no;
            public TableItem(string lectures, string no)
            {
                this.lectures = lectures;
                this.no = no;
            }
        }



        //   menu

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu, menu);

            for (int i = 0; i < 6; i++)
            {
                IMenuItem item = menu.GetItem(i);
                Android.Text.SpannableString spanString = new Android.Text.SpannableString(menu.GetItem(i).ToString());
                spanString.SetSpan(new ForegroundColorSpan(Android.Graphics.Color.DarkBlue), 0, spanString.Length(), 0); //fix the color to red
                item.SetTitle(spanString);
                if (i == 5)
                {

                    spanString.SetSpan(new ForegroundColorSpan(Android.Graphics.Color.Red), 0, spanString.Length(), 0); //fix the color to red
                    item.SetTitle(spanString);
                }
            }

            return base.OnCreateOptionsMenu(menu);
        }


        //   selected menu

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {

                case Resource.Id.projects_menu:
                    var intent = new Intent(this, typeof(projects));
                    StartActivity(intent);
                    break;

                case Resource.Id.software_menu:
                    var intent2 = new Intent(this, typeof(softwares_page));
                    StartActivity(intent2);
                    break;

                case Resource.Id.problem_menu:
                    var url = Android.Net.Uri.Parse("https://play.google.com/store/apps/details?id=com.alaa.UTM_projection");
                    var intent470 = new Intent(Intent.ActionView, url);
                    StartActivity(intent470);
                    break;

                case Resource.Id.whatsappUS:
                    var url2 = Android.Net.Uri.Parse("https://wa.me/message/35GIPSZWKOKYN1");
                    var intent4702 = new Intent(Intent.ActionView, url2);
                    StartActivity(intent4702);
                    break;

                case Resource.Id.face:
                    var url_face = Android.Net.Uri.Parse("https://www.facebook.com/%D8%B1%D9%83%D9%86-%D8%A7%D9%84%D9%85%D8%B3%D8%A7%D8%AD%D9%87-102050431974230/");
                    var intent_face = new Intent(Intent.ActionView, url_face);
                    StartActivity(intent_face);
                    break;

            }
            return base.OnOptionsItemSelected(item);
           
        }


    }




}


