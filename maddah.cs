using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AndroidX.AppCompat.App;



namespace App1
{
    [Activity(Label = "Surveying  BAU  App", Theme = "@style/AppTheme")]
    public class maddah : AppCompatActivity
    {

        ListView selected_maddah;
        List<TableItem> tableitem;

        string link1 = "https://drive.google.com/file/d/11aQO1__IPzAD3Qj3pcS8mGXEXdXTP_Tp/view?usp=sharing";
        string link2 = "https://drive.google.com/file/d/11aQO1__IPzAD3Qj3pcS8mGXEXdXTP_Tp/view?usp=sharing";



        protected override void OnCreate(Bundle savedInstanceState)
        {


            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.mawad_menu);

            var rock = FindViewById<TextView>(Resource.Id.roknm);
            rock.Text = " فريق ركــن الـمــسـاحه ";

            string no = Intent.GetStringExtra("no");
            string lectures = Intent.GetStringExtra("lectures");

            var maddah = FindViewById<TextView>(Resource.Id.mawad_name);
            maddah.Text = lectures;


            //   listview  Data

            selected_maddah = FindViewById<ListView>(Resource.Id.mawad_list);

            tableitem = new List<TableItem>();
            tableitem.Add(new TableItem("المادة", "1"));
            tableitem.Add(new TableItem("اسئلة السنوات", "2"));
            tableitem.Add(new TableItem("مشاريع المادة", "3"));

            selected_maddah.Adapter = new HomeScreenAdapter(this, tableitem);



            int number = Convert.ToInt32(no);



