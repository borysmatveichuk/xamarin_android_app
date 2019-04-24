using System;

using Android.Support.V4.App;
using Android.Arch.Lifecycle;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace App1Android
{
    public class FragmentRadioButton : Fragment
    {
        public static FragmentRadioButton NewInstance()
        {
            FragmentRadioButton Fragment = new FragmentRadioButton();
            return Fragment;
        }

        MainViewModel ViewModel;
        RadioGroup RadioGroup;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
            ViewModel = ViewModelProviders.Of(Activity).Get(Java.Lang.Class.FromType(typeof(MainViewModel))) as MainViewModel;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            base.OnCreateView(inflater, container, savedInstanceState);

            return inflater.Inflate(Resource.Layout.fragment_radio_button, container, false);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            RadioGroup = view.FindViewById<RadioGroup>(Resource.Id.radio_group);

            ViewModel.subjectQuestion.Subscribe(q =>
            {
                
                //Toast.MakeText(Context, q.Answers[0].Content, ToastLength.Short).Show();
                for(int i=0; i < q.Answers.Count; i++)
                {
                    var radioButton = new RadioButton(this.Context);
                    radioButton.Text = q.Answers[i].Content;
                    radioButton.Tag = q.Answers[i].Id;
                    radioButton.Click += (sender, e) => {
                        //https://docs.microsoft.com/ru-ru/xamarin/android/internals/api-design#Events_and_Listeners
                        Toast.MakeText(Context, q.Answers[0].Content, ToastLength.Short).Show();
                    };
                    RadioGroup.AddView(radioButton);
                }
               
            });
        }
    }
}