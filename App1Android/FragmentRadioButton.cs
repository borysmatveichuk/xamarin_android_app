using Android.OS;
using Android.Views;
using Android.Widget;
using Model;
using System;

namespace App1Android
{
    public class FragmentRadioButton : FragmentBase
    {
        public static FragmentRadioButton NewInstance()
        {
            FragmentRadioButton Fragment = new FragmentRadioButton();
            return Fragment;
        }

        private RadioGroup radioGroup;
        private Button nextButton;

        private Question CurrentQuestion;
        private Answer CurrentAnswer;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.fragment_radio_button, container, false);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            radioGroup = view.FindViewById<RadioGroup>(Resource.Id.radio_group);
            nextButton = view.FindViewById<Button>(Resource.Id.next_question);
            nextButton.Enabled = false;
            nextButton.Click += (sender, e) =>
            {
                viewModel.SetCurrentAnswer(CurrentAnswer);
                Toast.MakeText(Context, CurrentAnswer.Content + " " + CurrentAnswer.Id + " " + CurrentAnswer.Next, ToastLength.Long).Show();
            };

            viewModel.subjectQuestion.Subscribe(q =>
            {

                CurrentQuestion = q;

                for (int i = 0; i < q.Answers.Count; i++)
                {
                    var radioButton = new RadioButton(this.Context)
                    {
                        Text = q.Answers[i].Content,
                        Tag = (int)i,
                    };
                    radioButton.Click += (sender, e) =>
                    {

                        var SelectedRadio = (RadioButton)sender;
                        if (SelectedRadio.Enabled)
                        {
                            nextButton.Enabled = true;
                        }
                        CurrentAnswer = CurrentQuestion.Answers[(int)SelectedRadio.Tag];
                    };
                    radioGroup.AddView(radioButton);
                }

            });
        }
    }
}