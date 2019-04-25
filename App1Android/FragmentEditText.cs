using Android.OS;
using Android.Views;
using Android.Widget;
using Model;
using Newtonsoft.Json;

namespace App1Android
{
    public class FragmentEditText : FragmentBase
    {
        const string ARG_QUESTION = "question";
        public static FragmentEditText NewInstance(Question question)
        {
            FragmentEditText Fragment = new FragmentEditText();
            Bundle bundle = new Bundle();
            bundle.PutString(ARG_QUESTION, JsonConvert.SerializeObject(question));
            Fragment.Arguments = bundle;
            return Fragment;           
        }

        private Question currentQuestion;

        private EditText answerText;
        private Button nextButton;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.fragment_edit_text, container, false);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            currentQuestion = JsonConvert.DeserializeObject<Question>(Arguments.GetString(ARG_QUESTION, ""));

            nextButton = view.FindViewById<Button>(Resource.Id.next_question);
            nextButton.Enabled = false;
            nextButton.Click += (sender, e) =>
            {
                viewModel.SetCurrentQuestion(currentQuestion);
            };

            answerText = view.FindViewById<EditText>(Resource.Id.answer_text);
            answerText.TextChanged += delegate
            {
                if (answerText.Text.Length > 0)
                {
                    nextButton.Enabled = true;
                }
            };
        }
    }
}