using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text.Style;
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
    public class projects : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.projects);

            var rock = FindViewById<TextView>(Resource.Id.roknp);
            rock.Text = " فريق ركــن الـمــسـاحه ";


            var project = FindViewById<TextView>(Resource.Id.text_project);
            var text = FindViewById<TextView>(Resource.Id.call_text);
            var call = FindViewById<Button>(Resource.Id.call_button);

            project.Text = " مشاريع التخرج والمواد ";
            text.Text = "الزملاء الأعزاء من طلاب هندسة المساحة والجيوماتكس  في حال واجهتكم اي مشكلة او صعوبة في المواد الدراسية او في مشاريع التخرج ومشاريع المواد لا تترددوا في الاتصال على الرقم ' 0787189817 ' وباذن الله ستتم مساعدتكم على الشكل المطلوب ولن يتم التقصير ";
            call.Text = " اتصال ";

            call.Click += delegate
            {

                var url = Android.Net.Uri.Parse("tel:" + "00962787189817");
                var intent = new Intent(Intent.ActionDial, url);
                StartActivity(intent);

            };


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


        //  selected  menu

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.material_menu2:
                    var intent = new Intent(this, typeof(MainActivity));
                    StartActivity(intent);
                    break;

                case Resource.Id.software_menu2:
                    var intent2 = new Intent(this, typeof(softwares_page));
                    StartActivity(intent2);
                    break;

                case Resource.Id.whatsappUS2:
                    var url2 = Android.Net.Uri.Parse("https://wa.me/message/35GIPSZWKOKYN1");
                    var intent4702 = new Intent(Intent.ActionView, url2);
                    StartActivity(intent4702);
                    break;

                case Resource.Id.problem_menu2:
                    var url = Android.Net.Uri.Parse("https://play.google.com/store/apps/details?id=com.alaa.UTM_projection");
                    var intent470 = new Intent(Intent.ActionView, url);
                    StartActivity(intent470);
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