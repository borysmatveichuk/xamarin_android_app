using Android.OS;
using Android.Views;
using Android.Widget;
using Model;
using Newtonsoft.Json;

namespace App1Android
{
    public class FragmentRadioButton : FragmentBase
    {
        const string ARG_QUESTION = "question";

        public static FragmentRadioButton NewInstance(Question question)
        {
            FragmentRadioButton Fragment = new FragmentRadioButton();
            Bundle bundle = new Bundle();
            bundle.PutString(ARG_QUESTION, JsonConvert.SerializeObject(question));
            Fragment.Arguments = bundle;
            return Fragment;
        }

        private RadioGroup radioGroup;
        private Button nextButton;

        private Question currentQuestion;
        private Answer currentAnswer;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.fragment_radio_button, container, false);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            currentQuestion = JsonConvert.DeserializeObject<Question>(Arguments.GetString(ARG_QUESTION, ""));

            radioGroup = view.FindViewById<RadioGroup>(Resource.Id.radio_group);
            nextButton = view.FindViewById<Button>(Resource.Id.next_question);
            nextButton.Enabled = false;
            nextButton.Click += (sender, e) =>
            {
                viewModel.SetCurrentAnswer(currentAnswer);
            };

            for (int i = 0; i < currentQuestion.Answers.Count; i++)
            {
                var radioButton = new RadioButton(this.Context)
                {
                    Text = currentQuestion.Answers[i].Content,
                    Tag = (int)i,
                };

                radioButton.Click += (sender, e) =>
                {

                    var SelectedRadio = (RadioButton)sender;
                    if (SelectedRadio.Enabled)
                    {
                        nextButton.Enabled = true;
                    }
                    currentAnswer = currentQuestion.Answers[(int)SelectedRadio.Tag];
                };

                radioGroup.AddView(radioButton);
            }

        }

    }
}