            switch (number)
            {
                case 1:
                    ////////
                    link1 = "https://drive.google.com/file/d/1x3ScLeYHSdwkObWtWKcaKi-RIIPNOW9y/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1x3ScLeYHSdwkObWtWKcaKi-RIIPNOW9y/view?usp=sharing";
                    break;

                case 2:
                    link1 = "https://drive.google.com/file/d/1czp8hiBUmiFX0mz9hxRMIimCJGvc67NO/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1czp8hiBUmiFX0mz9hxRMIimCJGvc67NO/view?usp=sharing";
                    break;
                case 3:
                    link1 = "https://drive.google.com/file/d/1gB1JIUfCbmLh1K4OKsLsk4pIRsIAGqmG/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1gB1JIUfCbmLh1K4OKsLsk4pIRsIAGqmG/view?usp=sharing";
                    break;
                case 4:
                    link1 = "https://drive.google.com/file/d/1PEy2tc4L48tA0i92Wg4CozCsTXkJybRP/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1PEy2tc4L48tA0i92Wg4CozCsTXkJybRP/view?usp=sharing";
                    break;
                case 5:
                    link1 = "https://drive.google.com/file/d/1wAKQWwVThlIAJ78ZeXjsEI5jUaGeMmnw/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1wAKQWwVThlIAJ78ZeXjsEI5jUaGeMmnw/view?usp=sharing";
                    break;
                case 6:
                    link1 = "https://drive.google.com/file/d/13Eq9_qTZYzPMtGsLHXldu7quJJNKfzMq/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/13Eq9_qTZYzPMtGsLHXldu7quJJNKfzMq/view?usp=sharing";
                    break;
                case 7:
                    
                    link1 = "https://drive.google.com/file/d/1nDnLQKmazVglIdRPNaAvHOQSoHsmU2WD/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1nDnLQKmazVglIdRPNaAvHOQSoHsmU2WD/view?usp=sharing";
                    break;
                case 8:
                    link1 = "https://drive.google.com/file/d/1yfT3L5R5_02OHebuYM9ZU2zGRo_1NaYl/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1yfT3L5R5_02OHebuYM9ZU2zGRo_1NaYl/view?usp=sharing";
                    break;
                case 9:
                    
                    link1 = "https://drive.google.com/file/d/1sh7uGHkkYTHx-juadV0721aXCKy0d3Yk/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1sh7uGHkkYTHx-juadV0721aXCKy0d3Yk/view?usp=sharing";
                    break;
                case 10:
                    link1 = "https://drive.google.com/file/d/1ZCA4DiOcS-JD0Gv4NdPmhq45Gn3tQSzX/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1ZCA4DiOcS-JD0Gv4NdPmhq45Gn3tQSzX/view?usp=sharing";
                    break;
                case 11:
                    link1 = "https://drive.google.com/file/d/1FiZizmVBEnwPM-n6lKmB8ktgOiZmXVdm/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1FiZizmVBEnwPM-n6lKmB8ktgOiZmXVdm/view?usp=sharing";
                    break;
                case 12:
                    link1 = "https://drive.google.com/file/d/1p1AzKGtH0nOozpHfPRxFk4F5Pf57vv85/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1p1AzKGtH0nOozpHfPRxFk4F5Pf57vv85/view?usp=sharing";
                    break;
                case 13:
                    link1 = "https://drive.google.com/file/d/1F5XmB1cv4UwU_pdL-IQF-EFV2UOPKXI2/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1F5XmB1cv4UwU_pdL-IQF-EFV2UOPKXI2/view?usp=sharing";
                    break;
                case 14:
                    link1 = "https://drive.google.com/file/d/1DLjnLFEyHEU4Jx2IkvhGZfT8DzmU9y-2/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1DLjnLFEyHEU4Jx2IkvhGZfT8DzmU9y-2/view?usp=sharing";
                    break;
                case 15:
                    link1 = "https://drive.google.com/file/d/1pvSjahK8CwGKZUSFEdejKLE6s-ZCoO-t/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1pvSjahK8CwGKZUSFEdejKLE6s-ZCoO-t/view?usp=sharing";
                    break;
                case 16:
                    link1 = "https://drive.google.com/file/d/1NWYMl9u2YHhGYJnrbClgUm0nRAr8xlgh/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1NWYMl9u2YHhGYJnrbClgUm0nRAr8xlgh/view?usp=sharing";
                    break;
                case 17:
                    link1 = "https://drive.google.com/file/d/1t2OVHg9K1goA0Ooe3FBU1aWv2z3GHv2g/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1t2OVHg9K1goA0Ooe3FBU1aWv2z3GHv2g/view?usp=sharing";
                    break;
                case 18:

                    link1 = "https://drive.google.com/file/d/17NgIL6WLSlSpngLKgGEC0RW_KQAzyB5v/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/17NgIL6WLSlSpngLKgGEC0RW_KQAzyB5v/view?usp=sharing";
                    break;
                case 19:
                    link1 = "https://drive.google.com/file/d/15TAwcCBbGh3AvYyGMkKfT2TnZp8gosO1/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/15TAwcCBbGh3AvYyGMkKfT2TnZp8gosO1/view?usp=sharing";
                    break;
                case 20:
                    
                    link1 = "https://drive.google.com/file/d/1zY_STGQn6Be2VWHquI8_k3I_5HMs2DR6/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1zY_STGQn6Be2VWHquI8_k3I_5HMs2DR6/view?usp=sharing";
                    break;
                case 21:
                    link1 = "https://drive.google.com/file/d/1plIcsBugMNtlUh081OQSlnyvjOwYkXCn/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1plIcsBugMNtlUh081OQSlnyvjOwYkXCn/view?usp=sharing";
                    break;
                case 22:
                    link1 = "https://drive.google.com/file/d/1wZDldLU2kjhZiYSp2XZkEFKFtfhN8631/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1wZDldLU2kjhZiYSp2XZkEFKFtfhN8631/view?usp=sharing";
                    break;
                case 23:
                    link1 = "https://drive.google.com/file/d/1DMQ5nFZQsvjOLFBc66PW5NxlToa8WrIW/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1DMQ5nFZQsvjOLFBc66PW5NxlToa8WrIW/view?usp=sharing";
                    break;
                case 24:
                    
                    link1 = "https://drive.google.com/file/d/1CtYqiVAkwf6OmwKUUbY95JOsF8Xt108d/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1CtYqiVAkwf6OmwKUUbY95JOsF8Xt108d/view?usp=sharing";
                    break;
                case 25:
                    link1 = "https://drive.google.com/file/d/1vf4Sq9iW83goV2lC0100-PmQl865xsfb/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1vf4Sq9iW83goV2lC0100-PmQl865xsfb/view?usp=sharing";
                    break;
                case 26:
                    link1 = "https://drive.google.com/file/d/19E_2t3fYI-eK4Jb-Et32U3HCF6U829SS/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/19E_2t3fYI-eK4Jb-Et32U3HCF6U829SS/view?usp=sharing";
                    break;
                case 27:
                    link1 = "https://drive.google.com/file/d/1R1ed-PDunpj4Ic4Q3kDvbbek05jfyKhs/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1R1ed-PDunpj4Ic4Q3kDvbbek05jfyKhs/view?usp=sharing";
                    break;

                case 29:
                    link1 = "https://drive.google.com/file/d/1Hb0TsDzgGqSjwdHSfVphVS0R7a51XmL6/view?usp=sharing";
                    link2 = "https://drive.google.com/file/d/1Hb0TsDzgGqSjwdHSfVphVS0R7a51XmL6/view?usp=sharing";
                    break;

                default:
                    break;

            }


