using Attribute = Android.App.ActivityAttribute;
using Android.Arch.Lifecycle;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using SupportActivity = Android.Support.V7.App.AppCompatActivity;
using Android.Views;
using Android.Widget;
using Model;
using System;
using Android.Support.V4.App;

namespace App1Android
{
    [Attribute(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : SupportActivity
    {
        TextView content;

        MainViewModel viewModel;
        private IDisposable disposable;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            viewModel = ViewModelProviders.Of(this).Get(Java.Lang.Class.FromType(typeof(MainViewModel))) as MainViewModel;

            content = FindViewById<TextView>(Resource.Id.content);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            disposable = viewModel.subjectQuestion.Subscribe(q =>
            {
                content.Text = q?.Content ?? "";

                initFragment(q);
            });
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            disposable?.Dispose();
        }

        private void initFragment(Question question)
        {
            FragmentTransaction fragmentTx = this.SupportFragmentManager.BeginTransaction();
            Fragment frag;
           
            if (question == null)
            {
                frag = FragmentFinish.NewInstance();
            }
            else if (question.inputType == InputType.text)
            {
                frag = FragmentEditText.NewInstance(question);
            }
            else if(question.inputType == InputType.select)
            {
                frag = FragmentRadioButton.NewInstance(question);
            } else
            {
                throw new ArgumentException("Unknown Question type!");
            }

            fragmentTx.Replace(Resource.Id.fragment_container, frag)
                .AddToBackStack(null)
                .Commit();
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

    }
}
