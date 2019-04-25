using System;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Model;
using Android.Arch.Lifecycle;
using Android.App;

namespace App1Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView content;

        MainViewModel viewModel;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            viewModel = ViewModelProviders.Of(this).Get(Java.Lang.Class.FromType(typeof(MainViewModel))) as MainViewModel;

            content = FindViewById<TextView>(Resource.Id.content);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            /*List<Question> questions = ViewModel.GetQuestions();

            string questionsStr = "";
            foreach(Question q in questions)
            {
                questionsStr += q.Content + "\n";
            }
            content.Text = questionsStr;
            */
            viewModel.subjectQuestion.Subscribe(q =>
            {
                content.Text = q.Content;

                initFragment(q);
            });
        }

        private void initFragment(Question Question)
        {
            Android.Support.V4.App.FragmentTransaction fragmentTx = this.SupportFragmentManager.BeginTransaction();
            Android.Support.V4.App.Fragment frag;
            if (Question.inputType == InputType.text)
            {
                frag = FragmentEditText.NewInstance();
            }
            else
            {
                frag = FragmentRadioButton.NewInstance();
            }


            // Replace the fragment that is in the View fragment_container (if applicable).
            fragmentTx.Replace(Resource.Id.fragment_container, frag);

            // Add the transaction to the back stack.
            fragmentTx.AddToBackStack(null);

            // Commit the transaction.
            fragmentTx.Commit();
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

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View)sender;
            Toast.MakeText(context: view?.Context, text: "Hello my friend!!!", duration: ToastLength.Short).Show();
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }


    }
}