            //  selected item

            selected_maddah.ItemClick += onlistitemclick;
        }



        //  selected item 


        void onlistitemclick(object sender, AdapterView.ItemClickEventArgs e)
        {

            var listview = sender as ListView;
            var r = tableitem[e.Position];

            if (r.no == "1")
            {
                var url = Android.Net.Uri.Parse(link1);
                var intent = new Intent(Intent.ActionView, url);
                StartActivity(intent);
            }
            else if (r.no == "2")
            {
                var url = Android.Net.Uri.Parse(link2);
                var intent = new Intent(Intent.ActionView, url);
                StartActivity(intent);
            }
            else if (r.no == "3")
            {

                var intent = new Intent(this, typeof(projects));
                StartActivity(intent);
            }

        }


        //   Table
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


        //   menu

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_two, menu);

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
                case Resource.Id.material_menu2:
                    var intent = new Intent(this, typeof(MainActivity));
                    StartActivity(intent);
                    break;


                case Resource.Id.projects_menu:
                    var intentas = new Intent(this, typeof(projects));
                    StartActivity(intentas);
                    break;


                case Resource.Id.software_menu2:
                    var intent2 = new Intent(this, typeof(softwares_page));
                    StartActivity(intent2);
                    break;

                case Resource.Id.problem_menu2:
                    var url = Android.Net.Uri.Parse("https://play.google.com/store/apps/details?id=com.alaa.UTM_projection");
                    var intent470 = new Intent(Intent.ActionView, url);
                    StartActivity(intent470);
                    break;

                case Resource.Id.whatsappUS2:
                    var url2 = Android.Net.Uri.Parse("https://wa.me/message/35GIPSZWKOKYN1");
                    var intent4702 = new Intent(Intent.ActionView, url2);
                    StartActivity(intent4702);
                    break;

                case Resource.Id.problem_menu:
                    var intent3 = new Intent(this, typeof(projects));
                    StartActivity(intent3);
                    break;

                case Resource.Id.face2:
                    var url_face = Android.Net.Uri.Parse("https://www.facebook.com/%D8%B1%D9%83%D9%86-%D8%A7%D9%84%D9%85%D8%B3%D8%A7%D8%AD%D9%87-102050431974230/");
                    var intent_face = new Intent(Intent.ActionView, url_face);
                    StartActivity(intent_face);
                    break;


            }
            return base.OnOptionsItemSelected(item);
        }



    }
}