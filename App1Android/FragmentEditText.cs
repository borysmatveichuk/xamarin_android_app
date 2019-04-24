using System;

using Android.Arch.Lifecycle;
using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;

namespace App1Android
{
    public class FragmentEditText : Fragment
    {
        public static FragmentEditText NewInstance()
        {
            FragmentEditText Fragment = new FragmentEditText();
            return Fragment;           
        }

        MainViewModel ViewModel;

        EditText AnswerText;

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

            return inflater.Inflate(Resource.Layout.fragment_edit_text, container, false);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            AnswerText = view.FindViewById<EditText>(Resource.Id.answer_text);

            ViewModel.subjectQuestion.Subscribe(q =>
            {
                AnswerText.Text = q.Content;

            });
        }
    }
}