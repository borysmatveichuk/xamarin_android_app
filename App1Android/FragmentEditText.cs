using System;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace App1Android
{
    public class FragmentEditText : FragmentBase
    {
        public static FragmentEditText NewInstance()
        {
            FragmentEditText Fragment = new FragmentEditText();
            return Fragment;           
        }

        EditText AnswerText;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.fragment_edit_text, container, false);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            AnswerText = view.FindViewById<EditText>(Resource.Id.answer_text);

            viewModel.subjectQuestion.Subscribe(q =>
            {
                AnswerText.Text = q.Content;
            });
        }
    }
}